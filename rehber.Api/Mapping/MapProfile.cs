using AutoMapper;
using rehber.Core.DTOs;
using rehber.Core.Models;

namespace rehber.Api.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ContactDto,Contact>();
            CreateMap<Contact, ContactDto>();
            CreateMap<Contact, ContactWithInfosDto>();
            CreateMap<ContactWithInfosDto, Contact>();
            CreateMap<ContactInfoDto, ContactInfo>();
            CreateMap<ContactInfo, ContactInfoDto>();
            CreateMap<InfosWithContactDto, ContactInfo>();
            CreateMap<ContactInfo, InfosWithContactDto>();
        }
    }
}