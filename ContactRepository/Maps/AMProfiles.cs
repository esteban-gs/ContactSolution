using AutoMapper;
using ContactDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactRepository.Maps
{
    public class AMProfiles : Profile
    {
        public AMProfiles()
        {
            CreateMap<Contact, ContactForCreationDTO>().ReverseMap();

        }
    }
}
