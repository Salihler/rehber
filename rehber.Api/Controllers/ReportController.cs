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

        public List<string> locations = new List<string>();

        public List<Report> Reports = new List<Report>();

        private Report report = new Report();

        public ReportController(IContactService contactService, IContactInfoService cInfoService)
        {
            _contactService = contactService;
            _cInfoService = cInfoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var contact = await _contactService.GetAllAsync();
            var infos = await _cInfoService.GetAllAsync();

            locations = infos.Distinct().Select(l => l.Location).ToList();

            foreach (var location in locations)
            {
                report.Contacts = infos.Where(x => x.Location == location).Select(x => x.ContactId).Count();
                report.Location = location;
                report.PhoneNumbers = infos.Where(x => x.Location == location).Select(x => x.Phone).Count();
                Reports.Add(report);
            }
            return Ok(Reports);
        }
    }
}