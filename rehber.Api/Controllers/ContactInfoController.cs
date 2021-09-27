using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using rehber.Core.DTOs;
using rehber.Core.Models;
using rehber.Core.Services;

namespace rehber.Api.Controllers
{
    [Route("api/[controller]")]
    public class ContactInfoController : Controller
    {
        private readonly IContactInfoService _service;
        private readonly IMapper _mapper;

        public ContactInfoController(IContactInfoService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Save(ContactInfoDto cInfoDto)
        {
            try
            {
                var contact = _service.Where(x => x.ContactId == cInfoDto.ContactId);

                if ((cInfoDto.ContactId == 0 || contact == null))
                {
                    return BadRequest("ID ile eşleşen kullanıcı bulunamadı!");
                }

                await _service.AddAsync(_mapper.Map<ContactInfo>(cInfoDto));
                return NoContent();

            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var cInfo = _service.GetByIdAsync(id).Result;
                _service.Remove(cInfo);
                return NoContent();
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}