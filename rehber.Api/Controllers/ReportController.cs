using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rehber.Core.Models;
using rehber.Core.Services;

namespace rehber.Api.Controllers
{
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IContactInfoService _cInfoService;

        public List<Report> ReportList { get; set; }

        public ReportController(IContactService contactService, IContactInfoService cInfoService)
        {
            _contactService = contactService;
            _cInfoService = cInfoService;
            ReportList = new List<Report>();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var contact = await _contactService.GetAllAsync();
                var infos = await _cInfoService.GetAllAsync();

                //Rapor Lokasyon odaklı olduğu için, Veritabanındaki tüm lokasyonları veri tekrarlarını teke düşürerek getirip, listeye atama.
                List<string> locations = infos.Select(l => l.Location).Distinct().ToList();

                foreach (var location in locations)
                {
                    //Telefon numaraları ve Contact sayısını lokasyon baz alarak hesaplatıp, rapor listesine ekleme.
                    ReportList.Add(new Report {
                        Contacts = infos.Where(x => x.Location == location && x.ContactId != 0).Select(x => x.ContactId).Count(),
                        Location = location,
                        PhoneNumbers = infos.Where(x => x.Location == location && !string.IsNullOrEmpty(x.Phone)).Select(x => x.Phone).Count()
                    });
                }
                return Ok(ReportList);
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}