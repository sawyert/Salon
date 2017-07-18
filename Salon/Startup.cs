using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SalonServices;
using SalonServices.Repositories;
using SalonServices.Dto;
using SalonServices.Migrations;

namespace Salon
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            Salon.Mappings.Mapping.CreateConfiguration();
            SalonServices.Mappings.Mapping.CreateConfiguration();

            FullDataLoad.LoadData();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            IConfigurationSection lFileSettingsSection = this.Configuration.GetSection("FileSettings");
            var lFileSettings = new FileSettings();
            lFileSettingsSection.Bind(lFileSettings);
            services.Configure<FileSettings>(lFileSettingsSection);

            services.AddScoped<IAccreditationRepository, AccreditationRepository>();
            services.AddScoped<IAwardLevelRepository, AwardLevelRepository>();
            services.AddScoped<ICompetitionEntryRepository, CompetitionEntryRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPhotoOrganisationRepository, PhotoOrganisationRepository>();
            services.AddScoped<ISalonRepository, SalonRepository>();
            services.AddScoped<ISalonYearRepository, SalonYearRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<ISectionTypeRepository, SectionTypeRepository>();
            services.AddScoped<ISubmissionRepository, SubmissionRepository>();
            services.AddScoped<ICircuitRepository, CircuitRepository>();

            services.AddScoped<ISalonYearService, SalonYearService>();
            services.AddScoped<ISubmissionService, SubmissionService>();
            services.AddScoped<IReferenceServices, ReferenceServices>();
            services.AddScoped<IPersonAwardService, PersonAwardService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IDbTransaction, SalonDbContext>();
            services.AddScoped<ISalonDbContext, SalonDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
