﻿using System;
using System.Collections.Generic;
using SalonServices.Entities;
using System.Linq;

namespace SalonServices.Migrations
{
    public static class FullDataLoad
    {
        public static void LoadData()
        {
            using (var lContext = new SalonDbContext())
            {
                if (lContext.People.Count() == 0)
                {
                    var lCountryCzechRep = new CountryEntity { Name = "Czech Republic", };
                    var lCountryEngland = new CountryEntity { Name = "England", };
                    var lCountryIndia = new CountryEntity { Name = "India", };
                    var lCountryBelgium = new CountryEntity { Name = "Belgium", };
                    var lCountryMontenegro = new CountryEntity { Name = "Montenegro", };
                    var lCountryNewZealand = new CountryEntity { Name = "New Zealand", };
                    var lCountryUsa = new CountryEntity { Name = "USA", };
                    var lCountryFrance = new CountryEntity { Name = "France", };
                    var lCountryItaly = new CountryEntity { Name = "Italy", };
                    var lCountryScotland = new CountryEntity { Name = "Scotland", };
                    var lCountryAustralia = new CountryEntity { Name = "Australia", };
                    var lCountryTurkey = new CountryEntity { Name = "Turkey", };
                    var lCountryBulgaria = new CountryEntity { Name = "Bulgaria", };
                    var lCountrySerbia = new CountryEntity { Name = "Serbia", };
                    var lCountryCyprus = new CountryEntity { Name = "Cyprus", };
                    var lCountryWales = new CountryEntity { Name = "Wales", };
                    var lCountryKyrgystan = new CountryEntity { Name = "Kyrgyzstan", };

                    try
                    {
                        lContext.Countries.AddRange(new List<CountryEntity>
                {
                    lCountryCzechRep,
                    lCountryEngland,
                    lCountryIndia,
                    lCountryBelgium,
                    lCountryMontenegro,
                    lCountryNewZealand,
                    lCountryUsa,
                    lCountryFrance,
                    lCountryItaly,
                    lCountryScotland,
                    lCountryAustralia,
                    lCountryTurkey,
                    lCountryBulgaria,
                    lCountrySerbia,
                    lCountryCyprus,
                    lCountryWales,
                    lCountryKyrgystan,
                });

                        lContext.SaveChanges();

                        lContext.PhotoOrganisations.AddRange(new List<PhotoOrganisationEntity>{ new PhotoOrganisationEntity
                {
                    Name = "FIAP",
                    EnableSectionTypes = false,
                    AwardLevels = new List<AwardLevelEntity>{
                        new AwardLevelEntity{
                            Name = "AFIAP",
                            MinimumAcceptances = 40,
                            MinimumCountries = 8,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 15,
                            MinimumSalons = 15,
                            MinimumPrints = 4,
                        },
                        new AwardLevelEntity{
                            Name = "EFIAP",
                            MinimumAcceptances = 250,
                            MinimumCountries = 20,
                            MinimumAwards = 2,
                            MinimumDistinctImages = 50,
                            MinimumSalons = 30,
                            MinimumPrints = 12,
                        },
                    }
                },
                new PhotoOrganisationEntity
                {
                    Name = "PSA",
                    EnableSectionTypes = true,
                    AwardLevels = new List<AwardLevelEntity>{
                        new AwardLevelEntity{
                            Name = "PSA 1*",
                            MinimumAcceptances = 18,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 6,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "PSA 2*",
                            MinimumAcceptances = 36,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 12,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "PSA 3*",
                            MinimumAcceptances = 72,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 24,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "PSA 4*",
                            MinimumAcceptances = 144,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 48,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "PSA 5*",
                            MinimumAcceptances = 288,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 96,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                    }
                },
                new PhotoOrganisationEntity
                {
                    Name = "BPE",
                    EnableSectionTypes = false,
                    AwardLevels = new List<AwardLevelEntity>{
                        new AwardLevelEntity{
                            Name = "BPE 1*",
                            MinimumAcceptances = 25,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "BPE 2*",
                            MinimumAcceptances = 50,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "BPE 3*",
                            MinimumAcceptances = 100,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "BPE 4*",
                            MinimumAcceptances = 200,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                        new AwardLevelEntity{
                            Name = "BPE 5*",
                            MinimumAcceptances = 300,
                            MinimumCountries = 0,
                            MinimumAwards = 0,
                            MinimumDistinctImages = 0,
                            MinimumSalons = 0,
                            MinimumPrints = 0,
                        },
                    }
                } });

                        var lSalonBohemia = new SalonEntity { Name = "Bohemia", Website = "http://bohemia.photosalon.cz/", Country = lCountryCzechRep };
                        var lSalonPhotoArtVision = new SalonEntity { Name = "Photo Art Vision", Website = "http://vision.photoart.cz/", Country = lCountryCzechRep };
                        var lSalonYorkshire = new SalonEntity { Name = "Yorkshire Salon", Website = "yorkshiresalon.co.uk", Country = lCountryEngland };
                        var lSalonBelghoria = new SalonEntity { Name = "Belghoria Photo Lovers", Website = "http://bohemia.photosalon.cz/", Country = lCountryIndia };
                        var lSalonRefletMondial = new SalonEntity { Name = "Reflet Mondial", Website = "http://refletmondial.be/wp/", Country = lCountryBelgium };
                        var lSalonBristol = new SalonEntity { Name = "Bristol", Website = "http://www.bristolphoto.org.uk/pages/bristol-salon.php", Country = lCountryEngland };
                        var lSalonVictoryPhotoClub = new SalonEntity { Name = "Victory Photo Club", Website = "http://www.victory-photo.club/", Country = lCountryMontenegro };
                        var lSalonNzis = new SalonEntity { Name = "NZIS", Website = "http://www.psnzinternationalsalons.com/", Country = lCountryNewZealand };
                        var lSalonPsaMet = new SalonEntity { Name = "PSA Metropolitan", Website = "http://www.psa-met.com/mipe", Country = lCountryUsa };
                        var lSalonCreativeArt = new SalonEntity { Name = "Creative Art", Website = "http://www.creativeartsalon.org/", Country = lCountryIndia };
                        var lSalonCarlisle = new SalonEntity { Name = "Carlisle Salon", Website = "http://www.solwaysalon.co.uk/gb17/entry.php", Country = lCountryEngland };
                        var lSalonPenrith = new SalonEntity { Name = "Penrith Salon", Website = "http://www.solwaysalon.co.uk/gb17/entry.php", Country = lCountryEngland };
                        var lSalonSolway = new SalonEntity { Name = "Solway Salon", Website = "http://www.solwaysalon.co.uk/gb17/entry.php", Country = lCountryEngland };
                        var lSalonKpaClub = new SalonEntity { Name = "KPA Club", Website = "http://www.kpaclub.com/", Country = lCountryIndia };
                        var lSalonLagacilly = new SalonEntity { Name = "Club Photo Lagacilly", Website = "http://www.clubphotolagacilly.com/", Country = lCountryFrance };
                        var lSalonDelleColline1 = new SalonEntity { Name = "21 Gan Tour Delle Colline - 35 Trofeo Arno - Incisa V.", Website = "http://www.grantourdellecolline.it/en/", Country = lCountryItaly };
                        var lSalonDelleColline2 = new SalonEntity { Name = "21 Gan Tour Delle Colline - 26 Trofeo Città di Figline Valdarno", Website = "http://www.grantourdellecolline.it/en/", Country = lCountryItaly };
                        var lSalonDelleColline3 = new SalonEntity { Name = "21 Gan Tour Delle Colline - 15 Trofeo Colline del Chianti", Website = "http://www.grantourdellecolline.it/en/", Country = lCountryItaly };
                        var lSalonDelleColline4 = new SalonEntity { Name = "21 Gan Tour Delle Colline - 15 Trofeo Colline del Pratomagno", Website = "http://www.grantourdellecolline.it/en/", Country = lCountryItaly };
                        var lSalonScottish = new SalonEntity { Name = "Scottish Salon", Website = "http://www.scottish-photographic-salon.org/", Country = lCountryScotland };
                        var lSalonSydney = new SalonEntity { Name = "Sydney Harbour", Website = "http://www.sydney-harbour-international.org.au/", Country = lCountryAustralia };
                        var lSalonCheltenham = new SalonEntity { Name = "Cheltenham", Website = "http://www.cheltenhamcameraclub.co.uk/wordpress/salon/", Country = lCountryEngland };
                        var lSalonHoylake = new SalonEntity { Name = "Hoylake", Website = "http://hoylakephoto.org/international/", Country = lCountryEngland };
                        var lSalonPerasto = new SalonEntity { Name = "Perasto", Website = "http://www.perasto.club/", Country = lCountryMontenegro };
                        var lSalonMof = new SalonEntity { Name = "MOF", Website = "http://contest.olbafotograf.com/", Country = lCountryTurkey };
                        var lSalonPrintAndDigitalVarna = new SalonEntity { Name = "Print and Digital Varna", Website = "http://printsalonvarna.org/", Country = lCountryBulgaria };
                        var lSalonGoodLight = new SalonEntity { Name = "Good Light", Website = "http://photoclubkragujevac.com/goodlight/", Country = lCountrySerbia };
                        var lSalonGradac = new SalonEntity { Name = "Gradac", Website = "http://www.gradacfoto.com/", Country = lCountryMontenegro };
                        var lSalonCyprus = new SalonEntity { Name = "Cyprus International", Website = "http://www.cps-cidpc.com/", Country = lCountryCyprus };
                        var lSalonPortTalbot = new SalonEntity { Name = "Port Talbot", Website = "http://www.cps-cidpc.com/", Country = lCountryWales };
                        var lSalonVictorPolynsky = new SalonEntity { Name = "Victor Polynsky", Website = "http://victorpolynsky.com", Country = lCountryKyrgystan };
                        var lSalonSrgb = new SalonEntity { Name = "SRGB Print Celebration", Website = "http://srgbphotogroup.co.uk/", Country = lCountryEngland };


                        lContext.Salons.AddRange(new List<SalonEntity>
                {
                    lSalonBohemia,
                    lSalonPhotoArtVision,
                    lSalonYorkshire,
                    lSalonBelghoria,
                    lSalonRefletMondial,
                    lSalonBristol,
                    lSalonVictoryPhotoClub,
                    lSalonNzis,
                    lSalonPsaMet,
                    lSalonCreativeArt,
                    lSalonCarlisle,
                    lSalonPenrith,
                    lSalonSolway,
                    lSalonKpaClub,
                    lSalonLagacilly,
                    lSalonDelleColline1,
                    lSalonDelleColline2,
                    lSalonDelleColline3,
                    lSalonDelleColline4,
                    lSalonScottish,
                    lSalonSydney,
                    lSalonCheltenham,
                    lSalonHoylake,
                    lSalonPerasto,
                    lSalonMof,
                    lSalonPrintAndDigitalVarna,
                    lSalonGoodLight,
                    lSalonGradac,
                    lSalonCyprus,
                    lSalonPortTalbot,
                    lSalonVictorPolynsky,
                });

                        lContext.SaveChanges();


                        var lCircuitGbSmallPrints = new CircuitEntity() { Name = "GB Small Prints 2017" };
                        var lGrandTourDelleColline = new CircuitEntity() { Name = "21 Gan Tour Delle Colline" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                    lCircuitGbSmallPrints,
                    lGrandTourDelleColline,
                });
                        lContext.SaveChanges();


                        var lSalonYearBohemia = new SalonYearEntity { Name = "Bohemia", Salon = lSalonBohemia, Year = 2016, ClosingDate = new DateTime(2016, 10, 9), JudgeDate = new DateTime(2016, 10, 15), NotificationDate = new DateTime(2016, 10, 15), CataloguesPostedDate = new DateTime(2016, 10, 15) };
                        var lSalonYearPhotoArtVision = new SalonYearEntity { Name = "Photo Art Vision", Salon = lSalonPhotoArtVision, Year = 2016, ClosingDate = new DateTime(2016, 11, 27), JudgeDate = new DateTime(2016, 12, 4), NotificationDate = new DateTime(2016, 12, 11), CataloguesPostedDate = new DateTime(2016, 12, 11) };
                        var lSalonYearYorkshire = new SalonYearEntity { Name = "Yorkshire Salon", Salon = lSalonYorkshire, Year = 2016, ClosingDate = new DateTime(2016, 12, 5), JudgeDate = new DateTime(2016, 12, 11), NotificationDate = new DateTime(2016, 12, 19), CataloguesPostedDate = new DateTime(2016, 12, 19) };
                        var lSalonYearBelghoria = new SalonYearEntity { Name = "Belghoria Photo Lovers", Salon = lSalonBelghoria, Year = 2017, ClosingDate = new DateTime(2016, 12, 31), JudgeDate = new DateTime(2017, 1, 19), NotificationDate = new DateTime(2017, 1, 31), CataloguesPostedDate = new DateTime(2017, 1, 31) };
                        var lSalonYearRefletMondial = new SalonYearEntity { Name = "Reflet Mondial", Salon = lSalonRefletMondial, Year = 2017, ClosingDate = new DateTime(2017, 1, 26), JudgeDate = new DateTime(2017, 1, 29), NotificationDate = new DateTime(2017, 2, 2), CataloguesPostedDate = new DateTime(2017, 2, 2) };
                        var lSalonYearBristol = new SalonYearEntity { Name = "Bristol", Salon = lSalonBristol, Year = 2017, ClosingDate = new DateTime(2017, 1, 31), JudgeDate = new DateTime(2017, 2, 19), NotificationDate = new DateTime(2017, 3, 4), CataloguesPostedDate = new DateTime(2017, 3, 4) };
                        var lSalonYearVictoryPhotoClub = new SalonYearEntity { Name = "Victory Photo Club", Salon = lSalonVictoryPhotoClub, Year = 2017, ClosingDate = new DateTime(2017, 2, 17), JudgeDate = new DateTime(2017, 3, 8), NotificationDate = new DateTime(2017, 3, 12), CataloguesPostedDate = new DateTime(2017, 3, 12) };
                        var lSalonYearNzis = new SalonYearEntity { Name = "NZIS", Salon = lSalonNzis, Year = 2017, ClosingDate = new DateTime(2017, 2, 17), JudgeDate = new DateTime(2017, 3, 5), NotificationDate = new DateTime(2017, 3, 18), CataloguesPostedDate = new DateTime(2017, 3, 18) };
                        var lSalonYearPsaMet = new SalonYearEntity { Name = "PSA Metropolitan", Salon = lSalonPsaMet, Year = 2017, ClosingDate = new DateTime(2017, 3, 3), JudgeDate = new DateTime(2017, 3, 17), NotificationDate = new DateTime(2017, 3, 26), CataloguesPostedDate = new DateTime(2017, 3, 26) };
                        var lSalonYearCreativeArt = new SalonYearEntity { Name = "Creative Art", Salon = lSalonCreativeArt, Year = 2017, ClosingDate = new DateTime(2017, 3, 6), JudgeDate = new DateTime(2017, 3, 19), NotificationDate = new DateTime(2017, 3, 31), CataloguesPostedDate = new DateTime(2017, 3, 31) };
                        var lSalonYearCarlisle = new SalonYearEntity { Name = "Carlisle Salon", Salon = lSalonCarlisle, Year = 2017, ClosingDate = new DateTime(2017, 3, 20), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 16), CataloguesPostedDate = new DateTime(2017, 4, 16), Circuit = lCircuitGbSmallPrints };
                        var lSalonYearPenrith = new SalonYearEntity { Name = "Penrith Salon", Salon = lSalonPenrith, Year = 2017, ClosingDate = new DateTime(2017, 3, 20), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 16), CataloguesPostedDate = new DateTime(2017, 4, 16), Circuit = lCircuitGbSmallPrints };
                        var lSalonYearSolway = new SalonYearEntity { Name = "Solway Salon", Salon = lSalonSolway, Year = 2017, ClosingDate = new DateTime(2017, 3, 20), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 16), CataloguesPostedDate = new DateTime(2017, 4, 16), Circuit = lCircuitGbSmallPrints };
                        var lSalonYearKpaClub = new SalonYearEntity { Name = "KPA Club", Salon = lSalonKpaClub, Year = 2017, ClosingDate = new DateTime(2017, 3, 11), JudgeDate = new DateTime(2017, 3, 25), NotificationDate = new DateTime(2017, 4, 5), CataloguesPostedDate = new DateTime(2017, 4, 5) };
                        var lSalonYearLagacilly = new SalonYearEntity { Name = "Club Photo Lagacilly", Salon = lSalonLagacilly, Year = 2017, ClosingDate = new DateTime(2017, 3, 27), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 10), CataloguesPostedDate = new DateTime(2017, 4, 10) };
                        var lSalonYearDelleColline1 = new SalonYearEntity { Name = "21 Gan Tour Delle Colline - 35 Trofeo Arno - Incisa V.", Salon = lSalonDelleColline1, Year = 2017, ClosingDate = new DateTime(2017, 4, 15), JudgeDate = new DateTime(2017, 4, 23), NotificationDate = new DateTime(2017, 4, 30), CataloguesPostedDate = new DateTime(2017, 4, 30), Circuit = lGrandTourDelleColline };
                        var lSalonYearDelleColline2 = new SalonYearEntity { Name = "21 Gan Tour Delle Colline - 26 Trofeo Città di Figline Valdarnoe", Salon = lSalonDelleColline2, Year = 2017, ClosingDate = new DateTime(2017, 4, 15), JudgeDate = new DateTime(2017, 4, 23), NotificationDate = new DateTime(2017, 4, 30), CataloguesPostedDate = new DateTime(2017, 4, 30), Circuit = lGrandTourDelleColline };
                        var lSalonYearDelleColline3 = new SalonYearEntity { Name = "21 Gan Tour Delle Colline - 15 Trofeo Colline del Chianti", Salon = lSalonDelleColline3, Year = 2017, ClosingDate = new DateTime(2017, 4, 15), JudgeDate = new DateTime(2017, 4, 23), NotificationDate = new DateTime(2017, 4, 30), CataloguesPostedDate = new DateTime(2017, 4, 30), Circuit = lGrandTourDelleColline };
                        var lSalonYearDelleColline4 = new SalonYearEntity { Name = "21 Gan Tour Delle Colline - 15 Trofeo Colline del Pratomagno", Salon = lSalonDelleColline4, Year = 2017, ClosingDate = new DateTime(2017, 4, 15), JudgeDate = new DateTime(2017, 4, 23), NotificationDate = new DateTime(2017, 4, 30), CataloguesPostedDate = new DateTime(2017, 4, 30), Circuit = lGrandTourDelleColline };
                        var lSalonYearScottish = new SalonYearEntity { Name = "Scottish Salon", Salon = lSalonScottish, Year = 2017, ClosingDate = new DateTime(2017, 3, 20), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 16), CataloguesPostedDate = new DateTime(2017, 4, 16) };
                        var lSalonYearSydney = new SalonYearEntity { Name = "Sydney Harbour", Salon = lSalonSydney, Year = 2017, ClosingDate = new DateTime(2017, 4, 13), JudgeDate = new DateTime(2017, 4, 30), NotificationDate = new DateTime(2017, 5, 8), CataloguesPostedDate = new DateTime(2017, 5, 8) };
                        var lSalonYearCheltenham = new SalonYearEntity { Name = "Cheltenham", Salon = lSalonCheltenham, Year = 2017, ClosingDate = new DateTime(2017, 4, 23), JudgeDate = new DateTime(2017, 5, 7), NotificationDate = new DateTime(2017, 5, 17), CataloguesPostedDate = new DateTime(2017, 5, 17) };
                        var lSalonYearHoylake = new SalonYearEntity { Name = "Hoylake", Salon = lSalonHoylake, Year = 2017, ClosingDate = new DateTime(2017, 4, 23), JudgeDate = new DateTime(2017, 5, 7), NotificationDate = new DateTime(2017, 5, 14), CataloguesPostedDate = new DateTime(2017, 5, 17) };
                        var lSalonYearPerasto = new SalonYearEntity { Name = "Perasto", Salon = lSalonPerasto, Year = 2017, ClosingDate = new DateTime(2017, 4, 30), JudgeDate = new DateTime(2017, 5, 14), NotificationDate = new DateTime(2017, 5, 17), CataloguesPostedDate = new DateTime(2017, 5, 17) };
                        var lSalonYearMof = new SalonYearEntity { Name = "MOF", Salon = lSalonMof, Year = 2017, ClosingDate = new DateTime(2017, 5, 5), JudgeDate = new DateTime(2017, 5, 17), NotificationDate = new DateTime(2017, 5, 31), CataloguesPostedDate = new DateTime(2017, 5, 31) };
                        var lSalonYearPrintAndDigitalVarna = new SalonYearEntity { Name = "Print and Digital Varna", Salon = lSalonPrintAndDigitalVarna, Year = 2017, ClosingDate = new DateTime(2017, 5, 10), JudgeDate = new DateTime(2017, 6, 1), NotificationDate = new DateTime(2017, 6, 9), CataloguesPostedDate = new DateTime(2017, 6, 9) };
                        var lSalonYearGoodLight = new SalonYearEntity { Name = "Good Light", Salon = lSalonGoodLight, Year = 2017, ClosingDate = new DateTime(2017, 5, 10), JudgeDate = new DateTime(2017, 5, 21), NotificationDate = new DateTime(2017, 6, 1), CataloguesPostedDate = new DateTime(2017, 7, 31) };
                        var lSalonYearGradac = new SalonYearEntity { Name = "Gradac", Salon = lSalonGradac, Year = 2017, ClosingDate = new DateTime(2017, 5, 14), JudgeDate = new DateTime(2017, 5, 30), NotificationDate = new DateTime(2017, 6, 5), CataloguesPostedDate = new DateTime(2017, 8, 13) };
                        var lSalonYearCyprus = new SalonYearEntity { Name = "Cyprus International", Salon = lSalonCyprus, Year = 2017, ClosingDate = new DateTime(2017, 5, 28), JudgeDate = new DateTime(2017, 6, 11), NotificationDate = new DateTime(2017, 6, 24), CataloguesPostedDate = new DateTime(2017, 8, 20) };
                        var lSalonYearPortTalbot = new SalonYearEntity { Name = "Port Talbot", Salon = lSalonPortTalbot, Year = 2017, ClosingDate = new DateTime(2017, 6, 17), JudgeDate = new DateTime(2017, 7, 2), NotificationDate = new DateTime(2017, 7, 9), CataloguesPostedDate = new DateTime(2017, 8, 13) };
                        var lSalonYearVictorPolynsky = new SalonYearEntity { Name = "Victor Polynsky", Salon = lSalonVictorPolynsky, Year = 2017, ClosingDate = new DateTime(2017, 6, 21), JudgeDate = new DateTime(2017, 6, 22), NotificationDate = new DateTime(2017, 7, 12), CataloguesPostedDate = new DateTime(2017, 7, 12) };
                        var lSalonYearSrgb = new SalonYearEntity { Name = "SRGB Print Celebration", Salon = lSalonSrgb, Year = 2017, ClosingDate = new DateTime(2017, 7, 16), JudgeDate = new DateTime(2017, 7, 22), NotificationDate = new DateTime(2017, 7, 22), CataloguesPostedDate = new DateTime(2017, 7, 22) };


