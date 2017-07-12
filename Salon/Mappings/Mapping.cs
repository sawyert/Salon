using AutoMapper;
using Salon.Models;
using SalonServices.Dto;
using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Mappings
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
                cfg.CreateMap<CountryViewModel, CountryDto>();
                cfg.CreateMap<CountryDto, CountryViewModel>();
                cfg.CreateMap<CreateCountryViewModel, CreateCountryDto>();
                cfg.CreateMap<CreateCountryDto, CreateCountryViewModel>()
                        .ForMember(model => model.Id, opt => opt.Ignore())
                        .ForMember(model => model.Errors, opt => opt.Ignore())
                        ;
            });
            Mapper = config.CreateMapper();
            return config;
        }
    }
}
