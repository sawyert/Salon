using AutoMapper;
using SalonServices.Dto;
using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonServices.Mappings
{
    public static class Mapping
    {
        /// <summary>
        /// Mapper to containing all the configurations
        /// </summary>
        public static IMapper Mapper { get; private set; }

        /// <summary>
        /// Creates the configuration and sets the public mapper
        /// </summary>
        /// <returns></returns>
        public static MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CountryEntity, CountryDto>();
                cfg.CreateMap<CountryDto, CountryEntity>();
            });
            Mapper = config.CreateMapper();
            return config;
        }
    }
}
