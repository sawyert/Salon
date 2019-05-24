using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SalonServices;

namespace SalonServices.Migrations
{
    [DbContext(typeof(SalonDbContext))]
    [Migration("20170718104543_CompetitionEntry_AwardDetails")]
    partial class CompetitionEntry_AwardDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalonServices.Entities.AccreditationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PhotoOrganisationId");

                    b.Property<string>("SalonNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("SalonYearId");

                    b.HasKey("Id");

                    b.HasIndex("PhotoOrganisationId");

                    b.HasIndex("SalonYearId");

                    b.ToTable("Accreditations");
                });

            modelBuilder.Entity("SalonServices.Entities.AwardLevelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MinimumAcceptances");

                    b.Property<int>("MinimumAwards");

                    b.Property<int>("MinimumCountries");

                    b.Property<int>("MinimumDistinctImages");

                    b.Property<int>("MinimumPrints");

                    b.Property<int>("MinimumSalons");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("PhotoOrganisationId");

                    b.HasKey("Id");

                    b.HasIndex("PhotoOrganisationId");

                    b.ToTable("AwardLevels");
                });

            modelBuilder.Entity("SalonServices.Entities.CircuitEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Circuits");
                });

            modelBuilder.Entity("SalonServices.Entities.CompetitionEntryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AwardDetails")
                        .HasMaxLength(100);

                    b.Property<int>("ImageId");

                    b.Property<bool?>("IsAccepted");

                    b.Property<bool?>("IsAwarded");

                    b.Property<int?>("Score");

                    b.Property<int>("SectionId");

                    b.Property<int?>("SubmissionEntityId");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("SectionId");

                    b.HasIndex("SubmissionEntityId");

                    b.ToTable("CompetitionEntries");
                });

            modelBuilder.Entity("SalonServices.Entities.CountryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("SalonServices.Entities.ImageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasMaxLength(1000);

                    b.Property<int>("PersonId");

                    b.Property<string>("ThumbnailLocation")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SalonServices.Entities.PersonEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("SalonServices.Entities.PhotoOrganisationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("PhotoOrganisations");
                });

            modelBuilder.Entity("SalonServices.Entities.SalonEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Salons");
                });

            modelBuilder.Entity("SalonServices.Entities.SalonYearEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CataloguesPostedDate");

                    b.Property<int?>("CircuitId");

                    b.Property<DateTime>("ClosingDate");

                    b.Property<DateTime>("JudgeDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("NotificationDate");

                    b.Property<int>("SalonId");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("CircuitId");

                    b.HasIndex("SalonId");

                    b.ToTable("SalonYears");
                });

            modelBuilder.Entity("SalonServices.Entities.SectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SalonYearId");

                    b.Property<int>("SectionTypeId");

                    b.HasKey("Id");

                    b.HasIndex("SalonYearId");

                    b.HasIndex("SectionTypeId");

                    b.ToTable("SalonSections");
                });

            modelBuilder.Entity("SalonServices.Entities.SectionTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPrint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SectionCode");

                    b.HasKey("Id");

                    b.ToTable("SectionTypes");
                });

            modelBuilder.Entity("SalonServices.Entities.SubmissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("EntryCost")
                        .HasColumnType("Money");

                    b.Property<DateTime>("EntryDate");

                    b.Property<bool>("IsJudged");

                    b.Property<string>("Notes")
                        .HasMaxLength(1000);

                    b.Property<int>("PersonId");

                    b.Property<int>("SalonYearId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("SalonYearId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("SalonServices.Entities.AccreditationEntity", b =>
                {
                    b.HasOne("SalonServices.Entities.PhotoOrganisationEntity", "PhotoOrganisation")
                        .WithMany("AccreditedSalons")
                        .HasForeignKey("PhotoOrganisationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalonServices.Entities.SalonYearEntity", "SalonYear")
                        .WithMany("Accreditations")
                        .HasForeignKey("SalonYearId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalonServices.Entities.AwardLevelEntity", b =>
                {
                    b.HasOne("SalonServices.Entities.PhotoOrganisationEntity", "PhotoOrganisation")
                        .WithMany("AwardLevels")
                        .HasForeignKey("PhotoOrganisationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalonServices.Entities.CompetitionEntryEntity", b =>
                {
                    b.HasOne("SalonServices.Entities.ImageEntity", "Image")
                        .WithMany("Entries")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalonServices.Entities.SectionEntity", "Section")
                        .WithMany("Entries")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalonServices.Entities.SubmissionEntity")
                        .WithMany("Entries")
                        .HasForeignKey("SubmissionEntityId");
                });

            modelBuilder.Entity("SalonServices.Entities.ImageEntity", b =>
                {
                    b.HasOne("SalonServices.Entities.PersonEntity", "Person")
                        .WithMany("Images")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("SalonServices.Entities.SalonEntity", b =>
                {
                    b.HasOne("SalonServices.Entities.CountryEntity", "Country")
                        .WithMany("Salons")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalonServices.Entities.SalonYearEntity", b =>
                {
                    b.HasOne("SalonServices.Entities.CircuitEntity", "Circuit")
                        .WithMany("SalonYears")
                        .HasForeignKey("CircuitId");

                    b.HasOne("SalonServices.Entities.SalonEntity", "Salon")
                        .WithMany("SalonYears")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalonServices.Entities.SectionEntity", b =>
                {
                    b.HasOne("SalonServices.Entities.SalonYearEntity", "SalonYear")
                        .WithMany()
                        .HasForeignKey("SalonYearId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalonServices.Entities.SectionTypeEntity", "SectionType")
                        .WithMany()
                        .HasForeignKey("SectionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalonServices.Entities.SubmissionEntity", b =>
                {
                    b.HasOne("SalonServices.Entities.PersonEntity", "Person")
                        .WithMany("Submissions")
                        .HasForeignKey("PersonId");

                    b.HasOne("SalonServices.Entities.SalonYearEntity", "SalonYear")
                        .WithMany()
                        .HasForeignKey("SalonYearId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
