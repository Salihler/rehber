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

        [HttpPost]
        public async Task<IActionResult> Create(ContactDto contactDto)
        {
            await _service.AddAsync(_mapper.Map<Contact>(contactDto));
            return NoContent();
        }
    }
}