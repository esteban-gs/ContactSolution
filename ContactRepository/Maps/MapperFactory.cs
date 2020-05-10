using AutoMapper;
using ContactDB;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ContactRepository.Maps
{
    public static class MapperFactory
    {
        public static IMapper Instance
        { 
            get
            {
                return new Mapper(SetMapperConfiguration());
            }
        }

        private static MapperConfiguration SetMapperConfiguration()
        {

            var conifg = new MapperConfiguration(cgf =>
            {
                cgf.AddProfile(new AMProfiles());
            });
            return conifg;
        }
    }

    
}
