using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using rehber.Core.DTOs;
using rehber.Core.Models;
using rehber.Core.Services;

namespace rehber.Api.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactService _service;
        private readonly IMapper _mapper;

        public ContactController(IContactService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contacts = await _service.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ContactDto>>(contacts));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var contact = await _service.GetByIdAsync(id);
                return Ok(_mapper.Map<ContactDto>(contact));
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{id}/infos")]
        public async Task<IActionResult> GetWithInfos(int id)
        {
            var contactWithInfos = await _service.GetWithInfosByIdAsync(id);
            return (Ok(_mapper.Map<ContactWithInfosDto>(contactWithInfos)));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ContactDto contactDto)
        {
            try
            {
                await _service.AddAsync(_mapper.Map<Contact>(contactDto));
                return NoContent();
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public ActionResult Update(ContactDto contactDto)
        {
            if (contactDto.Id == 0)
            {
                return BadRequest("Güncellenecek kişinin id'si zorunludur.");
            }

            try
            {
                var updatedEntity  = _service.Update(_mapper.Map<Contact>(contactDto));
                return (Ok(_mapper.Map<ContactDto>(updatedEntity)));
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }
        
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {            
            try
            {
                var contact = _service.GetByIdAsync(id).Result;
                _service.Remove(contact);
                return NoContent();
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}