                        lContext.SalonYears.AddRange(new List<SalonYearEntity>
                {
                    lSalonYearBohemia,
                    lSalonYearPhotoArtVision,
                    lSalonYearYorkshire,
                    lSalonYearBelghoria,
                    lSalonYearRefletMondial,
                    lSalonYearBristol,
                    lSalonYearVictoryPhotoClub,
                    lSalonYearNzis,
                    lSalonYearPsaMet,
                    lSalonYearCreativeArt,
                    lSalonYearCarlisle,
                    lSalonYearPenrith,
                    lSalonYearSolway,
                    lSalonYearKpaClub,
                    lSalonYearLagacilly,
                    lSalonYearDelleColline1,
                    lSalonYearDelleColline2,
                    lSalonYearDelleColline3,
                    lSalonYearDelleColline4,
                    lSalonYearScottish,
                    lSalonYearSydney,
                    lSalonYearCheltenham,
                    lSalonYearHoylake,
                    lSalonYearPerasto,
                    lSalonYearMof,
                    lSalonYearPrintAndDigitalVarna,
                    lSalonYearGoodLight,
                    lSalonYearGradac,
                    lSalonYearCyprus,
                    lSalonYearPortTalbot,
                    lSalonYearVictorPolynsky,
                });
                        lContext.SaveChanges();


