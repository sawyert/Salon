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

                cfg.CreateMap<CountryEntity, CreateCountryDto>()
                ;

                cfg.CreateMap<SectionTypeEntity, SectionTypeDto>();
                cfg.CreateMap<CreateSectionTypeDto, SectionTypeDto>()
                .ForMember(ent => ent.Id, x => x.Ignore())
                ;
                cfg.CreateMap<SectionTypeDto, CreateSectionTypeDto>()
                    .ForMember(dto => dto.Errors, x => x.Ignore())
                ;
                cfg.CreateMap<SectionTypeDto, SectionTypeEntity>()
                ;
                cfg.CreateMap<CreateSectionTypeDto, SectionTypeEntity>()
                ;
                cfg.CreateMap<SectionTypeEntity, CreateSectionTypeDto>()
                    .ForMember(dto => dto.Errors, x => x.Ignore())
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
                 .ForMember(ent => ent.Country, x => x.ResolveUsing(dto => !dto.CountryId.HasValue && !string.IsNullOrEmpty(dto.CountryName) ? new CountryEntity { Name = dto.CountryName } : null))
                 .ForMember(ent => ent.SalonYears, x => x.Ignore())
                ;

                cfg.CreateMap<AccreditationEntity, SalonYearAccreditationDto>()
                 .ForMember(dto => dto.PhotoOrganisationName, x => x.MapFrom(ent => ent.PhotoOrganisation.Name))
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
                    .ForMember(ent => ent.EnableSectionTypes, x => x.Ignore())
                ;
                
                cfg.CreateMap<SubmissionEntity, SubmissionSaveDto>()
                    .ForMember(dto => dto.SubmissionCreated, x => x.Ignore())
                    .ForMember(dto => dto.CircuitId, x => x.Ignore())
                    .ForMember(dto => dto.Sections, x => x.Ignore())
                    .ForMember(dto => dto.Errors, x => x.Ignore())
                    .ForMember(dto => dto.Cost, x => x.MapFrom(t => t.EntryCost))
                ;
                cfg.CreateMap<SubmissionSaveDto, SubmissionEntity>()
                    .ForMember(ent => ent.Id, x => x.Ignore())
                    .ForMember(ent => ent.SalonYear, x => x.Ignore())
                    .ForMember(ent => ent.Person, x => x.Ignore())
                    .ForMember(ent => ent.Entries, x => x.Ignore())
                    .ForMember(ent => ent.IsJudged, x => x.Ignore())
                    .ForMember(ent => ent.EntryCost, x => x.MapFrom(t => t.Cost))
                ;

                cfg.CreateMap<ImageEntity, SubmissionSaveSectionImagesDto>()
                    .ForMember(dto => dto.ImageNotes, x => x.MapFrom(t => t.Notes))
                    .ForMember(dto => dto.ImageName, x => x.MapFrom(t => t.Name))
                    .ForMember(dto => dto.ImageId, x => x.MapFrom(t => t.Id))
                    .ForMember(dto => dto.ImageThumbnail, x => x.Ignore())
                    .ForMember(dto => dto.Extension, x => x.Ignore())
               ;

                cfg.CreateMap<SubmissionSaveSectionImagesDto, ImageEntity>()
                    .ForMember(ent => ent.Notes, x => x.MapFrom(t => t.ImageNotes))
                    .ForMember(ent => ent.Name, x => x.MapFrom(t => t.ImageName))
                    .ForMember(ent => ent.Id, x => x.MapFrom(t => t.ImageId))
                    .ForMember(ent => ent.ThumbnailLocation, x => x.Ignore())
                    .ForMember(ent => ent.PersonId, x => x.Ignore())
                    .ForMember(ent => ent.Person, x => x.Ignore())
                    .ForMember(ent => ent.Entries, x => x.Ignore())
                ;

                cfg.CreateMap<SubmissionResultsEntryDto, CompetitionEntryEntity>()
                .ForMember(ent => ent.ImageId, x => x.Ignore())
                .ForMember(ent => ent.Image, x => x.Ignore())
                .ForMember(ent => ent.SectionId, x => x.Ignore())
                .ForMember(ent => ent.Section, x => x.Ignore())
                ;
                cfg.CreateMap<CompetitionEntryEntity, SubmissionResultsEntryDto>()
                ;

                cfg.CreateMap<CompetitionEntryEntity, OrganisationAcceptedEntryReportDto>()
                .ForMember(dto => dto.SalonName, x => x.MapFrom(ent => ent.Section.SalonYear.Name))
                .ForMember(dto => dto.SalonNumber, x => x.Ignore())
                .ForMember(dto => dto.SalonYear, x => x.MapFrom(ent => ent.Section.SalonYear.Year))
                .ForMember(dto => dto.ImageName, x => x.MapFrom(ent => ent.Image.Name))
                .ForMember(dto => dto.IsPrint, x => x.MapFrom(ent => ent.Section.SectionType.IsPrint))
                .ForMember(dto => dto.AwardName, x => x.MapFrom(ent => ent.AwardDetails))
                .ForMember(dto => dto.SalonCountry, x => x.MapFrom(ent => ent.Section.SalonYear.Salon.Country))
                ;

            });
            Mapper = config.CreateMapper();
            return config;
        }
    }
}
