using AutoMapper;
using Salon.Models;
using Salon.Models.Submission;
using SalonServices.Dto;
using SalonServices.Dto.Submission;
using SalonServices.Entities;
using System;
using System.Collections.Generic;
using System.IO;
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

                cfg.CreateMap<BasicPersonViewModel, BasicPersonDto>();
                cfg.CreateMap<BasicPersonDto, BasicPersonViewModel>();

                cfg.CreateMap<PersonAwardTableOrgViewModel, PersonAwardTableOrgDto>();
                cfg.CreateMap<PersonAwardTableOrgDto, PersonAwardTableOrgViewModel>();

                cfg.CreateMap<PersonAwardTableRowViewModel, PersonAwardTableRowDto>();
                cfg.CreateMap<PersonAwardTableRowDto, PersonAwardTableRowViewModel>();

                cfg.CreateMap<PersonAwardTableViewModel, PersonAwardTableDto>();
                cfg.CreateMap<PersonAwardTableDto, PersonAwardTableViewModel>();


                cfg.CreateMap<SalonYearInformationViewModel, SalonYearInformationDto>();
                cfg.CreateMap<SalonYearInformationDto, SalonYearInformationViewModel>();

                cfg.CreateMap<SalonYearAccreditationViewModel, SalonYearAccreditationDto>();
                cfg.CreateMap<SalonYearAccreditationDto, SalonYearAccreditationViewModel>();

                cfg.CreateMap<FullSalonInformationViewModel, FullSalonInformationDto>();
                cfg.CreateMap<FullSalonInformationDto, FullSalonInformationViewModel>();

                cfg.CreateMap<CircuitViewModel, CircuitDto>();
                cfg.CreateMap<CircuitDto, CircuitViewModel>();

                cfg.CreateMap<SectionTypeViewModel, SectionTypeDto>();
                cfg.CreateMap<SectionTypeDto, SectionTypeViewModel>();

                cfg.CreateMap<CreateSectionTypeViewModel, CreateSectionTypeDto>();
                cfg.CreateMap<CreateSectionTypeDto, CreateSectionTypeViewModel>()
                        .ForMember(model => model.Errors, opt => opt.Ignore())
                        ;

                cfg.CreateMap<OrganisationViewModel, OrganisationDto>();
                cfg.CreateMap<OrganisationDto, OrganisationViewModel>();

                cfg.CreateMap<CreateCircuitViewModel, CreateCircuitDto>();
                cfg.CreateMap<CreateCircuitDto, CreateCircuitViewModel>();

                cfg.CreateMap<CreateSalonViewModel, CreateSalonDto>();
                cfg.CreateMap<CreateSalonDto, CreateSalonViewModel>();

                cfg.CreateMap<CreateSalonYearViewModel, CreateSalonYearDto>();
                cfg.CreateMap<CreateSalonYearDto, CreateSalonYearViewModel>();

                cfg.CreateMap<SubmissionSaveViewModel, SubmissionSaveDto>();
                cfg.CreateMap<SubmissionSaveDto, SubmissionSaveViewModel>();

                cfg.CreateMap<SubmissionSaveSectionViewModel, SubmissionSaveSectionDto>();
                cfg.CreateMap<SubmissionSaveSectionDto, SubmissionSaveSectionViewModel>();

                cfg.CreateMap<SubmissionSaveSectionImagesViewModel, SubmissionSaveSectionImagesDto>()
                .ForMember(dto => dto.ImageThumbnail, opt => opt.Ignore())
                .ForMember(dto => dto.Extension, opt => opt.Ignore())
                .AfterMap((src, dest) =>
                {
                    if (src.ImageThumbnail != null)
                    {
                        using (var fileStream = src.ImageThumbnail.OpenReadStream())
                        using (var ms = new MemoryStream())
                        {
                            fileStream.CopyTo(ms);
                            var fileBytes = ms.ToArray();
                            dest.ImageThumbnail = fileBytes;
                            dest.Extension = Path.GetExtension(src.ImageThumbnail.FileName);
                        }
                    }
                })
                ;
                cfg.CreateMap<SubmissionSaveSectionImagesDto, SubmissionSaveSectionImagesViewModel>()
                    .ForMember(dto => dto.ImageThumbnail, opt => opt.Ignore())
                ;


                cfg.CreateMap<SubmissionResultsViewModel, SubmissionResultsDto>();
                cfg.CreateMap<SubmissionResultsDto, SubmissionResultsViewModel>()
                    .ForMember(vm => vm.ResultsUpdated, opt => opt.Ignore())
                ;

                cfg.CreateMap<SubmissionResultsEntryViewModel, SubmissionResultsEntryDto>();
                cfg.CreateMap<SubmissionResultsEntryDto, SubmissionResultsEntryViewModel>();

                cfg.CreateMap<SubmissionListItemViewModel, SubmissionListItemDto>();
                cfg.CreateMap<SubmissionListItemDto, SubmissionListItemViewModel>();

                cfg.CreateMap<OrganisationSubmissionReportDto, PsaSubmissionViewModel>();
                cfg.CreateMap<ImageDto, ImageViewModel>();
                cfg.CreateMap<ImageSalonEntryDto, ImageSalonViewModel>();

            });
            Mapper = config.CreateMapper();
            return config;
        }
    }
}