                        var lPsa = (from org in lContext.PhotoOrganisations
                                    where org.Name == "PSA"
                                    select org).FirstOrDefault();

                        var lFiap = (from org in lContext.PhotoOrganisations
                                     where org.Name == "FIAP"
                                     select org).FirstOrDefault();

                        var lBpe = (from org in lContext.PhotoOrganisations
                                    where org.Name == "BPE"
                                    select org).FirstOrDefault();

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                    new AccreditationEntity() { SalonNumber = "2016/460", PhotoOrganisation = lFiap, SalonYear = lSalonYearBohemia },
                    new AccreditationEntity() { SalonNumber = "2016/499", PhotoOrganisation = lFiap, SalonYear = lSalonYearPhotoArtVision },
                    new AccreditationEntity() { SalonNumber = "2016/309", PhotoOrganisation = lFiap, SalonYear = lSalonYearYorkshire },
                    new AccreditationEntity() { SalonNumber = "2017/017", PhotoOrganisation = lFiap, SalonYear = lSalonYearBelghoria },
                    new AccreditationEntity() { SalonNumber = "2017/004", PhotoOrganisation = lFiap, SalonYear = lSalonYearRefletMondial },
                    new AccreditationEntity() { SalonNumber = "2017/002", PhotoOrganisation = lFiap, SalonYear = lSalonYearBristol },
                    new AccreditationEntity() { SalonNumber = "2017/130", PhotoOrganisation = lFiap, SalonYear = lSalonYearVictoryPhotoClub },
                    new AccreditationEntity() { SalonNumber = "2017/029", PhotoOrganisation = lFiap, SalonYear = lSalonYearNzis },
                    new AccreditationEntity() { SalonNumber = "2017/012", PhotoOrganisation = lFiap, SalonYear = lSalonYearPsaMet },
                    new AccreditationEntity() { SalonNumber = "2017/078", PhotoOrganisation = lFiap, SalonYear = lSalonYearCreativeArt },
                    new AccreditationEntity() { SalonNumber = "2017/084", PhotoOrganisation = lFiap, SalonYear = lSalonYearCarlisle, },
                    new AccreditationEntity() { SalonNumber = "2017/085", PhotoOrganisation = lFiap, SalonYear = lSalonYearPenrith, },
                    new AccreditationEntity() { SalonNumber = "2017/086", PhotoOrganisation = lFiap, SalonYear = lSalonYearSolway, },
                    new AccreditationEntity() { SalonNumber = "2017/176", PhotoOrganisation = lFiap, SalonYear = lSalonYearKpaClub, },
                    new AccreditationEntity() { SalonNumber = "2017/152", PhotoOrganisation = lFiap, SalonYear = lSalonYearLagacilly, },
                    new AccreditationEntity() { SalonNumber = "2017/125", PhotoOrganisation = lFiap, SalonYear = lSalonYearDelleColline1, },
                    new AccreditationEntity() { SalonNumber = "2017/126", PhotoOrganisation = lFiap, SalonYear = lSalonYearDelleColline2, },
                    new AccreditationEntity() { SalonNumber = "2017/127", PhotoOrganisation = lFiap, SalonYear = lSalonYearDelleColline3, },
                    new AccreditationEntity() { SalonNumber = "2017/128", PhotoOrganisation = lFiap, SalonYear = lSalonYearDelleColline4, },
                    new AccreditationEntity() { SalonNumber = "2017/217", PhotoOrganisation = lFiap, SalonYear = lSalonYearScottish, },
                    new AccreditationEntity() { SalonNumber = "2017/052", PhotoOrganisation = lFiap, SalonYear = lSalonYearSydney, },
                    new AccreditationEntity() { SalonNumber = "2017/138", PhotoOrganisation = lFiap, SalonYear = lSalonYearCheltenham, },
                    new AccreditationEntity() { SalonNumber = "2017/136", PhotoOrganisation = lFiap, SalonYear = lSalonYearHoylake, },
                    new AccreditationEntity() { SalonNumber = "2017/185", PhotoOrganisation = lFiap, SalonYear = lSalonYearPerasto, },
                    new AccreditationEntity() { SalonNumber = "2017/211", PhotoOrganisation = lFiap, SalonYear = lSalonYearMof, },
                    new AccreditationEntity() { SalonNumber = "2017/190", PhotoOrganisation = lFiap, SalonYear = lSalonYearPrintAndDigitalVarna, },
                    new AccreditationEntity() { SalonNumber = "2017/171", PhotoOrganisation = lFiap, SalonYear = lSalonYearGoodLight, },
                    new AccreditationEntity() { SalonNumber = "2017/226", PhotoOrganisation = lFiap, SalonYear = lSalonYearGradac, },
                    new AccreditationEntity() { SalonNumber = "2017/204", PhotoOrganisation = lFiap, SalonYear = lSalonYearCyprus, },
                    new AccreditationEntity() { SalonNumber = "2017/250", PhotoOrganisation = lFiap, SalonYear = lSalonYearPortTalbot, },
                    new AccreditationEntity() { SalonNumber = "2017/403", PhotoOrganisation = lFiap, SalonYear = lSalonYearVictorPolynsky, },

