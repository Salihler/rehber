using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using rehber.Core.DTOs;
using rehber.Core.Models;
using rehber.Core.Services;

namespace rehber.Api.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactService _service;
        private readonly IDistributedCache _distrubutedCache;
        private readonly IMapper _mapper;

        public ContactController(IContactService service,IMapper mapper, IDistributedCache distributedCache)
        {
            _service = service;
            _distrubutedCache = distributedCache;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var contacts = await _service.GetAllAsync();
                return Ok(_mapper.Map<IEnumerable<ContactDto>>(contacts.OrderBy(x => x.Id)));
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Contact contact;

            string cacheJsonItem;

            try
            {
                var contactsOnCache = await _distrubutedCache.GetAsync(id.ToString());

                if (contactsOnCache != null)
                {
                    cacheJsonItem = Encoding.UTF8.GetString(contactsOnCache);
                    contact = JsonConvert.DeserializeObject<Contact>(cacheJsonItem);
                }
                else
                {
                    contact = await _service.GetByIdAsync(id);

                    cacheJsonItem = JsonConvert.SerializeObject(contact);

                    contactsOnCache = Encoding.UTF8.GetBytes(cacheJsonItem);

                    var options = new DistributedCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromDays(1))
                    .SetAbsoluteExpiration(DateTime.Now.AddMonths(1));

                    await _distrubutedCache.SetAsync(id.ToString(), contactsOnCache, options);
                }

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
            try
            {
                var contactWithInfos = await _service.GetWithInfosByIdAsync(id);
                return (Ok(_mapper.Map<ContactWithInfosDto>(contactWithInfos)));
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
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

        [HttpPost("range/")]
        public async Task<IActionResult> SaveRange([FromBody]List<ContactDto> contacts)
        {
            try
            {
                await _service.AddRangeAsync(_mapper.Map<IEnumerable<Contact>>(contacts));
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

        [HttpDelete("range/")]
        public IActionResult Remove([FromBody]List<ContactDto> contacts)
        {
            try
            {
                _service.RemoveRange(_mapper.Map<IEnumerable<Contact>>(contacts));
                return NoContent();
            }
            catch (System.Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}