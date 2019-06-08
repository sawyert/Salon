using System;
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
                FullDataLoad.clearAllData(lContext);
                
                if (lContext.People.Count() == 0)
                {
                    var lCountryCzechRep = new CountryEntity { Name = "Czech Republic", };
                    var lCountryEngland = new CountryEntity { Name = "England", };
                    var lCountrySpain = new CountryEntity { Name = "Spain", };
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
                    var lCountryUkraine = new CountryEntity { Name = "Ukraine", };
                    var lCountryPoland = new CountryEntity { Name = "Poland", };
                    var lCountryHungary = new CountryEntity { Name = "Hungary", };
                    var lCountryMacedonia = new CountryEntity { Name = "Macedonia", };

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
                            lCountryUkraine,
                            lCountryPoland,
                            lCountryHungary,
                            lCountryMacedonia,
                            lCountrySpain,
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
                            Name = "FIAP Levels",
                            EnableSectionTypes = false,
                            AwardLevels = new List<AwardLevelEntity>{
                                new AwardLevelEntity{
                                    Name = "1 EFIAP/b",
                                    MinimumAcceptances = 200,
                                    MinimumCountries = 5,
                                    MinimumAwards = 4,
                                    MinimumDistinctImages = 50,
                                    MinimumSalons = 1,
                                    MinimumPrints = 0,
                                },
                                new AwardLevelEntity{
                                    Name = "2 EFIAP/s",
                                    MinimumAcceptances = 300,
                                    MinimumCountries = 10,
                                    MinimumAwards = 9,
                                    MinimumDistinctImages = 100,
                                    MinimumSalons = 1,
                                    MinimumPrints = 0,
                                },
								new AwardLevelEntity{
                                    Name = "3 EFIAP/g",
                                    MinimumAcceptances = 500,
                                    MinimumCountries = 15,
                                    MinimumAwards = 15,
                                    MinimumDistinctImages = 150,
                                    MinimumSalons = 1,
                                    MinimumPrints = 0,
                                },
								new AwardLevelEntity{
                                    Name = "4 EFIAP/p",
                                    MinimumAcceptances = 700,
                                    MinimumCountries = 20,
                                    MinimumAwards = 22,
                                    MinimumDistinctImages = 250,
                                    MinimumSalons = 1,
                                    MinimumPrints = 0,
                                },
                            }
                        },new PhotoOrganisationEntity
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
                        },
                            new PhotoOrganisationEntity
                        {
                            Name = "GPU",
                            EnableSectionTypes = false,
                            AwardLevels = new List<AwardLevelEntity>{
                                new AwardLevelEntity{
                                    Name = "GPU Crown 1",
                                    MinimumAcceptances = 200,
                                    MinimumCountries = 0,
                                    MinimumAwards = 0,
                                    MinimumDistinctImages = 0,
                                    MinimumSalons = 0,
                                    MinimumPrints = 0,
                                },
                                new AwardLevelEntity{
                                    Name = "GPU Crown 2",
                                    MinimumAcceptances = 600,
                                    MinimumCountries = 0,
                                    MinimumAwards = 0,
                                    MinimumDistinctImages = 0,
                                    MinimumSalons = 0,
                                    MinimumPrints = 0,
                                },
                                new AwardLevelEntity{
                                    Name = "GPU Crown 3",
                                    MinimumAcceptances = 2500,
                                    MinimumCountries = 0,
                                    MinimumAwards = 0,
                                    MinimumDistinctImages = 0,
                                    MinimumSalons = 0,
                                    MinimumPrints = 0,
                                },
                                new AwardLevelEntity{
                                    Name = "GPU Crown 4",
                                    MinimumAcceptances = 6000,
                                    MinimumCountries = 0,
                                    MinimumAwards = 0,
                                    MinimumDistinctImages = 0,
                                    MinimumSalons = 0,
                                    MinimumPrints = 0,
                                },
                                new AwardLevelEntity{
                                    Name = "GPU Crown 5",
                                    MinimumAcceptances = 15000,
                                    MinimumCountries = 0,
                                    MinimumAwards = 0,
                                    MinimumDistinctImages = 0,
                                    MinimumSalons = 0,
                                    MinimumPrints = 0,
                                },
                            }
                        },
                        
                        });

                        var lSalonBohemia = new SalonEntity { Name = "Bohemia", Website = "http://bohemia.photosalon.cz/", Country = lCountryCzechRep };
                        var lSalonPhotoArtVision = new SalonEntity { Name = "Photo Art Vision", Website = "http://vision.photoart.cz/", Country = lCountryCzechRep };
                        var lSalonYorkshire = new SalonEntity { Name = "Yorkshire", Website = "yorkshiresalon.co.uk", Country = lCountryEngland };
                        var lSalonBelghoria = new SalonEntity { Name = "3rd Creative International Salon", Website = "www.bplclub.in", Country = lCountryIndia };
                        var lSalonRefletMondial = new SalonEntity { Name = "Reflet Mondial", Website = "http://refletmondial.be/wp/", Country = lCountryBelgium };
                        var lSalonBristol = new SalonEntity { Name = "Bristol", Website = "http://www.bristolphoto.org.uk/pages/bristol-salon.php", Country = lCountryEngland };
                        var lSalonVictoryPhotoClub = new SalonEntity { Name = "Victory Photo Club", Website = "http://www.victory-photo.club/", Country = lCountryMontenegro };
                        var lSalonNzis = new SalonEntity { Name = "NZIS", Website = "http://www.psnzinternationalsalons.com/", Country = lCountryNewZealand };
                        var lSalonPsaMet = new SalonEntity { Name = "PSA Metropolitan", Website = "http://www.psa-met.com/mipe", Country = lCountryUsa };
                        var lSalonCreativeArt = new SalonEntity { Name = "Creative Art", Website = "http://www.creativeartsalon.org/", Country = lCountryIndia };
                        var lSalonCarlisle = new SalonEntity { Name = "GBSPC - Carlisle", Website = "http://www.solwaysalon.co.uk/gb17/entry.php", Country = lCountryEngland };
                        var lSalonPenrith = new SalonEntity { Name = "GBSPC - Penrith", Website = "http://www.solwaysalon.co.uk/gb17/entry.php", Country = lCountryEngland };
                        var lSalonSolway = new SalonEntity { Name = "GBSPC - Solway", Website = "http://www.solwaysalon.co.uk/gb17/entry.php", Country = lCountryEngland };
                        var lSalonKpaClub = new SalonEntity { Name = "KPA Club", Website = "http://www.kpaclub.com/", Country = lCountryIndia };
                        var lSalonLagacilly = new SalonEntity { Name = "Club Photo Lagacilly", Website = "http://www.clubphotolagacilly.com/", Country = lCountryFrance };
                        var lSalonDelleColline1 = new SalonEntity { Name = "Gan Tour Delle Colline - Incisa", Website = "http://www.grantourdellecolline.it/en/", Country = lCountryItaly };
                        var lSalonDelleColline2 = new SalonEntity { Name = "Gan Tour Delle Colline - Valdarno", Website = "http://www.grantourdellecolline.it/en/", Country = lCountryItaly };
                        var lSalonDelleColline3 = new SalonEntity { Name = "Gan Tour Delle Colline - Chianti", Website = "http://www.grantourdellecolline.it/en/", Country = lCountryItaly };
                        var lSalonDelleColline4 = new SalonEntity { Name = "Gan Tour Delle Colline - Pratomagno", Website = "http://www.grantourdellecolline.it/en/", Country = lCountryItaly };
                        var lSalonScottish = new SalonEntity { Name = "Scottish", Website = "http://www.scottish-photographic-salon.org/", Country = lCountryScotland };
                        var lSalonSydney = new SalonEntity { Name = "Sydney Harbour", Website = "http://www.sydney-harbour-international.org.au/", Country = lCountryAustralia };
                        var lSalonCheltenham = new SalonEntity { Name = "Cheltenham", Website = "http://www.cheltenhamcameraclub.co.uk/wordpress/salon/", Country = lCountryEngland };
                        var lSalonHoylake = new SalonEntity { Name = "Hoylake", Website = "http://hoylakephoto.org/international/", Country = lCountryEngland };
                        var lSalonPerasto = new SalonEntity { Name = "Perasto", Website = "http://www.perasto.club/", Country = lCountryMontenegro };
                        var lSalonMof = new SalonEntity { Name = "MOF", Website = "http://contest.olbafotograf.com/", Country = lCountryTurkey };
                        var lSalonPrintAndDigitalVarna = new SalonEntity { Name = "Print and Digital Varna", Website = "http://printsalonvarna.org/", Country = lCountryBulgaria };
                        var lSalonGoodLight = new SalonEntity { Name = "Good Light", Website = "http://photoclubkragujevac.com/goodlight/", Country = lCountrySerbia };
                        var lSalonGradac = new SalonEntity { Name = "Gradac", Website = "http://www.gradacfoto.com/", Country = lCountryMontenegro };
                        var lSalonCyprus = new SalonEntity { Name = "Cyprus", Website = "http://www.cps-cidpc.com/", Country = lCountryCyprus };
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
                        var lSalonYearYorkshire = new SalonYearEntity { Name = "Yorkshire", Salon = lSalonYorkshire, Year = 2016, ClosingDate = new DateTime(2016, 12, 5), JudgeDate = new DateTime(2016, 12, 11), NotificationDate = new DateTime(2016, 12, 19), CataloguesPostedDate = new DateTime(2016, 12, 19) };
                        var lSalonYearBelghoria = new SalonYearEntity { Name = "Belghoria Photo Lovers", Salon = lSalonBelghoria, Year = 2017, ClosingDate = new DateTime(2016, 12, 31), JudgeDate = new DateTime(2017, 1, 19), NotificationDate = new DateTime(2017, 1, 31), CataloguesPostedDate = new DateTime(2017, 1, 31) };
                        var lSalonYearRefletMondial = new SalonYearEntity { Name = "Reflet Mondial", Salon = lSalonRefletMondial, Year = 2017, ClosingDate = new DateTime(2017, 1, 26), JudgeDate = new DateTime(2017, 1, 29), NotificationDate = new DateTime(2017, 2, 2), CataloguesPostedDate = new DateTime(2017, 2, 2) };
                        var lSalonYearBristol = new SalonYearEntity { Name = "Bristol", Salon = lSalonBristol, Year = 2017, ClosingDate = new DateTime(2017, 1, 31), JudgeDate = new DateTime(2017, 2, 19), NotificationDate = new DateTime(2017, 3, 4), CataloguesPostedDate = new DateTime(2017, 3, 4) };
                        var lSalonYearVictoryPhotoClub = new SalonYearEntity { Name = "Victory Photo Club", Salon = lSalonVictoryPhotoClub, Year = 2017, ClosingDate = new DateTime(2017, 2, 17), JudgeDate = new DateTime(2017, 3, 8), NotificationDate = new DateTime(2017, 3, 12), CataloguesPostedDate = new DateTime(2017, 3, 12) };
                        var lSalonYearNzis = new SalonYearEntity { Name = "NZIS", Salon = lSalonNzis, Year = 2017, ClosingDate = new DateTime(2017, 2, 17), JudgeDate = new DateTime(2017, 3, 5), NotificationDate = new DateTime(2017, 3, 18), CataloguesPostedDate = new DateTime(2017, 3, 18) };
                        var lSalonYearPsaMet = new SalonYearEntity { Name = "PSA Metropolitan", Salon = lSalonPsaMet, Year = 2017, ClosingDate = new DateTime(2017, 3, 3), JudgeDate = new DateTime(2017, 3, 17), NotificationDate = new DateTime(2017, 3, 26), CataloguesPostedDate = new DateTime(2017, 3, 26) };
                        var lSalonYearCreativeArt = new SalonYearEntity { Name = "Creative Art", Salon = lSalonCreativeArt, Year = 2017, ClosingDate = new DateTime(2017, 3, 6), JudgeDate = new DateTime(2017, 3, 19), NotificationDate = new DateTime(2017, 3, 31), CataloguesPostedDate = new DateTime(2017, 3, 31) };
                        var lSalonYearCarlisle = new SalonYearEntity { Name = "GBSPC - Carlisle", Salon = lSalonCarlisle, Year = 2017, ClosingDate = new DateTime(2017, 3, 20), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 16), CataloguesPostedDate = new DateTime(2017, 4, 16), Circuit = lCircuitGbSmallPrints };
                        var lSalonYearPenrith = new SalonYearEntity { Name = "GBSPC - Penrith", Salon = lSalonPenrith, Year = 2017, ClosingDate = new DateTime(2017, 3, 20), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 16), CataloguesPostedDate = new DateTime(2017, 4, 16), Circuit = lCircuitGbSmallPrints };
                        var lSalonYearSolway = new SalonYearEntity { Name = "GBSPC - Solway", Salon = lSalonSolway, Year = 2017, ClosingDate = new DateTime(2017, 3, 20), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 16), CataloguesPostedDate = new DateTime(2017, 4, 16), Circuit = lCircuitGbSmallPrints };
                        var lSalonYearKpaClub = new SalonYearEntity { Name = "KPA Club", Salon = lSalonKpaClub, Year = 2017, ClosingDate = new DateTime(2017, 3, 11), JudgeDate = new DateTime(2017, 3, 25), NotificationDate = new DateTime(2017, 4, 5), CataloguesPostedDate = new DateTime(2017, 4, 5) };
                        var lSalonYearLagacilly = new SalonYearEntity { Name = "Club Photo Lagacilly", Salon = lSalonLagacilly, Year = 2017, ClosingDate = new DateTime(2017, 3, 27), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 10), CataloguesPostedDate = new DateTime(2017, 4, 10) };
                        var lSalonYearDelleColline1 = new SalonYearEntity { Name = "Gan Tour Delle Colline - Incisa", Salon = lSalonDelleColline1, Year = 2017, ClosingDate = new DateTime(2017, 4, 15), JudgeDate = new DateTime(2017, 4, 23), NotificationDate = new DateTime(2017, 4, 30), CataloguesPostedDate = new DateTime(2017, 4, 30), Circuit = lGrandTourDelleColline };
                        var lSalonYearDelleColline2 = new SalonYearEntity { Name = "Gan Tour Delle Colline - Valdarnoe", Salon = lSalonDelleColline2, Year = 2017, ClosingDate = new DateTime(2017, 4, 15), JudgeDate = new DateTime(2017, 4, 23), NotificationDate = new DateTime(2017, 4, 30), CataloguesPostedDate = new DateTime(2017, 4, 30), Circuit = lGrandTourDelleColline };
                        var lSalonYearDelleColline3 = new SalonYearEntity { Name = "Gan Tour Delle Colline - Chianti", Salon = lSalonDelleColline3, Year = 2017, ClosingDate = new DateTime(2017, 4, 15), JudgeDate = new DateTime(2017, 4, 23), NotificationDate = new DateTime(2017, 4, 30), CataloguesPostedDate = new DateTime(2017, 4, 30), Circuit = lGrandTourDelleColline };
                        var lSalonYearDelleColline4 = new SalonYearEntity { Name = "Gan Tour Delle Colline - Pratomagno", Salon = lSalonDelleColline4, Year = 2017, ClosingDate = new DateTime(2017, 4, 15), JudgeDate = new DateTime(2017, 4, 23), NotificationDate = new DateTime(2017, 4, 30), CataloguesPostedDate = new DateTime(2017, 4, 30), Circuit = lGrandTourDelleColline };
                        var lSalonYearScottish = new SalonYearEntity { Name = "Scottish", Salon = lSalonScottish, Year = 2017, ClosingDate = new DateTime(2017, 3, 20), JudgeDate = new DateTime(2017, 4, 2), NotificationDate = new DateTime(2017, 4, 16), CataloguesPostedDate = new DateTime(2017, 4, 16) };
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

						var lFiapLevels = (from org in lContext.PhotoOrganisations
                                     where org.Name == "FIAP Levels"
                                     select org).FirstOrDefault();                  

                        var lBpe = (from org in lContext.PhotoOrganisations
                                    where org.Name == "BPE"
                                    select org).FirstOrDefault();

                        var lGpu = (from org in lContext.PhotoOrganisations
                                    where org.Name == "GPU"
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

                            new AccreditationEntity() { SalonNumber = "GPU L170002", PhotoOrganisation = lGpu, SalonYear = lSalonYearRefletMondial, },
                            new AccreditationEntity() { SalonNumber = "GPU L170001", PhotoOrganisation = lGpu, SalonYear = lSalonYearBristol, },
                            new AccreditationEntity() { SalonNumber = "GPU L170056", PhotoOrganisation = lGpu, SalonYear = lSalonYearScottish, },
                            new AccreditationEntity() { SalonNumber = "GPU L170033", PhotoOrganisation = lGpu, SalonYear = lSalonYearLagacilly, },
                            new AccreditationEntity() { SalonNumber = "GPU L170008", PhotoOrganisation = lGpu, SalonYear = lSalonYearSydney, },
                            new AccreditationEntity() { SalonNumber = "GPU L170032", PhotoOrganisation = lGpu, SalonYear = lSalonYearDelleColline1, },
                            new AccreditationEntity() { SalonNumber = "GPU L170032", PhotoOrganisation = lGpu, SalonYear = lSalonYearDelleColline2, },
                            new AccreditationEntity() { SalonNumber = "GPU L170032", PhotoOrganisation = lGpu, SalonYear = lSalonYearDelleColline3, },
                            new AccreditationEntity() { SalonNumber = "GPU L170032", PhotoOrganisation = lGpu, SalonYear = lSalonYearDelleColline4, },
                            new AccreditationEntity() { SalonNumber = "GPU L170015", PhotoOrganisation = lGpu, SalonYear = lSalonYearCheltenham, },
                            new AccreditationEntity() { SalonNumber = "GPU L170044", PhotoOrganisation = lGpu, SalonYear = lSalonYearHoylake, },
                            new AccreditationEntity() { SalonNumber = "GPU L170048", PhotoOrganisation = lGpu, SalonYear = lSalonYearMof, },
                            new AccreditationEntity() { SalonNumber = "GPU L170041", PhotoOrganisation = lGpu, SalonYear = lSalonYearCyprus, },
                            new AccreditationEntity() { SalonNumber = "GPU L170053", PhotoOrganisation = lGpu, SalonYear = lSalonYearPortTalbot, },
		                });
                        lContext.SaveChanges();

                        var lSectionTypeColourPdi = new SectionTypeEntity() { Name = "Open Colour", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeMonoPdi = new SectionTypeEntity() { Name = "Open Mono", IsPrint = false, SectionCode = "PIDM" };
                        var lSectionTypeOpenPdi = new SectionTypeEntity() { Name = "Open Colour and Mono", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeNaturePdi = new SectionTypeEntity() { Name = "Nature", IsPrint = false, SectionCode = "ND" };
                        var lSectionTypeWildlifePdi = new SectionTypeEntity() { Name = "Wildlife", IsPrint = false, SectionCode = "ND" };
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
                        var lSectionTypePortraitPdi = new SectionTypeEntity() { Name = "Portrait", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeStreetPdi = new SectionTypeEntity() { Name = "Street", IsPrint = false, SectionCode = "PIDC" };
                        var lSectionTypeMyPlacePdi = new SectionTypeEntity() { Name = "My Place", IsPrint = false, SectionCode = "PIDC" };
						var lSectionTypePeoplePdi = new SectionTypeEntity() { Name = "People", IsPrint = false, SectionCode = "PIDC" };

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
                        var lRedFox = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Red Fox" };
                        var lHarvestMiceOnWheat = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Harvest Mice on Wheat [Creative]" };
                        var lHedgehogInLeaves = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Hedgehog In Leaves" };
                        var lLakeGuardian = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Lake Guardian", Notes = "Not suitable for FIAP/PSA, use Across The Lake instead" };
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
                                    new CompetitionEntryEntity { Section = lSalonYearSrgbEnvironment, Image = lIntoTheMist, IsAwarded = true, IsAccepted = true, AwardDetails = "Ribbon", Score=13 },
		                            new CompetitionEntryEntity { Section = lSalonYearSrgbEnvironment, Image = lLakeGuardian, IsAwarded = false, IsAccepted = false, Score=11 },
		                            new CompetitionEntryEntity { Section = lSalonYearSrgbHumanity, Image = lZombieGirl, IsAwarded = false, IsAccepted = false, Score=10 },
		                            new CompetitionEntryEntity { Section = lSalonYearSrgbHumanity, Image = lBoatingInTheHail, IsAwarded = false, IsAccepted = false, Score=10 },
		                            new CompetitionEntryEntity { Section = lSalonYearSrgbHumanity, Image = lEchoesOfTheGreatWar, IsAwarded = false, IsAccepted = false, Score=10 },
		                            new CompetitionEntryEntity { Section = lSalonYearSrgbHumanity, Image = lVikingShieldWall, IsAwarded = false, IsAccepted = false, Score=8 },
		                            new CompetitionEntryEntity { Section = lSalonYearSrgbTriptych, Image = lGrassesTriptych, IsAwarded = false, IsAccepted = true, Score=13 },
		                            new CompetitionEntryEntity { Section = lSalonYearSrgbTriptych, Image = lParisianLightTriptych, IsAwarded = false, IsAccepted = true, Score=12},
		                            new CompetitionEntryEntity { Section = lSalonYearSrgbTriptych, Image = lOrbsTriptych, IsAwarded = true, IsAccepted = true, AwardDetails = "Gold Award", Score=15 },
		                            new CompetitionEntryEntity { Section = lSalonYearSrgbTriptych, Image = lCubePyramidSphereTriptych, IsAwarded = false, IsAccepted = false, Score=10 },
		                        },
		                    },
		                });
                        lContext.SaveChanges();

						// *************** South Devon Salon
						var lSalonSouthDevon = new SalonEntity { Name = "South Devon", Website = "http://www.newtonabbot-photoclub.org.uk/pages/salon-2017.php", Country = lCountryEngland };
						lContext.Salons.Add(lSalonSouthDevon);

						var lSalonYearSouthDevon = new SalonYearEntity { Name = "South Devon", Salon = lSalonSouthDevon, Year = 2017, ClosingDate = new DateTime(2017, 7, 16), JudgeDate = new DateTime(2017, 7, 30), NotificationDate = new DateTime(2017, 8, 9), CataloguesPostedDate = new DateTime(2017, 10, 17) };
						lContext.SalonYears.Add(lSalonYearSouthDevon);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017/270", PhotoOrganisation = lFiap, SalonYear = lSalonYearSouthDevon },
                            new AccreditationEntity() { SalonNumber = "2017-204", PhotoOrganisation = lPsa, SalonYear = lSalonYearSouthDevon },
                            new AccreditationEntity() { SalonNumber = "GPU L170076", PhotoOrganisation = lGpu, SalonYear = lSalonYearSouthDevon },
						});

						var lSalonYearSouthDevonCreative = new SectionEntity() { SalonYear = lSalonYearSouthDevon, SectionType = lSectionTypeCreativePdi };
						var lSalonYearSouthDevonMono = new SectionEntity() { SalonYear = lSalonYearSouthDevon, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSouthDevonColour = new SectionEntity() { SalonYear = lSalonYearSouthDevon, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSouthDevonNature = new SectionEntity() { SalonYear = lSalonYearSouthDevon, SectionType = lSectionTypeNaturePdi };

						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearSouthDevonCreative,
							lSalonYearSouthDevonMono,
							lSalonYearSouthDevonColour,
                            lSalonYearSouthDevonNature,
						});


						var lPetalIllumination = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Petal Illumination" };
						var lWaterFlight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Water Flight" };



						lContext.Images.AddRange(new List<ImageEntity>
						{
							lPetalIllumination,
							lWaterFlight,
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity() {
								IsJudged = true,
								EntryCost = 15M,
								SalonYear = lSalonYearSouthDevon,
								EntryDate = new DateTime(2017,7,16),
								Person = lTim,
								Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearSouthDevonCreative, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = true, Score= 12},
									new CompetitionEntryEntity { Section = lSalonYearSouthDevonCreative, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = true, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonCreative, Image = lOrb, IsAwarded = false, IsAccepted = true, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonCreative, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonMono, Image = lWaterFlight, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonColour, Image = lDaisy, IsAwarded = false, IsAccepted = false, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonColour, Image = lPetalIllumination, IsAwarded = false, IsAccepted = false, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonColour, Image = lTheDance, IsAwarded = false, IsAccepted = false, Score= 7},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonColour, Image = lSpiralNine, IsAwarded = false, IsAccepted = false, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonNature, Image = lHarvestMouseWheat, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonNature, Image = lRedFox, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonNature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevonNature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score= 10},
								},
							},
						});
                        lContext.SaveChanges();

                        // *************** Beyond Group BPE
                        var lSalonBeyondGroup = new SalonEntity { Name = "Beyond Group", Website = "http://www.beyondgroup.info/", Country = lCountryEngland };
                        lContext.Salons.Add(lSalonBeyondGroup);

                        var lSalonYearBeyondGroup = new SalonYearEntity { Name = "Beyond Group", Salon = lSalonBeyondGroup, Year = 2017, ClosingDate = new DateTime(2017, 7, 30), JudgeDate = new DateTime(2017, 8, 13), NotificationDate = new DateTime(2017, 8, 13), CataloguesPostedDate = new DateTime(2017, 8, 13) };
                        lContext.SalonYears.Add(lSalonYearBeyondGroup);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017 BPE", PhotoOrganisation = lBpe, SalonYear = lSalonYearBeyondGroup },
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
                        var lBirdAndWaterfall = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bird & Waterfall", Notes="BPE Version - use Water Flight for FIAP/PSA" };


                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lReflectionBars,
                            lArcReflections,
                            lBuildingAbstract,
                            lOfficePatterns,
                            lBirdAndWaterfall,
                        });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity() {
                                IsJudged = true,
                                EntryCost = 18M,
                                SalonYear = lSalonYearBeyondGroup,
                                EntryDate = new DateTime(2017,7,26),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupColour, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupColour, Image = lLakeGuardian, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupMono, Image = lBuildingAbstract, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupMono, Image = lReflectionBars, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupMono, Image = lOfficePatterns, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupMono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupScapes, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupScapes, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupScapes, Image = lBirdAndWaterfall, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeyondGroupScapes, Image = lLoneTree, IsAwarded = false, IsAccepted = false, Score=9 },
                                },
                            },
                        });
                        lContext.SaveChanges();


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
                            new AccreditationEntity() { SalonNumber = "GPU L170054", PhotoOrganisation = lGpu, SalonYear = lSalonYearMahuzullah },
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
                        var lZombieApocalypseSafetyTraining = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zombie Apocalypse Safety Training" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lBusySteppingStones,
                            lDuckWatching,
                            lHelpingHands,
                            lImSoBored,
                            lHeronFishing,
                            lTerrierRacing,
                            lZombieApocalypseSafetyTraining,
                        });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 23.32M,
                                SalonYear = lSalonYearMahuzullah,
                                EntryDate = new DateTime(2017,7,29),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahChildhood, Image = lBusySteppingStones, IsAwarded = false, IsAccepted = false, Score= null},
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahChildhood, Image = lDuckWatching, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahChildhood, Image = lHelpingHands, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahChildhood, Image = lImSoBored, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahNature, Image = lHarvestMouseWheat, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = true, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahNature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = true, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahColour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahColour, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahMono, Image = lReflectionBars, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahMono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahMono, Image = lBuildingAbstract, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahMono, Image = lOfficePatterns, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahTravel, Image = lBudirChurch, IsAwarded = false, IsAccepted = false, Score=null},
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahTravel, Image = lFreshSnow, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahTravel, Image = lIcelandicHorse, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahPhotojournalism, Image = lBoatingInTheHail, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahPhotojournalism, Image = lFloodingInLeeds, IsAwarded = true, AwardDetails = "IUP HM Green Ribbon", IsAccepted = true, Score=null},
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahPhotojournalism, Image = lTerrierRacing, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearMahuzullahPhotojournalism, Image = lZombieApocalypseSafetyTraining, IsAwarded = false, IsAccepted = false, Score=null },
                                },
                            },
                        });


						// *************** Romania Danubius International

						var lCountryRomania = new CountryEntity { Name = "Romania", };
						lContext.Countries.Add(lCountryRomania);

						var lSalonRomania = new SalonEntity { Name = "Danubious", Website = "http://www.photoclub.voltin.ro", Country = lCountryRomania };
						lContext.Salons.Add(lSalonRomania);

						var lSalonYearRomania = new SalonYearEntity { Name = "Danubious", Salon = lSalonRomania, Year = 2017, ClosingDate = new DateTime(2017, 8, 7), JudgeDate = new DateTime(2017, 8, 20), NotificationDate = new DateTime(2017, 8, 30), CataloguesPostedDate = new DateTime(2017, 10, 22) };
						lContext.SalonYears.Add(lSalonYearRomania);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017/313", PhotoOrganisation = lFiap, SalonYear = lSalonYearRomania },
							new AccreditationEntity() { SalonNumber = "2017-237", PhotoOrganisation = lPsa, SalonYear = lSalonYearRomania },
						});

						var lSalonYearRomaniaMono = new SectionEntity() { SalonYear = lSalonYearRomania, SectionType = lSectionTypeMonoPdi };
						var lSalonYearRomaniaColour = new SectionEntity() { SalonYear = lSalonYearRomania, SectionType = lSectionTypeColourPdi };
						var lSalonYearRomaniaNature = new SectionEntity() { SalonYear = lSalonYearRomania, SectionType = lSectionTypeNaturePdi };
						
						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearRomaniaMono,
							lSalonYearRomaniaColour,
							lSalonYearRomaniaNature,
						});

						var lPilgrimDoor = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Pilgrim Door" };
						
						lContext.Images.AddRange(new List<ImageEntity>
						{
							lPilgrimDoor,
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
								IsJudged = true,
								EntryCost = 23.26M,
								SalonYear = lSalonYearRomania,
								EntryDate = new DateTime(2017,8, 1),
								Person = lTim,
								Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaMono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaMono, Image = lOfficePatterns, IsAwarded = false, IsAccepted = false, Score= 9 },
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaMono, Image = lBuildingAbstract, IsAwarded = false, IsAccepted = false, Score= 9 },
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaMono, Image = lReflectionBars, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaColour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false, Score=15 },
									new CompetitionEntryEntity { Section = lSalonYearRomaniaColour, Image = lPilgrimDoor, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaNature, Image = lCanadaGosling, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearRomaniaNature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=9 },
								},
							},
						});


                        // *************** Welsh International

                        var lSalonWelsh = new SalonEntity { Name = "Welsh", Website = "http://thewpf.co.uk/?cat=9", Country = lCountryWales };
                        lContext.Salons.Add(lSalonWelsh);

                        var lSalonYearWelsh = new SalonYearEntity { Name = "Welsh", Salon = lSalonWelsh, Year = 2017, ClosingDate = new DateTime(2017, 8, 19), JudgeDate = new DateTime(2017, 8, 28), NotificationDate = new DateTime(2017, 9, 11), CataloguesPostedDate = new DateTime(2017, 11, 9) };
                        lContext.SalonYears.Add(lSalonYearWelsh);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/379", PhotoOrganisation = lFiap, SalonYear = lSalonYearWelsh },
                            new AccreditationEntity() { SalonNumber = "2017-250", PhotoOrganisation = lPsa, SalonYear = lSalonYearWelsh },
                            new AccreditationEntity() { SalonNumber = "GPU L170106", PhotoOrganisation = lGpu, SalonYear = lSalonYearWelsh },
                        });

                        var lSalonYearWelshMono = new SectionEntity() { SalonYear = lSalonYearWelsh, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearWelshColour = new SectionEntity() { SalonYear = lSalonYearWelsh, SectionType = lSectionTypeColourPdi };
                        var lSalonYearWelshNature = new SectionEntity() { SalonYear = lSalonYearWelsh, SectionType = lSectionTypeNaturePdi };
                        
                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearWelshMono,
                            lSalonYearWelshColour,
                            lSalonYearWelshNature,
                        });

                        var lSacreCoeurDetail = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Sacre Coeur Detail" };
						var lKingfisherWatching = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Kingfisher Watching" };

						lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lSacreCoeurDetail,
                            lKingfisherWatching,
                        });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 18.00M,
                                SalonYear = lSalonYearWelsh,
                                EntryDate = new DateTime(2017,8, 18),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearWelshMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearWelshMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshMono, Image = lSacreCoeurDetail, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshColour, Image = lOrb, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshColour, Image = lGrassesTriptych, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshNature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearWelshNature, Image = lKingfisherWatching, IsAwarded = false, IsAccepted = false, Score=9 },
                                },
                            },
                        });

						// *************** Smederevo Serbia
						var lSalonSerbia = new SalonEntity { Name = "Smederevo", Website = "http://www.fotokinoklub-smederevo.com", Country = lCountrySerbia };
						lContext.Salons.Add(lSalonSerbia);

						var lSalonYearSerbia = new SalonYearEntity { Name = "Smederevo", Salon = lSalonSerbia, Year = 2017, ClosingDate = new DateTime(2017, 8, 27), JudgeDate = new DateTime(2017, 9, 10), NotificationDate = new DateTime(2017, 9, 15), CataloguesPostedDate = new DateTime(2017, 11, 30) };
						lContext.SalonYears.Add(lSalonYearSerbia);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017/336", PhotoOrganisation = lFiap, SalonYear = lSalonYearSerbia },
							new AccreditationEntity() { SalonNumber = "2017-248", PhotoOrganisation = lPsa, SalonYear = lSalonYearSerbia },
                            new AccreditationEntity() { SalonNumber = "GPU L170093", PhotoOrganisation = lGpu, SalonYear = lSalonYearSerbia },
						});

						var lSalonYearSerbiaMono = new SectionEntity() { SalonYear = lSalonYearSerbia, SectionType = lSectionTypeMonoPdi };
						var lSalonYearSerbiaColour = new SectionEntity() { SalonYear = lSalonYearSerbia, SectionType = lSectionTypeColourPdi };
						var lSalonYearServiaPhotojournalism = new SectionEntity() { SalonYear = lSalonYearSerbia, SectionType = lSectionTypePhotojournalismPdi };

						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearSerbiaMono,
							lSalonYearSerbiaColour,
							lSalonYearServiaPhotojournalism,
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
								IsJudged = true,
								EntryCost = 19.06M,
								SalonYear = lSalonYearSerbia,
								EntryDate = new DateTime(2017,8, 19),
								Person = lTim,
								Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearSerbiaMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score= null},
									new CompetitionEntryEntity { Section = lSalonYearSerbiaMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearSerbiaMono, Image = lSacreCoeurDetail, IsAwarded = false, IsAccepted = false, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearSerbiaMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearSerbiaColour, Image = lOrb, IsAwarded = false, IsAccepted = false, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearSerbiaColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = true, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearSerbiaColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearSerbiaColour, Image = lGrassesTriptych, IsAwarded = true, AwardDetails="Salon Diploma", IsAccepted = true, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearServiaPhotojournalism, Image = lBoatingInTheHail, IsAwarded = false, IsAccepted = false, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearServiaPhotojournalism, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = true, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearServiaPhotojournalism, Image = lTerrierRacing, IsAwarded = false, IsAccepted = false, Score=null },
									new CompetitionEntryEntity { Section = lSalonYearServiaPhotojournalism, Image = lZombieApocalypseSafetyTraining, IsAwarded = false, IsAccepted = false, Score=null },
								},
							},
						});
						// *************** Photo Journey 
						var lSalonPhotoJourney = new SalonEntity { Name = "Photo Journey", Website = "http://journey.photosalon.cz", Country = lCountryCzechRep };
						lContext.Salons.Add(lSalonPhotoJourney);

						var lSalonYearPhotoJourney = new SalonYearEntity { Name = "Photo Journey", Salon = lSalonPhotoJourney, Year = 2017, ClosingDate = new DateTime(2017, 8, 28), JudgeDate = new DateTime(2017, 9, 2), NotificationDate = new DateTime(2017, 9, 7), CataloguesPostedDate = new DateTime(2017, 10, 31) };
						lContext.SalonYears.Add(lSalonYearPhotoJourney);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017/478", PhotoOrganisation = lFiap, SalonYear = lSalonYearPhotoJourney },
						});

						var lSalonYearPhotoJourneyMono = new SectionEntity() { SalonYear = lSalonYearPhotoJourney, SectionType = lSectionTypeMonoPdi };
						var lSalonYearPhotoJourneyColour = new SectionEntity() { SalonYear = lSalonYearPhotoJourney, SectionType = lSectionTypeColourPdi };
						var lSalonYearPhotoJourneyNature = new SectionEntity() { SalonYear = lSalonYearPhotoJourney, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearPhotoJourneyTravel = new SectionEntity() { SalonYear = lSalonYearPhotoJourney, SectionType = lSectionTypeTravelPdi };

						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearPhotoJourneyMono,
							lSalonYearPhotoJourneyColour,
							lSalonYearPhotoJourneyNature,
                            lSalonYearPhotoJourneyTravel,
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
								IsJudged = true,
								EntryCost = 28.92M,
								SalonYear = lSalonYearPhotoJourney,
								EntryDate = new DateTime(2017,8, 27),
								Person = lTim,
								Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyMono, Image = lSacreCoeurDetail, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyColour, Image = lGrassesTriptych, IsAwarded = false, IsAccepted = true, Score=19 },
									new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=15 },
									new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyColour, Image = lIntoTheMist, IsAwarded = true, AwardDetails = "FIAP Blue Ribbon", IsAccepted = true, Score=19 },
									new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyColour, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyNature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyNature, Image = lKingfisherWatching, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyTravel, Image = lFreshSnow, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=14},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyTravel, Image = lIcelandicHorse, IsAwarded = false, IsAccepted = false, Score=12},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoJourneyTravel, Image = lBudirChurch, IsAwarded = false, IsAccepted = true, Score=17 },
								},
							},
						});


						// *************** Through The Viewfinder Serbia
						var lSalonViewfinder = new SalonEntity { Name = "Through The Viewfinder", Website = "https://photoclubkragujevac.com/viewfinder/", Country = lCountrySerbia};
						lContext.Salons.Add(lSalonViewfinder);

						var lSalonYearViewfinder = new SalonYearEntity { Name = "Through The Viewfinder", Salon = lSalonViewfinder, Year = 2017, ClosingDate = new DateTime(2017, 11, 11), JudgeDate = new DateTime(2017, 11, 23), NotificationDate = new DateTime(2017, 12, 1), CataloguesPostedDate = new DateTime(2017, 12, 1) };
						lContext.SalonYears.Add(lSalonYearViewfinder);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017/503", PhotoOrganisation = lFiap, SalonYear = lSalonYearViewfinder },
                            new AccreditationEntity() { SalonNumber = "2017-346", PhotoOrganisation = lPsa, SalonYear = lSalonYearViewfinder },
						});

                        var lSalonYearViewfinderMastersOfLight = new SectionEntity() { SalonYear = lSalonYearViewfinder, SectionType = lSectionTypeGoodLightPdi };
                        var lSalonYearViewfinderPhotojournalism = new SectionEntity() { SalonYear = lSalonYearViewfinder, SectionType = lSectionTypePhotojournalismPdi };
						var lSalonYearViewfinderNature = new SectionEntity() { SalonYear = lSalonYearViewfinder, SectionType = lSectionTypeNaturePdi };
						var lSalonYearViewfinderColour = new SectionEntity() { SalonYear = lSalonYearViewfinder, SectionType = lSectionTypeColourPdi };
						var lSalonYearViewfinderMono = new SectionEntity() { SalonYear = lSalonYearViewfinder, SectionType = lSectionTypeMonoPdi };

						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearViewfinderMastersOfLight,
							lSalonYearViewfinderPhotojournalism,
							lSalonYearViewfinderNature,
							lSalonYearViewfinderColour,
                            lSalonYearViewfinderMono,
						});

						var lBoltonAbbeySunbeam = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bolton Abbey Sunbeam" };
						var lZombieAttack = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zombie Attack" };
                        var lTheresSomethingBehindYou = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "There's Something Behind You" };
                        var lKingfisherTurningFish = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Kingfisher Turning Fish" };

						lContext.Images.AddRange(new List<ImageEntity>
						{
							lBoltonAbbeySunbeam,
							lZombieAttack,
                            lTheresSomethingBehindYou,
                            lKingfisherTurningFish,
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
								IsJudged = true,
								EntryCost = 11.45M,
                                SalonYear = lSalonYearViewfinder,
								EntryDate = new DateTime(2017,9, 5),
								Person = lTim,
								Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearViewfinderMastersOfLight, Image = lDawnInTheOutback, IsAwarded = false, IsAccepted = false, Score= 21},
                                    new CompetitionEntryEntity { Section = lSalonYearViewfinderMastersOfLight, Image = lTwelveApostlesSunset, IsAwarded = false, IsAccepted = true, Score=27 },
                                    new CompetitionEntryEntity { Section = lSalonYearViewfinderMastersOfLight, Image = lPathStripes, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearViewfinderMastersOfLight, Image = lBoltonAbbeySunbeam, IsAwarded = true, AwardDetails = "Salon Diploma", IsAccepted = true, Score=29 },
                                    new CompetitionEntryEntity { Section = lSalonYearViewfinderPhotojournalism, Image = lTerrierRacing, IsAwarded = false, IsAccepted = false, Score= 21},
									new CompetitionEntryEntity { Section = lSalonYearViewfinderPhotojournalism, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = true, Score=27 },
									new CompetitionEntryEntity { Section = lSalonYearViewfinderPhotojournalism, Image = lZombieAttack, IsAwarded = false, IsAccepted = false, Score=23 },
                                    new CompetitionEntryEntity { Section = lSalonYearViewfinderPhotojournalism, Image = lTheresSomethingBehindYou, IsAwarded = false, IsAccepted = false, Score=20 },
									new CompetitionEntryEntity { Section = lSalonYearViewfinderNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score=26 },
                                    new CompetitionEntryEntity { Section = lSalonYearViewfinderNature, Image = lKingfisherWatching, IsAwarded = false, IsAccepted = false, Score=21 },
									new CompetitionEntryEntity { Section = lSalonYearViewfinderNature, Image = lKingfisherTurningFish, IsAwarded = false, IsAccepted = false, Score=22 },
									new CompetitionEntryEntity { Section = lSalonYearViewfinderNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=23 },
									new CompetitionEntryEntity { Section = lSalonYearViewfinderColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score=32 },
									new CompetitionEntryEntity { Section = lSalonYearViewfinderColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = true, Score=25 },
									new CompetitionEntryEntity { Section = lSalonYearViewfinderColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=30 },
                                    new CompetitionEntryEntity { Section = lSalonYearViewfinderColour, Image = lGrassesTriptych, IsAwarded = true, AwardDetails="PSA Honorable Mention", IsAccepted = true, Score=31 },
                                    new CompetitionEntryEntity { Section = lSalonYearViewfinderMono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=21 },
									new CompetitionEntryEntity { Section = lSalonYearViewfinderMono, Image = lReflectionBars, IsAwarded = false, IsAccepted = false, Score=19},
									new CompetitionEntryEntity { Section = lSalonYearViewfinderMono, Image = lSacreCoeurDetail, IsAwarded = false, IsAccepted = false, Score=19},
									new CompetitionEntryEntity { Section = lSalonYearViewfinderMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score=26 },
								},
							},
						});

						// *************** Dingwall
						var lSalonDingwall = new SalonEntity { Name = "Dingwall", Website = "http://www.dingwallcameraclub.com/nationalcompetition.asp", Country = lCountryEngland };
						lContext.Salons.Add(lSalonDingwall);

						var lSalonYearDingwall = new SalonYearEntity { Name = "Dingwall", Salon = lSalonDingwall, Year = 2017, ClosingDate = new DateTime(2017, 9, 30), JudgeDate = new DateTime(2017, 10, 15), NotificationDate = new DateTime(2017, 10, 27), CataloguesPostedDate = new DateTime(2017, 12, 4) };
						lContext.SalonYears.Add(lSalonYearDingwall);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017 BPE", PhotoOrganisation = lBpe, SalonYear = lSalonYearDingwall },
						});

                        var lSalonYearDingwallColour = new SectionEntity() { SalonYear = lSalonYearDingwall, SectionType = lSectionTypeColourPdi };
						var lSalonYearDingwallMono = new SectionEntity() { SalonYear = lSalonYearDingwall, SectionType = lSectionTypeMonoPdi };
						var lSalonYearDingwallNature = new SectionEntity() { SalonYear = lSalonYearDingwall, SectionType = lSectionTypeNaturePdi };
						
						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearDingwallColour,
							lSalonYearDingwallMono,
							lSalonYearDingwallNature,
						});

						var lOrbEclipse = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Orb Eclipse" };
						var lKingfisherWithFish = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Kingfisher With Fish" };
						var lReflected = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Reflected" };

						lContext.Images.AddRange(new List<ImageEntity>
						{
							lOrbEclipse,
							lKingfisherWithFish,
                            lReflected,
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.00M,
                                SalonYear = lSalonYearDingwall,
                                EntryDate = new DateTime(2017,9, 15),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallColour, Image = lIntoTheMist, IsAwarded = true, AwardDetails="Commended", IsAccepted = true, Score= 14},
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallColour, Image = lOrbEclipse, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallMono, Image = lSacreCoeurDetail, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallMono, Image = lBuildingAbstract, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallNature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallNature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearDingwallNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=10 },
                                },
							},
						});

						// *************** Canvas 2017
						var lSalonCanvas = new SalonEntity { Name = "Canvas", Website = "http://www.gradacfoto.com/", Country = lCountryMontenegro };
						lContext.Salons.Add(lSalonCanvas);

						var lSalonYearCanvas = new SalonYearEntity { Name = "Canvas", Salon = lSalonCanvas, Year = 2017, ClosingDate = new DateTime(2017, 9, 17), JudgeDate = new DateTime(2017, 10, 5), NotificationDate = new DateTime(2017, 10, 10), CataloguesPostedDate = new DateTime(2017, 12, 19) };
						lContext.SalonYears.Add(lSalonYearCanvas);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017/364", PhotoOrganisation = lFiap, SalonYear = lSalonYearCanvas },
                            new AccreditationEntity() { SalonNumber = "2017-290", PhotoOrganisation = lPsa, SalonYear = lSalonYearCanvas },
						});

						var lSalonYearCanvasColour = new SectionEntity() { SalonYear = lSalonYearCanvas, SectionType = lSectionTypeColourPdi };
						var lSalonYearCanvasMono = new SectionEntity() { SalonYear = lSalonYearCanvas, SectionType = lSectionTypeMonoPdi };
						var lSalonYearCanvasNature = new SectionEntity() { SalonYear = lSalonYearCanvas, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearCanvasTravel = new SectionEntity() { SalonYear = lSalonYearCanvas, SectionType = lSectionTypeTravelPdi };

						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearCanvasColour,
							lSalonYearCanvasMono,
							lSalonYearCanvasNature,
                            lSalonYearCanvasTravel,
						});

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 17.56M,
                                SalonYear = lSalonYearCanvas,
                                EntryDate = new DateTime(2017,9, 15),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score= 22},
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasColour, Image = lOrbEclipse, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score= 19},
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasMono, Image = lBuildingAbstract, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasMono, Image = lReflected, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = true, Score=24 },
									new CompetitionEntryEntity { Section = lSalonYearCanvasNature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=17 },
									new CompetitionEntryEntity { Section = lSalonYearCanvasNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=19 },
									new CompetitionEntryEntity { Section = lSalonYearCanvasNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasTravel, Image = lFreshSnow, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasTravel, Image = lHarbourSailingInMalta, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearCanvasTravel, Image = lBudirChurch, IsAwarded = false, IsAccepted = false, Score=18 },
								},
							},
						});

						// *************** Reflection of the world
						var lSalonReflection = new SalonEntity { Name = "Reflection Of The World", Website = "http://worldreflection.com.ua", Country = lCountryUkraine };
						lContext.Salons.Add(lSalonReflection);

						var lSalonYearReflection = new SalonYearEntity { Name = "Reflection Of The World", Salon = lSalonReflection, Year = 2017, ClosingDate = new DateTime(2017, 10, 1), JudgeDate = new DateTime(2017, 11, 6), NotificationDate = new DateTime(2017, 11, 15), CataloguesPostedDate = new DateTime(2018, 1, 25) };
						lContext.SalonYears.Add(lSalonYearReflection);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017/538", PhotoOrganisation = lFiap, SalonYear = lSalonYearReflection },
						});

						var lSalonYearReflectionColour = new SectionEntity() { SalonYear = lSalonYearReflection, SectionType = lSectionTypeColourPdi };
						var lSalonYearReflectionMono = new SectionEntity() { SalonYear = lSalonYearReflection, SectionType = lSectionTypeMonoPdi };
						var lSalonYearReflectionNature = new SectionEntity() { SalonYear = lSalonYearReflection, SectionType = lSectionTypeNaturePdi };
						var lSalonYearReflectionTravel = new SectionEntity() { SalonYear = lSalonYearReflection, SectionType = lSectionTypeTravelPdi };

						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearReflectionColour,
							lSalonYearReflectionMono,
							lSalonYearReflectionNature,
							lSalonYearReflectionTravel,
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
								IsJudged = true,
								EntryCost = 18.37M,
								SalonYear = lSalonYearReflection,
								EntryDate = new DateTime(2017,9, 30),
								Person = lTim,
								Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearReflectionColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false, Score= 18},
									new CompetitionEntryEntity { Section = lSalonYearReflectionColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = true, Score=20 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearReflectionColour, Image = lParisianLightTriptych, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearReflectionMono, Image = lBuildingAbstract, IsAwarded = false, IsAccepted = false, Score= 14},
                                    new CompetitionEntryEntity { Section = lSalonYearReflectionMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=17 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=18 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionMono, Image = lSacreCoeurDetail, IsAwarded = false, IsAccepted = false, Score=16 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=15 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionNature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=17 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=15 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionNature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=15 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionTravel, Image = lBudirChurch, IsAwarded = false, IsAccepted = false, Score=17 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionTravel, Image = lHarbourSailingInMalta, IsAwarded = false, IsAccepted = false, Score=15 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=16 },
									new CompetitionEntryEntity { Section = lSalonYearReflectionTravel, Image = lFreshSnow, IsAwarded = false, IsAccepted = false, Score=15 },

								},
							},
						});

						// *************** 3rd Wojnicz International Salon of Photography 2017

						var lSalonWojnicz = new SalonEntity { Name = "Wojnicz", Website = "http://salon.fotum.org", Country = lCountryPoland };
						lContext.Salons.Add(lSalonWojnicz);

						var lSalonYearWojnicz = new SalonYearEntity { Name = "Wojnicz", Salon = lSalonWojnicz, Year = 2017, ClosingDate = new DateTime(2017, 10, 2), JudgeDate = new DateTime(2017, 10, 15), NotificationDate = new DateTime(2017, 10, 20), CataloguesPostedDate = new DateTime(2017, 10, 20) };
						lContext.SalonYears.Add(lSalonYearWojnicz);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017/329", PhotoOrganisation = lFiap, SalonYear = lSalonYearWojnicz },
                            new AccreditationEntity() { SalonNumber = "2017-295", PhotoOrganisation = lPsa, SalonYear = lSalonYearWojnicz },
                            new AccreditationEntity() { SalonNumber = "GPU L170087", PhotoOrganisation = lGpu, SalonYear = lSalonYearWojnicz },
						});

						var lSalonYearWojniczColour = new SectionEntity() { SalonYear = lSalonYearWojnicz, SectionType = lSectionTypeColourPdi };
						var lSalonYearWojniczMono = new SectionEntity() { SalonYear = lSalonYearWojnicz, SectionType = lSectionTypeMonoPdi };
						var lSalonYearWojniczPortrait = new SectionEntity() { SalonYear = lSalonYearWojnicz, SectionType = lSectionTypePortraitPdi };
						
						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearWojniczColour,
							lSalonYearWojniczMono,
							lSalonYearWojniczPortrait,
						});

						var lThePilgrimage = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Pilgrimage" };
						var lThePriest = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Priest" };
						var lWraith = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Wraith" };
                        var lDapperZombie = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Dapper Zombie" };

						lContext.Images.AddRange(new List<ImageEntity>
						{
							lOrbEclipse,
							lKingfisherWithFish,
							lReflected,
						});


						lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 13.77M,
                                SalonYear = lSalonYearWojnicz,
                                EntryDate = new DateTime(2017,9, 30),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearWojniczColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearWojniczColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=17},
                                    new CompetitionEntryEntity { Section = lSalonYearWojniczColour, Image = lParisianLightTriptych, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearWojniczColour, Image = lThePilgrimage, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearWojniczMono, Image = lSacreCoeurDetail, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearWojniczMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearWojniczMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearWojniczMono, Image = lReflectionBars, IsAwarded = false, IsAccepted = false, Score=8 },
									new CompetitionEntryEntity { Section = lSalonYearWojniczPortrait, Image = lThePriest, IsAwarded = false, IsAccepted = false, Score=13 },
									new CompetitionEntryEntity { Section = lSalonYearWojniczPortrait, Image = lWraith, IsAwarded = false, IsAccepted = false, Score=14 },
									new CompetitionEntryEntity { Section = lSalonYearWojniczPortrait, Image = lDapperZombie, IsAwarded = false, IsAccepted = false, Score=13 },
									new CompetitionEntryEntity { Section = lSalonYearWojniczPortrait, Image = lZombieGirl, IsAwarded = false, IsAccepted = true, Score=16 },
								},
							},
						});

						// *** French Digital Tour ****
						var lFrenchDigitalTour = new CircuitEntity() { Name = "French Digital Tour 2017" };
                        lContext.Circuits.Add(lFrenchDigitalTour);

						var lSalonFrench1 = new SalonEntity { Name = "FDT - Legé", Website = "http://frenchdigitaltour.org", Country = lCountryFrance };
                        var lSalonFrench2 = new SalonEntity { Name = "FDT - Saint Aignan de Crasmenil", Website = "http://frenchdigitaltour.org", Country = lCountryFrance };
                        var lSalonFrench3 = new SalonEntity { Name = "FDT - Saint Martin de Crau", Website = "http://frenchdigitaltour.org", Country = lCountryFrance };
                        var lSalonFrench4 = new SalonEntity { Name = "FDT - Bagnols Marcoule", Website = "http://frenchdigitaltour.org", Country = lCountryFrance };
                        lContext.Salons.AddRange(new List<SalonEntity>(){
                            lSalonFrench1,
                            lSalonFrench2,
                            lSalonFrench3,
                            lSalonFrench4,
                        });

						var lSalonYearFrench1 = new SalonYearEntity { Name = "FDT - Legé", Salon = lSalonFrench1, Year = 2017, ClosingDate = new DateTime(2017, 10, 23), JudgeDate = new DateTime(2017, 11, 5), NotificationDate = new DateTime(2017, 12, 7), CataloguesPostedDate = new DateTime(2018, 2, 9), Circuit = lFrenchDigitalTour };
                        var lSalonYearFrench2 = new SalonYearEntity { Name = "FDT - Saint Aignan de Crasmenil", Salon = lSalonFrench2, Year = 2017, ClosingDate = new DateTime(2017, 10, 23), JudgeDate = new DateTime(2017, 11, 12), NotificationDate = new DateTime(2017, 12, 7), CataloguesPostedDate = new DateTime(2018, 2, 9), Circuit = lFrenchDigitalTour };
                        var lSalonYearFrench3 = new SalonYearEntity { Name = "FDT - Saint Martin de Crau", Salon = lSalonFrench3, Year = 2017, ClosingDate = new DateTime(2017, 10, 23), JudgeDate = new DateTime(2017, 11, 19), NotificationDate = new DateTime(2017, 12, 7), CataloguesPostedDate = new DateTime(2018, 2, 9), Circuit = lFrenchDigitalTour };
                        var lSalonYearFrench4 = new SalonYearEntity { Name = "FDT - Bagnols Marcoule", Salon = lSalonFrench4, Year = 2017, ClosingDate = new DateTime(2017, 10, 23), JudgeDate = new DateTime(2017, 11, 26), NotificationDate = new DateTime(2017, 12, 7), CataloguesPostedDate = new DateTime(2018, 2, 9), Circuit = lFrenchDigitalTour };
                        lContext.SalonYears.AddRange(new List<SalonYearEntity>(){
                            lSalonYearFrench1,
                            lSalonYearFrench2,
                            lSalonYearFrench3,
                            lSalonYearFrench4,
                        });

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2017/294", PhotoOrganisation = lFiap, SalonYear = lSalonYearFrench1 },
                            new AccreditationEntity() { SalonNumber = "2017/295", PhotoOrganisation = lFiap, SalonYear = lSalonYearFrench2 },
                            new AccreditationEntity() { SalonNumber = "2017/296", PhotoOrganisation = lFiap, SalonYear = lSalonYearFrench3 },
                            new AccreditationEntity() { SalonNumber = "2017/297", PhotoOrganisation = lFiap, SalonYear = lSalonYearFrench4 },
                            new AccreditationEntity() { SalonNumber = "2017-249", PhotoOrganisation = lPsa, SalonYear = lSalonYearFrench1 },
                            new AccreditationEntity() { SalonNumber = "2017-249", PhotoOrganisation = lPsa, SalonYear = lSalonYearFrench2 },
                            new AccreditationEntity() { SalonNumber = "2017-249", PhotoOrganisation = lPsa, SalonYear = lSalonYearFrench3 },
                            new AccreditationEntity() { SalonNumber = "2017-249", PhotoOrganisation = lPsa, SalonYear = lSalonYearFrench4 },                            
                            new AccreditationEntity() { SalonNumber = "GPU L170086", PhotoOrganisation = lGpu, SalonYear = lSalonYearFrench1 },
                            new AccreditationEntity() { SalonNumber = "GPU L170086", PhotoOrganisation = lGpu, SalonYear = lSalonYearFrench2 },
                            new AccreditationEntity() { SalonNumber = "GPU L170086", PhotoOrganisation = lGpu, SalonYear = lSalonYearFrench3 },
                            new AccreditationEntity() { SalonNumber = "GPU L170086", PhotoOrganisation = lGpu, SalonYear = lSalonYearFrench4 },
						});

						var lSalonYearFrench1Colour = new SectionEntity() { SalonYear = lSalonYearFrench1, SectionType = lSectionTypeColourPdi };
						var lSalonYearFrench1Mono = new SectionEntity() { SalonYear = lSalonYearFrench1, SectionType = lSectionTypeMonoPdi };
						var lSalonYearFrench1Nature = new SectionEntity() { SalonYear = lSalonYearFrench1, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearFrench1Street = new SectionEntity() { SalonYear = lSalonYearFrench1, SectionType = lSectionTypeStreetPdi };
						var lSalonYearFrench2Colour = new SectionEntity() { SalonYear = lSalonYearFrench2, SectionType = lSectionTypeColourPdi };
						var lSalonYearFrench2Mono = new SectionEntity() { SalonYear = lSalonYearFrench2, SectionType = lSectionTypeMonoPdi };
						var lSalonYearFrench2Nature = new SectionEntity() { SalonYear = lSalonYearFrench2, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearFrench2Street = new SectionEntity() { SalonYear = lSalonYearFrench2, SectionType = lSectionTypeStreetPdi };
						var lSalonYearFrench3Colour = new SectionEntity() { SalonYear = lSalonYearFrench3, SectionType = lSectionTypeColourPdi };
						var lSalonYearFrench3Mono = new SectionEntity() { SalonYear = lSalonYearFrench3, SectionType = lSectionTypeMonoPdi };
						var lSalonYearFrench3Nature = new SectionEntity() { SalonYear = lSalonYearFrench3, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearFrench3Street = new SectionEntity() { SalonYear = lSalonYearFrench3, SectionType = lSectionTypeStreetPdi };
						var lSalonYearFrench4Colour = new SectionEntity() { SalonYear = lSalonYearFrench4, SectionType = lSectionTypeColourPdi };
						var lSalonYearFrench4Mono = new SectionEntity() { SalonYear = lSalonYearFrench4, SectionType = lSectionTypeMonoPdi };
						var lSalonYearFrench4Nature = new SectionEntity() { SalonYear = lSalonYearFrench4, SectionType = lSectionTypeNaturePdi };
						var lSalonYearFrench4Street = new SectionEntity() { SalonYear = lSalonYearFrench4, SectionType = lSectionTypeStreetPdi };

						lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearFrench1Colour,
                            lSalonYearFrench1Mono,
                            lSalonYearFrench1Nature,
                            lSalonYearFrench1Street,
							lSalonYearFrench2Colour,
							lSalonYearFrench2Mono,
							lSalonYearFrench2Nature,
							lSalonYearFrench2Street,
							lSalonYearFrench3Colour,
							lSalonYearFrench3Mono,
							lSalonYearFrench3Nature,
							lSalonYearFrench3Street,
                            lSalonYearFrench4Colour,
							lSalonYearFrench4Mono,
							lSalonYearFrench4Nature,
							lSalonYearFrench4Street,
						});

						var lTheSpectator = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Spectator" };
		
						lContext.Images.AddRange(new List<ImageEntity>
						{
							lTheSpectator,
						});


						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
								IsJudged = true,
								EntryCost = 10.52M,
								SalonYear = lSalonYearFrench1,
								EntryDate = new DateTime(2017,10, 8),
								Person = lTim,
								Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Colour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score= 35},
									new CompetitionEntryEntity { Section = lSalonYearFrench1Colour, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = true, Score=40 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Colour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=37 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Colour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score=42 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score= 32},
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score=34 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=31 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Mono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=27 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Nature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=31 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score=45 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Nature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=35 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Nature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=38 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Street, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = false, Score=30 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Street, Image = lTheresSomethingBehindYou, IsAwarded = false, IsAccepted = false, Score=26 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Street, Image = lTheSpectator, IsAwarded = false, IsAccepted = false, Score=30 },
                                    new CompetitionEntryEntity { Section = lSalonYearFrench1Street, Image = lBusySteppingStones, IsAwarded = false, IsAccepted = false, Score=26 },
							    },
							},
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
								IsJudged = true,
								EntryCost = 10.52M,
								SalonYear = lSalonYearFrench2,
								EntryDate = new DateTime(2017,10, 8),
								Person = lTim,
								Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearFrench2Colour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score= 42},
									new CompetitionEntryEntity { Section = lSalonYearFrench2Colour, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = false, Score=35 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Colour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=32 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Colour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score=44 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score= 46},
									new CompetitionEntryEntity { Section = lSalonYearFrench2Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=38 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=38 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Mono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=38 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Nature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=40 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=44 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Nature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=39 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Nature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=45 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Street, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = false, Score=40 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Street, Image = lTheresSomethingBehindYou, IsAwarded = false, IsAccepted = false, Score=33 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Street, Image = lTheSpectator, IsAwarded = false, IsAccepted = false, Score=41 },
									new CompetitionEntryEntity { Section = lSalonYearFrench2Street, Image = lBusySteppingStones, IsAwarded = false, IsAccepted = false, Score=39 },
								},
							},
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
								IsJudged = true,
								EntryCost = 10.52M,
								SalonYear = lSalonYearFrench3,
								EntryDate = new DateTime(2017,10, 8),
								Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearFrench3Colour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score= 27},
									new CompetitionEntryEntity { Section = lSalonYearFrench3Colour, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = true, Score=32 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Colour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=29 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Colour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false, Score=29 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score= 33},
									new CompetitionEntryEntity { Section = lSalonYearFrench3Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=30 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true, Score=33 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Mono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=26 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Nature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=25 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score=36 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Nature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = true, Score=35 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Nature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = true, Score=38 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Street, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = true, Score=33 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Street, Image = lTheresSomethingBehindYou, IsAwarded = false, IsAccepted = false, Score=26 },
									new CompetitionEntryEntity { Section = lSalonYearFrench3Street, Image = lTheSpectator, IsAwarded = false, IsAccepted = false, Score=30},
									new CompetitionEntryEntity { Section = lSalonYearFrench3Street, Image = lBusySteppingStones, IsAwarded = false, IsAccepted = true, Score=37 },
								},
							},
						});

						lContext.Submissions.AddRange(new List<SubmissionEntity> {
							new SubmissionEntity(){
								IsJudged = true,
								EntryCost = 10.53M,
								SalonYear = lSalonYearFrench4,
								EntryDate = new DateTime(2017,10, 8),
								Person = lTim,
								Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearFrench4Colour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score= 39},
									new CompetitionEntryEntity { Section = lSalonYearFrench4Colour, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = true, Score=42 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Colour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=40 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Colour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false, Score=38 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score= 40},
									new CompetitionEntryEntity { Section = lSalonYearFrench4Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=41 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=39 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Mono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=37 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Nature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=37 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=41 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Nature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=37 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Nature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=38 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Street, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = false, Score=18 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Street, Image = lTheresSomethingBehindYou, IsAwarded = false, IsAccepted = false, Score=41 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Street, Image = lTheSpectator, IsAwarded = false, IsAccepted = false, Score=40 },
									new CompetitionEntryEntity { Section = lSalonYearFrench4Street, Image = lBusySteppingStones, IsAwarded = false, IsAccepted = true, Score=43 },
								},
							},
						});

                        // Belgium ISO 2017
                        var lSalonIso = new SalonEntity { Name = "International Sillian Organisation", Website = "http://www.ddcontest.com", Country = lCountryBelgium };
                        lContext.Salons.Add(lSalonIso);

                        var lSalonYearIso = new SalonYearEntity { Name = "ISO", Salon = lSalonIso, Year = 2017, ClosingDate = new DateTime(2017, 10, 22), JudgeDate = new DateTime(2017, 10, 30), NotificationDate = new DateTime(2017, 11, 13), CataloguesPostedDate = new DateTime(2017, 12, 15) };
                        lContext.SalonYears.Add(lSalonYearIso);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/316", PhotoOrganisation = lFiap, SalonYear = lSalonYearIso },
                            new AccreditationEntity() { SalonNumber = "2017-294", PhotoOrganisation = lPsa, SalonYear = lSalonYearIso },
                        });

                        var lSalonYearIsoColour = new SectionEntity() { SalonYear = lSalonYearIso, SectionType = lSectionTypeColourPdi };
                        var lSalonYearIsoMono = new SectionEntity() { SalonYear = lSalonYearIso, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearIsoCreative = new SectionEntity() { SalonYear = lSalonYearIso, SectionType = lSectionTypeCreativePdi };
                        var lSalonYearIsoNature = new SectionEntity() { SalonYear = lSalonYearIso, SectionType = lSectionTypeNaturePdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearIsoColour,
                            lSalonYearIsoMono,
                            lSalonYearIsoCreative,
                            lSalonYearIsoNature,
                        });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 14.05M,
                                SalonYear = lSalonYearIso,
                                EntryDate = new DateTime(2017,10, 20),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearIsoColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false, Score= 19},
                                    new CompetitionEntryEntity { Section = lSalonYearIsoColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoColour, Image = lTheWatcher, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoColour, Image = lGrassesTriptych, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoMono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearIsoMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoCreative, Image = lOrbEclipse, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoCreative, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = true, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoCreative, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = true, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoCreative, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = true, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoNature, Image = lCanadaGosling, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearIsoNature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = true, Score=20 },
                                },
                            },
                        });

                        // Tramontana
                        var lSalonTramontana = new SalonEntity { Name = "Tramontana", Website = "http://www.victory-photo.club/", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonTramontana);

                        var lSalonYearTramontana = new SalonYearEntity { Name = "Tramontana", Salon = lSalonTramontana, Year = 2017, ClosingDate = new DateTime(2017, 10, 29), JudgeDate = new DateTime(2017, 11, 7), NotificationDate = new DateTime(2017, 11, 10), CataloguesPostedDate = new DateTime(2018, 1, 20) };
                        lContext.SalonYears.Add(lSalonYearTramontana);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/429", PhotoOrganisation = lFiap, SalonYear = lSalonYearTramontana },
                            new AccreditationEntity() { SalonNumber = "2017-332", PhotoOrganisation = lPsa, SalonYear = lSalonYearTramontana },
                        });

                        var lSalonYearTramontanaColour = new SectionEntity() { SalonYear = lSalonYearTramontana, SectionType = lSectionTypeColourPdi };
                        var lSalonYearTramontanaMono = new SectionEntity() { SalonYear = lSalonYearTramontana, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearTramontanaTravel = new SectionEntity() { SalonYear = lSalonYearTramontana, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearTramontanaNature = new SectionEntity() { SalonYear = lSalonYearTramontana, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearTramontanaPortraitFineArt = new SectionEntity() { SalonYear = lSalonYearTramontana, SectionType = lSectionTypePortraitPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearTramontanaColour,
                            lSalonYearTramontanaMono,
                            lSalonYearTramontanaTravel,
                            lSalonYearTramontanaNature,
                            lSalonYearTramontanaPortraitFineArt,
                        });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 16.58M,
                                SalonYear = lSalonYearTramontana,
                                EntryDate = new DateTime(2017,10, 29),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score= 19},
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaColour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaColour, Image = lGrassesTriptych, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score= 19},
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaMono, Image = lReflected, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaTravel, Image = lBudirChurch, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaTravel, Image = lHarbourSailingInMalta, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaTravel, Image = lFreshSnow, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaNature, Image = lCanadaGosling, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaNature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaPortraitFineArt, Image = lZombieGirl, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaPortraitFineArt, Image = lThePriest, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaPortraitFineArt, Image = lDapperZombie, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearTramontanaPortraitFineArt, Image = lWraith, IsAwarded = false, IsAccepted = false, Score=17 },
                                },
                            },
                        });

                        // Soproni
                        var lSalonSoproni = new SalonEntity { Name = "Soproni Fotoklub", Website = "http://www.sopronifotoklub.hu/", Country = lCountryHungary };
                        lContext.Salons.Add(lSalonSoproni);

                        var lSalonYearSoproni = new SalonYearEntity { Name = "Soproni Fotoklub", Salon = lSalonSoproni, Year = 2017, ClosingDate = new DateTime(2017, 11, 10), JudgeDate = new DateTime(2017, 11, 19), NotificationDate = new DateTime(2017, 12, 5), CataloguesPostedDate = new DateTime(2018, 1, 29) };
                        lContext.SalonYears.Add(lSalonYearSoproni);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/461", PhotoOrganisation = lFiap, SalonYear = lSalonYearSoproni },
});

                        var lSalonYearSoproniColour = new SectionEntity() { SalonYear = lSalonYearSoproni, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSoproniMono = new SectionEntity() { SalonYear = lSalonYearSoproni, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSoproniCreative = new SectionEntity() { SalonYear = lSalonYearSoproni, SectionType = lSectionTypeCreativePdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearSoproniColour,
                            lSalonYearSoproniMono,
                            lSalonYearSoproniCreative,
                        });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 18.59M,
                                SalonYear = lSalonYearSoproni,
                                EntryDate = new DateTime(2017,11, 3),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniColour, Image = lTheWatcherInTheWaves, IsAwarded = true, AwardDetails = "FIAP Honorable Mention", IsAccepted = true, Score= null},
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniColour, Image = lGrassesTriptych, IsAwarded = false, IsAccepted = true, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score= null},
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniMono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniMono, Image = lRuinsByNight, IsAwarded = true, AwardDetails = "FIAP Honorable Mention", IsAccepted = true, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniCreative, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniCreative, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniCreative, Image = lLoneTree, IsAwarded = false, IsAccepted = true, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearSoproniCreative, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false, Score=null },
                                },
                            },
                        });

                        // Smethwick
                        var lSalonSmethwick = new SalonEntity { Name = "Smethwick", Website = "http://www.smethwickps.co.uk/sps-international/4591954408", Country = lCountryEngland };
                        lContext.Salons.Add(lSalonSmethwick);

                        var lSalonYearSmethwick = new SalonYearEntity { Name = "Smethwick", Salon = lSalonSmethwick, Year = 2017, ClosingDate = new DateTime(2017, 11, 9), JudgeDate = new DateTime(2017, 11, 19), NotificationDate = new DateTime(2017, 11, 24), CataloguesPostedDate = new DateTime(2018, 1, 25) };
                        lContext.SalonYears.Add(lSalonYearSmethwick);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/407", PhotoOrganisation = lFiap, SalonYear = lSalonYearSmethwick },
                            new AccreditationEntity() { SalonNumber = "2017-325", PhotoOrganisation = lPsa, SalonYear = lSalonYearSmethwick },
                            new AccreditationEntity() { SalonNumber = "GPU L170108", PhotoOrganisation = lGpu, SalonYear = lSalonYearSmethwick },
                        });

                        var lSalonYearSmethwickPrintColour = new SectionEntity() { SalonYear = lSalonYearSmethwick, SectionType = lSectionTypeColourPrint };
                        var lSalonYearSmethwickPrintNature = new SectionEntity() { SalonYear = lSalonYearSmethwick, SectionType = lSectionTypeNaturePrint };
                        var lSalonYearSmethwickColour = new SectionEntity() { SalonYear = lSalonYearSmethwick, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSmethwickMono = new SectionEntity() { SalonYear = lSalonYearSmethwick, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSmethwickNature = new SectionEntity() { SalonYear = lSalonYearSmethwick, SectionType = lSectionTypeNaturePdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearSmethwickPrintColour,
                            lSalonYearSmethwickPrintNature,
                            lSalonYearSmethwickColour,
                            lSalonYearSmethwickMono,
                            lSalonYearSmethwickNature,
                        });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 23.00M,
                                SalonYear = lSalonYearSmethwick,
                                EntryDate = new DateTime(2017,11, 3),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickPrintColour, Image = lGrassesTriptych, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickPrintColour, Image = lTheWatcher, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickPrintColour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickPrintColour, Image = lLoneTree, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickPrintNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickPrintNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickPrintNature, Image = lCanadaGosling, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickPrintNature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickColour, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickMono, Image = lArcReflections, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickNature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickNature, Image = lKingfisherWatching, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickNature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmethwickNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=9 },
                                },
                            },
                        });

                        // Cacak
                        var lSalonCacak = new SalonEntity { Name = "Cacak", Website = "http://www.perasto.club/", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonCacak);

                        var lSalonYearCacak = new SalonYearEntity { Name = "Cacak", Salon = lSalonCacak, Year = 2017, ClosingDate = new DateTime(2017, 11, 12), JudgeDate = new DateTime(2017, 11, 29), NotificationDate = new DateTime(2017, 12, 4), CataloguesPostedDate = new DateTime(2018, 2, 10) };
                        lContext.SalonYears.Add(lSalonYearCacak);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/474", PhotoOrganisation = lFiap, SalonYear = lSalonYearCacak },
                            new AccreditationEntity() { SalonNumber = "2017-369", PhotoOrganisation = lPsa, SalonYear = lSalonYearCacak },
                        });

                        var lSalonYearCacakColour = new SectionEntity() { SalonYear = lSalonYearCacak, SectionType = lSectionTypeColourPdi };
                        var lSalonYearCacakNature = new SectionEntity() { SalonYear = lSalonYearCacak, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearCacakTravel = new SectionEntity() { SalonYear = lSalonYearCacak, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearCacakMono = new SectionEntity() { SalonYear = lSalonYearCacak, SectionType = lSectionTypeMonoPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearCacakColour,
                            lSalonYearCacakNature,
                            lSalonYearCacakTravel,
                            lSalonYearCacakMono,
                        });

                        var lOutspan = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Outspan" };
                        var lSunflower = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Sunflower" };
                        var lRimlitKingfisher = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Rimlit Kingfisher" };
                        var lMdinaMalta = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Mdina Malta" };
                        var lIcelandicRefuge = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Icelandic Refuge" };
                        var lKirkjufellReflected = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Kirkjufell Reflected" };
                        var lCorner = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Corner" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lOutspan,
                            lSunflower,
                            lRimlitKingfisher,
                            lMdinaMalta,
                            lIcelandicRefuge,
                            lKirkjufellReflected,
                            lCorner,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 18.39M,
                                SalonYear = lSalonYearCacak,
                                EntryDate = new DateTime(2017,11, 11),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearCacakColour, Image = lOutspan, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakColour, Image = lLoneTree, IsAwarded = false, IsAccepted = true, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearCacakColour, Image = lParisianLightTriptych, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakColour, Image = lSunflower, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakNature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score= 14},
                                    new CompetitionEntryEntity { Section = lSalonYearCacakNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakNature, Image = lHeronFishing, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakTravel, Image = lMdinaMalta, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakTravel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakTravel, Image = lIcelandicRefuge, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakTravel, Image = lKirkjufellReflected, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score= 25},
                                    new CompetitionEntryEntity { Section = lSalonYearCacakMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearCacakMono, Image = lCorner, IsAwarded = false, IsAccepted = false, Score=12 },
                                },
                            },
                        });

                        // Yorkshire
                        var lSalonYearYorkshire2017 = new SalonYearEntity { Name = "Yorkshire", Salon = lSalonYorkshire, Year = 2017, ClosingDate = new DateTime(2017, 12, 4), JudgeDate = new DateTime(2017, 12, 10), NotificationDate = new DateTime(2017, 12, 18), CataloguesPostedDate = new DateTime(2018, 2, 15) };
                        lContext.SalonYears.Add(lSalonYearYorkshire2017);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/402", PhotoOrganisation = lFiap, SalonYear = lSalonYearYorkshire2017 },
                            new AccreditationEntity() { SalonNumber = "2017-349", PhotoOrganisation = lPsa, SalonYear = lSalonYearYorkshire2017 },
                        });

                        var lSalonYearYorkshire2017Colour = new SectionEntity() { SalonYear = lSalonYearYorkshire2017, SectionType = lSectionTypeColourPrint };
                        var lSalonYearYorkshire2017Mono = new SectionEntity() { SalonYear = lSalonYearYorkshire2017, SectionType = lSectionTypeMonoPrint };
                        var lSalonYearYorkshire2017Open = new SectionEntity() { SalonYear = lSalonYearYorkshire2017, SectionType = lSectionTypeColourPdi };
                        var lSalonYearYorkshire2017Nature = new SectionEntity() { SalonYear = lSalonYearYorkshire2017, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearYorkshire2017Travel = new SectionEntity() { SalonYear = lSalonYearYorkshire2017, SectionType = lSectionTypeTravelPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearYorkshire2017Colour,
                            lSalonYearYorkshire2017Mono,
                            lSalonYearYorkshire2017Open,
                            lSalonYearYorkshire2017Nature,
                            lSalonYearYorkshire2017Travel,
                        });

                        var lCircleTheTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Circle The Tree" };
                        var lFlowersInCircle = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Flowers In Circle" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lCircleTheTree,
                            lFlowersInCircle
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 21.0M,
                                SalonYear = lSalonYearYorkshire2017,
                                EntryDate = new DateTime(2017,11, 26),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Colour, Image = lCircleTheTree, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Colour, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = true, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Colour, Image = lSunflower, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Colour, Image = lFlowersInCircle, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Mono, Image = lCorner, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Open, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Open, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Open, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Open, Image = lSpiralNine, IsAwarded = false, IsAccepted = true, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Nature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Nature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Nature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=9 },                                
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Travel, Image = lMdinaMalta, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Travel, Image = lIcelandicRefuge, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Travel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=10 },                                   
                                    new CompetitionEntryEntity { Section = lSalonYearYorkshire2017Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=10 },
                                },
                            },
                        });

                        // Ohrid
                        var lSalonOhrid = new SalonEntity { Name = "Ohrid", Website = "http://www.exhibitions.photo/", Country = lCountryMacedonia };
                        lContext.Salons.Add(lSalonOhrid);


                        var lSalonYearOhrid = new SalonYearEntity { Name = "Ohrid", Salon = lSalonOhrid, Year = 2017, ClosingDate = new DateTime(2017, 12, 10), JudgeDate = new DateTime(2017, 12, 26), NotificationDate = new DateTime(2017, 12, 29), CataloguesPostedDate = new DateTime(2018, 3, 18) };
                        lContext.SalonYears.Add(lSalonYearOhrid);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/504", PhotoOrganisation = lFiap, SalonYear = lSalonYearOhrid },
                            new AccreditationEntity() { SalonNumber = "2017-396", PhotoOrganisation = lPsa, SalonYear = lSalonYearOhrid },
                        });

                        var lSalonYearOhridColour = new SectionEntity() { SalonYear = lSalonYearOhrid, SectionType = lSectionTypeColourPdi };
                        var lSalonYearOhridMono = new SectionEntity() { SalonYear = lSalonYearOhrid, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearOhridNature = new SectionEntity() { SalonYear = lSalonYearOhrid, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearOhridTravel = new SectionEntity() { SalonYear = lSalonYearOhrid, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearOhridManWomanChild = new SectionEntity() { SalonYear = lSalonYearOhrid, SectionType = lSectionTypeManWomanChildPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearOhridColour,
                            lSalonYearOhridMono,
                            lSalonYearOhridNature,
                            lSalonYearOhridTravel,
                            lSalonYearOhridManWomanChild,
                        });

                        var lTheTower = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Tower" };
                       
                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lTheTower,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 23.0M,
                                SalonYear = lSalonYearOhrid,
                                EntryDate = new DateTime(2017,12, 3),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearOhridColour, Image = lLoneTree, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearOhridColour, Image = lFlowersInCircle, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridColour, Image = lSunflower, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score= 16},
                                    new CompetitionEntryEntity { Section = lSalonYearOhridMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridMono, Image = lTheTower, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridNature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridNature, Image = lWaterVole, IsAwarded = false, IsAccepted = true, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridTravel, Image = lMdinaMalta, IsAwarded = false, IsAccepted = false, Score= 15},
                                    new CompetitionEntryEntity { Section = lSalonYearOhridTravel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridTravel, Image = lIcelandicRefuge, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridManWomanChild, Image = lZombieGirl, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridManWomanChild, Image = lThePriest, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridManWomanChild, Image = lDapperZombie, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearOhridManWomanChild, Image = lWraith, IsAwarded = false, IsAccepted = false, Score=18 },
                                },
                            },
                        });

                        // AFAD Turkey
                        var lSalonAfad = new SalonEntity { Name = "AFAD", Website = "http://contest.afad.org.tr", Country = lCountryTurkey };
                        lContext.Salons.Add(lSalonAfad);


                        var lSalonYearAfad = new SalonYearEntity { Name = "AFAD", Salon = lSalonAfad, Year = 2017, ClosingDate = new DateTime(2017, 12, 10), JudgeDate = new DateTime(2017, 12, 17), NotificationDate = new DateTime(2017, 12, 29), CataloguesPostedDate = new DateTime(2018, 2, 28) };
                        lContext.SalonYears.Add(lSalonYearAfad);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/549", PhotoOrganisation = lFiap, SalonYear = lSalonYearAfad },
});

                        var lSalonYearAfadNature = new SectionEntity() { SalonYear = lSalonYearAfad, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearAfadColour = new SectionEntity() { SalonYear = lSalonYearAfad, SectionType = lSectionTypeColourPdi };
                        var lSalonYearAfadMono = new SectionEntity() { SalonYear = lSalonYearAfad, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearAfadTravel = new SectionEntity() { SalonYear = lSalonYearAfad, SectionType = lSectionTypeTravelPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearAfadNature,
                            lSalonYearAfadColour,
                            lSalonYearAfadMono,
                            lSalonYearAfadTravel,
                        });

                        var lBirdsSilhouette = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Birds Silhouette" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lBirdsSilhouette,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 13.75M,
                                SalonYear = lSalonYearAfad,
                                EntryDate = new DateTime(2017,12, 9),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearAfadNature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = true, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearAfadNature, Image = lLittleOwl, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadColour, Image = lFlowersInCircle, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearAfadColour, Image = lBoltonAbbeySunbeam, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadColour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadColour, Image = lLoneTree, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadMono, Image = lTheTower, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadMono, Image = lBirdsSilhouette, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadTravel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score= 16},
                                    new CompetitionEntryEntity { Section = lSalonYearAfadTravel, Image = lIcelandicRefuge, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfadTravel, Image = lMdinaMalta, IsAwarded = false, IsAccepted = false, Score=16 },
                                 },
                            },
                        });

                        // Photo Dream Serbia
                        var lSalonPhotoDream = new SalonEntity { Name = "Photo Dream", Website = "http://www.pca-exhibition.com/photodream", Country = lCountrySerbia };
                        lContext.Salons.Add(lSalonPhotoDream);


                        var lSalonYearPhotoDream = new SalonYearEntity { Name = "Photo Dream", Salon = lSalonPhotoDream, Year = 2017, ClosingDate = new DateTime(2017, 12, 10), JudgeDate = new DateTime(2017, 12, 31), NotificationDate = new DateTime(2017, 1, 13), CataloguesPostedDate = new DateTime(2018, 1, 23) };
                        lContext.SalonYears.Add(lSalonYearPhotoDream);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2017/462", PhotoOrganisation = lFiap, SalonYear = lSalonYearPhotoDream },
                            new AccreditationEntity() { SalonNumber = "2017-383", PhotoOrganisation = lPsa, SalonYear = lSalonYearPhotoDream },
                        });

                        var lSalonYearPhotoDreamTravel = new SectionEntity() { SalonYear = lSalonYearPhotoDream, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearPhotoDreamNature = new SectionEntity() { SalonYear = lSalonYearPhotoDream, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearPhotoDreamColour = new SectionEntity() { SalonYear = lSalonYearPhotoDream, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoDreamMono = new SectionEntity() { SalonYear = lSalonYearPhotoDream, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPhotoDreamPhotojournalism = new SectionEntity() { SalonYear = lSalonYearPhotoDream, SectionType = lSectionTypePhotojournalismPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearPhotoDreamTravel,
                            lSalonYearPhotoDreamNature,
                            lSalonYearPhotoDreamColour,
                            lSalonYearPhotoDreamMono,
                            lSalonYearPhotoDreamPhotojournalism,
                        });

                        var lInMemorium = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "In Memorium" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lInMemorium,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 18.33M,
                                SalonYear = lSalonYearPhotoDream,
                                EntryDate = new DateTime(2017,12, 10),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamTravel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamTravel, Image = lIcelandicRefuge, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamTravel, Image = lMdinaMalta, IsAwarded = false, IsAccepted = true, Score=23 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamNature, Image = lLittleOwl, IsAwarded = false, IsAccepted = true, Score= 25},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score=24 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = true, Score=26 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamNature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamColour, Image = lFlowersInCircle, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamColour, Image = lInMemorium, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamColour, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = false, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamColour, Image = lGrassesTriptych, IsAwarded = true, AwardDetails="PCA Honourable Mention", IsAccepted = true, Score=26 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score= 24},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score=24 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamMono, Image = lTheTower, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamMono, Image = lBirdsSilhouette, IsAwarded = false, IsAccepted = true, Score=24 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamPhotojournalism, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = false, Score=24 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamPhotojournalism, Image = lTerrierRacing, IsAwarded = false, IsAccepted = false, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamPhotojournalism, Image = lZombieAttack, IsAwarded = false, IsAccepted = true, Score=27 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoDreamPhotojournalism, Image = lTheresSomethingBehindYou, IsAwarded = false, IsAccepted = true, Score=25 },
                                },
                            },
                        });                        

                        // Boka Bay Montengro
                        var lSalonBokaBay = new SalonEntity { Name = "Boka Bay", Website = "http://www.gradacfoto.com", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonBokaBay);


                        var lSalonYearBokaBay = new SalonYearEntity { Name = "Boka Bay", Salon = lSalonBokaBay, Year = 2018, ClosingDate = new DateTime(2018, 1, 14), JudgeDate = new DateTime(2018, 1, 29), NotificationDate = new DateTime(2018, 2, 1), CataloguesPostedDate = new DateTime(2018, 4, 13) };
                        lContext.SalonYears.Add(lSalonYearBokaBay);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018/051", PhotoOrganisation = lFiap, SalonYear = lSalonYearBokaBay },
                            new AccreditationEntity() { SalonNumber = "2018-046", PhotoOrganisation = lPsa, SalonYear = lSalonYearBokaBay },
                        });

                        var lSalonYearBokaBayColour = new SectionEntity() { SalonYear = lSalonYearBokaBay, SectionType = lSectionTypeColourPdi };
                        var lSalonYearBokaBayMono = new SectionEntity() { SalonYear = lSalonYearBokaBay, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearBokaBayNature = new SectionEntity() { SalonYear = lSalonYearBokaBay, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearBokaBayTravel = new SectionEntity() { SalonYear = lSalonYearBokaBay, SectionType = lSectionTypeTravelPdi };
                      

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearBokaBayColour,
                            lSalonYearBokaBayMono,
                            lSalonYearBokaBayNature,
                            lSalonYearBokaBayTravel,
});

                        var lStarOfWonder = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Star of Wonder" };
                        var lDiagonalTulip = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Diagonal Tulip" };
                        var lThreeTulipCircle = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Three Tulip Circle" };
                        var lWinterTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Winter Tree" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lStarOfWonder,
                            lDiagonalTulip,
                            lThreeTulipCircle,
                            lWinterTree,
                         });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 18.49M,
                                SalonYear = lSalonYearBokaBay,
                                EntryDate = new DateTime(2018, 1, 6),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayColour, Image = lStarOfWonder, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayColour, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayColour, Image = lDiagonalTulip, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayColour, Image = lThreeTulipCircle, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayMono, Image = lBirdsSilhouette, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayMono, Image = lWinterTree, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayMono, Image = lTheTower, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayNature, Image = lLittleOwl, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayNature, Image = lGreatGreyOwl, IsAwarded = true, AwardDetails = "PC Perasto Honorable Mention", IsAccepted = true, Score=24 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayNature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayTravel, Image = lIcelandicRefuge, IsAwarded = false, IsAccepted = true, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayTravel, Image = lMdinaMalta, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayTravel, Image = lAfternoonGun, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBokaBayTravel, Image = lHarbourSailingInMalta, IsAwarded = false, IsAccepted = false, Score=18 },
                                },
                            },
                        });

                        // Evesham BPE
                        var lSalonEveshamBpe = new SalonEntity { Name = "Evesham", Website = "http://www.photo2018.net", Country = lCountryEngland };
                        lContext.Salons.Add(lSalonEveshamBpe);


                        var lSalonYearEveshamBpe = new SalonYearEntity { Name = "Evesham", Salon = lSalonEveshamBpe, Year = 2018, ClosingDate = new DateTime(2018, 2, 28), JudgeDate = new DateTime(2018, 3, 11), NotificationDate = new DateTime(2018, 4, 12), CataloguesPostedDate = new DateTime(2018, 4, 12) };
                        lContext.SalonYears.Add(lSalonYearEveshamBpe);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018 BPE", PhotoOrganisation = lBpe, SalonYear = lSalonYearEveshamBpe },
                        });

                        var lSalonYearEveshamColour = new SectionEntity() { SalonYear = lSalonYearEveshamBpe, SectionType = lSectionTypeColourPdi };
                        var lSalonYearEveshamMono = new SectionEntity() { SalonYear = lSalonYearEveshamBpe, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearEveshamCreative = new SectionEntity() { SalonYear = lSalonYearEveshamBpe, SectionType = lSectionTypeCreativePdi };
          


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearEveshamColour,
                            lSalonYearEveshamMono,
                            lSalonYearEveshamCreative,
                        });

                        var lWoodlandMage = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Woodland Mage" };
                        var lBlueSymmetree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Blue Symmetree" };
                        var lThreeTulips = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Three Tulips" };


                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lWoodlandMage,
                            lBlueSymmetree,
                            lThreeTulips,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 18.00M,
                                SalonYear = lSalonYearEveshamBpe,
                                EntryDate = new DateTime(2018, 1, 14),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamColour, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamColour, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamColour, Image = lThreeTulips, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamColour, Image = lWraith, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamMono, Image = lBirdsSilhouette, IsAwarded = false, IsAccepted = false, Score= 8},
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamMono, Image = lWinterTree, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamCreative, Image = lWoodlandMage, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamCreative, Image = lBlueSymmetree, IsAwarded = false, IsAccepted = true, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamCreative, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearEveshamCreative, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score=12 },
                                  },
                            },
                        });

                        // Bristol
                        var lSalonYearBristol2018 = new SalonYearEntity { Name = "Bristol", Salon = lSalonBristol, Year = 2018, ClosingDate = new DateTime(2018, 1, 27), JudgeDate = new DateTime(2018, 2, 18), NotificationDate = new DateTime(2018, 2, 26), CataloguesPostedDate = new DateTime(2018, 5, 6) };
                        lContext.SalonYears.Add(lSalonYearBristol2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018/023", PhotoOrganisation = lFiap, SalonYear = lSalonYearBristol2018 },
                            new AccreditationEntity() { SalonNumber = "2018-023", PhotoOrganisation = lPsa, SalonYear = lSalonYearBristol2018 },
                            new AccreditationEntity() { SalonNumber = "GPU L180010", PhotoOrganisation = lGpu, SalonYear = lSalonYearBristol2018 },
                        });

                        var lSalonYearBristol2018Colour = new SectionEntity() { SalonYear = lSalonYearBristol2018, SectionType = lSectionTypeColourPdi };
                        var lSalonYearBristol2018Mono = new SectionEntity() { SalonYear = lSalonYearBristol2018, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearBristol2018Nature = new SectionEntity() { SalonYear = lSalonYearBristol2018, SectionType = lSectionTypeNaturePdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearBristol2018Colour,
                            lSalonYearBristol2018Mono,
                            lSalonYearBristol2018Nature,
                        });

                        var lSymmetreeBlue = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Blue Symmetree Blue" };


                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lSymmetreeBlue,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 17.00M,
                                SalonYear = lSalonYearBristol2018,
                                EntryDate = new DateTime(2018, 1, 21),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Colour, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Colour, Image = lThreeTulipCircle, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Colour, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Colour, Image = lSymmetreeBlue, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Mono, Image = lBirdsSilhouette, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Mono, Image = lWinterTree, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Mono, Image = lTheTower, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Nature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Nature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearBristol2018Nature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=9 },
                                  },
                            },
                        });


                        // Trofeu Torretes Spain, Ppq123
                        var lSalonSpain = new SalonEntity { Name = "Trofeu Torretes", Website = "https://www.festimatge.org/fotografia_torretes_EN.html", Country = lCountrySpain };
                        lContext.Salons.Add(lSalonSpain);

                        var lSalonYearSpain2018 = new SalonYearEntity { Name = "Trofeu Torretes", Salon = lSalonSpain, Year = 2018, ClosingDate = new DateTime(2018, 2, 15), JudgeDate = new DateTime(2018, 3, 4), NotificationDate = new DateTime(2018, 3, 17), CataloguesPostedDate = new DateTime(2018, 5, 19) };
                        lContext.SalonYears.Add(lSalonYearSpain2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018/049", PhotoOrganisation = lFiap, SalonYear = lSalonYearSpain2018 },
                            new AccreditationEntity() { SalonNumber = "2018-059", PhotoOrganisation = lPsa, SalonYear = lSalonYearSpain2018 },
                            new AccreditationEntity() { SalonNumber = "GPU L180014", PhotoOrganisation = lGpu, SalonYear = lSalonYearSpain2018 },
                        });

                        var lSalonYearSpain2018Colour = new SectionEntity() { SalonYear = lSalonYearSpain2018, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSpain2018Mono = new SectionEntity() { SalonYear = lSalonYearSpain2018, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSpain2018Creative = new SectionEntity() { SalonYear = lSalonYearSpain2018, SectionType = lSectionTypeCreativePdi };
                        var lSalonYearSpain2018TheSea = new SectionEntity() { SalonYear = lSalonYearSpain2018, SectionType = lSectionTypeScapesPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearSpain2018Colour,
                            lSalonYearSpain2018Mono,
                            lSalonYearSpain2018Creative,
                            lSalonYearSpain2018TheSea,
                        });

                        var lIceBeachTrio = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Ice Beach Trio" };
                        var lIceBeachSwirls = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Ice Beach Swirls" };
                        var lIceBeachWaves = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Ice Beach Waves" };


                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lIceBeachTrio,
                            lIceBeachSwirls,
                            lIceBeachWaves,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 13.68M,
                                SalonYear = lSalonYearSpain2018,
                                EntryDate = new DateTime(2018, 1, 26),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Colour, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=533 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Colour, Image = lAfternoonGun, IsAwarded = false, IsAccepted = false, Score= 533},
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Colour, Image = lMdinaMalta, IsAwarded = false, IsAccepted = false, Score=533 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Colour, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=633 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Mono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score= 467},
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true, Score=667 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Mono, Image = lWinterTree, IsAwarded = false, IsAccepted = false, Score=533 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score=633 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Creative, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=700 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Creative, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score=700 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Creative, Image = lLoneTree, IsAwarded = false, IsAccepted = false, Score=600 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018Creative, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = false, Score=567 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018TheSea, Image = lTwelveApostlesSunset, IsAwarded = false, IsAccepted = false, Score=533 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018TheSea, Image = lIceBeachTrio, IsAwarded = false, IsAccepted = false, Score=600 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018TheSea, Image = lIceBeachSwirls, IsAwarded = false, IsAccepted = false, Score=467 },
                                    new CompetitionEntryEntity { Section = lSalonYearSpain2018TheSea, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=567 },
                                  },
                            },
                        });

                        // Clay Cross Bpe
                        var lSalonClayCross = new SalonEntity { Name = "Clay Cross", Website = "http://www.claycrossps.org/section849383.html", Country = lCountryEngland };
                        lContext.Salons.Add(lSalonClayCross);

                        var lSalonYearClayCross2018 = new SalonYearEntity { Name = "Clay Cross", Salon = lSalonClayCross, Year = 2018, ClosingDate = new DateTime(2018, 1, 31), JudgeDate = new DateTime(2018, 2, 18), NotificationDate = new DateTime(2018, 3, 23), CataloguesPostedDate = new DateTime(2018, 4, 16) };
                        lContext.SalonYears.Add(lSalonYearClayCross2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018 BPE", PhotoOrganisation = lBpe, SalonYear = lSalonYearClayCross2018 },

                        });

                        var lSalonYearClayCrossNature = new SectionEntity() { SalonYear = lSalonYearClayCross2018, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearClayCrossMono = new SectionEntity() { SalonYear = lSalonYearClayCross2018, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearClayCrossCreative = new SectionEntity() { SalonYear = lSalonYearClayCross2018, SectionType = lSectionTypeCreativePdi };
                        var lSalonYearClayCrossScapes = new SectionEntity() { SalonYear = lSalonYearClayCross2018, SectionType = lSectionTypeScapesPdi };
                        var lSalonYearClayCrossColour = new SectionEntity() { SalonYear = lSalonYearClayCross2018, SectionType = lSectionTypeColourPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearClayCrossNature,
                            lSalonYearClayCrossMono,
                            lSalonYearClayCrossCreative,
                            lSalonYearClayCrossScapes,
                            lSalonYearClayCrossColour,
                        });

                        var lPyramidEclipse = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Pyramid Eclipse" };
                        var lSymmetreeFire = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Symmetree Fire" };
                        var lZombiePriest = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zombie Priest" };
                        var lRefuge = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Icelandic Refuge (Like Sharon's)" };


                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lPyramidEclipse,
                            lSymmetreeFire,
                            lZombiePriest,
                            lRefuge,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 22.50M,
                                SalonYear = lSalonYearClayCross2018,
                                EntryDate = new DateTime(2018, 1, 29),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossCreative, Image = lLakeGuardian, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossCreative, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossCreative, Image = lPyramidEclipse, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossCreative, Image = lSymmetreeFire, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossScapes, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossScapes, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossScapes, Image = lRefuge, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossScapes, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossColour, Image = lDaisy, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossColour, Image = lThreeTulipCircle, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossColour, Image = lSunflower, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearClayCrossColour, Image = lZombiePriest, IsAwarded = false, IsAccepted = false, Score=9 },
                                  },
                            },
                        });

                        // Victory 2018
                        var lSalonYearVictory2018 = new SalonYearEntity { Name = "Victory Photo Club", Salon = lSalonVictoryPhotoClub, Year = 2018, ClosingDate = new DateTime(2018, 2, 11), JudgeDate = new DateTime(2018, 2, 27), NotificationDate = new DateTime(2018, 3, 2), CataloguesPostedDate = new DateTime(2018, 5, 11) };
                        lContext.SalonYears.Add(lSalonYearVictory2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018/080", PhotoOrganisation = lFiap, SalonYear = lSalonYearVictory2018 },
                            new AccreditationEntity() { SalonNumber = "2018-061", PhotoOrganisation = lPsa, SalonYear = lSalonYearVictory2018 },
                        });

                        var lSalonYearVictory2018Colour = new SectionEntity() { SalonYear = lSalonYearVictory2018, SectionType = lSectionTypeColourPdi };
                        var lSalonYearVictory2018Mono = new SectionEntity() { SalonYear = lSalonYearVictory2018, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearVictory2018Nature = new SectionEntity() { SalonYear = lSalonYearVictory2018, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearVictory2018ManWomanChild = new SectionEntity() { SalonYear = lSalonYearVictory2018, SectionType = lSectionTypeManWomanChildPdi };
                        var lSalonYearVictory2018Travel = new SectionEntity() { SalonYear = lSalonYearVictory2018, SectionType = lSectionTypeTravelPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearVictory2018Colour,
                            lSalonYearVictory2018Mono,
                            lSalonYearVictory2018Nature,
                            lSalonYearVictory2018ManWomanChild,
                            lSalonYearVictory2018Travel,
                        });

                        var lSnowdrop = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Snowdrop" };
   

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lSnowdrop,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 17.46M,
                                SalonYear = lSalonYearVictory2018,
                                EntryDate = new DateTime(2018, 2, 5),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Colour, Image = lSymmetreeFire, IsAwarded = false, IsAccepted = true, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Colour, Image = lPyramidEclipse, IsAwarded = false, IsAccepted = false, Score= 16},
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Colour, Image = lDarkHorizons, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Colour, Image = lThreeTulips, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score= 15},
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Mono, Image = lWinterTree, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Mono, Image = lBirdsSilhouette, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Mono, Image = lSnowdrop, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Nature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Nature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Nature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Nature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018ManWomanChild, Image = lWraith, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018ManWomanChild, Image = lThePriest, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018ManWomanChild, Image = lZombieGirl, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018ManWomanChild, Image = lTheresSomethingBehindYou, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Travel, Image = lTwelveApostlesSunset, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Travel, Image = lMdinaMalta, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearVictory2018Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=16 },
                                  },
                            },
                        });

                        // South Birmingham Bpe
                        var lSalonSouthBirmingham = new SalonEntity { Name = "South Birmingham", Website = "http://southbirminghamphotographicsociety.co.uk/exhibition", Country = lCountryEngland };
                        lContext.Salons.Add(lSalonSouthBirmingham);

                        var lSalonYearSouthBirmingham2018 = new SalonYearEntity { Name = "South Birmingham", Salon = lSalonSouthBirmingham, Year = 2018, ClosingDate = new DateTime(2018, 2, 25), JudgeDate = new DateTime(2018, 3, 11), NotificationDate = new DateTime(2018, 3, 25), CataloguesPostedDate = new DateTime(2018, 5, 12) };
                        lContext.SalonYears.Add(lSalonYearSouthBirmingham2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018 BPE", PhotoOrganisation = lBpe, SalonYear = lSalonYearSouthBirmingham2018 },

                        });

                        var lSalonYearSouthBirminghamColour = new SectionEntity() { SalonYear = lSalonYearSouthBirmingham2018, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSouthBirminghamMono = new SectionEntity() { SalonYear = lSalonYearSouthBirmingham2018, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSouthBirminghamPortrait = new SectionEntity() { SalonYear = lSalonYearSouthBirmingham2018, SectionType = lSectionTypePortraitPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearSouthBirminghamColour,
                            lSalonYearSouthBirminghamMono,
                            lSalonYearSouthBirminghamPortrait,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 15M,
                                SalonYear = lSalonYearSouthBirmingham2018,
                                EntryDate = new DateTime(2018, 2, 17),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamColour, Image = lSymmetreeFire, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamColour, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamColour, Image = lPyramidEclipse, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamColour, Image = lLakeGuardian, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamMono, Image = lWinterTree, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamPortrait, Image = lZombieGirl, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthBirminghamPortrait, Image = lThePriest, IsAwarded = false, IsAccepted = false, Score=10 },
                                    },
                            },
                        });

                        // Rushden Bpe
                        var lSalonRushden = new SalonEntity { Name = "Rushden", Website = "http://www.rdps.co.uk/open/", Country = lCountryEngland };
                        lContext.Salons.Add(lSalonRushden);

                        var lSalonYearRushden2018 = new SalonYearEntity { Name = "Rushden", Salon = lSalonRushden, Year = 2018, ClosingDate = new DateTime(2018, 4, 8), JudgeDate = new DateTime(2018, 4, 22), NotificationDate = new DateTime(2018, 4, 30), CataloguesPostedDate = new DateTime(2018, 5, 13) };
                        lContext.SalonYears.Add(lSalonYearRushden2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018 BPE", PhotoOrganisation = lBpe, SalonYear = lSalonYearRushden2018 },

                        });

                        var lSalonYearRushdenColour = new SectionEntity() { SalonYear = lSalonYearRushden2018, SectionType = lSectionTypeColourPdi };
                        var lSalonYearRushdenMono = new SectionEntity() { SalonYear = lSalonYearRushden2018, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearRushdenNature = new SectionEntity() { SalonYear = lSalonYearRushden2018, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearRushdenCreative = new SectionEntity() { SalonYear = lSalonYearRushden2018, SectionType = lSectionTypeCreativePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearRushdenColour,
                            lSalonYearRushdenMono,
                            lSalonYearRushdenNature,
                            lSalonYearRushdenCreative,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 16M,
                                SalonYear = lSalonYearRushden2018,
                                EntryDate = new DateTime(2018, 3, 30),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenColour, Image = lIcelandicRefuge, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenColour, Image = lDaisy, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = true, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenMono, Image = lSnowdrop, IsAwarded = false, IsAccepted = false, Score=9},
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenNature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenNature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenNature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenNature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenCreative, Image = lGrassesTriptych, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenCreative, Image = lLakeGuardian, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenCreative, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearRushdenCreative, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = false, Score=8 },

                                    },
                            },
                        });

                        // Sydney Harbour
                        var lSalonYearSydney2018 = new SalonYearEntity { Name = "Sydney Harbour", Salon = lSalonSydney, Year = 2018, ClosingDate = new DateTime(2018, 4, 15), JudgeDate = new DateTime(2018, 4, 29), NotificationDate = new DateTime(2018, 5, 7), CataloguesPostedDate = new DateTime(2018, 6, 29) };
                        lContext.SalonYears.Add(lSalonYearSydney2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018/115", PhotoOrganisation = lFiap, SalonYear = lSalonYearSydney2018 },
                            new AccreditationEntity() { SalonNumber = "2018-144", PhotoOrganisation = lPsa, SalonYear = lSalonYearSydney2018 },
                            new AccreditationEntity() { SalonNumber = "GPU L180026", PhotoOrganisation = lGpu, SalonYear = lSalonYearSydney2018 },

                        });

                        var lSalonYearSydney2018Mono = new SectionEntity() { SalonYear = lSalonYearSydney2018, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSydney2018Colour = new SectionEntity() { SalonYear = lSalonYearSydney2018, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSydney2018Creative = new SectionEntity() { SalonYear = lSalonYearSydney2018, SectionType = lSectionTypeCreativePdi };
                        var lSalonYearSydney2018Nature = new SectionEntity() { SalonYear = lSalonYearSydney2018, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearSydney2018Wildlife = new SectionEntity() { SalonYear = lSalonYearSydney2018, SectionType = lSectionTypeWildlifePdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearSydney2018Mono,
                            lSalonYearSydney2018Colour,
                            lSalonYearSydney2018Creative,
                            lSalonYearSydney2018Nature,
                            lSalonYearSydney2018Wildlife,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 20.57M,
                                SalonYear = lSalonYearSydney2018,
                                EntryDate = new DateTime(2018, 3, 30),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Mono, Image = lButtermereTree, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Mono, Image = lSnowdrop, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Mono, Image = lBirdsSilhouette, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Mono, Image = lWinterTree, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Colour, Image = lIntoTheMist, IsAwarded = false, IsAccepted = true, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Colour, Image = lDaisy, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Colour, Image = lTheWatcher, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Colour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score=10},
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Creative, Image = lLoneTree, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Creative, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Creative, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Creative, Image = lBlueSymmetree, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Nature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Nature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=3 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Nature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Wildlife, Image = lCanadaGosling, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Wildlife, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Wildlife, Image = lHedgehog, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSydney2018Wildlife, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=11 },

                                    },
                            },
                        });

                        // Scottish Salon 2018
                        var lSalonYearScottish2018 = new SalonYearEntity { Name = "Scottish", Salon = lSalonScottish, Year = 2018, ClosingDate = new DateTime(2018, 4, 15), JudgeDate = new DateTime(2018, 4, 29), NotificationDate = new DateTime(2018, 5, 4), CataloguesPostedDate = new DateTime(2018, 7, 15) };
                        lContext.SalonYears.Add(lSalonYearScottish2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018/141", PhotoOrganisation = lFiap, SalonYear = lSalonYearScottish2018 },
                            new AccreditationEntity() { SalonNumber = "2018-133", PhotoOrganisation = lPsa, SalonYear = lSalonYearScottish2018 },
                        });

                        var lTulipInTheRound = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tulip in the Round" };
                        var lPointedReflection = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Pointed Reflection" };
                        var lTerracedOliveGrove = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Terraced Olive Grove" };
 
                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lTulipInTheRound,
                            lPointedReflection,
                            lTerracedOliveGrove,
                        });


                        var lSalonYearScottish2018MonoPrint = new SectionEntity() { SalonYear = lSalonYearScottish2018, SectionType = lSectionTypeMonoPrint };
                        var lSalonYearScottish2018NaturePDI = new SectionEntity() { SalonYear = lSalonYearScottish2018, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearScottish2018ColourPrint = new SectionEntity() { SalonYear = lSalonYearScottish2018, SectionType = lSectionTypeColourPrint };
                        var lSalonYearScottish2018ColourPDI = new SectionEntity() { SalonYear = lSalonYearScottish2018, SectionType = lSectionTypeColourPdi };
                        var lSalonYearScottish201MonoPDI = new SectionEntity() { SalonYear = lSalonYearScottish2018, SectionType = lSectionTypeMonoPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearScottish2018MonoPrint,
                            lSalonYearScottish2018NaturePDI,
                            lSalonYearScottish2018ColourPrint,
                            lSalonYearScottish2018ColourPDI,
                            lSalonYearScottish201MonoPDI,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 23.20M,
                                SalonYear = lSalonYearScottish2018,
                                EntryDate = new DateTime(2018, 4, 9),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018MonoPrint, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018MonoPrint, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = true, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018MonoPrint, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018MonoPrint, Image = lSnowdrop, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018NaturePDI, Image = lLittleOwl, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018NaturePDI, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018NaturePDI, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018NaturePDI, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=9},
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018ColourPrint, Image = lTulipInTheRound, IsAwarded = false, IsAccepted = true, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018ColourPrint, Image = lTheWatcher, IsAwarded = false, IsAccepted = true, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018ColourPrint, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018ColourPrint, Image = lBlueSymmetree, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018ColourPDI, Image = lLoneTree, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018ColourPDI, Image = lTheWatcherInTheWaves, IsAwarded = false, IsAccepted = true, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018ColourPDI, Image = lAcrossTheLake, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish2018ColourPDI, Image = lPyramidEclipse, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish201MonoPDI, Image = lWinterTree, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish201MonoPDI, Image = lBirdsSilhouette, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish201MonoPDI, Image = lPointedReflection, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearScottish201MonoPDI, Image = lTerracedOliveGrove, IsAwarded = false, IsAccepted = false, Score=9 },

                                    },
                            },
                        });

                        // Edinburgh Salon 2018
                        var lSalonEdinburgh = new SalonEntity { Name = "Edinburgh", Website = "https://www.edinburghphotosalon.org/", Country = lCountryScotland };
                        lContext.Salons.Add(lSalonEdinburgh);


                        var lSalonYearEdinburgh2018 = new SalonYearEntity { Name = "Edinburgh", Salon = lSalonEdinburgh, Year = 2018, ClosingDate = new DateTime(2018, 6, 20), JudgeDate = new DateTime(2018, 6, 30), NotificationDate = new DateTime(2018, 7, 6), CataloguesPostedDate = new DateTime(2018, 9, 8) };
                        lContext.SalonYears.Add(lSalonYearEdinburgh2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018/118", PhotoOrganisation = lFiap, SalonYear = lSalonYearEdinburgh2018 },
                        });

               
                        var lSalonYearEdinburgh2018MonoPrint = new SectionEntity() { SalonYear = lSalonYearEdinburgh2018, SectionType = lSectionTypeMonoPrint };
                        var lSalonYearEdinburgh2018ColourPrint = new SectionEntity() { SalonYear = lSalonYearEdinburgh2018, SectionType = lSectionTypeColourPrint };
                     
                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearEdinburgh2018MonoPrint,
                            lSalonYearEdinburgh2018ColourPrint,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12M,
                                SalonYear = lSalonYearEdinburgh2018,
                                EntryDate = new DateTime(2018, 4, 9),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearEdinburgh2018MonoPrint, Image = lOliversCastle, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearEdinburgh2018MonoPrint, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score= null},
                                    new CompetitionEntryEntity { Section = lSalonYearEdinburgh2018MonoPrint, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearEdinburgh2018MonoPrint, Image = lSnowdrop, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearEdinburgh2018ColourPrint, Image = lTulipInTheRound, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearEdinburgh2018ColourPrint, Image = lTheWatcher, IsAwarded = false, IsAccepted = true, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearEdinburgh2018ColourPrint, Image = lDarkHorizons, IsAwarded = false, IsAccepted = false, Score=null },
                                    new CompetitionEntryEntity { Section = lSalonYearEdinburgh2018ColourPrint, Image = lBlueSymmetree, IsAwarded = false, IsAccepted = false, Score=null },
               
                                    },
                            },
                        });

                        // Manhattan 2018
                        var lSalonManhattan = new SalonEntity { Name = "Manhattan", Website = "http://www.nycexhibition.com/manhattan/", Country = lCountryUsa };
                        lContext.Salons.Add(lSalonManhattan);

                        var lSalonYearManhattan2018 = new SalonYearEntity { Name = "Manhattan", Salon = lSalonManhattan, Year = 2018, ClosingDate = new DateTime(2018, 4, 15), JudgeDate = new DateTime(2018, 4, 25), NotificationDate = new DateTime(2018, 5, 10), CataloguesPostedDate = new DateTime(2018, 5, 10) };
                        lContext.SalonYears.Add(lSalonYearManhattan2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018/164", PhotoOrganisation = lFiap, SalonYear = lSalonYearManhattan2018 },
                            new AccreditationEntity() { SalonNumber = "2018-009", PhotoOrganisation = lPsa, SalonYear = lSalonYearManhattan2018 },
                        });

                        var lTheQuestion = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Question" };
                        var lMetalGearRising = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Metal Gear Rising" };
                        var lRainbowMosaic = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Rainbow Mosaic" };
                        var lFeedMe = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Feed Me" };
                        var lThreeBridges = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Three Bridges" };
                        var lStreetArt = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Street Art" };
                        var lLeedsTownHall = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Leeds Town Hall" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lTheQuestion,
                            lMetalGearRising,
                            lRainbowMosaic,
                            lFeedMe,
                            lThreeBridges,
                            lStreetArt,
                            lLeedsTownHall,
                        });


                        var lSalonYearManhattan2018MMyPlace = new SectionEntity() { SalonYear = lSalonYearManhattan2018, SectionType = lSectionTypeMyPlacePdi };
                        var lSalonYearManhattan2018Street = new SectionEntity() { SalonYear = lSalonYearManhattan2018, SectionType = lSectionTypeStreetPdi };
                        var lSalonYearManhattan2018Photojournalism = new SectionEntity() { SalonYear = lSalonYearManhattan2018, SectionType = lSectionTypePhotojournalismPdi };
                        var lSalonYearManhattan2018Nature = new SectionEntity() { SalonYear = lSalonYearManhattan2018, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearManhattan201OpenColour = new SectionEntity() { SalonYear = lSalonYearManhattan2018, SectionType = lSectionTypeColourPdi };
                        var lSalonYearManhattan201OpenMono = new SectionEntity() { SalonYear = lSalonYearManhattan2018, SectionType = lSectionTypeMonoPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearManhattan2018MMyPlace,
                            lSalonYearManhattan2018Street,
                            lSalonYearManhattan2018Photojournalism,
                            lSalonYearManhattan2018Nature,
                            lSalonYearManhattan201OpenColour,
                            lSalonYearManhattan201OpenMono,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 14.50M,
                                SalonYear = lSalonYearManhattan2018,
                                EntryDate = new DateTime(2018, 4, 14),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018MMyPlace, Image = lPointedReflection, IsAwarded = false, IsAccepted = true, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018MMyPlace, Image = lTheQuestion, IsAwarded = false, IsAccepted = true, Score= 16},
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018MMyPlace, Image = lMetalGearRising, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018MMyPlace, Image = lRainbowMosaic, IsAwarded = false, IsAccepted = true, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Street, Image = lFeedMe, IsAwarded = false, IsAccepted = false, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Street, Image = lThreeBridges, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Street, Image = lStreetArt, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Street, Image = lLeedsTownHall, IsAwarded = false, IsAccepted = false, Score=11},
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Photojournalism, Image = lTerrierRacing, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Photojournalism, Image = lTheresSomethingBehindYou, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Photojournalism, Image = lFloodingInLeeds, IsAwarded = false, IsAccepted = true, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Photojournalism, Image = lZombieAttack, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Nature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Nature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = true, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Nature, Image = lLittleOwl, IsAwarded = false, IsAccepted = true, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan2018Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = true, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan201OpenColour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan201OpenColour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = true, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan201OpenColour, Image = lTheWatcher, IsAwarded = false, IsAccepted = true, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan201OpenColour, Image = lTulipInTheRound, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan201OpenMono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan201OpenMono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan201OpenMono, Image = lOliversCastle, IsAwarded = false, IsAccepted = true, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearManhattan201OpenMono, Image = lSnowdrop, IsAwarded = false, IsAccepted = true, Score=19 },

                                    },
                            },
                        });

                        // Gradac 2018 - http://perasto.club
                        var lSalonYearGradac2018 = new SalonYearEntity { Name = "Gradac", Salon = lSalonGradac, Year = 2018, ClosingDate = new DateTime(2018, 4, 15), JudgeDate = new DateTime(2018, 5, 1), NotificationDate = new DateTime(2018, 5, 4), CataloguesPostedDate = new DateTime(2018, 5, 4) };
                        lContext.SalonYears.Add(lSalonYearGradac2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2018/179", PhotoOrganisation = lFiap, SalonYear = lSalonYearGradac2018 },
                            new AccreditationEntity() { SalonNumber = "2018-152", PhotoOrganisation = lPsa, SalonYear = lSalonYearGradac2018 },
                        });

                        var lAlhambraAtDusk = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Alhambra at Dusk" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lAlhambraAtDusk,
                        });

                        var lSalonYearGradac2018Mono = new SectionEntity() { SalonYear = lSalonYearGradac2018, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearGradac2018ManWomanChild = new SectionEntity() { SalonYear = lSalonYearGradac2018, SectionType = lSectionTypeManWomanChildPdi };
                        var lSalonYearGradac2018Nature = new SectionEntity() { SalonYear = lSalonYearGradac2018, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearGradac2018Colour = new SectionEntity() { SalonYear = lSalonYearGradac2018, SectionType = lSectionTypeColourPdi };
                        var lSalonYearGradac2018Travel = new SectionEntity() { SalonYear = lSalonYearGradac2018, SectionType = lSectionTypeTravelPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearGradac2018Mono,
                            lSalonYearGradac2018ManWomanChild,
                            lSalonYearGradac2018Nature,
                            lSalonYearGradac2018Colour,
                            lSalonYearGradac2018Travel,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 17.09M,
                                SalonYear = lSalonYearGradac2018,
                                EntryDate = new DateTime(2018, 4, 14),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Mono, Image = lBirdsSilhouette, IsAwarded = false, IsAccepted = true, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Mono, Image = lWinterTree, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Mono, Image = lSnowdrop, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018ManWomanChild, Image = lWraith, IsAwarded = false, IsAccepted = true, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018ManWomanChild, Image = lZombieAttack, IsAwarded = false, IsAccepted = true, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018ManWomanChild, Image = lThePriest, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018ManWomanChild, Image = lTheresSomethingBehindYou, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Nature, Image = lWaterVole, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Nature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Nature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Nature, Image = lRimlitKingfisher, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Colour, Image = lThroughTheArch, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Colour, Image = lTreeGroveInTheMist, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Colour, Image = lTulipInTheRound, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Colour, Image = lTheWatcher, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Travel, Image = lMdinaMalta, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearGradac2018Travel, Image = lAlhambraAtDusk, IsAwarded = false, IsAccepted = false, Score=17 },

                                    },
                            },
                        });

						// SRGB 2018 
						var lSalonYearSrgb2018 = new SalonYearEntity { Name = "SRGB", Salon = lSalonSrgb, Year = 2018, ClosingDate = new DateTime(2018, 7, 15), JudgeDate = new DateTime(2018, 7, 21), NotificationDate = new DateTime(2018, 9, 1), CataloguesPostedDate = new DateTime(2018, 9, 1) };
						lContext.SalonYears.Add(lSalonYearSrgb2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "BPE 2018", PhotoOrganisation = lBpe, SalonYear = lSalonYearSrgb2018 },
                        });

						var lRemembrance = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Remembrance" };
						var lRedEyedGreenTreeFrog = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Red Eyed Green Tree Frog" };
						var lPantherChameleonLunch = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Panther Chameleon Lunch" };
						var lArgentinianHornedFrog = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Argentinian Horned Frog" };
						var lGargoyleGecko = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Gargoyle Gecko" };
						var lTwisted = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Twisted" };
						var lJilted = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Jilted" };
						var lAcrobatics = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Acrobatics" };
						var lNoExit = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "No Exit" };
						var lLillies = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Lillies" };
						var lPoppyLifeCycle = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Poppy Life Cycle" };
						var lBugs = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bugs" };
						var lMonsterPhotoBooth = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Monster Photo Booth" };
					
                        lContext.Images.AddRange(new List<ImageEntity>
                        {
							lRemembrance,
							lRedEyedGreenTreeFrog,
							lPantherChameleonLunch,
							lArgentinianHornedFrog,
							lGargoyleGecko,
							lTwisted,
							lJilted,
							lAcrobatics,
							lNoExit,
							lLillies,
							lPoppyLifeCycle,
							lBugs,
							lMonsterPhotoBooth,
                        });

						var lSalonYearSrgb2018AnythingGoes = new SectionEntity() { SalonYear = lSalonYearSrgb2018, SectionType = lSectionTypeSrgbAnythingGoes };
						var lSalonYearSrgb2018Creatures = new SectionEntity() { SalonYear = lSalonYearSrgb2018, SectionType = lSectionTypeSrgbCreatures };
						var lSalonYearSrgb2018Environment = new SectionEntity() { SalonYear = lSalonYearSrgb2018, SectionType = lSectionTypeSrgbEnvironment };
						var lSalonYearSrgb2018Humanity = new SectionEntity() { SalonYear = lSalonYearSrgb2018, SectionType = lSectionTypeSrgbHumanity };
						var lSalonYearSrgb2018Triptych = new SectionEntity() { SalonYear = lSalonYearSrgb2018, SectionType = lSectionTypeSrgbTriptych };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearSrgb2018AnythingGoes,
							lSalonYearSrgb2018Creatures,
							lSalonYearSrgb2018Environment,
							lSalonYearSrgb2018Humanity,
							lSalonYearSrgb2018Triptych,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 26M,
								SalonYear = lSalonYearSrgb2018,
                                EntryDate = new DateTime(2018, 7, 7),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018AnythingGoes, Image = lSymmetreeFire, IsAwarded = false, IsAccepted = true, Score=12 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018AnythingGoes, Image = lSymmetreeBlue, IsAwarded = false, IsAccepted = true, Score= 12},
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018AnythingGoes, Image = lRemembrance, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018AnythingGoes, Image = lThroughTheArch, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Creatures, Image = lRedEyedGreenTreeFrog, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Creatures, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Creatures, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = true, Score=12 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Creatures, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = false, Score=10},
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Environment, Image = lTwisted, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Environment, Image = lRainbowMosaic, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Environment, Image = lKirkjufellSnow, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Environment, Image = lLoneTree, IsAwarded = true, AwardDetails="SRGB Ribbon", IsAccepted = true, Score=13 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Humanity, Image = lZombiePriest, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Humanity, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Humanity, Image = lAcrobatics, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Humanity, Image = lNoExit, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Triptych, Image = lLillies, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Triptych, Image = lPoppyLifeCycle, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Triptych, Image = lBugs, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearSrgb2018Triptych, Image = lMonsterPhotoBooth, IsAwarded = true, AwardDetails="BPE Ribbon", IsAccepted = true, Score=13 },

                                    },
                            },
                        });

						// Beyond Group 2018 
						var lSalonYearBeyond2018 = new SalonYearEntity { Name = "Beyond Group", Salon = lSalonBeyondGroup, Year = 2018, ClosingDate = new DateTime(2018, 7, 29), JudgeDate = new DateTime(2018, 8, 12), NotificationDate = new DateTime(2018, 9, 2), CataloguesPostedDate = new DateTime(2018, 9, 2) };
						lContext.SalonYears.Add(lSalonYearBeyond2018);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "BPE 2018", PhotoOrganisation = lBpe, SalonYear = lSalonYearBeyond2018 },
                        });

						var lByTheEveningLight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "By The Evening Light" };
						var lByLamplight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "By Lamplight" };
						var lThreeLeaves = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Three Leaves" };
						var lSummerInTheCity = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Summer in the City" };
						var lToweringSky = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Towering Sky" };
                       
                        lContext.Images.AddRange(new List<ImageEntity>
                        {
							lByTheEveningLight,
							lByLamplight,
							lThreeLeaves,
                            lArgentinianHornedFrog,
							lSummerInTheCity,
							lToweringSky,
                        });

						var lSalonYearBeyond2018Colour = new SectionEntity() { SalonYear = lSalonYearBeyond2018, SectionType = lSectionTypeColourPdi };
						var lSalonYearBeyond2018Mono = new SectionEntity() { SalonYear = lSalonYearBeyond2018, SectionType = lSectionTypeMonoPdi };
						var lSalonYearBeyond2018Nature = new SectionEntity() { SalonYear = lSalonYearBeyond2018, SectionType = lSectionTypeNaturePdi };
						var lSalonYearBeyond2018Scapes = new SectionEntity() { SalonYear = lSalonYearBeyond2018, SectionType = lSectionTypeScapesPdi };
                      
                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearBeyond2018Colour,
							lSalonYearBeyond2018Mono,
							lSalonYearBeyond2018Nature,
							lSalonYearBeyond2018Scapes,
                        });
                        

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 24M,
								SalonYear = lSalonYearBeyond2018,
                                EntryDate = new DateTime(2018, 7, 28),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Colour, Image = lByTheEveningLight, IsAwarded = false, IsAccepted = false, Score=8 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Colour, Image = lRemembrance, IsAwarded = false, IsAccepted = false, Score= 11},
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Colour, Image = lByLamplight, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Colour, Image = lOrbsTriptych, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Mono, Image = lRuinsByNight, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Mono, Image = lPointedReflection, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Mono, Image = lCathedralCeiling, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Mono, Image = lThreeLeaves, IsAwarded = false, IsAccepted = false, Score=10},
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Nature, Image = lGreatGreyOwl, IsAwarded = false, IsAccepted = false, Score=8 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Scapes, Image = lRainbowMosaic, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Scapes, Image = lSummerInTheCity, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Scapes, Image = lTwisted, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearBeyond2018Scapes, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=9 },
                                },
                            },
                        });

						// Yorkshire 2018  A18-685-516
                        var lSalonYearYorkshire2018 = new SalonYearEntity { Name = "Yorkshire", Salon = lSalonYorkshire, Year = 2018, ClosingDate = new DateTime(2018, 12, 3), JudgeDate = new DateTime(2018, 12, 9), NotificationDate = new DateTime(2018, 12, 7), CataloguesPostedDate = new DateTime(2018, 9, 2) };
						lContext.SalonYears.Add(lSalonYearYorkshire2018);
                        
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2018/441", PhotoOrganisation = lFiap, SalonYear = lSalonYearYorkshire2018 },
							new AccreditationEntity() { SalonNumber = "2018-476", PhotoOrganisation = lPsa, SalonYear = lSalonYearYorkshire2018 },
                        });

						var lSalonYearYorkshire2018ColourPrint = new SectionEntity() { SalonYear = lSalonYearYorkshire2018, SectionType = lSectionTypeColourPrint };
						var lSalonYearYorkshire2018PdiOpen = new SectionEntity() { SalonYear = lSalonYearYorkshire2018, SectionType = lSectionTypeOpenPdi };
						var lSalonYearYorkshire2018Nature = new SectionEntity() { SalonYear = lSalonYearYorkshire2018, SectionType = lSectionTypeNaturePdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearYorkshire2018ColourPrint,
							lSalonYearYorkshire2018PdiOpen,
							lSalonYearYorkshire2018Nature,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 15M,
								SalonYear = lSalonYearYorkshire2018,
                                EntryDate = new DateTime(2018, 11, 7),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018ColourPrint, Image = lTheWatcher, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018ColourPrint, Image = lSymmetreeFire, IsAwarded = false, IsAccepted = true, Score= 13},
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018ColourPrint, Image = lLoneTree, IsAwarded = false, IsAccepted = true, Score=13 },
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018ColourPrint, Image = lTulipInTheRound, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018PdiOpen, Image = lBoatingInTheHail, IsAwarded = false, IsAccepted = false, Score=11},
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018PdiOpen, Image = lZombieGirl, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018PdiOpen, Image = lAWorldBeyond, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018PdiOpen, Image = lRainbowMosaic, IsAwarded = false, IsAccepted = false, Score=10},
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018Nature, Image = lWaterVoleInPipe, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018Nature, Image = lKingfisherWithFish, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018Nature, Image = lLongEaredOwl, IsAwarded = false, IsAccepted = false, Score=11 },
									new CompetitionEntryEntity { Section = lSalonYearYorkshire2018Nature, Image = lLittleOwl, IsAwarded = false, IsAccepted = false, Score=11 },

                                },
                            },
                        });

						// Solihull BPE 2018  
						var lSalonSolihull = new SalonEntity { Name = "Solihull", Website = "https://solihullopenexhibition.co.uk", Country = lCountryEngland };
						lContext.Salons.Add(lSalonSolihull);

						var lSalonYearSolihull2018 = new SalonYearEntity { Name = "Solihull", Salon = lSalonSolihull, Year = 2018, ClosingDate = new DateTime(2018, 12, 15), JudgeDate = new DateTime(2019, 2, 3), NotificationDate = new DateTime(2019, 2, 6), CataloguesPostedDate = new DateTime(2019, 2, 6) };
						lContext.SalonYears.Add(lSalonYearSolihull2018);
                        
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "BPE 2018", PhotoOrganisation = lBpe, SalonYear = lSalonYearSolihull2018 },
                        });

						var lSalonYearSolihull2018Colour = new SectionEntity() { SalonYear = lSalonYearSolihull2018, SectionType = lSectionTypeColourPdi };
						var lSalonYearSolihull2018MonoPdi = new SectionEntity() { SalonYear = lSalonYearSolihull2018, SectionType = lSectionTypeMonoPdi };
						var lSalonYearSolihull2018Nature = new SectionEntity() { SalonYear = lSalonYearSolihull2018, SectionType = lSectionTypeNaturePdi };
						var lSalonYearSolihull2018Scapes = new SectionEntity() { SalonYear = lSalonYearSolihull2018, SectionType = lSectionTypeScapesPdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearSolihull2018Colour,
							lSalonYearSolihull2018MonoPdi,
							lSalonYearSolihull2018Nature,
							lSalonYearSolihull2018Scapes,
                        });

						var lWorkersBreak = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Worker's Break" };
                        var lWaitingToTravel = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Waiting to Travel" };
                        var lIUsedToDreamIdMarryAPrince = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "I Used to Dream I'd Marry a Prince" };
                        var lAWalkInTheCountryside = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "A Walk in the Countryside" }; 
						var lWhoLivesAlone = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Who Lives Alone" };
						var lMirrorOfReminiscence = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Mirror of Reminiscence" };
						var lTheWishingTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Wishing Tree" };
						var lPantherChameleonTailDangling = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Panthern Chameleon Tail Dangling" };
						var lLondrangar = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Londrangar" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
							lWorkersBreak,
							lWaitingToTravel,
							lIUsedToDreamIdMarryAPrince,
							lAWalkInTheCountryside,
							lWhoLivesAlone,
							lMirrorOfReminiscence,
							lTheWishingTree,
							lPantherChameleonTailDangling,
							lLondrangar,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 18M,
								SalonYear = lSalonYearSolihull2018,
                                EntryDate = new DateTime(2018, 12, 2),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Colour, Image = lWorkersBreak, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Colour, Image = lWaitingToTravel, IsAwarded = false, IsAccepted = false, Score= 9},
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Colour, Image = lAWalkInTheCountryside, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018MonoPdi, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018MonoPdi, Image = lWhoLivesAlone, IsAwarded = false, IsAccepted = false, Score=8 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018MonoPdi, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018MonoPdi, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=10},
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Nature, Image = lPantherChameleonTailDangling, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Nature, Image = lYoungRedKite, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = false, Score=9 },                                  
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Scapes, Image = lLondrangar, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Scapes, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Scapes, Image = lRefuge, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = lSalonYearSolihull2018Scapes, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=9 },

                                },
                            },
                        });

						// Clay Cross BPE 2019  
                        var lSalonYearClayCross2019 = new SalonYearEntity { Name = "Clay Cross", Salon = lSalonClayCross, Year = 2019, ClosingDate = new DateTime(2019, 1, 26), JudgeDate = new DateTime(2019, 2, 10), NotificationDate = new DateTime(2019, 3, 23), CataloguesPostedDate = new DateTime(2019, 4, 16) };
						lContext.SalonYears.Add(lSalonYearClayCross2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "BPE 2019", PhotoOrganisation = lBpe, SalonYear = lSalonYearClayCross2019 },
                        });

						var SalonYearClayCross2019Colour = new SectionEntity() { SalonYear = lSalonYearClayCross2019, SectionType = lSectionTypeColourPdi };
						var SalonYearClayCross2019Creative = new SectionEntity() { SalonYear = lSalonYearClayCross2019, SectionType = lSectionTypeCreativePdi };
                       

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							SalonYearClayCross2019Colour,
							SalonYearClayCross2019Creative,
                         });

						var lLoveLetters = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Love Letters" };
						var lTheSeamstressTakesHerFee = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Seamstress Takes Her Fee" };
						var lBetwixtRealities = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Betwixt Realities" };
						var lTheMagician = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Magician" };
                  
                        lContext.Images.AddRange(new List<ImageEntity>
                        {
							lLoveLetters,
							lTheSeamstressTakesHerFee,
							lBetwixtRealities,
							lTheMagician,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12M,
								SalonYear = lSalonYearClayCross2019,
                                EntryDate = new DateTime(2019, 1, 22),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = SalonYearClayCross2019Colour, Image = lLoveLetters, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = SalonYearClayCross2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 11},
									new CompetitionEntryEntity { Section = SalonYearClayCross2019Colour, Image = lWaitingToTravel, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = SalonYearClayCross2019Colour, Image = lTheSeamstressTakesHerFee, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = SalonYearClayCross2019Creative, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=10 },
									new CompetitionEntryEntity { Section = SalonYearClayCross2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = SalonYearClayCross2019Creative, Image = lTheMagician, IsAwarded = false, IsAccepted = false, Score=9 },
									new CompetitionEntryEntity { Section = SalonYearClayCross2019Creative, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=12},
                                },
                            },
                        });

						// Queensland Circuit 2019
						var lQueenslandCircuit2019 = new CircuitEntity() { Name = "Queensland Circuit 2019" };
                        
                        lContext.Circuits.AddRange(new List<CircuitEntity> {
							lQueenslandCircuit2019,
                        });

						var lSalonGoldCoast = new SalonEntity { Name = "Gold Coast", Website = "http://www.queensland-photo.com", Country = lCountryAustralia };
                        lContext.Salons.Add(lSalonGoldCoast);

                        var lSalonYearGoldCoast2019 = new SalonYearEntity { Name = "Gold Coast", Salon = lSalonGoldCoast, Year = 2019, ClosingDate = new DateTime(2019, 6, 3), JudgeDate = new DateTime(2019, 6, 16), NotificationDate = new DateTime(2019, 6, 30), CataloguesPostedDate = new DateTime(2019, 9, 30), Circuit = lQueenslandCircuit2019 };
                        lContext.SalonYears.Add(lSalonYearGoldCoast2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/135", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearGoldCoast2019 },
                            new AccreditationEntity() { SalonNumber = "2019-204", PhotoOrganisation = lPsa, SalonYear = lSalonYearGoldCoast2019 },
                            new AccreditationEntity() { SalonNumber = "L190047", PhotoOrganisation = lGpu, SalonYear = lSalonYearGoldCoast2019 },
                        });

                        var lSalonYearGoldCoast2019Colour = new SectionEntity() { SalonYear = lSalonYearGoldCoast2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearGoldCoast2019Creative = new SectionEntity() { SalonYear = lSalonYearGoldCoast2019, SectionType = lSectionTypeCreativePdi };
                        var lSalonYearGoldCoast2019Mono = new SectionEntity() { SalonYear = lSalonYearGoldCoast2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearGoldCoast2019Nature = new SectionEntity() { SalonYear = lSalonYearGoldCoast2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearGoldCoast2019Colour,
                            lSalonYearGoldCoast2019Creative,
                            lSalonYearGoldCoast2019Mono,
                            lSalonYearGoldCoast2019Nature,
                         });

                        var lQueenOfTheCastle = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Queen of the Castle" };
                        var lChrysanthemumCloseUp = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Chrysanthemum Close Up" };
                        var lProtectors = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Protectors" };
                        var lWorshipImpressions = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Worship Impressions" };
                        var lPartyAtTheApocalypse = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Party at the Apocalypse" };
                        var lContemplationByStarlight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Contemplation By Starlight" };
                        var lAmazonMilkFrog = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Amazon Milk Frog" };
                        var lCrestedGeckoTongue = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Crested Gecko Tongue" };
                        var lPeacockTreeFrogTrio = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Peacock Tree Frog Trio" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lLoveLetters,
                            lTheSeamstressTakesHerFee,
                            lBetwixtRealities,
                            lTheMagician,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 12.13M,
                                SalonYear = lSalonYearGoldCoast2019,
                                EntryDate = new DateTime(2019, 5, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Colour, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Creative, Image = lProtectors, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Creative, Image = lWorshipImpressions, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=0},
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

						var lSalonMarybourgh = new SalonEntity { Name = "Marybourgh", Website = "http://www.queensland-photo.com", Country = lCountryAustralia };
						lContext.Salons.Add(lSalonMarybourgh);

						var lSalonYearMarybourgh2019 = new SalonYearEntity { Name = "Marybourgh", Salon = lSalonMarybourgh, Year = 2019, ClosingDate = new DateTime(2019, 6, 3), JudgeDate = new DateTime(2019, 6, 16), NotificationDate = new DateTime(2019, 6, 30), CataloguesPostedDate = new DateTime(2019, 9, 30), Circuit = lQueenslandCircuit2019 };
						lContext.SalonYears.Add(lSalonYearMarybourgh2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/136", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearMarybourgh2019 },
							new AccreditationEntity() { SalonNumber = "2019-204", PhotoOrganisation = lPsa, SalonYear = lSalonYearMarybourgh2019 },
							new AccreditationEntity() { SalonNumber = "L190047", PhotoOrganisation = lGpu, SalonYear = lSalonYearMarybourgh2019 },
                        });

						var lSalonYearMarybourgh2019Colour = new SectionEntity() { SalonYear = lSalonYearMarybourgh2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearMarybourgh2019Creative = new SectionEntity() { SalonYear = lSalonYearMarybourgh2019, SectionType = lSectionTypeCreativePdi };
						var lSalonYearMarybourgh2019Mono = new SectionEntity() { SalonYear = lSalonYearMarybourgh2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearMarybourgh2019Nature = new SectionEntity() { SalonYear = lSalonYearMarybourgh2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearMarybourgh2019Colour,
							lSalonYearMarybourgh2019Creative,
							lSalonYearMarybourgh2019Mono,
							lSalonYearMarybourgh2019Nature,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 12.12M,
								SalonYear = lSalonYearMarybourgh2019,
                                EntryDate = new DateTime(2019, 5, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Colour, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Creative, Image = lProtectors, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Creative, Image = lWorshipImpressions, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=0},
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

						var lSalonMtGravatt = new SalonEntity { Name = "Mt Gravatt", Website = "http://www.queensland-photo.com", Country = lCountryAustralia };
						lContext.Salons.Add(lSalonMtGravatt);

						var lSalonYearMtGravatt2019 = new SalonYearEntity { Name = "Mt Gravatt", Salon = lSalonMtGravatt, Year = 2019, ClosingDate = new DateTime(2019, 6, 3), JudgeDate = new DateTime(2019, 6, 16), NotificationDate = new DateTime(2019, 6, 30), CataloguesPostedDate = new DateTime(2019, 9, 30), Circuit = lQueenslandCircuit2019 };
						lContext.SalonYears.Add(lSalonYearMtGravatt2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/137", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearMtGravatt2019 },
							new AccreditationEntity() { SalonNumber = "2019-204", PhotoOrganisation = lPsa, SalonYear = lSalonYearMtGravatt2019 },
							new AccreditationEntity() { SalonNumber = "L190047", PhotoOrganisation = lGpu, SalonYear = lSalonYearMtGravatt2019 },
                        });

						var lSalonYearMtGravatt2019Colour = new SectionEntity() { SalonYear = lSalonYearMtGravatt2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearMtGravatt2019Creative = new SectionEntity() { SalonYear = lSalonYearMtGravatt2019, SectionType = lSectionTypeCreativePdi };
						var lSalonYearMtGravatt2019Mono = new SectionEntity() { SalonYear = lSalonYearMtGravatt2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearMtGravatt2019Nature = new SectionEntity() { SalonYear = lSalonYearMtGravatt2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearMtGravatt2019Colour,
							lSalonYearMtGravatt2019Creative,
							lSalonYearMtGravatt2019Mono,
							lSalonYearMtGravatt2019Nature,
                         });

         
                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 12.12M,
								SalonYear = lSalonYearMtGravatt2019,
                                EntryDate = new DateTime(2019, 5, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Colour, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Creative, Image = lProtectors, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Creative, Image = lWorshipImpressions, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=0},
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

						var lSalonTownsville = new SalonEntity { Name = "Townsville", Website = "http://www.queensland-photo.com", Country = lCountryAustralia };
						lContext.Salons.Add(lSalonTownsville);
                        
						var llSalonYearTownsville2019 = new SalonYearEntity { Name = "Townsville", Salon = lSalonTownsville, Year = 2019, ClosingDate = new DateTime(2019, 6, 3), JudgeDate = new DateTime(2019, 6, 16), NotificationDate = new DateTime(2019, 6, 30), CataloguesPostedDate = new DateTime(2019, 9, 30), Circuit = lQueenslandCircuit2019 };
						lContext.SalonYears.Add(llSalonYearTownsville2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/138", PhotoOrganisation = lFiapLevels, SalonYear = llSalonYearTownsville2019 },
							new AccreditationEntity() { SalonNumber = "2019-204", PhotoOrganisation = lPsa, SalonYear = llSalonYearTownsville2019 },
							new AccreditationEntity() { SalonNumber = "L190047", PhotoOrganisation = lGpu, SalonYear = llSalonYearTownsville2019 },
                        });

						var lSalonYearTownsville2019Colour = new SectionEntity() { SalonYear = llSalonYearTownsville2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearTownsville2019Creative = new SectionEntity() { SalonYear = llSalonYearTownsville2019, SectionType = lSectionTypeCreativePdi };
						var lSalonYearTownsville2019Mono = new SectionEntity() { SalonYear = llSalonYearTownsville2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearTownsville2019Nature = new SectionEntity() { SalonYear = llSalonYearTownsville2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearTownsville2019Colour,
							lSalonYearTownsville2019Creative,
							lSalonYearTownsville2019Mono,
							lSalonYearTownsville2019Nature,
                         });

                        
                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 12.12M,
								SalonYear = llSalonYearTownsville2019,
                                EntryDate = new DateTime(2019, 5, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Colour, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Creative, Image = lProtectors, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Creative, Image = lWorshipImpressions, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=0},
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearTownsville2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });


                        // Citadela 2019 
						var lSalonCitadela = new SalonEntity { Name = "Citadela", Website = "https://www.perasto.club/", Country = lCountryMontenegro };
						lContext.Salons.Add(lSalonCitadela);
                        
						var lSalonYearCitadela2019 = new SalonYearEntity { Name = "Citadela", Salon = lSalonCitadela, Year = 2019, ClosingDate = new DateTime(2019, 6, 23), JudgeDate = new DateTime(2019, 7, 11), NotificationDate = new DateTime(2019, 7, 15), CataloguesPostedDate = new DateTime(2019, 9, 23) };
						lContext.SalonYears.Add(lSalonYearCitadela2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/258", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearCitadela2019 },
							new AccreditationEntity() { SalonNumber = "2019-267", PhotoOrganisation = lPsa, SalonYear = lSalonYearCitadela2019 },
                        });


						var lSalonYearCitadela2019Colour = new SectionEntity() { SalonYear = lSalonYearCitadela2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearCitadela2019Mono = new SectionEntity() { SalonYear = lSalonYearCitadela2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearCitadela2019Travel = new SectionEntity() { SalonYear = lSalonYearCitadela2019, SectionType = lSectionTypeTravelPdi };
						var lSalonYearCitadela2019Nature = new SectionEntity() { SalonYear = lSalonYearCitadela2019, SectionType = lSectionTypeNaturePdi };
						var lSalonYearCitadela2019People = new SectionEntity() { SalonYear = lSalonYearCitadela2019, SectionType = lSectionTypePeoplePdi};

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearCitadela2019Colour,
							lSalonYearCitadela2019Mono,
							lSalonYearCitadela2019Travel,
							lSalonYearCitadela2019Nature,
							lSalonYearCitadela2019People,
                        });

						var lWatchingTheWind = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Watching The Wind" };
						var lBLuebellInWoodenVase = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bluebell in Wooden Vase" };
						var lChiveFlower = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Chive Flower" };
						var lLoversInAndalucia = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Lovers In Andalucia" };
						var lTheRedHut = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Red Hut" };
						var lWaterDance = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Water Dance" };
						var lvictorianRailwayWorker = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Victorian Railway Worker" };
						var lTimeFlies = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Time Flies" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
							lWatchingTheWind,
							lChrysanthemumCloseUp,
							lBLuebellInWoodenVase,
							lChiveFlower,
                            lSummerInTheCity,
							lLoversInAndalucia,
							lTheRedHut,
							lWaterDance,
							lvictorianRailwayWorker,
							lTimeFlies,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 18.45M,
								SalonYear = lSalonYearCitadela2019,
                                EntryDate = new DateTime(2019, 6, 1),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Colour, Image = lWatchingTheWind, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Colour, Image = lBLuebellInWoodenVase, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Colour, Image = lChiveFlower, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0},
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019People, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019People, Image = lWaterDance, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019People, Image = lvictorianRailwayWorker, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearCitadela2019People, Image = lWaitingToTravel, IsAwarded = false, IsAccepted = false, Score=0 },
                                },
                            },
                        });

						// Mahfuz Ullah Memorial 2019 
                         var lSalonYearMahfzulla2019 = new SalonYearEntity { Name = "Mahfuz Ullah", Salon = lSalonMahuzullah, Year = 2019, ClosingDate = new DateTime(2019, 6, 27), JudgeDate = new DateTime(2019, 7, 6), NotificationDate = new DateTime(2019, 7, 13), CataloguesPostedDate = new DateTime(2019, 9, 2) };
						lContext.SalonYears.Add(lSalonYearMahfzulla2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/223", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearMahfzulla2019 },
							new AccreditationEntity() { SalonNumber = "2019-229", PhotoOrganisation = lPsa, SalonYear = lSalonYearMahfzulla2019 },
                        });


						var lSalonYearMahfzulla2019Colour = new SectionEntity() { SalonYear = lSalonYearMahfzulla2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearMahfzulla2019Mono = new SectionEntity() { SalonYear = lSalonYearMahfzulla2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearMahfzulla2019Travel = new SectionEntity() { SalonYear = lSalonYearMahfzulla2019, SectionType = lSectionTypeTravelPdi };
						var lSalonYearMahfzulla2019Nature = new SectionEntity() { SalonYear = lSalonYearMahfzulla2019, SectionType = lSectionTypeNaturePdi };
                        
                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearMahfzulla2019Colour,
							lSalonYearMahfzulla2019Mono,
							lSalonYearMahfzulla2019Travel,
							lSalonYearMahfzulla2019Nature,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 18.45M,
								SalonYear = lSalonYearMahfzulla2019,
                                EntryDate = new DateTime(2019, 6, 1),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Colour, Image = lBLuebellInWoodenVase, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Colour, Image = lChiveFlower, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0},
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
                                },
                            },
                        });

						// AFAD 2019 
						var lSalonYearAfad2019 = new SalonYearEntity { Name = "AFAD", Salon = lSalonAfad, Year = 2019, ClosingDate = new DateTime(2019, 6, 12), JudgeDate = new DateTime(2019, 7, 16), NotificationDate = new DateTime(2019, 6, 22), CataloguesPostedDate = new DateTime(2019, 9, 1) };
						lContext.SalonYears.Add(lSalonYearAfad2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/236", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearAfad2019 },
                        });


						var lSalonYearAfad2019Colour = new SectionEntity() { SalonYear = lSalonYearAfad2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearAfad2019Mono = new SectionEntity() { SalonYear = lSalonYearAfad2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearAfad2019Travel = new SectionEntity() { SalonYear = lSalonYearAfad2019, SectionType = lSectionTypeTravelPdi };
						var lSalonYearAfad2019Nature = new SectionEntity() { SalonYear = lSalonYearAfad2019, SectionType = lSectionTypeNaturePdi };

                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearAfad2019Colour,
							lSalonYearAfad2019Mono,
							lSalonYearAfad2019Travel,
							lSalonYearAfad2019Nature,
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 13.84M,
								SalonYear = lSalonYearAfad2019,
                                EntryDate = new DateTime(2019, 6, 2),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0},
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearAfad2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
                                },
                            },
                        });

						// Montenegro Zeta Circuit 2019
                        var lZetaCircuit2019 = new CircuitEntity() { Name = "Zeta 2019" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
							lZetaCircuit2019,
                        });

						var lRoughFrilledTreeFrogOnFlower = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Rough Frilled Tree Frog on Flower" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lRoughFrilledTreeFrogOnFlower,
                        });

						var lSalonPodgorica = new SalonEntity { Name = "Podgorica", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
						lContext.Salons.Add(lSalonPodgorica);

						var lSalonYearPodgorica2019 = new SalonYearEntity { Name = "Podgorica", Salon = lSalonPodgorica, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
						lContext.SalonYears.Add(lSalonYearPodgorica2019);

						lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/301", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearPodgorica2019 },
							new AccreditationEntity() { SalonNumber = "2019-244", PhotoOrganisation = lPsa, SalonYear = lSalonYearPodgorica2019 },
                        });

						var lSalonYearPodgorica2019Colour = new SectionEntity() { SalonYear = lSalonYearPodgorica2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearPodgorica2019Mono = new SectionEntity() { SalonYear = lSalonYearPodgorica2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearPodgorica2019Nature = new SectionEntity() { SalonYear = lSalonYearPodgorica2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearPodgorica2019Colour,
							lSalonYearPodgorica2019Mono,
							lSalonYearPodgorica2019Nature,
                         });

					    lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 7.42M,
								SalonYear = lSalonYearPodgorica2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

						var lSalonBudva = new SalonEntity { Name = "Budva", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
						lContext.Salons.Add(lSalonBudva);

						var lSalonYearBudva2019 = new SalonYearEntity { Name = "Budva", Salon = lSalonBudva, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
						lContext.SalonYears.Add(lSalonYearBudva2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/302", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearBudva2019 },
							new AccreditationEntity() { SalonNumber = "2019-244", PhotoOrganisation = lPsa, SalonYear = lSalonYearBudva2019 },
                        });

						var lSalonYearBudva2019Colour = new SectionEntity() { SalonYear = lSalonYearBudva2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearBudva2019Mono = new SectionEntity() { SalonYear = lSalonYearBudva2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearBudva2019Nature = new SectionEntity() { SalonYear = lSalonYearBudva2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearBudva2019Colour,
							lSalonYearBudva2019Mono,
							lSalonYearBudva2019Nature,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 7.42M,
                                SalonYear = lSalonYearBudva2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearBudva2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearBudva2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearBudva2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearBudva2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearBudva2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearBudva2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearBudva2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearBudva2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearBudva2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

						var lSalonNiksic = new SalonEntity { Name = "Niksic", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
						lContext.Salons.Add(lSalonNiksic);

						var lSalonYearNiksic2019 = new SalonYearEntity { Name = "Niksic", Salon = lSalonNiksic, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
						lContext.SalonYears.Add(lSalonYearNiksic2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/303", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearNiksic2019 },
							new AccreditationEntity() { SalonNumber = "2019-244", PhotoOrganisation = lPsa, SalonYear = lSalonYearNiksic2019 },
                        });

						var lSalonYearNiksic2019Colour = new SectionEntity() { SalonYear = lSalonYearNiksic2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearNiksic2019Mono = new SectionEntity() { SalonYear = lSalonYearNiksic2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearNiksic2019Nature = new SectionEntity() { SalonYear = lSalonYearNiksic2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearNiksic2019Colour,
							lSalonYearNiksic2019Mono,
							lSalonYearNiksic2019Nature,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 7.41M,
                                SalonYear = lSalonYearNiksic2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearNiksic2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearNiksic2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearNiksic2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearNiksic2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearNiksic2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearNiksic2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearNiksic2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearNiksic2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearNiksic2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

						var lSalonKolasin = new SalonEntity { Name = "Kolasin", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
						lContext.Salons.Add(lSalonKolasin);

						var lSalonYearKolasin2019 = new SalonYearEntity { Name = "Kolasin", Salon = lSalonKolasin, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
						lContext.SalonYears.Add(lSalonYearKolasin2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/304", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearKolasin2019 },
							new AccreditationEntity() { SalonNumber = "2019-244", PhotoOrganisation = lPsa, SalonYear = lSalonYearKolasin2019 },
                        });

						var lSalonYearKolasin2019Colour = new SectionEntity() { SalonYear = lSalonYearKolasin2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearKolasin2019Mono = new SectionEntity() { SalonYear = lSalonYearKolasin2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearKolasin2019Nature = new SectionEntity() { SalonYear = lSalonYearKolasin2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearKolasin2019Colour,
							lSalonYearKolasin2019Mono,
							lSalonYearKolasin2019Nature,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 7.41M,
                                SalonYear = lSalonYearKolasin2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearKolasin2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKolasin2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearKolasin2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKolasin2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKolasin2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearKolasin2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKolasin2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKolasin2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKolasin2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

						var lSalonKotor = new SalonEntity { Name = "Kotor", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
						lContext.Salons.Add(lSalonKotor);

						var lSalonYearKotor2019 = new SalonYearEntity { Name = "Kotor", Salon = lSalonKotor, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
						lContext.SalonYears.Add(lSalonYearKotor2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
							new AccreditationEntity() { SalonNumber = "2019/305", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearKotor2019 },
							new AccreditationEntity() { SalonNumber = "2019-244", PhotoOrganisation = lPsa, SalonYear = lSalonYearKotor2019 },
                        });

						var lSalonYearKotor2019Colour = new SectionEntity() { SalonYear = lSalonYearKotor2019, SectionType = lSectionTypeColourPdi };
						var lSalonYearKotor2019Mono = new SectionEntity() { SalonYear = lSalonYearKotor2019, SectionType = lSectionTypeMonoPdi };
						var lSalonYearKotor2019Nature = new SectionEntity() { SalonYear = lSalonYearKotor2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
							lSalonYearKotor2019Colour,
							lSalonYearKotor2019Mono,
							lSalonYearKotor2019Nature,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = false,
                                EntryCost = 7.41M,
                                SalonYear = lSalonYearKotor2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=0 },
									new CompetitionEntryEntity { Section = lSalonYearKotor2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=0},
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

        private static void clearAllData(SalonDbContext pContext)
        {
            pContext.CompetitionEntries.RemoveRange(pContext.CompetitionEntries.ToList());
            pContext.SalonSections.RemoveRange(pContext.SalonSections.ToList());
            pContext.Submissions.RemoveRange(pContext.Submissions.ToList());
            pContext.AwardLevels.RemoveRange(pContext.AwardLevels.ToList());
            pContext.PhotoOrganisations.RemoveRange(pContext.PhotoOrganisations.ToList());
            pContext.Images.RemoveRange(pContext.Images.ToList());
            pContext.People.RemoveRange(pContext.People.ToList());
            pContext.Countries.RemoveRange(pContext.Countries.ToList());
            pContext.Accreditations.RemoveRange(pContext.Accreditations.ToList());
			pContext.SalonYears.RemoveRange(pContext.SalonYears.ToList());
            pContext.Salons.RemoveRange(pContext.Salons.ToList());
            pContext.Circuits.RemoveRange(pContext.Circuits.ToList());
            pContext.SectionTypes.RemoveRange(pContext.SectionTypes.ToList());

            pContext.SaveChanges();
        }
    }
}