                    new AccreditationEntity() { SalonNumber = "2016-317", PhotoOrganisation = lPsa, SalonYear = lSalonYearPhotoArtVision, },
                    new AccreditationEntity() { SalonNumber = "2016-245", PhotoOrganisation = lPsa, SalonYear = lSalonYearYorkshire, },
                    new AccreditationEntity() { SalonNumber = "2016-346", PhotoOrganisation = lPsa, SalonYear = lSalonYearBelghoria, },
                    new AccreditationEntity() { SalonNumber = "2017-002", PhotoOrganisation = lPsa, SalonYear = lSalonYearRefletMondial, },
                    new AccreditationEntity() { SalonNumber = "2017-006", PhotoOrganisation = lPsa, SalonYear = lSalonYearBristol, },
                    new AccreditationEntity() { SalonNumber = "2017-064", PhotoOrganisation = lPsa, SalonYear = lSalonYearVictoryPhotoClub, },
                    new AccreditationEntity() { SalonNumber = "2017-053", PhotoOrganisation = lPsa, SalonYear = lSalonYearNzis, },
                    new AccreditationEntity() { SalonNumber = "2017-011", PhotoOrganisation = lPsa, SalonYear = lSalonYearPsaMet, },
                    new AccreditationEntity() { SalonNumber = "2017-067", PhotoOrganisation = lPsa, SalonYear = lSalonYearCreativeArt, },
                    new AccreditationEntity() { SalonNumber = "2017-091", PhotoOrganisation = lPsa, SalonYear = lSalonYearCarlisle, },
                    new AccreditationEntity() { SalonNumber = "2017-091", PhotoOrganisation = lPsa, SalonYear = lSalonYearPenrith, },
                    new AccreditationEntity() { SalonNumber = "2017-091", PhotoOrganisation = lPsa, SalonYear = lSalonYearSolway, },
                    new AccreditationEntity() { SalonNumber = "2017-066", PhotoOrganisation = lPsa, SalonYear = lSalonYearKpaClub, },
                    new AccreditationEntity() { SalonNumber = "2017-086", PhotoOrganisation = lPsa, SalonYear = lSalonYearLagacilly, },
                    new AccreditationEntity() { SalonNumber = "2017-113", PhotoOrganisation = lPsa, SalonYear = lSalonYearScottish, },
                    new AccreditationEntity() { SalonNumber = "2017-020", PhotoOrganisation = lPsa, SalonYear = lSalonYearSydney, },
                    new AccreditationEntity() { SalonNumber = "2017-071", PhotoOrganisation = lPsa, SalonYear = lSalonYearCheltenham, },
                    new AccreditationEntity() { SalonNumber = "2017-095", PhotoOrganisation = lPsa, SalonYear = lSalonYearHoylake, },
                    new AccreditationEntity() { SalonNumber = "2017-125", PhotoOrganisation = lPsa, SalonYear = lSalonYearPerasto, },
                    new AccreditationEntity() { SalonNumber = "2017-144", PhotoOrganisation = lPsa, SalonYear = lSalonYearPrintAndDigitalVarna, },
                    new AccreditationEntity() { SalonNumber = "2017-142", PhotoOrganisation = lPsa, SalonYear = lSalonYearGoodLight, },
                    new AccreditationEntity() { SalonNumber = "2017-154", PhotoOrganisation = lPsa, SalonYear = lSalonYearGradac, },
                    new AccreditationEntity() { SalonNumber = "2017-155", PhotoOrganisation = lPsa, SalonYear = lSalonYearCyprus, },
                    new AccreditationEntity() { SalonNumber = "2017-175", PhotoOrganisation = lPsa, SalonYear = lSalonYearPortTalbot, },
                    new AccreditationEntity() { SalonNumber = "2017-165", PhotoOrganisation = lPsa, SalonYear = lSalonYearVictorPolynsky, },
                    new AccreditationEntity() { SalonNumber = "2017 BPE", PhotoOrganisation = lBpe, SalonYear = lSalonYearSrgb, },
                });
                        lContext.SaveChanges();

                        var lSectionTypeColourPdi = new SectionTypeEntity() { Name = "Open Colour", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeMonoPdi = new SectionTypeEntity() { Name = "Open Mono", IsPrint = false, SectionCode = "PIDM" };
                        var lSectionTypeOpenPdi = new SectionTypeEntity() { Name = "Open Colour and Mono", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeNaturePdi = new SectionTypeEntity() { Name = "Nature", IsPrint = false, SectionCode = "ND" };
                        var lSectionTypeTravelPdi = new SectionTypeEntity() { Name = "Travel", IsPrint = false, SectionCode = "PTD" };
                        var lSectionTypeCreativePdi = new SectionTypeEntity() { Name = "Creative", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeMonoLandscapePdi = new SectionTypeEntity() { Name = "Landscape Mono", IsPrint = false, SectionCode = "PIDM" };
                        var lSectionTypeScapesPdi = new SectionTypeEntity() { Name = "Scapes", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypePhotojournalismPdi = new SectionTypeEntity() { Name = "Photojournalism", IsPrint = false, SectionCode = "PJD" };
                        var lSectionTypeActionMovementSportPdi = new SectionTypeEntity() { Name = "Action Movement Sport", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeDecisiveMomentPdi = new SectionTypeEntity() { Name = "Decisive Moment", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeChildPdi = new SectionTypeEntity() { Name = "Child", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeWomanPdi = new SectionTypeEntity() { Name = "Woman", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeManWomanChildPdi = new SectionTypeEntity() { Name = "Man Woman Child", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeGoodLightPdi = new SectionTypeEntity() { Name = "Good Light", IsPrint = false, SectionCode = "PIDC" };

                        var lSectionTypeColourPrint = new SectionTypeEntity() { Name = "Open Colour Print", IsPrint = true, SectionCode = "PPD" };
                        var lSectionTypeMonoPrint = new SectionTypeEntity() { Name = "Open Mono Print", IsPrint = true, SectionCode = "PPD" };
                        var lSectionTypeTravelPrint = new SectionTypeEntity() { Name = "Travel Print", IsPrint = true, SectionCode = "PTD" };
                        var lSectionTypeNaturePrint = new SectionTypeEntity() { Name = "Nature Print", IsPrint = true, SectionCode = "ND" };
                        var lSectionTypeMonoLandscapePrint = new SectionTypeEntity() { Name = "Mono Landscape Print", IsPrint = true, SectionCode = "PPD" };

                        var lSectionTypeSrgbAnythingGoes = new SectionTypeEntity() { Name = "SRGB Anything Goes", IsPrint = true, SectionCode = "" };
                        var lSectionTypeSrgbCreatures = new SectionTypeEntity() { Name = "SRGB Creatures of the World", IsPrint = true, SectionCode = "" };
                        var lSectionTypeSrgbEnvironment = new SectionTypeEntity() { Name = "SRGB Environment", IsPrint = true, SectionCode = "" };
                        var lSectionTypeSrgbHumanity = new SectionTypeEntity() { Name = "SRGB Humanity", IsPrint = true, SectionCode = "" };
                        var lSectionTypeSrgbTriptych = new SectionTypeEntity() { Name = "SRGB Triptych", IsPrint = true, SectionCode = "" };

                        lContext.SectionTypes.AddRange(new List<SectionTypeEntity> {
                    lSectionTypeColourPdi,
                    lSectionTypeMonoPdi,
                    lSectionTypeOpenPdi,
                    lSectionTypeNaturePdi,
                    lSectionTypeTravelPdi,
                    lSectionTypeCreativePdi,
                    lSectionTypeMonoLandscapePdi,
                    lSectionTypeScapesPdi,
                    lSectionTypePhotojournalismPdi,
                    lSectionTypeActionMovementSportPdi,
                    lSectionTypeDecisiveMomentPdi,
                    lSectionTypeChildPdi,
                    lSectionTypeWomanPdi,
                    lSectionTypeManWomanChildPdi,
                    lSectionTypeGoodLightPdi,
                    lSectionTypeColourPrint,
                    lSectionTypeMonoPrint,
                    lSectionTypeTravelPrint,
                    lSectionTypeNaturePrint,
                    lSectionTypeMonoLandscapePrint,
            });
                        lContext.SaveChanges();

                        var lTim = new PersonEntity() { Name = "Tim" };
                        lContext.People.Add(lTim);
                        lContext.SaveChanges();

                        var lIntoTheMist = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Into The Mist" };
                        var lDaisy = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Daisy" };
                        var lRuinsByNight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Ruins By Night" };
                        var lOliversCastle = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Olivers Castle" };
                        var lCathedralCeiling = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Cathedral Ceiling" };
                        var lTheDance = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Dance" };
                        var lThroughTheArch = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Through The Arch" };
                        var lTreeGroveInTheMist = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tree Grove In The Mist" };
                        var lTheWatcherInTheWaves = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Watcher In The Waves" };
                        var lYoungRedKite = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Young Red Kite" };
                        var lGreatGreyOwl = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Great Grey Owl" };
                        var lAcrossTheLake = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Across The Lake" };
                        var lAWorldBeyond = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "A World Beyond" };
                        var lWatchfulness = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Watchfulness" };
                        var lAfternoonGun = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Afternoon Gun Valletta Malta" };
                        var lFreshSnow = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Fresh Snow South Island NZ" };
                        var lLongEaredOwl = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Long Eared Owl" };
                        var lButtermere = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Buttermere Lake District UK" };
                        var lButtermereTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Buttermere Tree" };
                        var lLakeKaniere = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Lake Kaniere New Zealand" };
                        var lTheWatcher = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Watcher" };
                        var lSpiralNine = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Sprial Nine" };
                        var lHedgehog = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Hedgehog" };
                        var lOrb = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Orb" };
                        var lLittleOwl = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Little Owl" };
                        var lFloodingInLeeds = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Flooding In Leeds 2015" };
                        var lBudirChurch = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Budir Church Iceland" };
                        var lKirkjufellSnow = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Kirkjufell Snow" };
                        var lBungeeJumpScream = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bungee Jump Scream" };
                        var lCanadaGosling = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Canada Gosling" };
                        var lTowardsTheLight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Towards The Light" };
                        var lBoatingInTheHail = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Boating In The Hail" };

                        var lLoneTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Lone Tree" };
                        var lSolitaryTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Solitary Tree" };
                        var lBridgeSuspension = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bridge Suspension" };
                        var lInnerLight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Inner Light" };
                        var lStarfall = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Starfall" };
                        var lAnotherPlaceAnotherWorld = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Another Place Another World" };
                        var lHarvestMouseCowParsley = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Harvest Mouse on Cow Parsley" };
                        var lHarvestMouseWheat = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Harvest Mouse on Wheat" };
                        var lWaterVole = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Water Vole" };
                        var lWaterVoleInPipe = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Water Vole in Pipe" };
                        var lZombieGirl = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zombie Girl" };
                        var lLakeShore = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Lake Shore" };
                        var lSteppingStones = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Stepping Stones" };
                        var lIcelandicPeak = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Icelandic Peak" };
                        var lKirkjufellRock = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Kirkjufell Rock" };
                        var lIcelandicHorse = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Icelandic Horse" };
                        var lLeithReflections = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Leith Reflections" };
                        var lDawnInTheOutback = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Dawn in the Outback" };
                        var lTwelveApostlesSunset = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Twelve Apostles Sunset" };
                        var lPathStripes = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Path Stripes" };
                        var lFreshSnowIceland = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Fresh Snow Iceland" };
                        var lSentinel = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Sentinel" };
                        var lWoodlandLight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Woodland Light" };
                        var lPollinationCanopy = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Pollination Canopy" };
                        var lTheQualityOfSilence = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Quality of Silence" };
                        var lLiverpoolWheelAndDocks = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Liverpool Wheel and Docks" };
                        var lDreamsOfNature = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Dreams Of Nature" };
                        var lLivingTheMalteseDream = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Living the Maltese Dream" };
                        var lHarbourSailingInMalta = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Harbour Sailing In Malta" };
                        var l4464Bittern = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "4464 Bittern" };
                        var lEricTreacy = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Eric Treacy" };
                        var lMalteseDoor = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Maltese Door" };
                        var lWaveWatcher = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Wave Watcher" };
                        var lDeepThinking = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Deep Thinking" };
                        var lRedKite = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Red Kite" };
                        var lBoltonAbbey = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bolton Abbey" };
                        var lGrassIceland = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Grass Iceland" };
                        var lGlacierLagoonIceland = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Glacier Lagoon Iceland" };
                        var lZombieSelfie = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zombie Selfie" };
                        var lZombieSafetyTraining = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zombie Safety Training" };
                        var lZombieTraining = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zombie Training" };
                        var lReflect = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Reflect" };
                        var lTourDeYorkshire = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tour De Yorkshire" };

                        var lWatchingTheApocalypse = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Watching The Apocalypse" };
                        var lDarkHorizons = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Dark Horizons" };
                        var lRedFox = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Red Fix" };
                        var lHarvestMiceOnWheat = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Harvest Mice on Wheat [Creative]" };
                        var lHedgehogInLeaves = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Hedgehog In Leaves" };
                        var lLakeGuardian = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Lake Guardian" };
                        var lEchoesOfTheGreatWar = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Echoes of the Great War" };
                        var lVikingShieldWall = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Viking Shield Wall" };
                        var lGrassesTriptych = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Grasses" };
                        var lParisianLightTriptych = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Parisian Light" };
                        var lOrbsTriptych = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Orbs" };
                        var lCubePyramidSphereTriptych = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Cube Pyramid Sphere" };

                        lContext.Images.AddRange(new List<ImageEntity> {
                     lIntoTheMist,
                     lDaisy,
                     lRuinsByNight,
                     lOliversCastle,
                     lCathedralCeiling,
                     lTheDance,
                     lThroughTheArch,
                     lTreeGroveInTheMist,
                     lTheWatcherInTheWaves,
                     lYoungRedKite,
                     lGreatGreyOwl,
                     lAcrossTheLake,
                     lAWorldBeyond,
                     lWatchfulness,
                     lAfternoonGun,
                     lFreshSnow,
                     lLongEaredOwl,
                     lButtermere,
                     lButtermereTree,
                     lLakeKaniere,
                     lTheWatcher,
                     lSpiralNine,
                     lHedgehog,
                     lOrb,
                     lLittleOwl,
                     lFloodingInLeeds,
                     lBudirChurch,
                     lKirkjufellSnow,
                     lBungeeJumpScream,
                     lCanadaGosling,
                     lTowardsTheLight,
                     lBoatingInTheHail,

                     lSolitaryTree,
                     lLoneTree,
                     lBridgeSuspension,
                     lInnerLight,
                     lStarfall,
                     lAnotherPlaceAnotherWorld,
                     lHarvestMouseCowParsley,
                     lHarvestMouseWheat,
                     lWaterVole,
                     lWaterVoleInPipe,
                     lZombieGirl,
                     lLakeShore,
                     lSteppingStones,
                     lIcelandicPeak,
                     lKirkjufellRock,
                     lLakeShore,
                     lSteppingStones,
                     lIcelandicHorse,
                     lLeithReflections,
                     lDawnInTheOutback,
                     lTwelveApostlesSunset,
                     lPathStripes,
                     lSteppingStones,
                     lFreshSnowIceland,
                     lSentinel,
                     lWoodlandLight,
                     lPollinationCanopy,
                     lTheQualityOfSilence,
                     lLiverpoolWheelAndDocks,
                     lDreamsOfNature,
                     lLivingTheMalteseDream,
                     lHarbourSailingInMalta,
                     l4464Bittern,
                     lEricTreacy,
                     lMalteseDoor,
                     lWaveWatcher,
                     lDeepThinking,
                     lRedKite,
                     lBoltonAbbey,
                     lGrassIceland,
                     lGlacierLagoonIceland,
                     lZombieSelfie,
                     lZombieSafetyTraining,
                     lZombieTraining,
                     lReflect,
                     lTourDeYorkshire,

            });
                        lContext.SaveChanges();


                        var lSalonYearBohemiaColour = new SectionEntity() { SalonYear = lSalonYearBohemia, SectionType = lSectionTypeColourPdi };

                        var lSalonYearPhotoArtVisionColour = new SectionEntity() { SalonYear = lSalonYearPhotoArtVision, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoArtVisionMono = new SectionEntity() { SalonYear = lSalonYearPhotoArtVision, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearYorkshireOpen = new SectionEntity() { SalonYear = lSalonYearYorkshire, SectionType = lSectionTypeOpenPdi };

                        var lSalonYearBelghoriaColour = new SectionEntity() { SalonYear = lSalonYearBelghoria, SectionType = lSectionTypeColourPdi };
                        var lSalonYearBelghoriaMono = new SectionEntity() { SalonYear = lSalonYearBelghoria, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearRefletMondialColour = new SectionEntity() { SalonYear = lSalonYearRefletMondial, SectionType = lSectionTypeColourPdi };
                        var lSalonYearRefletMondialMono = new SectionEntity() { SalonYear = lSalonYearRefletMondial, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearBristolColour = new SectionEntity() { SalonYear = lSalonYearBristol, SectionType = lSectionTypeColourPdi };
                        var lSalonYearBristolMono = new SectionEntity() { SalonYear = lSalonYearBristol, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearVictoryPhotoClubOpen = new SectionEntity() { SalonYear = lSalonYearVictoryPhotoClub, SectionType = lSectionTypeOpenPdi };
                        var lSalonYearVictoryPhotoClubNature = new SectionEntity() { SalonYear = lSalonYearVictoryPhotoClub, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearVictoryPhotoClubTravel = new SectionEntity() { SalonYear = lSalonYearVictoryPhotoClub, SectionType = lSectionTypeTravelPdi };

                        var lSalonYearNzisColour = new SectionEntity() { SalonYear = lSalonYearNzis, SectionType = lSectionTypeColourPdi };
                        var lSalonYearNzisCreative = new SectionEntity() { SalonYear = lSalonYearNzis, SectionType = lSectionTypeCreativePdi };

                        var lSalonYearPsaMetColour = new SectionEntity() { SalonYear = lSalonYearPsaMet, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPsaMetMono = new SectionEntity() { SalonYear = lSalonYearPsaMet, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearCreativeArtColour = new SectionEntity() { SalonYear = lSalonYearCreativeArt, SectionType = lSectionTypeColourPdi };
                        var lSalonYearCreativeArtMono = new SectionEntity() { SalonYear = lSalonYearCreativeArt, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearCarlisleColourPrint = new SectionEntity() { SalonYear = lSalonYearCarlisle, SectionType = lSectionTypeColourPrint };
                        var lSalonYearCarlisleMonoPrint = new SectionEntity() { SalonYear = lSalonYearCarlisle, SectionType = lSectionTypeMonoPrint };
                        var lSalonYearCarlisleTravelPrint = new SectionEntity() { SalonYear = lSalonYearCarlisle, SectionType = lSectionTypeTravelPrint };
                        var lSalonYearCarlisleNaturePrint = new SectionEntity() { SalonYear = lSalonYearCarlisle, SectionType = lSectionTypeNaturePrint };
                        var lSalonYearCarlisleMonoLandscapePrint = new SectionEntity() { SalonYear = lSalonYearCarlisle, SectionType = lSectionTypeMonoLandscapePrint };

                        var lSalonYearPenrithColourPrint = new SectionEntity() { SalonYear = lSalonYearPenrith, SectionType = lSectionTypeColourPrint };
                        var lSalonYearPenrithMonoPrint = new SectionEntity() { SalonYear = lSalonYearPenrith, SectionType = lSectionTypeMonoPrint };
                        var lSalonYearPenrithTravelPrint = new SectionEntity() { SalonYear = lSalonYearPenrith, SectionType = lSectionTypeTravelPrint };
                        var lSalonYearPenrithNaturePrint = new SectionEntity() { SalonYear = lSalonYearPenrith, SectionType = lSectionTypeNaturePrint };
                        var lSalonYearPenrithMonoLandscapePrint = new SectionEntity() { SalonYear = lSalonYearPenrith, SectionType = lSectionTypeMonoLandscapePrint };

                        var lSalonYearSolwayColourPrint = new SectionEntity() { SalonYear = lSalonYearSolway, SectionType = lSectionTypeColourPrint };
                        var lSalonYearSolwayMonoPrint = new SectionEntity() { SalonYear = lSalonYearSolway, SectionType = lSectionTypeMonoPrint };
                        var lSalonYearSolwayTravelPrint = new SectionEntity() { SalonYear = lSalonYearSolway, SectionType = lSectionTypeTravelPrint };
                        var lSalonYearSolwayNaturePrint = new SectionEntity() { SalonYear = lSalonYearSolway, SectionType = lSectionTypeNaturePrint };
                        var lSalonYearSolwayMonoLandscapePrint = new SectionEntity() { SalonYear = lSalonYearSolway, SectionType = lSectionTypeMonoLandscapePrint };

                        var lSalonYearKpaClubColour = new SectionEntity() { SalonYear = lSalonYearKpaClub, SectionType = lSectionTypeColourPdi };
                        var lSalonYearKpaClubMono = new SectionEntity() { SalonYear = lSalonYearKpaClub, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearKpaClubNature = new SectionEntity() { SalonYear = lSalonYearKpaClub, SectionType = lSectionTypeNaturePdi };

                        var lSalonYearLagacillyColour = new SectionEntity() { SalonYear = lSalonYearLagacilly, SectionType = lSectionTypeColourPdi };

                        var lSalonYearDelleColline1Colour = new SectionEntity() { SalonYear = lSalonYearDelleColline1, SectionType = lSectionTypeColourPdi };
                        var lSalonYearDelleColline1Mono = new SectionEntity() { SalonYear = lSalonYearDelleColline1, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearDelleColline2Colour = new SectionEntity() { SalonYear = lSalonYearDelleColline2, SectionType = lSectionTypeColourPdi };
                        var lSalonYearDelleColline2Mono = new SectionEntity() { SalonYear = lSalonYearDelleColline2, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearDelleColline3Colour = new SectionEntity() { SalonYear = lSalonYearDelleColline3, SectionType = lSectionTypeColourPdi };
                        var lSalonYearDelleColline3Mono = new SectionEntity() { SalonYear = lSalonYearDelleColline3, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearDelleColline4Colour = new SectionEntity() { SalonYear = lSalonYearDelleColline4, SectionType = lSectionTypeColourPdi };
                        var lSalonYearDelleColline4Mono = new SectionEntity() { SalonYear = lSalonYearDelleColline4, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearScottishMonoPrint = new SectionEntity() { SalonYear = lSalonYearScottish, SectionType = lSectionTypeMonoPrint };
                        var lSalonYearScottishColourPrint = new SectionEntity() { SalonYear = lSalonYearScottish, SectionType = lSectionTypeColourPrint };
                        var lSalonYearScottishColour = new SectionEntity() { SalonYear = lSalonYearScottish, SectionType = lSectionTypeColourPdi };

                        var lSalonYearSydneyColour = new SectionEntity() { SalonYear = lSalonYearSydney, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSydneyMono = new SectionEntity() { SalonYear = lSalonYearSydney, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSydneyCreative = new SectionEntity() { SalonYear = lSalonYearSydney, SectionType = lSectionTypeCreativePdi };

                        var lSalonYearCheltenhamColour = new SectionEntity() { SalonYear = lSalonYearCheltenham, SectionType = lSectionTypeColourPdi };
                        var lSalonYearCheltenhamMono = new SectionEntity() { SalonYear = lSalonYearCheltenham, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearCheltenhamCreative = new SectionEntity() { SalonYear = lSalonYearCheltenham, SectionType = lSectionTypeCreativePdi };

                        var lSalonYearHoylakeColour = new SectionEntity() { SalonYear = lSalonYearHoylake, SectionType = lSectionTypeColourPdi };
                        var lSalonYearHoylakeMono = new SectionEntity() { SalonYear = lSalonYearHoylake, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearHoylakeScapes = new SectionEntity() { SalonYear = lSalonYearHoylake, SectionType = lSectionTypeScapesPdi };
                        var lSalonYearHoylakeNature = new SectionEntity() { SalonYear = lSalonYearHoylake, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearHoylakePhotojournalism = new SectionEntity() { SalonYear = lSalonYearHoylake, SectionType = lSectionTypePhotojournalismPdi };
                        var lSalonYearHoylakeTravel = new SectionEntity() { SalonYear = lSalonYearHoylake, SectionType = lSectionTypeTravelPdi };

                        var lSalonYearPerastoOpen = new SectionEntity() { SalonYear = lSalonYearPerasto, SectionType = lSectionTypeOpenPdi };
                        var lSalonYearPerastoNature = new SectionEntity() { SalonYear = lSalonYearPerasto, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearPerastoTravel = new SectionEntity() { SalonYear = lSalonYearPerasto, SectionType = lSectionTypeTravelPdi };

                        var lSalonYearMofNature = new SectionEntity() { SalonYear = lSalonYearMof, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearMofColour = new SectionEntity() { SalonYear = lSalonYearMof, SectionType = lSectionTypeColourPdi };
                        var lSalonYearMofMono = new SectionEntity() { SalonYear = lSalonYearMof, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearPrintAndDigitalVarnaActionMovementSport = new SectionEntity() { SalonYear = lSalonYearPrintAndDigitalVarna, SectionType = lSectionTypeActionMovementSportPdi };
                        var lSalonYearPrintAndDigitalVarnaColour = new SectionEntity() { SalonYear = lSalonYearPrintAndDigitalVarna, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPrintAndDigitalVarnaMono = new SectionEntity() { SalonYear = lSalonYearPrintAndDigitalVarna, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearGoodLightDecisiveMoment = new SectionEntity() { SalonYear = lSalonYearGoodLight, SectionType = lSectionTypeDecisiveMomentPdi };
                        var lSalonYearGoodLightChild = new SectionEntity() { SalonYear = lSalonYearGoodLight, SectionType = lSectionTypeChildPdi };
                        var lSalonYearGoodLightNature = new SectionEntity() { SalonYear = lSalonYearGoodLight, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearGoodLightColour = new SectionEntity() { SalonYear = lSalonYearGoodLight, SectionType = lSectionTypeColourPdi };
                        var lSalonYearGoodLightMono = new SectionEntity() { SalonYear = lSalonYearGoodLight, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearGoodLightGoodLight = new SectionEntity() { SalonYear = lSalonYearGoodLight, SectionType = lSectionTypeGoodLightPdi };

                        var lSalonYearGradacColour = new SectionEntity() { SalonYear = lSalonYearGradac, SectionType = lSectionTypeColourPdi };
                        var lSalonYearGradacNature = new SectionEntity() { SalonYear = lSalonYearGradac, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearGradacTravel = new SectionEntity() { SalonYear = lSalonYearGradac, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearGradacMono = new SectionEntity() { SalonYear = lSalonYearGradac, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearGradacManWomanChild = new SectionEntity() { SalonYear = lSalonYearGradac, SectionType = lSectionTypeManWomanChildPdi };

                        var lSalonYearCyprusColour = new SectionEntity() { SalonYear = lSalonYearCyprus, SectionType = lSectionTypeColourPdi };
                        var lSalonYearCyprusMono = new SectionEntity() { SalonYear = lSalonYearCyprus, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearCyprusWoman = new SectionEntity() { SalonYear = lSalonYearCyprus, SectionType = lSectionTypeWomanPdi };

                        var lSalonYearPortTalbotColour = new SectionEntity() { SalonYear = lSalonYearPortTalbot, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPortTalbotMono = new SectionEntity() { SalonYear = lSalonYearPortTalbot, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPortTalbotNature = new SectionEntity() { SalonYear = lSalonYearPortTalbot, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearPortTalbotCreative = new SectionEntity() { SalonYear = lSalonYearPortTalbot, SectionType = lSectionTypeCreativePdi };

                        var lSalonYearVictorPolynskyColour = new SectionEntity() { SalonYear = lSalonYearVictorPolynsky, SectionType = lSectionTypeColourPdi };
                        var lSalonYearVictorPolynskyMono = new SectionEntity() { SalonYear = lSalonYearVictorPolynsky, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearVictorPolynskyCreative = new SectionEntity() { SalonYear = lSalonYearVictorPolynsky, SectionType = lSectionTypeCreativePdi };

                        var lSalonYearSrgbAnythingGoes = new SectionEntity() { SalonYear = lSalonYearSrgb, SectionType = lSectionTypeSrgbAnythingGoes };
                        var lSalonYearSrgbHumanity = new SectionEntity() { SalonYear = lSalonYearSrgb, SectionType = lSectionTypeSrgbHumanity };
                        var lSalonYearSrgbTriptych = new SectionEntity() { SalonYear = lSalonYearSrgb, SectionType = lSectionTypeSrgbTriptych };
                        var lSalonYearSrgbCreatures = new SectionEntity() { SalonYear = lSalonYearSrgb, SectionType = lSectionTypeSrgbCreatures };
                        var lSalonYearSrgbEnvironment = new SectionEntity() { SalonYear = lSalonYearSrgb, SectionType = lSectionTypeSrgbEnvironment };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                    lSalonYearBohemiaColour,

                    lSalonYearPhotoArtVisionColour,
                    lSalonYearPhotoArtVisionMono,

                    lSalonYearYorkshireOpen,

                    lSalonYearBelghoriaColour,
                    lSalonYearBelghoriaMono,

                    lSalonYearRefletMondialColour,
                    lSalonYearRefletMondialMono,

                    lSalonYearBristolColour,
                    lSalonYearBristolMono,


                    lSalonYearVictoryPhotoClubOpen,
                    lSalonYearVictoryPhotoClubNature,
                    lSalonYearVictoryPhotoClubTravel,

                    lSalonYearNzisColour,
                    lSalonYearNzisCreative,

                    lSalonYearPsaMetColour,
                    lSalonYearPsaMetMono,

                    lSalonYearCreativeArtColour,
                    lSalonYearCreativeArtMono,

                    lSalonYearCarlisleColourPrint,
                    lSalonYearCarlisleMonoPrint,
                    lSalonYearCarlisleTravelPrint,
                    lSalonYearCarlisleNaturePrint,
                    lSalonYearCarlisleMonoLandscapePrint,

                    lSalonYearPenrithColourPrint,
                    lSalonYearPenrithMonoPrint,
                    lSalonYearPenrithTravelPrint,
                    lSalonYearPenrithNaturePrint,
                    lSalonYearPenrithMonoLandscapePrint,

                    lSalonYearSolwayColourPrint,
                    lSalonYearSolwayMonoPrint,
                    lSalonYearSolwayTravelPrint,
                    lSalonYearSolwayNaturePrint,
                    lSalonYearSolwayMonoLandscapePrint,

                    lSalonYearKpaClubColour,
                    lSalonYearKpaClubMono,
                    lSalonYearKpaClubNature,

                    lSalonYearLagacillyColour,

                    lSalonYearDelleColline1Colour,
                    lSalonYearDelleColline1Mono,
                    lSalonYearDelleColline2Colour,
                    lSalonYearDelleColline2Mono,
                    lSalonYearDelleColline3Colour,
                    lSalonYearDelleColline3Mono,
                    lSalonYearDelleColline4Colour,
                    lSalonYearDelleColline4Mono,

                    lSalonYearScottishMonoPrint,
                    lSalonYearScottishColourPrint,
                    lSalonYearScottishColour,

                    lSalonYearSydneyColour,
                    lSalonYearSydneyMono,
                    lSalonYearSydneyCreative,

                    lSalonYearCheltenhamColour,
                    lSalonYearCheltenhamMono,
                    lSalonYearCheltenhamCreative,

                    lSalonYearHoylakeColour,
                    lSalonYearHoylakeMono,
                    lSalonYearHoylakeScapes,
                    lSalonYearHoylakeNature,
                    lSalonYearHoylakePhotojournalism,
                    lSalonYearHoylakeTravel,

                    lSalonYearPerastoOpen,
                    lSalonYearPerastoNature,
                    lSalonYearPerastoTravel,

                    lSalonYearMofNature,
                    lSalonYearMofColour,
                    lSalonYearMofMono,

                    lSalonYearPrintAndDigitalVarnaActionMovementSport,
                    lSalonYearPrintAndDigitalVarnaColour,
                    lSalonYearPrintAndDigitalVarnaMono,

                    lSalonYearGoodLightDecisiveMoment,
                    lSalonYearGoodLightChild,
                    lSalonYearGoodLightNature,
                    lSalonYearGoodLightColour,
                    lSalonYearGoodLightMono,
                    lSalonYearGoodLightGoodLight,

                    lSalonYearGradacColour,
                    lSalonYearGradacNature,
                    lSalonYearGradacTravel,
                    lSalonYearGradacMono,
                    lSalonYearGradacManWomanChild,

                    lSalonYearCyprusColour,
                    lSalonYearCyprusMono,
                    lSalonYearCyprusWoman,

                    lSalonYearPortTalbotColour,
                    lSalonYearPortTalbotMono,
                    lSalonYearPortTalbotNature,
                    lSalonYearPortTalbotCreative,

                    lSalonYearVictorPolynskyColour,
                    lSalonYearVictorPolynskyMono,
                    lSalonYearVictorPolynskyCreative,

                    lSalonYearSrgbAnythingGoes,
                    lSalonYearSrgbHumanity,
                    lSalonYearSrgbTriptych,
                    lSalonYearSrgbCreatures,
                    lSalonYearSrgbEnvironment,
                });
                        lContext.SaveChanges();


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 14.00M,
                        SalonYear = lSalonYearBohemia,
                        EntryDate = lSalonYearBohemia.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearBohemiaColour, Image = lDaisy, IsAwarded = false, IsAccepted = false, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearBohemiaColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearBohemiaColour, Image = lTheDance, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearBohemiaColour, Image = lSolitaryTree, IsAwarded = false, IsAccepted = false, Score = 12, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 22.07M,
                        SalonYear = lSalonYearPhotoArtVision,
                        EntryDate = lSalonYearPhotoArtVision.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearPhotoArtVisionMono, Image = lLakeKaniere, IsAwarded = false, IsAccepted = false, Score = 13, },
                            new CompetitionEntryEntity { Section = lSalonYearPhotoArtVisionMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score = 15, },
                            new CompetitionEntryEntity { Section = lSalonYearPhotoArtVisionMono, Image = lBridgeSuspension, IsAwarded = false, IsAccepted = false, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearPhotoArtVisionMono, Image = lInnerLight, IsAwarded = false, IsAccepted = false, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearPhotoArtVisionColour, Image = lStarfall, IsAwarded = false, IsAccepted = false, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearPhotoArtVisionColour, Image = lIntoTheMist, IsAwarded = true, IsAccepted = true, Score = 18, AwardDetails = "PSA Honorable Mention" },
                            new CompetitionEntryEntity { Section = lSalonYearPhotoArtVisionColour, Image = lLoneTree, IsAwarded = false, IsAccepted = false, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearPhotoArtVisionColour, Image = lAnotherPlaceAnotherWorld, IsAwarded = false, IsAccepted = false, Score = 12, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 9.00M,
                        SalonYear = lSalonYearYorkshire,
                        EntryDate = lSalonYearYorkshire.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearYorkshireOpen, Image = lDaisy, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearYorkshireOpen, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearYorkshireOpen, Image = lSentinel, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearYorkshireOpen, Image = lWoodlandLight, IsAwarded = false, IsAccepted = false, Score = 8, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 15.07M,
                        SalonYear = lSalonYearBelghoria,
                        EntryDate = lSalonYearBelghoria.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearBelghoriaMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearBelghoriaMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearBelghoriaMono, Image = lPollinationCanopy, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearBelghoriaMono, Image = lTheQualityOfSilence, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearBelghoriaColour, Image = lTowardsTheLight, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearBelghoriaColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearBelghoriaColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearBelghoriaColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = false },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 13.40M,
                        SalonYear = lSalonYearRefletMondial,
                        EntryDate = lSalonYearRefletMondial.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearRefletMondialColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearRefletMondialColour, Image = lLoneTree, IsAwarded = false, IsAccepted = false, Score = 8, },
                            new CompetitionEntryEntity { Section = lSalonYearRefletMondialColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score = 8, },
                            new CompetitionEntryEntity { Section = lSalonYearRefletMondialColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = false, Score = 8, },
                            new CompetitionEntryEntity { Section = lSalonYearRefletMondialMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearRefletMondialMono, Image = lLiverpoolWheelAndDocks, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearRefletMondialMono, Image = lDreamsOfNature, IsAwarded = false, IsAccepted = false, Score = 6, },
                            new CompetitionEntryEntity { Section = lSalonYearRefletMondialMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true, Score = 10, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 14.00M,
                        SalonYear = lSalonYearBristol,
                        EntryDate = lSalonYearBristol.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearBristolColour, Image = lTheDance, IsAwarded = false, IsAccepted = true, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearBristolColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearBristolColour, Image = lDaisy, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearBristolColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearBristolMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearBristolMono, Image = lPollinationCanopy, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearBristolMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score = 8, },
                            new CompetitionEntryEntity { Section = lSalonYearBristolMono, Image = lLiverpoolWheelAndDocks, IsAwarded = false, IsAccepted = false, Score = 9, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 14.23M,
                        SalonYear = lSalonYearVictoryPhotoClub,
                        EntryDate = lSalonYearVictoryPhotoClub.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubOpen, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score = 22, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubOpen, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = true, Score = 21, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubOpen, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 23, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubOpen, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubNature, Image = lHedgehog, IsAwarded = false, IsAccepted = false, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubNature, Image = lLongEaredOwl, IsAwarded = false, IsAccepted = false, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score = 20, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = true, Score = 20, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubTravel, Image = lFreshSnow, IsAwarded = false, IsAccepted = false, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score = 18, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubTravel, Image = lLivingTheMalteseDream, IsAwarded = false, IsAccepted = false, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearVictoryPhotoClubTravel, Image = lHarbourSailingInMalta, IsAwarded = false, IsAccepted = false, Score = 17, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 17.49M,
                        SalonYear = lSalonYearNzis,
                        EntryDate = lSalonYearNzis.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearNzisColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearNzisColour, Image = lTheDance, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearNzisColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearNzisCreative, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearNzisCreative, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearNzisCreative, Image = lWatchfulness, IsAwarded = false, IsAccepted = true },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 16.90M,
                        SalonYear = lSalonYearPsaMet,
                        EntryDate = lSalonYearPsaMet.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearPsaMetColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearPsaMetColour, Image = lTowardsTheLight, IsAwarded = false, IsAccepted = false},
                            new CompetitionEntryEntity { Section = lSalonYearPsaMetColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearPsaMetColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearPsaMetMono, Image = l4464Bittern, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearPsaMetMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearPsaMetMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true},
                            new CompetitionEntryEntity { Section = lSalonYearPsaMetMono, Image = lEricTreacy, IsAwarded = false, IsAccepted = false },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 16.03M,
                        SalonYear = lSalonYearCreativeArt,
                        EntryDate = lSalonYearCreativeArt.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearCreativeArtColour, Image = lTheWatcher, IsAwarded = false, IsAccepted = false},
                            new CompetitionEntryEntity { Section = lSalonYearCreativeArtColour, Image = lStarfall, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearCreativeArtColour, Image = lMalteseDoor, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearCreativeArtColour, Image = lDaisy, IsAwarded = false, IsAccepted = false},
                            new CompetitionEntryEntity { Section = lSalonYearCreativeArtMono, Image = lButtermereTree, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearCreativeArtMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearCreativeArtMono, Image = lWaveWatcher, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearCreativeArtMono, Image = lButtermere, IsAwarded = false, IsAccepted = false },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 11.07M,
                        SalonYear = lSalonYearCarlisle,
                        EntryDate = lSalonYearCarlisle.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleColourPrint, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 13, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleColourPrint, Image = lDaisy, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleColourPrint, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score = 12, },
                                    new CompetitionEntryEntity { Section = lSalonYearCarlisleColourPrint, Image = lIntoTheMist, IsAwarded = true, IsAccepted = true, Score = 15, AwardDetails = "FIAP Gold Medal"},
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleMonoPrint, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleMonoPrint, Image = l4464Bittern, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleMonoPrint, Image = lWaveWatcher, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleMonoPrint, Image = lDeepThinking, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleTravelPrint, Image = lLivingTheMalteseDream, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleTravelPrint, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleTravelPrint, Image = lFreshSnow, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleTravelPrint, Image = lHarbourSailingInMalta, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleNaturePrint, Image = lLongEaredOwl, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleNaturePrint, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleNaturePrint, Image = lRedKite, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleNaturePrint, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleMonoLandscapePrint, Image = lButtermere, IsAwarded = false, IsAccepted = true, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleMonoLandscapePrint, Image = lButtermereTree, IsAwarded = false, IsAccepted = false, Score = 10 , },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleMonoLandscapePrint, Image = lLakeKaniere, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearCarlisleMonoLandscapePrint, Image = lOliversCastle, IsAwarded = true, IsAccepted = true, Score = 15, AwardDetails = "Honorable Mention"},
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 11.07M,
                        SalonYear = lSalonYearPenrith,
                        EntryDate = lSalonYearPenrith.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearPenrithColourPrint, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithColourPrint, Image = lDaisy, IsAwarded = false, IsAccepted = true, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithColourPrint, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithColourPrint, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score = 15, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithMonoPrint, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithMonoPrint, Image = l4464Bittern, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithMonoPrint, Image = lWaveWatcher, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithMonoPrint, Image = lDeepThinking, IsAwarded = false, IsAccepted = false, Score = 10 , },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithTravelPrint, Image = lLivingTheMalteseDream, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithTravelPrint, Image = lAfternoonGun, IsAwarded = false, IsAccepted = true, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithTravelPrint, Image = lFreshSnow, IsAwarded = false, IsAccepted = true, Score = 13, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithTravelPrint, Image = lHarbourSailingInMalta, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithNaturePrint, Image = lLongEaredOwl, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithNaturePrint, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithNaturePrint, Image = lRedKite, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithNaturePrint, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithMonoLandscapePrint, Image = lButtermere, IsAwarded = false, IsAccepted = true, Score = 13, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithMonoLandscapePrint, Image = lButtermereTree, IsAwarded = false, IsAccepted = true, Score = 13, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithMonoLandscapePrint, Image = lLakeKaniere, IsAwarded = false, IsAccepted = true, Score = 13, },
                            new CompetitionEntryEntity { Section = lSalonYearPenrithMonoLandscapePrint, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score = 15, },                       },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 11.07M,
                        SalonYear = lSalonYearSolway,
                        EntryDate = lSalonYearSolway.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearSolwayColourPrint, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayColourPrint, Image = lDaisy, IsAwarded = false, IsAccepted = true, Score = 13, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayColourPrint, Image = lThroughTheArch, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayColourPrint, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score =13, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayMonoPrint, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayMonoPrint, Image = l4464Bittern, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayMonoPrint, Image = lWaveWatcher, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayMonoPrint, Image = lDeepThinking, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayTravelPrint, Image = lLivingTheMalteseDream, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayTravelPrint, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayTravelPrint, Image = lFreshSnow, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayTravelPrint, Image = lHarbourSailingInMalta, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayNaturePrint, Image = lLongEaredOwl, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayNaturePrint, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayNaturePrint, Image = lRedKite, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayNaturePrint, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayMonoLandscapePrint, Image = lButtermere, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayMonoLandscapePrint, Image = lButtermereTree, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayMonoLandscapePrint, Image = lLakeKaniere, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearSolwayMonoLandscapePrint, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score = 11, },                    },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 22.97M,
                        SalonYear = lSalonYearKpaClub,
                        EntryDate = lSalonYearKpaClub.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true},
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubMono, Image = lWaveWatcher, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubColour, Image = lTheWatcher, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubColour, Image = lSpiralNine, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubColour, Image = lDaisy, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubColour, Image = lReflect, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubNature, Image = lRedKite, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearKpaClubNature, Image = lHedgehog, IsAwarded = false, IsAccepted = true },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 10.87M,
                        SalonYear = lSalonYearLagacilly,
                        EntryDate = lSalonYearLagacilly.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearLagacillyColour, Image = lIntoTheMist, IsAwarded = true, IsAccepted = true, Score = 50, AwardDetails = "Judge Two Favourite"},
                            new CompetitionEntryEntity { Section = lSalonYearLagacillyColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score = 43, },
                            new CompetitionEntryEntity { Section = lSalonYearLagacillyColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 45, },
                            new CompetitionEntryEntity { Section = lSalonYearLagacillyColour, Image = lTheWatcher, IsAwarded = false, IsAccepted = false, Score = 40, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 8.89M,
                        SalonYear = lSalonYearDelleColline1,
                        EntryDate = lSalonYearDelleColline1.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline1Mono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline1Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline1Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false},
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline1Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false},
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline1Colour, Image = lDaisy, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline1Colour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline1Colour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline1Colour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 8.89M,
                        SalonYear = lSalonYearDelleColline2,
                        EntryDate = lSalonYearDelleColline2.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline2Mono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline2Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline2Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false},
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline2Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false},
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline2Colour, Image = lDaisy, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline2Colour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline2Colour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline2Colour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false },         },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 8.89M,
                        SalonYear = lSalonYearDelleColline3,
                        EntryDate = lSalonYearDelleColline3.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline3Mono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline3Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline3Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false},
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline3Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true},
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline3Colour, Image = lDaisy, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline3Colour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline3Colour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline3Colour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false },              },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 8.89M,
                        SalonYear = lSalonYearDelleColline4,
                        EntryDate = lSalonYearDelleColline4.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline4Mono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline4Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline4Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true},
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline4Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true},
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline4Colour, Image = lDaisy, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline4Colour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline4Colour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearDelleColline4Colour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 15.00M,
                        SalonYear = lSalonYearScottish,
                        EntryDate = lSalonYearScottish.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearScottishMonoPrint, Image = lOliversCastle, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearScottishMonoPrint, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearScottishMonoPrint, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearScottishMonoPrint, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearScottishColourPrint, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearScottishColourPrint, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearScottishColourPrint, Image = lThroughTheArch, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearScottishColourPrint, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearScottishColour, Image = lSpiralNine, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearScottishColour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearScottishColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearScottishColour, Image = lDaisy, IsAwarded = false, IsAccepted = false },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 18.35M,
                        SalonYear = lSalonYearSydney,
                        EntryDate = lSalonYearSydney.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearSydneyColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyColour, Image = lTowardsTheLight, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyColour, Image = lBoltonAbbey, IsAwarded = false, IsAccepted = false, Score = 8, },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyMono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false, Score = 6, },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyMono, Image = lRuinsByNight, IsAwarded = true, IsAccepted = true, Score = 14, AwardDetails = "Sydney Harbour Ribbon"},
                                    new CompetitionEntryEntity { Section = lSalonYearSydneyCreative, Image = lAWorldBeyond, IsAwarded = true, IsAccepted = true, Score = 15, AwardDetails = "Sydney Harbour Bronze Medal" },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyCreative, Image = lWatchfulness, IsAwarded = false, IsAccepted = true, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyCreative, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false, Score = 8, },
                            new CompetitionEntryEntity { Section = lSalonYearSydneyCreative, Image = lSentinel, IsAwarded = false, IsAccepted = false, Score = 6, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 15.00M,
                        SalonYear = lSalonYearCheltenham,
                        EntryDate = lSalonYearCheltenham.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamColour, Image = lTheWatcher, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamMono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamCreative, Image = lOrb, IsAwarded = false, IsAccepted = true, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamCreative, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamCreative, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = true, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearCheltenhamCreative, Image = lWatchfulness, IsAwarded = false, IsAccepted = false, Score = 10, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 15.00M,
                        SalonYear = lSalonYearHoylake,
                        EntryDate = lSalonYearHoylake.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeColour, Image = lOrb, IsAwarded = false, IsAccepted = true, Score = 12,},
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeMono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeMono, Image = lFreshSnowIceland, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeMono, Image = lKirkjufellRock, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeScapes, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeScapes, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeScapes, Image = lButtermere, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeScapes, Image = lLakeKaniere, IsAwarded = false, IsAccepted = false, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeNature, Image = lLittleOwl, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeNature, Image = lLongEaredOwl, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakePhotojournalism, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakePhotojournalism, Image = lZombieSelfie, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakePhotojournalism, Image = lZombieSafetyTraining, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakePhotojournalism, Image = lZombieTraining, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeTravel, Image = lIcelandicHorse, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeTravel, Image = lGlacierLagoonIceland, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearHoylakeTravel, Image = lBudirChurch, IsAwarded = false, IsAccepted = true, Score = 12, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 14.02M,
                        SalonYear = lSalonYearPerasto,
                        EntryDate = lSalonYearPerasto.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearPerastoOpen, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoOpen, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 21, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoOpen, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score = 20, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoOpen, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = true, Score = 20, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoNature, Image = lLittleOwl, IsAwarded = false, IsAccepted = false, Score = 16, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score = 18, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoNature, Image = lCanadaGosling, IsAwarded = false, IsAccepted = false, Score = 15, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoTravel, Image = lIcelandicHorse, IsAwarded = false, IsAccepted = false, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoTravel, Image = lGlacierLagoonIceland, IsAwarded = false, IsAccepted = false, Score = 18, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoTravel, Image = lBudirChurch, IsAwarded = false, IsAccepted = false, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearPerastoTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score = 15, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 15.78M,
                        SalonYear = lSalonYearMof,
                        EntryDate = lSalonYearMof.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearMofNature, Image = lCanadaGosling, IsAwarded = false, IsAccepted = true, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearMofNature, Image = lLittleOwl, IsAwarded = false, IsAccepted = true, Score = 16, },
                                    new CompetitionEntryEntity { Section = lSalonYearMofNature, Image = lYoungRedKite, IsAwarded = true, IsAccepted = true, Score = 20, AwardDetails = "FIAP Blue Ribbon"},
                            new CompetitionEntryEntity { Section = lSalonYearMofNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = true, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearMofColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearMofColour, Image = lDaisy, IsAwarded = false, IsAccepted = false, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearMofColour, Image = lTheWatcher, IsAwarded = false, IsAccepted = false, Score = 13, },
                            new CompetitionEntryEntity { Section = lSalonYearMofColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearMofMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearMofMono, Image = lFreshSnowIceland, IsAwarded = false, IsAccepted = false, Score = 8, },
                            new CompetitionEntryEntity { Section = lSalonYearMofMono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearMofMono, Image = lKirkjufellRock, IsAwarded = false, IsAccepted = false, Score = 9, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 17.68M,
                        SalonYear = lSalonYearPrintAndDigitalVarna,
                        EntryDate = lSalonYearPrintAndDigitalVarna.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaActionMovementSport, Image = lTheDance, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaActionMovementSport, Image = lBoatingInTheHail, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaActionMovementSport, Image = lBungeeJumpScream, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaActionMovementSport, Image = lTourDeYorkshire, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaColour, Image = lDaisy, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaMono, Image = lFreshSnowIceland, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearPrintAndDigitalVarnaMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 13.26M,
                        SalonYear = lSalonYearGoodLight,
                        EntryDate = lSalonYearGoodLight.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightDecisiveMoment, Image = lBungeeJumpScream, IsAwarded = false, IsAccepted = true, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightDecisiveMoment, Image = lAfternoonGun, IsAwarded = false, IsAccepted = true, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightChild, Image = lZombieGirl, IsAwarded = false, IsAccepted = false, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightChild, Image = lSteppingStones, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightNature, Image = lCanadaGosling, IsAwarded = false, IsAccepted = true, Score = 21, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightNature, Image = lLittleOwl, IsAwarded = false, IsAccepted = true, Score = 20, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score = 21, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = true, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = true, Score = 20, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightColour, Image = lDaisy, IsAwarded = false, IsAccepted = true, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score = 22, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score = 15, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightMono, Image = lFreshSnowIceland, IsAwarded = false, IsAccepted = false, Score = 16, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score = 16, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightGoodLight, Image = lPathStripes, IsAwarded = false, IsAccepted = false, Score = 15, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightGoodLight, Image = lTwelveApostlesSunset, IsAwarded = false, IsAccepted = false, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearGoodLightGoodLight, Image = lDawnInTheOutback, IsAwarded = false, IsAccepted = false, Score = 18, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 15.02M,
                        SalonYear = lSalonYearGradac,
                        EntryDate = lSalonYearGradac.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearGradacColour, Image = lOrb, IsAwarded = false, IsAccepted = true, Score = 22, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacColour, Image = lTowardsTheLight, IsAwarded = false, IsAccepted = true, Score = 22, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacColour, Image = lDaisy, IsAwarded = false, IsAccepted = false, Score = 18, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacColour, Image = lLeithReflections, IsAwarded = false, IsAccepted = false, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacNature, Image = lCanadaGosling, IsAwarded = false, IsAccepted = false, Score = 16, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacNature, Image = lLittleOwl, IsAwarded = false, IsAccepted = true, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score = 19, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = true, Score = 20, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score = 18, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacTravel, Image = lIcelandicHorse, IsAwarded = false, IsAccepted = false, Score = 16, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacTravel, Image = lBudirChurch, IsAwarded = false, IsAccepted = false, Score = 18, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacTravel, Image = lIcelandicPeak, IsAwarded = false, IsAccepted = false, Score = 16, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score = 21, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacMono, Image = lKirkjufellRock, IsAwarded = false, IsAccepted = false, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacMono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false, Score = 17, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacManWomanChild, Image = lSteppingStones, IsAwarded = false, IsAccepted = false, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacManWomanChild, Image = lLakeShore, IsAwarded = false, IsAccepted = false, Score = 13, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacManWomanChild, Image = lBungeeJumpScream, IsAwarded = false, IsAccepted = false, Score = 14, },
                            new CompetitionEntryEntity { Section = lSalonYearGradacManWomanChild, Image = lZombieGirl, IsAwarded = false, IsAccepted = false, Score = 17, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 17.86M,
                        SalonYear = lSalonYearCyprus,
                        EntryDate = lSalonYearCyprus.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearCyprusColour, Image = lTheWatcherInTheWaves, IsAwarded = true, IsAccepted = true, AwardDetails = "ISF Silver Medal" },
                            new CompetitionEntryEntity { Section = lSalonYearCyprusColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearCyprusColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearCyprusColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearCyprusMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearCyprusMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearCyprusMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearCyprusMono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearCyprusWoman, Image = lZombieGirl, IsAwarded = false, IsAccepted = false},
                            new CompetitionEntryEntity { Section = lSalonYearCyprusWoman, Image = lTheDance, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearCyprusWoman, Image = lBungeeJumpScream, IsAwarded = false, IsAccepted = false },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 15.30M,
                        SalonYear = lSalonYearPortTalbot,
                        EntryDate = lSalonYearPortTalbot.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotColour, Image = lSpiralNine, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotColour, Image = lDaisy, IsAwarded = false, IsAccepted = true, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotColour, Image = lBudirChurch, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotMono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score = 12, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotNature, Image = lHarvestMouseCowParsley, IsAwarded = false, IsAccepted = false, Score = 8, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotNature, Image = lHarvestMouseWheat, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotNature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotNature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score = 9, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotCreative, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotCreative, Image = lOrb, IsAwarded = false, IsAccepted = false, Score = 10, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotCreative, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score = 11, },
                            new CompetitionEntryEntity { Section = lSalonYearPortTalbotCreative, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = true, Score = 11, },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 24.44M,
                        SalonYear = lSalonYearVictorPolynsky,
                        EntryDate = lSalonYearVictorPolynsky.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyMono, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyColour, Image = lSpiralNine, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyColour, Image = lDaisy, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyColour, Image = lBudirChurch, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyCreative, Image = lOrb, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyCreative, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyCreative, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false },
                            new CompetitionEntryEntity { Section = lSalonYearVictorPolynskyCreative, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false },
                        },
                    },
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 26M,
                        SalonYear = lSalonYearSrgb,
                        EntryDate = lSalonYearSrgb.ClosingDate,
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {
                            new CompetitionEntryEntity { Section = lSalonYearSrgbAnythingGoes, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score= 12},
                            new CompetitionEntryEntity { Section = lSalonYearSrgbAnythingGoes, Image = lTheWatcher, IsAwarded = false, IsAccepted = false, Score=11 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbAnythingGoes, Image = lWatchingTheApocalypse, IsAwarded = false, IsAccepted = false, Score=10 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbAnythingGoes, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=11 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbCreatures, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=10 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbCreatures, Image = lRedFox, IsAwarded = false, IsAccepted = false, Score=8 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbCreatures, Image = lHarvestMiceOnWheat, IsAwarded = false, IsAccepted = false, Score=11 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbCreatures, Image = lHedgehogInLeaves, IsAwarded = false, IsAccepted = false, Score=11 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbEnvironment, Image = lDaisy, IsAwarded = false, IsAccepted = false, Score=11 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbEnvironment, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=10 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbEnvironment, Image = lIntoTheMist, IsAwarded = true, IsAccepted = true, Score=13 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbEnvironment, Image = lLakeGuardian, IsAwarded = false, IsAccepted = false, Score=11 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbHumanity, Image = lZombieGirl, IsAwarded = false, IsAccepted = false, Score=10 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbHumanity, Image = lBoatingInTheHail, IsAwarded = false, IsAccepted = false, Score=10 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbHumanity, Image = lEchoesOfTheGreatWar, IsAwarded = false, IsAccepted = false, Score=10 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbHumanity, Image = lVikingShieldWall, IsAwarded = false, IsAccepted = false, Score=8 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbTriptych, Image = lGrassesTriptych, IsAwarded = false, IsAccepted = true, Score=13 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbTriptych, Image = lParisianLightTriptych, IsAwarded = false, IsAccepted = true, Score=12},
                            new CompetitionEntryEntity { Section = lSalonYearSrgbTriptych, Image = lOrbsTriptych, IsAwarded = true, IsAccepted = true, Score=15 },
                            new CompetitionEntryEntity { Section = lSalonYearSrgbTriptych, Image = lCubePyramidSphereTriptych, IsAwarded = false, IsAccepted = false, Score=10 },
                        },
                    },
                });

						// *************** Beyond Group BPE
						var lSalonBeyondGroup = new SalonEntity { Name = "Beyond Group", Website = "http://www.beyondgroup.info/", Country = lCountryEngland };
						lContext.Salons.Add(lSalonBeyondGroup);

						var lSalonYearBeyondGroup = new SalonYearEntity { Name = "Beyond Group", Salon = lSalonBeyondGroup, Year = 2017, ClosingDate = new DateTime(2017, 7, 30), JudgeDate = new DateTime(2017, 8, 13), NotificationDate = new DateTime(2017, 8, 13), CataloguesPostedDate = new DateTime(2017, 8, 13) };
						lContext.SalonYears.Add(lSalonYearBeyondGroup);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017", PhotoOrganisation = lBpe, SalonYear = lSalonYearBeyondGroup },
						});

                        var lSalonYearBeyondGroupColour = new SectionEntity() { SalonYear = lSalonYearBeyondGroup, SectionType = lSectionTypeColourPdi };
						var lSalonYearBeyondGroupMono = new SectionEntity() { SalonYear = lSalonYearBeyondGroup, SectionType = lSectionTypeMonoPdi };
						var lSalonYearBeyondGroupScapes = new SectionEntity() { SalonYear = lSalonYearBeyondGroup, SectionType = lSectionTypeScapesPdi };
						
						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearBeyondGroupColour,
							lSalonYearBeyondGroupMono,
							lSalonYearBeyondGroupScapes,
						});


						var lReflectionBars = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Reflection Bars" };
						var lArcReflections = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Arc Reflections" };
						var lBuildingAbstract = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Building Abstract" };
						var lOfficePatterns = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Office Patterns" };
                        var lBirdAndWaterfall = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bird & Waterfall" };


						lContext.Images.AddRange(new List<ImageEntity>
						{
							lReflectionBars,
                            lArcReflections,
						    lBuildingAbstract,
                            lOfficePatterns,
                            lBirdAndWaterfall,
						});

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity()
                            {
                                IsJudged = false,
                                EntryCost = 18M,
                                SalonYear = lSalonYearBeyondGroup,
                                EntryDate = new DateTime(2017,7,26),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupColour, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupColour, Image = lLakeGuardian, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupMono, Image = lBuildingAbstract, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupMono, Image = lReflectionBars, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupMono, Image = lOfficePatterns, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupMono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupScapes, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupScapes, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupScapes, Image = lBirdAndWaterfall, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupScapes, Image = lLoneTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                },
                            },
						});

                        // *************** Mahzullah Memorial

                        var lCountryBangladesh = new CountryEntity { Name = "Bangladesh", };
                        lContext.Countries.Add(lCountryBangladesh);

                        var lSalonMahuzullah = new SalonEntity { Name = "Mahfuzullah Memorial", Website = "http://mmsalon.net/", Country = lCountryBangladesh };
                        lContext.Salons.Add(lSalonMahuzullah);

                        var lSalonYearMahuzullah = new SalonYearEntity { Name = "Mahfuzullah Memorial", Salon = lSalonMahuzullah, Year = 2017, ClosingDate = new DateTime(2017, 8, 5), JudgeDate = new DateTime(2017, 8, 18), NotificationDate = new DateTime(2017, 8, 29), CataloguesPostedDate = new DateTime(2017, 10, 15) };
                        lContext.SalonYears.Add(lSalonYearMahuzullah);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/281", PhotoOrganisation = lFiap, SalonYear = lSalonYearMahuzullah },
                            new AccreditationEntity() { SalonNumber = "2017-210", PhotoOrganisation = lPsa, SalonYear = lSalonYearMahuzullah },
                        });

                        var lSalonYearMahuzullahTravel = new SectionEntity() { SalonYear = lSalonYearMahuzullah, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearMahuzullahNature = new SectionEntity() { SalonYear = lSalonYearMahuzullah, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearMahuzullahChildhood = new SectionEntity() { SalonYear = lSalonYearMahuzullah, SectionType = lSectionTypeChildPdi };
                        var lSalonYearMahuzullahPhotojournalism = new SectionEntity() { SalonYear = lSalonYearMahuzullah, SectionType = lSectionTypePhotojournalismPdi };
                        var lSalonYearMahuzullahColour = new SectionEntity() { SalonYear = lSalonYearMahuzullah, SectionType = lSectionTypeColourPdi };
                        var lSalonYearMahuzullahMono = new SectionEntity() { SalonYear = lSalonYearMahuzullah, SectionType = lSectionTypeMonoPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearMahuzullahTravel,
                            lSalonYearMahuzullahNature,
                            lSalonYearMahuzullahChildhood,
                            lSalonYearMahuzullahPhotojournalism,
                            lSalonYearMahuzullahColour,
                            lSalonYearMahuzullahMono,
                        });

						var lBusySteppingStones = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Busy Stepping Stones" };
						var lDuckWatching = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Duck Watching" };
						var lHelpingHands = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Helping Hands" };
						var lImSoBored = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "I'm So Bored" };
						var lHeronFishing = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Heron Fishing" };
						var lTerrierRacing = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Terrier Racing" };
						var lzombieApocalypseSafetyTraining = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zombie Apocalypse Safety Training" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lBusySteppingStones,
                            lDuckWatching,
                            lHelpingHands,
                            lImSoBored,
                            lHeronFishing,
                            lTerrierRacing,
                            lzombieApocalypseSafetyTraining,
                        });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity()
                            {
                                IsJudged = false,
                                EntryCost = 23.32M,
                                SalonYear = lSalonYearMahuzullah,
                                EntryDate = new DateTime(2017,7,29),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahChildhood, Image = lBusySteppingStones, IsAwarded = false, IsAccepted = false, Score= 0},
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahChildhood, Image = lDuckWatching, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahChildhood, Image = lHelpingHands, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahChildhood, Image = lImSoBored, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahNature, Image = lHarvestMouseWheat, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahNature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahColour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahColour, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahMono, Image = lReflectionBars, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahMono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahMono, Image = lBuildingAbstract, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahMono, Image = lOfficePatterns, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahTravel, Image = lBudirChurch, IsAwarded = false, IsAccepted = false, Score=0},
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahTravel, Image = lFreshSnow, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahTravel, Image = lIcelandicHorse, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahPhotojournalism, Image = lBoatingInTheHail, IsAwarded = false, IsAccepted = false, Score=0 },
	                                new CompetitionEntryEntity { Section = lSalonYearMahuzullahPhotojournalism, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = false, Score=0},
									new CompetitionEntryEntity { Section = lSalonYearMahuzullahPhotojournalism, Image = lTerrierRacing, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahuzullahPhotojournalism, Image = lzombieApocalypseSafetyTraining, IsAwarded = false, IsAccepted = false, Score=0 },
                                },
                            },
                        });
                    

                        lContext.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error:" + ex.Message + ", " + ex.StackTrace);
                        throw;
                    }
                }
            }
        }
    }
}
