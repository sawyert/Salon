using AutoMapper;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
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
                cfg.CreateMap<CreateCountryDto, CountryDto>()
                .ForMember(ent => ent.Id, x => x.Ignore())
                ;
                cfg.CreateMap<CountryDto, CreateCountryDto>();
                cfg.CreateMap<CountryDto, CountryEntity>()
                .ForMember(ent => ent.Salons, x => x.Ignore())
                ;
                cfg.CreateMap<CreateCountryDto, CountryEntity>()
                .ForMember(ent => ent.Id, x => x.Ignore())
                .ForMember(ent => ent.Salons, x => x.Ignore())
                ;

                cfg.CreateMap<PersonEntity, BasicPersonDto>()
                ;
                cfg.CreateMap<BasicPersonDto, PersonEntity>()
                    .ForMember(ent => ent.Submissions, x => x.Ignore())
                    .ForMember(ent => ent.Images, x => x.Ignore())
                ;


                cfg.CreateMap<SalonYearEntity, SalonYearInformationDto>()
                    .ForMember(ent => ent.SalonYearId, x => x.MapFrom(t => t.Id))
                ;
                cfg.CreateMap<SalonYearInformationDto, SalonYearEntity>()
                    .ForMember(ent => ent.Id, x => x.MapFrom(t => t.SalonYearId))
                    .ForMember(ent => ent.Circuit, x => x.Ignore())
                    .ForMember(ent => ent.CircuitId, x => x.Ignore())
                    .ForMember(ent => ent.Salon, x => x.Ignore())
                ;

                cfg.CreateMap<SalonYearEntity, CreateSalonYearDto>()
                 .ForMember(dto => dto.Errors, x => x.Ignore())
                ;
                cfg.CreateMap<CreateSalonYearDto, SalonYearEntity>()
                    .ForMember(ent => ent.Circuit, x => x.Ignore())
                    .ForMember(ent => ent.Salon, x => x.Ignore())
                 .ForMember(ent => ent.Accreditations, x => x.Ignore())

                ;

                cfg.CreateMap<SalonEntity, CreateSalonDto>()
                 .ForMember(dto => dto.SalonName, x => x.MapFrom(ent => ent.Name))
                 .ForMember(dto => dto.SalonId, x => x.MapFrom(ent => ent.Id))
                 .ForMember(dto => dto.CountryName, x => x.MapFrom(ent => ent.Country != null ? ent.Country.Name : null))
                 .ForMember(dto => dto.Errors, x => x.Ignore())
                ;
                cfg.CreateMap<CreateSalonDto, SalonEntity>()
                 .ForMember(ent => ent.Name, x => x.MapFrom(dto => dto.SalonName))
                 .ForMember(ent => ent.Id, x => x.MapFrom(dto => dto.SalonId))
                 .ForMember(ent => ent.Country, x => x.ResolveUsing(dto => !string.IsNullOrEmpty(dto.CountryName) ? new CountryEntity { Name = dto.CountryName } : null))
                 .ForMember(ent => ent.SalonYears, x => x.Ignore())
                ;

                cfg.CreateMap<AccreditationEntity, SalonYearAccreditationDto>()
               ;
                cfg.CreateMap<SalonYearAccreditationDto, AccreditationEntity>()
                    .ForMember(ent => ent.SalonYear, x => x.Ignore())
                    .ForMember(ent => ent.PhotoOrganisation, x => x.Ignore())
                    .ForMember(ent => ent.SalonYearId, x => x.Ignore())
                ;

                cfg.CreateMap<CircuitEntity, CircuitDto>()
               ;
                cfg.CreateMap<CircuitDto, CircuitEntity>()
                    .ForMember(ent => ent.SalonYears, x => x.Ignore())
                ;

                cfg.CreateMap<CircuitEntity, CreateCircuitDto>()
                .ForMember(ent => ent.Errors, x => x.Ignore())
               ;
                cfg.CreateMap<CreateCircuitDto, CircuitEntity>()
                    .ForMember(ent => ent.SalonYears, x => x.Ignore())
                ;

                cfg.CreateMap<PhotoOrganisationEntity, OrganisationDto>()
               ;
                cfg.CreateMap<OrganisationDto, PhotoOrganisationEntity>()
                    .ForMember(ent => ent.AccreditedSalons, x => x.Ignore())
                    .ForMember(ent => ent.AwardLevels, x => x.Ignore())
                ;

                cfg.CreateMap<SectionTypeEntity, SectionTypeDto>()
                ;
                cfg.CreateMap<SectionTypeDto, SectionTypeEntity>()
                ;
            });
            Mapper = config.CreateMapper();
            return config;
        }
    }
}
