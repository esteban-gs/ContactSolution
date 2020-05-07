using AutoMapper;
using ContactDB;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ContactRepository.Maps
{
    public static class MapperFactory<TSource, TDest> 
        where TSource : class
        where TDest : class
    {
        public static IMapper Mapper 
        { 
            get
            {
                return new Mapper(CreateIt());
            }
        }

        public static MapperConfiguration CreateIt()
        {
            return new MapperConfiguration(cfg => cfg.CreateMap<TSource, TDest>());
        }
    }
}
