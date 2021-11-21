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
                    var lCountryAlbania = new CountryEntity { Name = "Albania", };
                    var lCountryGeorgia = new CountryEntity { Name = "Georgia", };
                    var lCountryCroatia = new CountryEntity { Name = "Croatia", };
                    var lCountryFinland = new CountryEntity { Name = "Finland", };
                    var lCountrySingapore = new CountryEntity { Name = "Singapore", };
                    var lCountryGreece = new CountryEntity { Name = "Greece", };
                    var lCountrySlovenia = new CountryEntity { Name = "Slovenia", };
                    var lCountryDenmark = new CountryEntity { Name = "Denmark", };
                    var lCountryBrazil = new CountryEntity { Name = "Brazil", };
                    var lCountryIndonesia = new CountryEntity { Name = "Indonesia", };
                    var lCountrySouthAfrica = new CountryEntity { Name = "South Africa", };
                    var lCountryGermany = new CountryEntity { Name = "Germany", };
                    var lCountrySweden = new CountryEntity { Name = "Sweden", };
                    var lCountryTajikistan = new CountryEntity { Name = "Tajikistan", };
                    var lCountryRussia = new CountryEntity { Name = "Russia", };
                    var lCountryNorway = new CountryEntity { Name = "Norway", };
                    var lCountryArgentina = new CountryEntity { Name = "Argentina", };
                    var lCountryBosniaAndHerzegovina = new CountryEntity { Name = "Bosnia and Herzegovina", };
                    var lCountryGuatamala = new CountryEntity { Name = "Guatamala", };
                    var lCountryBelarus = new CountryEntity { Name = "Belarus", };
                    var lCountryKenya = new CountryEntity { Name = "Kenya", };
                    var lCountryIceland = new CountryEntity { Name = "Iceland", };


                    try
                    {
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
                        var lBirdAndWaterfall = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bird & Waterfall", Notes = "BPE Version - use Water Flight for FIAP/PSA" };


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
                        var lSalonViewfinder = new SalonEntity { Name = "Through The Viewfinder", Website = "https://photoclubkragujevac.com/viewfinder/", Country = lCountrySerbia };
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

                        var lSalonGoldCoast = new SalonEntity { Name = "Queensland - Gold Coast", Website = "http://www.queensland-photo.com", Country = lCountryAustralia };
                        lContext.Salons.Add(lSalonGoldCoast);

                        var lSalonYearGoldCoast2019 = new SalonYearEntity { Name = "Queensland - Gold Coast", Salon = lSalonGoldCoast, Year = 2019, ClosingDate = new DateTime(2019, 6, 3), JudgeDate = new DateTime(2019, 6, 16), NotificationDate = new DateTime(2019, 6, 30), CataloguesPostedDate = new DateTime(2019, 9, 30), Circuit = lQueenslandCircuit2019 };
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
                                IsJudged = true,
                                EntryCost = 12.13M,
                                SalonYear = lSalonYearGoldCoast2019,
                                EntryDate = new DateTime(2019, 5, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score= 0},
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
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCoast2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = true, Score=0},
                                },
                            },
                        });

                        var lSalonMarybourgh = new SalonEntity { Name = "Queensland - Marybourgh", Website = "http://www.queensland-photo.com", Country = lCountryAustralia };
                        lContext.Salons.Add(lSalonMarybourgh);

                        var lSalonYearMarybourgh2019 = new SalonYearEntity { Name = "Queensland - Marybourgh", Salon = lSalonMarybourgh, Year = 2019, ClosingDate = new DateTime(2019, 6, 3), JudgeDate = new DateTime(2019, 6, 16), NotificationDate = new DateTime(2019, 6, 30), CataloguesPostedDate = new DateTime(2019, 9, 30), Circuit = lQueenslandCircuit2019 };
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
                                IsJudged = true,
                                EntryCost = 12.12M,
                                SalonYear = lSalonYearMarybourgh2019,
                                EntryDate = new DateTime(2019, 5, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Colour, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Creative, Image = lProtectors, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Creative, Image = lWorshipImpressions, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = true, Score=0},
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMarybourgh2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = true, Score=0},
                                },
                            },
                        });

                        var lSalonMtGravatt = new SalonEntity { Name = "Queensland - Mt Gravatt", Website = "http://www.queensland-photo.com", Country = lCountryAustralia };
                        lContext.Salons.Add(lSalonMtGravatt);

                        var lSalonYearMtGravatt2019 = new SalonYearEntity { Name = "Queensland - Mt Gravatt", Salon = lSalonMtGravatt, Year = 2019, ClosingDate = new DateTime(2019, 6, 3), JudgeDate = new DateTime(2019, 6, 16), NotificationDate = new DateTime(2019, 6, 30), CataloguesPostedDate = new DateTime(2019, 9, 30), Circuit = lQueenslandCircuit2019 };
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
                                IsJudged = true,
                                EntryCost = 12.12M,
                                SalonYear = lSalonYearMtGravatt2019,
                                EntryDate = new DateTime(2019, 5, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Colour, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Creative, Image = lProtectors, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Creative, Image = lWorshipImpressions, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=0},
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMtGravatt2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = true, Score=0},
                                },
                            },
                        });

                        var lSalonTownsville = new SalonEntity { Name = "Queensland - Townsville", Website = "http://www.queensland-photo.com", Country = lCountryAustralia };
                        lContext.Salons.Add(lSalonTownsville);

                        var llSalonYearTownsville2019 = new SalonYearEntity { Name = "Queensland - Townsville", Salon = lSalonTownsville, Year = 2019, ClosingDate = new DateTime(2019, 6, 3), JudgeDate = new DateTime(2019, 6, 16), NotificationDate = new DateTime(2019, 6, 30), CataloguesPostedDate = new DateTime(2019, 9, 30), Circuit = lQueenslandCircuit2019 };
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
                                IsJudged = true,
                                EntryCost = 12.12M,
                                SalonYear = llSalonYearTownsville2019,
                                EntryDate = new DateTime(2019, 5, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Colour, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Creative, Image = lProtectors, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Creative, Image = lWorshipImpressions, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=0},
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearTownsville2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
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
                        var lSalonYearCitadela2019People = new SectionEntity() { SalonYear = lSalonYearCitadela2019, SectionType = lSectionTypePeoplePdi };

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
                                IsJudged = true,
                                EntryCost = 18.45M,
                                SalonYear = lSalonYearCitadela2019,
                                EntryDate = new DateTime(2019, 6, 1),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Colour, Image = lWatchingTheWind, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score= 16},
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Colour, Image = lBLuebellInWoodenVase, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Colour, Image = lChiveFlower, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=12},
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019People, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019People, Image = lWaterDance, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019People, Image = lvictorianRailwayWorker, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearCitadela2019People, Image = lWaitingToTravel, IsAwarded = false, IsAccepted = true, Score=21 },
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
                                IsJudged = true,
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
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0},
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearMahfzulla2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = true, AwardDetails = "PSA HM Red Ribbon", IsAccepted = true, Score=0 },
                                },
                            },
                        });

                        // AFAD 2019
                        var lSalonYearAfad2019 = new SalonYearEntity { Name = "AFAD", Salon = lSalonAfad, Year = 2019, ClosingDate = new DateTime(2019, 6, 12), JudgeDate = new DateTime(2019, 6, 16), NotificationDate = new DateTime(2019, 6, 22), CataloguesPostedDate = new DateTime(2019, 9, 1) };
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
                                IsJudged = true,
                                EntryCost = 13.84M,
                                SalonYear = lSalonYearAfad2019,
                                EntryDate = new DateTime(2019, 6, 2),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score=26 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score=29 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=28},
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = true, Score=24 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Nature, Image = lArgentinianHornedFrog, IsAwarded = false, IsAccepted = true, Score=26 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=30 },
                                    new CompetitionEntryEntity { Section = lSalonYearAfad2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=29 },
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

                        var lSalonPodgorica = new SalonEntity { Name = "Zeta - Podgorica", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonPodgorica);

                        var lSalonYearPodgorica2019 = new SalonYearEntity { Name = "Zeta - Podgorica", Salon = lSalonPodgorica, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
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
                                IsJudged = true,
                                EntryCost = 7.42M,
                                SalonYear = lSalonYearPodgorica2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 22},
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=24 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 22},
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=23 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearPodgorica2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=22},
                                },
                            },
                        });

                        var lSalonBudva = new SalonEntity { Name = "Zeta - Budva", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonBudva);

                        var lSalonYearBudva2019 = new SalonYearEntity { Name = "Zeta - Budva", Salon = lSalonBudva, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
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
                                IsJudged = true,
                                EntryCost = 7.42M,
                                SalonYear = lSalonYearBudva2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 22},
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 21},
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score=23 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = true, Score=25 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=25 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=24 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudva2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = true, Score=24},
                                },
                            },
                        });

                        var lSalonNiksic = new SalonEntity { Name = "Zeta - Niksic", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonNiksic);

                        var lSalonYearNiksic2019 = new SalonYearEntity { Name = "Zeta - Niksic", Salon = lSalonNiksic, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
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
                                IsJudged = true,
                                EntryCost = 7.41M,
                                SalonYear = lSalonYearNiksic2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 19},
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearNiksic2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=20},
                                },
                            },
                        });

                        var lSalonKolasin = new SalonEntity { Name = "Zeta - Kolasin", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonKolasin);

                        var lSalonYearKolasin2019 = new SalonYearEntity { Name = "Zeta - Kolasin", Salon = lSalonKolasin, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
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
                                IsJudged = true,
                                EntryCost = 7.41M,
                                SalonYear = lSalonYearKolasin2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 21},
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 21},
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasin2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=21},
                                },
                            },
                        });

                        var lSalonKotor = new SalonEntity { Name = "Zeta - Kotor", Website = "http://www.photoclubmontenegro.com", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonKotor);

                        var lSalonYearKotor2019 = new SalonYearEntity { Name = "Zeta - Kotor", Salon = lSalonKotor, Year = 2019, ClosingDate = new DateTime(2019, 6, 10), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 10), CataloguesPostedDate = new DateTime(2019, 9, 10), Circuit = lZetaCircuit2019 };
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
                                IsJudged = true,
                                EntryCost = 7.41M,
                                SalonYear = lSalonYearKotor2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = true, Score=23 },
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKotor2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=21},
                                },
                            },
                        });

                        // Mirage 2019
                        var lSalonMirage = new SalonEntity { Name = "Mirage", Website = "https://mirage.photofenix.com", Country = lCountryAlbania };
                        lContext.Salons.Add(lSalonMirage);

                        var lSalonYearMirage2019 = new SalonYearEntity { Name = "Mirage", Salon = lSalonMirage, Year = 2019, ClosingDate = new DateTime(2019, 6, 16), JudgeDate = new DateTime(2019, 6, 26), NotificationDate = new DateTime(2019, 7, 3), CataloguesPostedDate = new DateTime(2019, 8, 15) };
                        lContext.SalonYears.Add(lSalonYearMirage2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/183", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearMirage2019 },
                            new AccreditationEntity() { SalonNumber = "2019-084", PhotoOrganisation = lPsa, SalonYear = lSalonYearMirage2019 },
                        });


                        var lSalonYearMirage2019Mono = new SectionEntity() { SalonYear = lSalonYearMirage2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearMirage2019Colour = new SectionEntity() { SalonYear = lSalonYearMirage2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearMirage2019Travel = new SectionEntity() { SalonYear = lSalonYearMirage2019, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearMirage2019Photojournalism = new SectionEntity() { SalonYear = lSalonYearMirage2019, SectionType = lSectionTypePhotojournalismPdi };
                        var lSalonYearMirage2019Nature = new SectionEntity() { SalonYear = lSalonYearMirage2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearMirage2019Streets = new SectionEntity() { SalonYear = lSalonYearMirage2019, SectionType = lSectionTypeStreetPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearMirage2019Mono,
                            lSalonYearMirage2019Colour,
                            lSalonYearMirage2019Travel,
                            lSalonYearMirage2019Photojournalism,
                            lSalonYearMirage2019Nature,
                            lSalonYearMirage2019Streets,
                        });

                        var lPeriodDramaLeeds = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Period Drama, Leeds" };
                        var lAnimatronicTRex = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Animatronic T Rex, Shopping Centre, Leeds" };
                        var lTourDeYorkshireArt = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tour De Yorkshire Art" };
                        var lTourDeYorkshireLeaders2019 = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tour De Yorkshire Leaders 2019" };
                        var lFatRascalBettys = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Far Rascal, Betty's Cafe, Ilkley" };
                        var lEmergency = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Emergency" };
                        var lThePinkTowel = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Pink Towel" };
                        var lDownhill = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Downhill" };
                        var lTourDeYorkshire2019 = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tour De Yorkshire 2019" };


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
                                IsJudged = true,
                                EntryCost = 23.17M,
                                SalonYear = lSalonYearMirage2019,
                                EntryDate = new DateTime(2019, 6, 8),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Mono, Image = lPeriodDramaLeeds, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Colour, Image = lBLuebellInWoodenVase, IsAwarded = false, IsAccepted = false, Score=14},
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Photojournalism, Image = lAnimatronicTRex, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Photojournalism, Image = lTourDeYorkshireArt, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Photojournalism, Image = lTourDeYorkshireLeaders2019, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Photojournalism, Image = lFatRascalBettys, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Streets, Image = lEmergency, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Streets, Image = lThePinkTowel, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Streets, Image = lDownhill, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearMirage2019Streets, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = false, Score=19 },
                                },
                            },
                        });

                        // Balkan International Wonder 2019
                        var lSalonBalkanWonder = new SalonEntity { Name = "Balkan Wonder", Website = "http://photobalkan.com/list-of-authors", Country = lCountrySerbia };
                        lContext.Salons.Add(lSalonBalkanWonder);

                        var lSalonYearBalkanWonder2019 = new SalonYearEntity { Name = "Balkan Wonder", Salon = lSalonBalkanWonder, Year = 2019, ClosingDate = new DateTime(2019, 6, 20), JudgeDate = new DateTime(2019, 7, 4), NotificationDate = new DateTime(2019, 7, 14), CataloguesPostedDate = new DateTime(2019, 9, 19) };
                        lContext.SalonYears.Add(lSalonYearBalkanWonder2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/237", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearBalkanWonder2019 },
                            new AccreditationEntity() { SalonNumber = "2019-269", PhotoOrganisation = lPsa, SalonYear = lSalonYearBalkanWonder2019 },
                            new AccreditationEntity() { SalonNumber = "L190069", PhotoOrganisation = lGpu, SalonYear = lSalonYearBalkanWonder2019 },
                        });


                        var lSalonYearBalkanWonder2019Colour = new SectionEntity() { SalonYear = lSalonYearBalkanWonder2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearBalkanWonder2019Street = new SectionEntity() { SalonYear = lSalonYearBalkanWonder2019, SectionType = lSectionTypeStreetPdi };
                        var lSalonYearBalkanWonder2019Mono = new SectionEntity() { SalonYear = lSalonYearBalkanWonder2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearBalkanWonder2019Nature = new SectionEntity() { SalonYear = lSalonYearBalkanWonder2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearBalkanWonder2019Birds = new SectionEntity() { SalonYear = lSalonYearBalkanWonder2019, SectionType = lSectionTypeNaturePdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearBalkanWonder2019Colour,
                            lSalonYearBalkanWonder2019Street,
                            lSalonYearBalkanWonder2019Mono,
                            lSalonYearBalkanWonder2019Nature,
                            lSalonYearBalkanWonder2019Birds,
                        });

                        var lTrendyCoupleOnSteps = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Trendy Couple on Steps" };
                        var lWindsweptLittleOwl = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Windswept Little Owl" };
                        var lRedKiteCall = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Red Kite Call" };
                        var lNorthernWhiteFacedOwl = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Northern White Faced Owl" };
                        var lContentedOwl = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Contented Owl" };


                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lTrendyCoupleOnSteps,
                            lWindsweptLittleOwl,
                            lRedKiteCall,
                            lNorthernWhiteFacedOwl,
                            lContentedOwl,

                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 18.60M,
                                SalonYear = lSalonYearBalkanWonder2019,
                                EntryDate = new DateTime(2019, 6, 16),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Street, Image = lTrendyCoupleOnSteps, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Street, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Street, Image = lEmergency, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Street, Image = lTourDeYorkshireLeaders2019, IsAwarded = false, IsAccepted = false, Score=18},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Mono, Image = lToweringSky, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Birds, Image = lWindsweptLittleOwl, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Birds, Image = lRedKiteCall, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Birds, Image = lNorthernWhiteFacedOwl, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanWonder2019Birds, Image = lContentedOwl, IsAwarded = false, IsAccepted = false, Score=19 },
                                },
                            },
                        });

                        // Georgian Drag 2019
                        var lSalonGeorgianDrag = new SalonEntity { Name = "Georgian Drag", Website = "http://photo-forum.eu/menu_id/18/lang/1/rules?project=1", Country = lCountryGeorgia };
                        lContext.Salons.Add(lSalonGeorgianDrag);

                        var lSalonYearGeorgianDrag2019 = new SalonYearEntity { Name = "Georgian Drag", Salon = lSalonGeorgianDrag, Year = 2019, ClosingDate = new DateTime(2019, 6, 27), JudgeDate = new DateTime(2019, 7, 13), NotificationDate = new DateTime(2019, 7, 23), CataloguesPostedDate = new DateTime(2019, 9, 1) };
                        lContext.SalonYears.Add(lSalonYearGeorgianDrag2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/243", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearGeorgianDrag2019 },
                            new AccreditationEntity() { SalonNumber = "L190101", PhotoOrganisation = lGpu, SalonYear = lSalonYearGeorgianDrag2019 },
                        });


                        var lSalonYearGeorgianDrag2019Colour = new SectionEntity() { SalonYear = lSalonYearGeorgianDrag2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearGeorgianDrag2019People = new SectionEntity() { SalonYear = lSalonYearGeorgianDrag2019, SectionType = lSectionTypePeoplePdi };
                        var lSalonYearGeorgianDrag2019Mono = new SectionEntity() { SalonYear = lSalonYearGeorgianDrag2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearGeorgianDrag2019Landscapes = new SectionEntity() { SalonYear = lSalonYearGeorgianDrag2019, SectionType = lSectionTypeScapesPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearGeorgianDrag2019Colour,
                            lSalonYearGeorgianDrag2019People,
                            lSalonYearGeorgianDrag2019Mono,
                            lSalonYearGeorgianDrag2019Landscapes,
                        });

                        var lWartimeLettersHome = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Wartime Letters Home" };
                        var lComfortInAHarshWorld = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Comfort in a Harsh World" };
                        var lPagoda = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Pagoda" };
                        var lDerwentwaterBoatHouse = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Derwentwater Boat House" };
                        var lGrasmereRocks = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Grasmere Rocks" };



                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lWartimeLettersHome,
                            lComfortInAHarshWorld,
                            lPagoda,
                            lDerwentwaterBoatHouse,
                            lGrasmereRocks
                        });


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 15.85M,
                                SalonYear = lSalonYearGeorgianDrag2019,
                                EntryDate = new DateTime(2019, 6, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score= 4},
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Colour, Image = lWartimeLettersHome, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019People, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019People, Image = lWaitingToTravel, IsAwarded = false, IsAccepted = true, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019People, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = true, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019People, Image = lJilted, IsAwarded = false, IsAccepted = true, Score=9},
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Mono, Image = lPagoda, IsAwarded = false, IsAccepted = false, Score=4 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=5 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=6 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Landscapes, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=6},
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Landscapes, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=5 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Landscapes, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score=6 },
                                    new CompetitionEntryEntity { Section = lSalonYearGeorgianDrag2019Landscapes, Image = lGrasmereRocks, IsAwarded = false, IsAccepted = false, Score=7 },
                                },
                            },
                        });


                        // Tour Circuit 2019
                        var lTourCircuit2019 = new CircuitEntity() { Name = "Tour 2019" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                            lTourCircuit2019,
                        });

                        var lBacklitTarantula = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Backlit Tarantula" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lBacklitTarantula,
                        });

                        var lSalonKula = new SalonEntity { Name = "Tour - Kula", Website = "https://www.fkk.rs/main/index.php", Country = lCountrySerbia };
                        lContext.Salons.Add(lSalonKula);

                        var lSalonYearKula2019 = new SalonYearEntity { Name = "Tour - Kula", Salon = lSalonKula, Year = 2019, ClosingDate = new DateTime(2019, 7, 3), JudgeDate = new DateTime(2019, 7, 29), NotificationDate = new DateTime(2019, 8, 1), CataloguesPostedDate = new DateTime(2019, 10, 1), Circuit = lTourCircuit2019 };
                        lContext.SalonYears.Add(lSalonYearKula2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/295", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearKula2019 },
                            new AccreditationEntity() { SalonNumber = "2019-289", PhotoOrganisation = lPsa, SalonYear = lSalonYearKula2019 },
                        });

                        var lSalonYearKula2019Nature = new SectionEntity() { SalonYear = lSalonYearKula2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearKula2019Woman = new SectionEntity() { SalonYear = lSalonYearKula2019, SectionType = lSectionTypeWomanPdi };
                        var lSalonYearKula2019Colour = new SectionEntity() { SalonYear = lSalonYearKula2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearKula2019Mono = new SectionEntity() { SalonYear = lSalonYearKula2019, SectionType = lSectionTypeMonoPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearKula2019Nature,
                            lSalonYearKula2019Woman,
                            lSalonYearKula2019Colour,
                            lSalonYearKula2019Mono,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.43M,
                                SalonYear = lSalonYearKula2019,
                                EntryDate = new DateTime(2019, 6, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Nature, Image = lCrestedGeckoTongue, IsAwarded = true, AwardDetails = "HM", IsAccepted = true, Score=23 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Nature, Image = lBacklitTarantula, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Woman, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Woman, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score= 19},
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Woman, Image = lByLamplight, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Woman, Image = lJilted, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=18},
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKula2019Mono, Image = lPagoda, IsAwarded = false, IsAccepted = false, Score=17},
                                },
                            },
                        });

                        var lSalonBudvaTour = new SalonEntity { Name = "Tour - Budva", Website = "https://www.fkk.rs/main/index.php", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonBudvaTour);

                        var lSalonYearBudvaTour2019 = new SalonYearEntity { Name = "Tour - Budva", Salon = lSalonBudvaTour, Year = 2019, ClosingDate = new DateTime(2019, 7, 3), JudgeDate = new DateTime(2019, 7, 29), NotificationDate = new DateTime(2019, 8, 1), CataloguesPostedDate = new DateTime(2019, 10, 1), Circuit = lTourCircuit2019 };
                        lContext.SalonYears.Add(lSalonYearBudvaTour2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/296", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearBudvaTour2019 },
                            new AccreditationEntity() { SalonNumber = "2019-289", PhotoOrganisation = lPsa, SalonYear = lSalonYearBudvaTour2019 },
                        });

                        var lSalonYearBudvaTour2019Nature = new SectionEntity() { SalonYear = lSalonYearBudvaTour2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearBudvaTour2019Woman = new SectionEntity() { SalonYear = lSalonYearBudvaTour2019, SectionType = lSectionTypeWomanPdi };
                        var lSalonYearBudvaTour2019Colour = new SectionEntity() { SalonYear = lSalonYearBudvaTour2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearBudvaTour2019Mono = new SectionEntity() { SalonYear = lSalonYearBudvaTour2019, SectionType = lSectionTypeMonoPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearBudvaTour2019Nature,
                            lSalonYearBudvaTour2019Woman,
                            lSalonYearBudvaTour2019Colour,
                            lSalonYearBudvaTour2019Mono,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.43M,
                                SalonYear = lSalonYearBudvaTour2019,
                                EntryDate = new DateTime(2019, 6, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=23 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Nature, Image = lBacklitTarantula, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Woman, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Woman, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Woman, Image = lByLamplight, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Woman, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=19},
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBudvaTour2019Mono, Image = lPagoda, IsAwarded = false, IsAccepted = false, Score=19},
                                },
                            },
                        });

                        var lSalonKolasinTour = new SalonEntity { Name = "Tour - Kolasin", Website = "https://www.fkk.rs/main/index.php", Country = lCountryMontenegro };
                        lContext.Salons.Add(lSalonKolasinTour);

                        var lSalonYearKolasinTour2019 = new SalonYearEntity { Name = "Tour - Kolasin", Salon = lSalonKolasinTour, Year = 2019, ClosingDate = new DateTime(2019, 7, 3), JudgeDate = new DateTime(2019, 7, 29), NotificationDate = new DateTime(2019, 8, 1), CataloguesPostedDate = new DateTime(2019, 10, 1), Circuit = lTourCircuit2019 };
                        lContext.SalonYears.Add(lSalonYearKolasinTour2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/297", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearKolasinTour2019 },
                            new AccreditationEntity() { SalonNumber = "2019-289", PhotoOrganisation = lPsa, SalonYear = lSalonYearKolasinTour2019 },
                        });

                        var lSalonYearKolasinTour2019Nature = new SectionEntity() { SalonYear = lSalonYearKolasinTour2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearKolasinTour2019Woman = new SectionEntity() { SalonYear = lSalonYearKolasinTour2019, SectionType = lSectionTypeWomanPdi };
                        var lSalonYearKolasinTour2019Colour = new SectionEntity() { SalonYear = lSalonYearKolasinTour2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearKolasinTour2019Mono = new SectionEntity() { SalonYear = lSalonYearKolasinTour2019, SectionType = lSectionTypeMonoPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearKolasinTour2019Nature,
                            lSalonYearKolasinTour2019Woman,
                            lSalonYearKolasinTour2019Colour,
                            lSalonYearKolasinTour2019Mono,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.44M,
                                SalonYear = lSalonYearKolasinTour2019,
                                EntryDate = new DateTime(2019, 6, 24),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Nature, Image = lBacklitTarantula, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Woman, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Woman, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score= 21},
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Woman, Image = lByLamplight, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Woman, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=19},
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearKolasinTour2019Mono, Image = lPagoda, IsAwarded = false, IsAccepted = false, Score=17},
                                },
                            },
                        });


                        // Jewels Circuit 2019
                        var lJewelsCircuit2019 = new CircuitEntity() { Name = "Jewels" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                            lJewelsCircuit2019,
                        });

                        var lLightNightInflatableMen = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Light Night Inflatable Men, Leeds" };

                        lContext.Images.AddRange(new List<ImageEntity>
                        {
                            lLightNightInflatableMen,
                        });

                        var lSalonDiamanti = new SalonEntity { Name = "Jewels - Diamanti", Website = "http://www.photocontestclub.org/en/jewels-circ/", Country = lCountryItaly };
                        lContext.Salons.Add(lSalonDiamanti);

                        var lSalonYearDiamanti2019 = new SalonYearEntity { Name = "Jewels - Diamanti", Salon = lSalonDiamanti, Year = 2019, ClosingDate = new DateTime(2019, 7, 1), JudgeDate = new DateTime(2019, 7, 7), NotificationDate = new DateTime(2019, 7, 15), CataloguesPostedDate = new DateTime(2019, 10, 14), Circuit = lJewelsCircuit2019 };
                        lContext.SalonYears.Add(lSalonYearDiamanti2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/227", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearDiamanti2019 },
                            new AccreditationEntity() { SalonNumber = "L190073", PhotoOrganisation = lGpu, SalonYear = lSalonYearDiamanti2019 },
                        });

                        var lSalonYearDiamanti2019Mono = new SectionEntity() { SalonYear = lSalonYearDiamanti2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearDiamanti2019Colour = new SectionEntity() { SalonYear = lSalonYearDiamanti2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearDiamanti2019Landscape = new SectionEntity() { SalonYear = lSalonYearDiamanti2019, SectionType = lSectionTypeScapesPdi };
                        var lSalonYearDiamanti2019Photojournalism = new SectionEntity() { SalonYear = lSalonYearDiamanti2019, SectionType = lSectionTypePhotojournalismPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearDiamanti2019Mono,
                            lSalonYearDiamanti2019Colour,
                            lSalonYearDiamanti2019Landscape,
                            lSalonYearDiamanti2019Photojournalism,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 9.33M,
                                SalonYear = lSalonYearDiamanti2019,
                                EntryDate = new DateTime(2019, 6, 29),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Mono, Image = lPeriodDramaLeeds, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Colour, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Landscape, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Landscape, Image = lTheRedHut, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Landscape, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Landscape, Image = lGrasmereRocks, IsAwarded = false, IsAccepted = false, Score=0},
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Photojournalism, Image = lAnimatronicTRex, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Photojournalism, Image = lLightNightInflatableMen, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Photojournalism, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearDiamanti2019Photojournalism, Image = lTourDeYorkshireArt, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });


                        var lSalonRubini = new SalonEntity { Name = "Jewels - Rubini", Website = "http://www.photocontestclub.org/en/jewels-circ/", Country = lCountryItaly };
                        lContext.Salons.Add(lSalonRubini);

                        var lSalonYearRubini2019 = new SalonYearEntity { Name = "Jewels - Rubini", Salon = lSalonDiamanti, Year = 2019, ClosingDate = new DateTime(2019, 7, 1), JudgeDate = new DateTime(2019, 7, 7), NotificationDate = new DateTime(2019, 7, 15), CataloguesPostedDate = new DateTime(2019, 10, 14), Circuit = lJewelsCircuit2019 };
                        lContext.SalonYears.Add(lSalonYearRubini2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/228", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearRubini2019 },
                            new AccreditationEntity() { SalonNumber = "L190073", PhotoOrganisation = lGpu, SalonYear = lSalonYearRubini2019 },
                        });

                        var lSalonYearRubini2019Mono = new SectionEntity() { SalonYear = lSalonYearRubini2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearRubini2019Colour = new SectionEntity() { SalonYear = lSalonYearRubini2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearRubini2019Landscape = new SectionEntity() { SalonYear = lSalonYearRubini2019, SectionType = lSectionTypeScapesPdi };
                        var lSalonYearRubini2019Photojournalism = new SectionEntity() { SalonYear = lSalonYearRubini2019, SectionType = lSectionTypePhotojournalismPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearRubini2019Mono,
                            lSalonYearRubini2019Colour,
                            lSalonYearRubini2019Landscape,
                            lSalonYearRubini2019Photojournalism,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 9.32M,
                                SalonYear = lSalonYearRubini2019,
                                EntryDate = new DateTime(2019, 6, 29),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Mono, Image = lPeriodDramaLeeds, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Colour, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Landscape, Image = lGrassIceland, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Landscape, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Landscape, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Landscape, Image = lGrasmereRocks, IsAwarded = false, IsAccepted = false, Score=0},
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Photojournalism, Image = lAnimatronicTRex, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Photojournalism, Image = lLightNightInflatableMen, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Photojournalism, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearRubini2019Photojournalism, Image = lTourDeYorkshireArt, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

                        var lSalonSmeraldi = new SalonEntity { Name = "Jewels - Smeraldi", Website = "http://www.photocontestclub.org/en/jewels-circ/", Country = lCountryItaly };
                        lContext.Salons.Add(lSalonSmeraldi);

                        var lSalonYearSmeraldi2019 = new SalonYearEntity { Name = "Jewels - Smeraldi", Salon = lSalonDiamanti, Year = 2019, ClosingDate = new DateTime(2019, 7, 1), JudgeDate = new DateTime(2019, 7, 7), NotificationDate = new DateTime(2019, 7, 15), CataloguesPostedDate = new DateTime(2019, 10, 14), Circuit = lJewelsCircuit2019 };
                        lContext.SalonYears.Add(lSalonYearSmeraldi2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/229", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearSmeraldi2019 },
                            new AccreditationEntity() { SalonNumber = "L190073", PhotoOrganisation = lGpu, SalonYear = lSalonYearSmeraldi2019 },
                        });

                        var lSalonYearSmeraldi2019Mono = new SectionEntity() { SalonYear = lSalonYearSmeraldi2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSmeraldi2019Colour = new SectionEntity() { SalonYear = lSalonYearSmeraldi2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSmeraldi2019Landscape = new SectionEntity() { SalonYear = lSalonYearSmeraldi2019, SectionType = lSectionTypeScapesPdi };
                        var lSalonYearSmeraldi2019Photojournalism = new SectionEntity() { SalonYear = lSalonYearSmeraldi2019, SectionType = lSectionTypePhotojournalismPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearSmeraldi2019Mono,
                            lSalonYearSmeraldi2019Colour,
                            lSalonYearSmeraldi2019Landscape,
                            lSalonYearSmeraldi2019Photojournalism,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 9.32M,
                                SalonYear = lSalonYearSmeraldi2019,
                                EntryDate = new DateTime(2019, 6, 29),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Mono, Image = lPeriodDramaLeeds, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Colour, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Landscape, Image = lGrassIceland, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Landscape, Image = lTheRedHut, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Landscape, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Landscape, Image = lGrasmereRocks, IsAwarded = false, IsAccepted = false, Score=0},
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Photojournalism, Image = lAnimatronicTRex, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Photojournalism, Image = lLightNightInflatableMen, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Photojournalism, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSmeraldi2019Photojournalism, Image = lTourDeYorkshireArt, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

                        var lSalonZaffiri = new SalonEntity { Name = "Jewels - Zaffiri", Website = "http://www.photocontestclub.org/en/jewels-circ/", Country = lCountryItaly };
                        lContext.Salons.Add(lSalonZaffiri);

                        var lSalonYearZaffiri2019 = new SalonYearEntity { Name = "Jewels - Zaffiri", Salon = lSalonZaffiri, Year = 2019, ClosingDate = new DateTime(2019, 7, 1), JudgeDate = new DateTime(2019, 7, 7), NotificationDate = new DateTime(2019, 7, 15), CataloguesPostedDate = new DateTime(2019, 10, 14), Circuit = lJewelsCircuit2019 };
                        lContext.SalonYears.Add(lSalonYearZaffiri2019);

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/230", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearZaffiri2019 },
                            new AccreditationEntity() { SalonNumber = "L190073", PhotoOrganisation = lGpu, SalonYear = lSalonYearZaffiri2019 },
                        });

                        var lSalonYearZaffiri2019Mono = new SectionEntity() { SalonYear = lSalonYearZaffiri2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearZaffiri2019Colour = new SectionEntity() { SalonYear = lSalonYearZaffiri2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearZaffiri2019Landscape = new SectionEntity() { SalonYear = lSalonYearZaffiri2019, SectionType = lSectionTypeScapesPdi };
                        var lSalonYearZaffiri2019Photojournalism = new SectionEntity() { SalonYear = lSalonYearZaffiri2019, SectionType = lSectionTypePhotojournalismPdi };


                        lContext.SalonSections.AddRange(new List<SectionEntity> {
                            lSalonYearZaffiri2019Mono,
                            lSalonYearZaffiri2019Colour,
                            lSalonYearZaffiri2019Landscape,
                            lSalonYearZaffiri2019Photojournalism,
                         });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 9.32M,
                                SalonYear = lSalonYearZaffiri2019,
                                EntryDate = new DateTime(2019, 6, 29),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Mono, Image = lPeriodDramaLeeds, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Colour, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Landscape, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Landscape, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Landscape, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Landscape, Image = lGrasmereRocks, IsAwarded = false, IsAccepted = false, Score=0},
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Photojournalism, Image = lAnimatronicTRex, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Photojournalism, Image = lLightNightInflatableMen, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Photojournalism, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZaffiri2019Photojournalism, Image = lTourDeYorkshireArt, IsAwarded = false, IsAccepted = false, Score=0},
                                },
                            },
                        });

                        // Shadowhunter Circuit 2019
                        var lShadowhunterCircuit2019 = new CircuitEntity() { Name = "Shadowhunter" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                            lShadowhunterCircuit2019,
                        });

                        var lPortal = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Portal" };
                        var lBagLady = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bag Lady" };
                        var lItsAllAboutTheHair = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "It's All About The Hair" };
                        var lShadowLight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Shadow Light" };
                        var lRealityDysfunction = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Reality Dysfunction" };
                        var lTheFinalGateway = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Final Gateway" };

                        var lSalonShadowHunterSerbia = new SalonEntity { Name = "Shadowhunter - Serbia", Website = "https://shadowhunter.lumiere.at/", Country = lCountrySerbia };

                        var lSalonYearShadowHunterSerbia2019 = new SalonYearEntity { Name = "Shadowhunter - Serbia", Salon = lSalonShadowHunterSerbia, Year = 2019, ClosingDate = new DateTime(2019, 7, 12), JudgeDate = new DateTime(2019, 7, 30), NotificationDate = new DateTime(2019, 8, 10), CataloguesPostedDate = new DateTime(2019, 8, 10), Circuit = lShadowhunterCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/211", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearShadowHunterSerbia2019 },
                            new AccreditationEntity() { SalonNumber = "2019-290", PhotoOrganisation = lPsa, SalonYear = lSalonYearShadowHunterSerbia2019 },
                        });

                        var lSalonYearShadowHunterSerbia2019Mono = new SectionEntity() { SalonYear = lSalonYearShadowHunterSerbia2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearShadowHunterSerbia2019Colour = new SectionEntity() { SalonYear = lSalonYearShadowHunterSerbia2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearShadowHunterSerbia2019ShadowHunter = new SectionEntity() { SalonYear = lSalonYearShadowHunterSerbia2019, SectionType = lSectionTypeGoodLightPdi };
                        var lSalonYearShadowHunterSerbia2019Nature = new SectionEntity() { SalonYear = lSalonYearShadowHunterSerbia2019, SectionType = lSectionTypeNaturePdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.51M,
                                SalonYear = lSalonYearShadowHunterSerbia2019,
                                EntryDate = new DateTime(2019, 7, 6),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019ShadowHunter, Image = lPortal, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019ShadowHunter, Image = lBagLady, IsAwarded = false, IsAccepted = true, Score= 19},
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019ShadowHunter, Image = lItsAllAboutTheHair, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019ShadowHunter, Image = lShadowLight, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score= 14},
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Colour, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score=21},
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterSerbia2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=18},
                                },
                            },
                        });

                        var lSalonShadowHunterMontenegro = new SalonEntity { Name = "Shadowhunter - Montenegro", Website = "https://shadowhunter.lumiere.at/", Country = lCountryMontenegro };

                        var lSalonYearShadowHunterMontenegro2019 = new SalonYearEntity { Name = "Shadowhunter - Montenegro", Salon = lSalonShadowHunterMontenegro, Year = 2019, ClosingDate = new DateTime(2019, 7, 12), JudgeDate = new DateTime(2019, 7, 30), NotificationDate = new DateTime(2019, 8, 10), CataloguesPostedDate = new DateTime(2019, 8, 10), Circuit = lShadowhunterCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/213", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearShadowHunterMontenegro2019 },
                            new AccreditationEntity() { SalonNumber = "2019-290", PhotoOrganisation = lPsa, SalonYear = lSalonYearShadowHunterMontenegro2019 },
                        });

                        var lSalonYearShadowHunterMontenegro2019Mono = new SectionEntity() { SalonYear = lSalonYearShadowHunterMontenegro2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearShadowHunterMontenegro2019Colour = new SectionEntity() { SalonYear = lSalonYearShadowHunterMontenegro2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearShadowHunterMontenegro2019ShadowHunter = new SectionEntity() { SalonYear = lSalonYearShadowHunterMontenegro2019, SectionType = lSectionTypeGoodLightPdi };
                        var lSalonYearShadowHunterMontenegro2019Nature = new SectionEntity() { SalonYear = lSalonYearShadowHunterMontenegro2019, SectionType = lSectionTypeNaturePdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.49M,
                                SalonYear = lSalonYearShadowHunterMontenegro2019,
                                EntryDate = new DateTime(2019, 7, 6),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019ShadowHunter, Image = lPortal, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019ShadowHunter, Image = lBagLady, IsAwarded = false, IsAccepted = false, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019ShadowHunter, Image = lItsAllAboutTheHair, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019ShadowHunter, Image = lShadowLight, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Colour, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=17},
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterMontenegro2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=22},
                                },
                            },
                        });

                        var lSalonShadowHunterCroatia = new SalonEntity { Name = "Shadowhunter - Croatia", Website = "https://shadowhunter.lumiere.at/", Country = lCountryCroatia };

                        var lSalonYearShadowHunterCroatia2019 = new SalonYearEntity { Name = "Shadowhunter - Croatia", Salon = lSalonShadowHunterCroatia, Year = 2019, ClosingDate = new DateTime(2019, 7, 12), JudgeDate = new DateTime(2019, 7, 30), NotificationDate = new DateTime(2019, 8, 10), CataloguesPostedDate = new DateTime(2019, 8, 10), Circuit = lShadowhunterCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/212", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearShadowHunterCroatia2019 },
                            new AccreditationEntity() { SalonNumber = "2019-290", PhotoOrganisation = lPsa, SalonYear = lSalonYearShadowHunterCroatia2019 },
                        });

                        var lSalonYearShadowHunterCroatia2019Mono = new SectionEntity() { SalonYear = lSalonYearShadowHunterCroatia2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearShadowHunterCroatia2019Colour = new SectionEntity() { SalonYear = lSalonYearShadowHunterCroatia2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearShadowHunterCroatia2019ShadowHunter = new SectionEntity() { SalonYear = lSalonYearShadowHunterCroatia2019, SectionType = lSectionTypeGoodLightPdi };
                        var lSalonYearShadowHunterCroatia2019Nature = new SectionEntity() { SalonYear = lSalonYearShadowHunterCroatia2019, SectionType = lSectionTypeNaturePdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.49M,
                                SalonYear = lSalonYearShadowHunterCroatia2019,
                                EntryDate = new DateTime(2019, 7, 6),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019ShadowHunter, Image = lPortal, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019ShadowHunter, Image = lBagLady, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019ShadowHunter, Image = lItsAllAboutTheHair, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019ShadowHunter, Image = lShadowLight, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Colour, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=20},
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Mono, Image = lTheFinalGateway, IsAwarded = true, AwardDetails="PSA HM", IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearShadowHunterCroatia2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=19},
                                },
                            },
                        });

                        // Midland Counties 2019
                        var lSalonMidlandCounties = new SalonEntity { Name = "Midland", Website = "http://www.midland-salon.com/", Country = lCountryEngland };

                        var lSalonMidlandCounties2019 = new SalonYearEntity { Name = "Midland", Salon = lSalonMidlandCounties, Year = 2019, ClosingDate = new DateTime(2019, 7, 14), JudgeDate = new DateTime(2019, 7, 21), NotificationDate = new DateTime(2019, 7, 26), CataloguesPostedDate = new DateTime(2019, 9, 13) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/241", PhotoOrganisation = lFiapLevels, SalonYear = lSalonMidlandCounties2019 },
                            new AccreditationEntity() { SalonNumber = "2019-304", PhotoOrganisation = lPsa, SalonYear = lSalonMidlandCounties2019 },
                            new AccreditationEntity() { SalonNumber = "L190072 M6G 6S", PhotoOrganisation = lGpu, SalonYear = lSalonMidlandCounties2019 },
                        });


                        var lSalonYearMidlandCounties2019Nature = new SectionEntity() { SalonYear = lSalonMidlandCounties2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearMidlandCounties2019Mono = new SectionEntity() { SalonYear = lSalonMidlandCounties2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearMidlandCounties201Colour = new SectionEntity() { SalonYear = lSalonMidlandCounties2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearMidlandCounties2019Creative = new SectionEntity() { SalonYear = lSalonMidlandCounties2019, SectionType = lSectionTypeCreativePdi };

                        var lJourneysEnd = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Journey's End" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 20.00M,
                                SalonYear = lSalonMidlandCounties2019,
                                EntryDate = new DateTime(2019, 7, 7),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=12},
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties201Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties201Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties201Colour, Image = lWartimeLettersHome, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties201Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Creative, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearMidlandCounties2019Creative, Image = lJourneysEnd, IsAwarded = false, IsAccepted = false, Score=10 },
                                },
                            },
                        });

                        // South Devon 2019
                        var lSalonSouthDevon2019 = new SalonYearEntity { Name = "South Devon", Salon = lSalonSouthDevon, Year = 2019, ClosingDate = new DateTime(2019, 7, 14), JudgeDate = new DateTime(2019, 7, 28), NotificationDate = new DateTime(2019, 8, 7), CataloguesPostedDate = new DateTime(2019, 10, 5) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/210", PhotoOrganisation = lFiapLevels, SalonYear = lSalonSouthDevon2019 },
                            new AccreditationEntity() { SalonNumber = "2019-306", PhotoOrganisation = lPsa, SalonYear = lSalonSouthDevon2019 },
                            new AccreditationEntity() { SalonNumber = "L190064", PhotoOrganisation = lGpu, SalonYear = lSalonSouthDevon2019 },
                        });


                        var lSalonYearSouthDevon2019Nature = new SectionEntity() { SalonYear = lSalonSouthDevon2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearSouthDevon2019Mono = new SectionEntity() { SalonYear = lSalonSouthDevon2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSouthDevon201Colour = new SectionEntity() { SalonYear = lSalonSouthDevon2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSouthDevon2019Creative = new SectionEntity() { SalonYear = lSalonSouthDevon2019, SectionType = lSectionTypeCreativePdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 20.00M,
                                SalonYear = lSalonSouthDevon2019,
                                EntryDate = new DateTime(2019, 7, 7),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 8},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=10},
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon201Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon201Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon201Colour, Image = lWartimeLettersHome, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon201Colour, Image = lBLuebellInWoodenVase, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Creative, Image = lTimeFlies, IsAwarded = false, IsAccepted = true, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearSouthDevon2019Creative, Image = lJourneysEnd, IsAwarded = false, IsAccepted = false, Score=10 },
                                },
                            },
                        });

                        // Balkan Frame Circuit 2019
                        var lBalkanFrameCircuit2019 = new CircuitEntity() { Name = "Balkan Frame" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                            lBalkanFrameCircuit2019,
                        });

                        var lTarantulaWarning = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tarantula Warning" };


                        var lSalonBalkanFramePerasto = new SalonEntity { Name = "Balkan Frame - Perasto", Website = "https://www.exhibitions.photo/?pg=6#cmain", Country = lCountryMontenegro };

                        var lSalonYearBalkanFramePerasto2019 = new SalonYearEntity { Name = "Balkan Frame - Perasto", Salon = lSalonBalkanFramePerasto, Year = 2019, ClosingDate = new DateTime(2019, 7, 14), JudgeDate = new DateTime(2019, 7, 31), NotificationDate = new DateTime(2019, 8, 6), CataloguesPostedDate = new DateTime(2019, 10, 15), Circuit = lBalkanFrameCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/410", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearBalkanFramePerasto2019 },
                            new AccreditationEntity() { SalonNumber = "2019-313", PhotoOrganisation = lPsa, SalonYear = lSalonYearBalkanFramePerasto2019 },
                        });

                        var lSalonYearBalkanFramePerasto2019Mono = new SectionEntity() { SalonYear = lSalonYearBalkanFramePerasto2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearBalkanFramePerasto2019Colour = new SectionEntity() { SalonYear = lSalonYearBalkanFramePerasto2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearBalkanFramePerasto2019Travel = new SectionEntity() { SalonYear = lSalonYearBalkanFramePerasto2019, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearBalkanFramePerasto2019People = new SectionEntity() { SalonYear = lSalonYearBalkanFramePerasto2019, SectionType = lSectionTypePeoplePdi };
                        var lSalonYearBalkanFramePerasto2019Nature = new SectionEntity() { SalonYear = lSalonYearBalkanFramePerasto2019, SectionType = lSectionTypeNaturePdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 14.34M,
                                SalonYear = lSalonYearBalkanFramePerasto2019,
                                EntryDate = new DateTime(2019, 7, 13),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019People, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019People, Image = lWaitingToTravel, IsAwarded = false, IsAccepted = false, Score= 15},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019People, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019People, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Nature, Image = lRedFox, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Nature, Image = lTarantulaWarning, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Colour, Image = lBLuebellInWoodenVase, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Colour, Image = lJourneysEnd, IsAwarded = false, IsAccepted = false, Score=15},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFramePerasto2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=17},
                                },
                            },
                        });

                        var lSalonBalkanFrameElema = new SalonEntity { Name = "Balkan Frame - Elema", Website = "https://www.exhibitions.photo/?pg=6#cmain", Country = lCountryMacedonia };

                        var lSalonYearBalkanFrameElema2019 = new SalonYearEntity { Name = "Balkan Frame - Elema", Salon = lSalonBalkanFrameElema, Year = 2019, ClosingDate = new DateTime(2019, 7, 14), JudgeDate = new DateTime(2019, 7, 31), NotificationDate = new DateTime(2019, 8, 6), CataloguesPostedDate = new DateTime(2019, 10, 15), Circuit = lBalkanFrameCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/411", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearBalkanFrameElema2019 },
                            new AccreditationEntity() { SalonNumber = "2019-313", PhotoOrganisation = lPsa, SalonYear = lSalonYearBalkanFrameElema2019 },
                        });

                        var lSalonYearBalkanFrameElema2019Mono = new SectionEntity() { SalonYear = lSalonYearBalkanFrameElema2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearBalkanFrameElema2019Colour = new SectionEntity() { SalonYear = lSalonYearBalkanFrameElema2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearBalkanFrameElema2019Travel = new SectionEntity() { SalonYear = lSalonYearBalkanFrameElema2019, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearBalkanFrameElema2019People = new SectionEntity() { SalonYear = lSalonYearBalkanFrameElema2019, SectionType = lSectionTypePeoplePdi };
                        var lSalonYearBalkanFrameElema2019Nature = new SectionEntity() { SalonYear = lSalonYearBalkanFrameElema2019, SectionType = lSectionTypeNaturePdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 14.33M,
                                SalonYear = lSalonYearBalkanFrameElema2019,
                                EntryDate = new DateTime(2019, 7, 13),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Travel, Image = lTheRedHut, IsAwarded = true, AwardDetails="FK ELEMA HM", IsAccepted = true, Score=23 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score= 13},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019People, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019People, Image = lWaitingToTravel, IsAwarded = false, IsAccepted = false, Score= 15},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019People, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019People, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Nature, Image = lCrestedGeckoTongue, IsAwarded = true, AwardDetails="FIAP HM", IsAccepted = true, Score=25 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Nature, Image = lRedFox, IsAwarded = false, IsAccepted = false, Score= 15},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Nature, Image = lTarantulaWarning, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Colour, Image = lBLuebellInWoodenVase, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Colour, Image = lJourneysEnd, IsAwarded = false, IsAccepted = false, Score=13},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameElema2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score=20},
                                },
                            },
                        });

                        var lSalonBalkanFrameCacak = new SalonEntity { Name = "Balkan Frame - Cacak", Website = "https://www.exhibitions.photo/?pg=6#cmain", Country = lCountrySerbia };

                        var lSalonYearBalkanFrameCacak2019 = new SalonYearEntity { Name = "Balkan Frame - Cacak", Salon = lSalonBalkanFrameCacak, Year = 2019, ClosingDate = new DateTime(2019, 7, 14), JudgeDate = new DateTime(2019, 7, 31), NotificationDate = new DateTime(2019, 8, 6), CataloguesPostedDate = new DateTime(2019, 10, 15), Circuit = lBalkanFrameCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/412", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearBalkanFrameCacak2019 },
                            new AccreditationEntity() { SalonNumber = "2019-313", PhotoOrganisation = lPsa, SalonYear = lSalonYearBalkanFrameCacak2019 },
                        });

                        var lSalonYearBalkanFrameCacak2019Mono = new SectionEntity() { SalonYear = lSalonYearBalkanFrameCacak2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearBalkanFrameCacak2019Colour = new SectionEntity() { SalonYear = lSalonYearBalkanFrameCacak2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearBalkanFrameCacak2019Travel = new SectionEntity() { SalonYear = lSalonYearBalkanFrameCacak2019, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearBalkanFrameCacak2019People = new SectionEntity() { SalonYear = lSalonYearBalkanFrameCacak2019, SectionType = lSectionTypePeoplePdi };
                        var lSalonYearBalkanFrameCacak2019Nature = new SectionEntity() { SalonYear = lSalonYearBalkanFrameCacak2019, SectionType = lSectionTypeNaturePdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 14.33M,
                                SalonYear = lSalonYearBalkanFrameCacak2019,
                                EntryDate = new DateTime(2019, 7, 13),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score= 15},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Travel, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019People, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019People, Image = lWaitingToTravel, IsAwarded = false, IsAccepted = true, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019People, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019People, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Nature, Image = lRedFox, IsAwarded = false, IsAccepted = false, Score= 16},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Nature, Image = lTarantulaWarning, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Colour, Image = lBLuebellInWoodenVase, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Colour, Image = lJourneysEnd, IsAwarded = false, IsAccepted = false, Score=16},
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearBalkanFrameCacak2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=19},
                                },
                            },
                        });

                        // Beauty 2019
                        var lSymmetricalOrangeFlower = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Symmetrical Orange Flower" };

                        var lSalonBeauty = new SalonEntity { Name = "Beauty", Website = "http://fotografija.rs/2nd-contest-of-photography-beauty-2019/", Country = lCountrySerbia };

                        var lSalonYearBeauty2019 = new SalonYearEntity { Name = "Beauty", Salon = lSalonBeauty, Year = 2019, ClosingDate = new DateTime(2019, 7, 22), JudgeDate = new DateTime(2019, 8, 5), NotificationDate = new DateTime(2019, 8, 15), CataloguesPostedDate = new DateTime(2019, 10, 21) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/421", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearBeauty2019 },
                        });


                        var lSalonYearBeauty2019Nature = new SectionEntity() { SalonYear = lSalonYearBeauty2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearBeauty2019Colour = new SectionEntity() { SalonYear = lSalonYearBeauty2019, SectionType = lSectionTypeColourPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 11.24M,
                                SalonYear = lSalonYearBeauty2019,
                                EntryDate = new DateTime(2019, 7, 20),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBeauty2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeauty2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearBeauty2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeauty2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeauty2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeauty2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeauty2019Colour, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBeauty2019Colour, Image = lSymmetricalOrangeFlower, IsAwarded = false, IsAccepted = false, Score=0 },
                                },
                            },
                        });

                        // Bon Voyage 2019
                        var lSalonBonVoyage = new SalonEntity { Name = "Bon Voyage", Website = "https://www.photoclub202.com/", Country = lCountrySerbia };

                        var lSalonYearBonVoyage2019 = new SalonYearEntity { Name = "Bon Voyage", Salon = lSalonBonVoyage, Year = 2019, ClosingDate = new DateTime(2019, 7, 23), JudgeDate = new DateTime(2019, 8, 6), NotificationDate = new DateTime(2019, 8, 16), CataloguesPostedDate = new DateTime(2019, 10, 22) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/420", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearBonVoyage2019 },
                        });


                        var lSalonYearBonVoyage2019Travel = new SectionEntity() { SalonYear = lSalonYearBonVoyage2019, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearBonVoyage2019Colour = new SectionEntity() { SalonYear = lSalonYearBonVoyage2019, SectionType = lSectionTypeColourPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 11.24M,
                                SalonYear = lSalonYearBonVoyage2019,
                                EntryDate = new DateTime(2019, 7, 20),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearBonVoyage2019Travel, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBonVoyage2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearBonVoyage2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBonVoyage2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBonVoyage2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBonVoyage2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBonVoyage2019Colour, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearBonVoyage2019Colour, Image = lSymmetricalOrangeFlower, IsAwarded = false, IsAccepted = false, Score=0 },
                                },
                            },
                        });

                        // Sunflower 2019
                        var lSalonSunflower = new SalonEntity { Name = "Sunflower", Website = "http://sunflower.photosalon.cz/", Country = lCountryCzechRep };

                        var lSalonYearSunflower2019 = new SalonYearEntity { Name = "Sunflower", Salon = lSalonSunflower, Year = 2019, ClosingDate = new DateTime(2019, 7, 31), JudgeDate = new DateTime(2019, 8, 11), NotificationDate = new DateTime(2019, 8, 25), CataloguesPostedDate = new DateTime(2019, 10, 31) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/262", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearSunflower2019 },
                            new AccreditationEntity() { SalonNumber = "2019-307", PhotoOrganisation = lPsa, SalonYear = lSalonYearSunflower2019 },
                        });

                        var lDaisyInWoodenVase = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Daisy In Wooden Vase" };
                        var lAbstractFirebird = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Abstract Firebird" };
                        var lEngineDriver = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Engine Driver" };


                        var lSalonYearSunflower2019Mono = new SectionEntity() { SalonYear = lSalonYearSunflower2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearSunflower2019Colour = new SectionEntity() { SalonYear = lSalonYearSunflower2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearSunflower2019Nature = new SectionEntity() { SalonYear = lSalonYearSunflower2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearSunflower2019Portrait = new SectionEntity() { SalonYear = lSalonYearSunflower2019, SectionType = lSectionTypePortraitPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 32.68M,
                                SalonYear = lSalonYearSunflower2019,
                                EntryDate = new DateTime(2019, 7, 27),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Colour, Image = lDaisyInWoodenVase, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Colour, Image = lAbstractFirebird, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Nature, Image = lAmazonMilkFrog, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Portrait, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Portrait, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Portrait, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearSunflower2019Portrait, Image = lEngineDriver, IsAwarded = false, IsAccepted = true, Score=0 },
                                },
                            },
                        });

                        // This Is Life Finland 2019
                        var lSalonThisIsLife = new SalonEntity { Name = "This Is Life", Website = "https://www.thisislife.fi/", Country = lCountryFinland };

                        var lSalonYearThisIsLife2019 = new SalonYearEntity { Name = "This Is Life", Salon = lSalonThisIsLife, Year = 2019, ClosingDate = new DateTime(2019, 7, 31), JudgeDate = new DateTime(2019, 8, 4), NotificationDate = new DateTime(2019, 8, 5), CataloguesPostedDate = new DateTime(2019, 9, 2) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/364", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearThisIsLife2019 },
                        });

                        var lSynapse = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Synapse" };



                        var lSalonYearThisIsLife2019Mono = new SectionEntity() { SalonYear = lSalonYearThisIsLife2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearThisIsLife2019Colour = new SectionEntity() { SalonYear = lSalonYearThisIsLife2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearThisIsLife2019Nature = new SectionEntity() { SalonYear = lSalonYearThisIsLife2019, SectionType = lSectionTypeNaturePdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 28.01M,
                                SalonYear = lSalonYearThisIsLife2019,
                                EntryDate = new DateTime(2019, 7, 27),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score= 12},
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=6 },
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Colour, Image = lTimeFlies, IsAwarded = false, IsAccepted = true, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Colour, Image = lSynapse, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = true, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Nature, Image = lTarantulaWarning, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearThisIsLife2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score=12 },
                                },
                            },
                        });

                        // Pacific Atlantic Circuit 2019
                        var lPacificAtlanticCircuit2019 = new CircuitEntity() { Name = "Pacific Atlantic" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                            lPacificAtlanticCircuit2019,
                        });

                        var lTheStuffOfNightmares = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Stuff of Nightmares" };
                        var lTimeGate = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Time Gate" };
                        var lEnteringTheMaelstrom = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Entering The Maelstrom" };
                        var lCrestedGeckoLook = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Crested Gecko Look" };


                        var lSalonPacificAtlanticGreece = new SalonEntity { Name = "Pacific Atlantic - Greece", Website = "http://www.pacificatlantic-photo.com/", Country = lCountryGreece };

                        var lSalonYearPacificAtlanticGreece2019 = new SalonYearEntity { Name = "Pacific Atlantic - Greece", Salon = lSalonPacificAtlanticGreece, Year = 2019, ClosingDate = new DateTime(2019, 9, 1), JudgeDate = new DateTime(2019, 9, 7), NotificationDate = new DateTime(2019, 9, 20), CataloguesPostedDate = new DateTime(2019, 10, 20), Circuit = lPacificAtlanticCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/487", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearPacificAtlanticGreece2019 },
                            new AccreditationEntity() { SalonNumber = "2019-366", PhotoOrganisation = lPsa, SalonYear = lSalonYearPacificAtlanticGreece2019 },
                            new AccreditationEntity() { SalonNumber = "L190140", PhotoOrganisation = lGpu, SalonYear = lSalonYearPacificAtlanticGreece2019 },
                        });

                        var lSalonYearPacificAtlanticGreece2019Mono = new SectionEntity() { SalonYear = lSalonYearPacificAtlanticGreece2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPacificAtlanticGreece2019Colour = new SectionEntity() { SalonYear = lSalonYearPacificAtlanticGreece2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPacificAtlanticGreece2019Nature = new SectionEntity() { SalonYear = lSalonYearPacificAtlanticGreece2019, SectionType = lSectionTypeNaturePdi };



                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.06M,
                                SalonYear = lSalonYearPacificAtlanticGreece2019,
                                EntryDate = new DateTime(2019, 8, 11),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Colour, Image = lTheStuffOfNightmares, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Colour, Image = lTimeGate, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Colour, Image = lEnteringTheMaelstrom, IsAwarded = false, IsAccepted = true, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Colour, Image = lDaisyInWoodenVase, IsAwarded = false, IsAccepted = true, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score= 14},
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Nature, Image = lRedFox, IsAwarded = false, IsAccepted = false, Score= 13},
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticGreece2019Nature, Image = lCrestedGeckoLook, IsAwarded = false, IsAccepted = true, Score=19 },
                                },
                            },
                        });

                        var lSalonPacificAtlanticUsa = new SalonEntity { Name = "Pacific Atlantic - USA", Website = "http://www.pacificatlantic-photo.com/", Country = lCountryUsa };

                        var lSalonYearPacificAtlanticUsa2019 = new SalonYearEntity { Name = "Pacific Atlantic - USA", Salon = lSalonPacificAtlanticUsa, Year = 2019, ClosingDate = new DateTime(2019, 9, 1), JudgeDate = new DateTime(2019, 9, 7), NotificationDate = new DateTime(2019, 9, 20), CataloguesPostedDate = new DateTime(2019, 10, 20), Circuit = lPacificAtlanticCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/486", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearPacificAtlanticUsa2019 },
                            new AccreditationEntity() { SalonNumber = "2019-366", PhotoOrganisation = lPsa, SalonYear = lSalonYearPacificAtlanticUsa2019 },
                            new AccreditationEntity() { SalonNumber = "L190140", PhotoOrganisation = lGpu, SalonYear = lSalonYearPacificAtlanticUsa2019 },
                        });

                        var lSalonYearPacificAtlanticUsa2019Mono = new SectionEntity() { SalonYear = lSalonYearPacificAtlanticUsa2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPacificAtlanticUsa2019Colour = new SectionEntity() { SalonYear = lSalonYearPacificAtlanticUsa2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPacificAtlanticUsa2019Nature = new SectionEntity() { SalonYear = lSalonYearPacificAtlanticUsa2019, SectionType = lSectionTypeNaturePdi };



                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.06M,
                                SalonYear = lSalonYearPacificAtlanticUsa2019,
                                EntryDate = new DateTime(2019, 8, 11),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Colour, Image = lTheStuffOfNightmares, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Colour, Image = lTimeGate, IsAwarded = false, IsAccepted = false, Score= 13},
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Colour, Image = lDaisyInWoodenVase, IsAwarded = false, IsAccepted = true, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Colour, Image = lEnteringTheMaelstrom, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=11 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score= 14},
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=13 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Nature, Image = lRedFox, IsAwarded = false, IsAccepted = false, Score= 13},
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticUsa2019Nature, Image = lCrestedGeckoLook, IsAwarded = false, IsAccepted = false, Score=12 },
                                },
                            },
                        });

                        var lSalonPacificAtlanticSingapore = new SalonEntity { Name = "Pacific Atlantic - Singapore", Website = "http://www.pacificatlantic-photo.com/", Country = lCountrySingapore };

                        var lSalonYearPacificAtlanticSingapore2019 = new SalonYearEntity { Name = "Pacific Atlantic - Singapore", Salon = lSalonPacificAtlanticSingapore, Year = 2019, ClosingDate = new DateTime(2019, 9, 1), JudgeDate = new DateTime(2019, 9, 7), NotificationDate = new DateTime(2019, 9, 20), CataloguesPostedDate = new DateTime(2019, 10, 20), Circuit = lPacificAtlanticCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/488", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearPacificAtlanticSingapore2019 },
                            new AccreditationEntity() { SalonNumber = "2019-366", PhotoOrganisation = lPsa, SalonYear = lSalonYearPacificAtlanticSingapore2019 },
                            new AccreditationEntity() { SalonNumber = "L190140", PhotoOrganisation = lGpu, SalonYear = lSalonYearPacificAtlanticSingapore2019 },
                        });

                        var lSalonYearPacificAtlanticSingapore2019Mono = new SectionEntity() { SalonYear = lSalonYearPacificAtlanticSingapore2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPacificAtlanticSingapore2019Colour = new SectionEntity() { SalonYear = lSalonYearPacificAtlanticSingapore2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPacificAtlanticSingapore2019Nature = new SectionEntity() { SalonYear = lSalonYearPacificAtlanticSingapore2019, SectionType = lSectionTypeNaturePdi };



                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 12.07M,
                                SalonYear = lSalonYearPacificAtlanticSingapore2019,
                                EntryDate = new DateTime(2019, 8, 11),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Colour, Image = lTheStuffOfNightmares, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Colour, Image = lTimeGate, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Colour, Image = lDaisyInWoodenVase, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Colour, Image = lEnteringTheMaelstrom, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score= 14},
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Nature, Image = lRedFox, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearPacificAtlanticSingapore2019Nature, Image = lCrestedGeckoLook, IsAwarded = false, IsAccepted = false, Score=13 },
                                },
                            },
                        });

                        // Northern counties 2019
                        var lSalonPacificNorthernCounties = new SalonEntity { Name = "Northern Counties", Website = "http://www.northerncountiessalon.org.uk/index.php", Country = lCountryEngland };

                        var lSalonYearNorthernCounties2019 = new SalonYearEntity { Name = "Northern Counties", Salon = lSalonPacificNorthernCounties, Year = 2019, ClosingDate = new DateTime(2019, 8, 25), JudgeDate = new DateTime(2019, 9, 14), NotificationDate = new DateTime(2019, 9, 28), CataloguesPostedDate = new DateTime(2019, 11, 28) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                new AccreditationEntity() { SalonNumber = "2019/298", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearNorthernCounties2019 },
                                new AccreditationEntity() { SalonNumber = "2019-309", PhotoOrganisation = lPsa, SalonYear = lSalonYearNorthernCounties2019 },
                                new AccreditationEntity() { SalonNumber = "L190094", PhotoOrganisation = lGpu, SalonYear = lSalonYearNorthernCounties2019 },
                        });

                        var lSalonYearNorthernCounties2019Mono = new SectionEntity() { SalonYear = lSalonYearNorthernCounties2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearNorthernCounties2019Colour = new SectionEntity() { SalonYear = lSalonYearNorthernCounties2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearNorthernCounties2019Nature = new SectionEntity() { SalonYear = lSalonYearNorthernCounties2019, SectionType = lSectionTypeNaturePdi };


                        var lAKissByMoonlight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "A Kiss By Moonlight" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 18M,
                                SalonYear = lSalonYearNorthernCounties2019,
                                EntryDate = new DateTime(2019, 8, 17),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Colour, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Colour, Image = lMonsterPhotoBooth, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Colour, Image = lAKissByMoonlight, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNorthernCounties2019Nature, Image = lCrestedGeckoLook, IsAwarded = false, IsAccepted = false, Score=0 },
                                },
                            },
                        });

                        // Gold Camera 2019
                        var lSalonPacificGoldCamera = new SalonEntity { Name = "Gold Camera", Website = "http://camera.fotolcinium.com", Country = lCountryMontenegro };

                        var lSalonYearGoldCamera2019 = new SalonYearEntity { Name = "Gold Camera", Salon = lSalonPacificGoldCamera, Year = 2019, ClosingDate = new DateTime(2019, 8, 31), JudgeDate = new DateTime(2019, 9, 20), NotificationDate = new DateTime(2019, 9, 30), CataloguesPostedDate = new DateTime(2019, 11, 15) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/308", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearGoldCamera2019 },
                            new AccreditationEntity() { SalonNumber = "2019-376", PhotoOrganisation = lPsa, SalonYear = lSalonYearGoldCamera2019 }
                        });

                        var lSalonYearGoldCamera2019Colour = new SectionEntity() { SalonYear = lSalonYearGoldCamera2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearGoldCamera2019Mono = new SectionEntity() { SalonYear = lSalonYearGoldCamera2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearGoldCamera2019Woman = new SectionEntity() { SalonYear = lSalonYearGoldCamera2019, SectionType = lSectionTypeWomanPdi };
                        var lSalonYearGoldCamera2019Nature = new SectionEntity() { SalonYear = lSalonYearGoldCamera2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearGoldCamera2019Travel = new SectionEntity() { SalonYear = lSalonYearGoldCamera2019, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearGoldCamera2019Photojournalism = new SectionEntity() { SalonYear = lSalonYearGoldCamera2019, SectionType = lSectionTypePhotojournalismPdi };


                        var lADaisyInMono = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "A Daisy In Mono" };
                        var iIcelandicLines = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Icelandic Lines" };
                        var lPyramidInTheSnow = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Pyramid in the Snow" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 23.91M,
                                SalonYear = lSalonYearGoldCamera2019,
                                EntryDate = new DateTime(2019, 8, 21),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Colour, Image = lChiveFlower, IsAwarded = false, IsAccepted = true, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Colour, Image = lEnteringTheMaelstrom, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Colour, Image = lAKissByMoonlight, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Mono, Image = lADaisyInMono, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Woman, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Woman, Image = lByLamplight, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Woman, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Woman, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = false, Score=19 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Nature, Image = lCrestedGeckoLook, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Travel, Image = iIcelandicLines, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = true, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Travel, Image = lPyramidInTheSnow, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = true, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Photojournalism, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Photojournalism, Image = lItsAllAboutTheHair, IsAwarded = false, IsAccepted = true, Score= 21},
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Photojournalism, Image = lTourDeYorkshireArt, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearGoldCamera2019Photojournalism, Image = lLightNightInflatableMen, IsAwarded = false, IsAccepted = false, Score=18 },
                                },
                            },
                        });

                        // Narava 2019
                        var lSalonNarava = new SalonEntity { Name = "Narava", Website = "http://www.fotodrustvo-grca.si/narava.html", Country = lCountrySlovenia };

                        var lSalonYearNarava2019 = new SalonYearEntity { Name = "Narava", Salon = lSalonNarava, Year = 2019, ClosingDate = new DateTime(2019, 8, 29), JudgeDate = new DateTime(2019, 9, 8), NotificationDate = new DateTime(2019, 9, 15), CataloguesPostedDate = new DateTime(2019, 10, 30) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/291", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearNarava2019 },
                            new AccreditationEntity() { SalonNumber = "2019-422", PhotoOrganisation = lPsa, SalonYear = lSalonYearNarava2019 },
                        });

                        var lSalonYearNarava2019Open = new SectionEntity() { SalonYear = lSalonYearNarava2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearNarava2019Scapes = new SectionEntity() { SalonYear = lSalonYearNarava2019, SectionType = lSectionTypeScapesPdi };
                        var lSalonYearNarava2019Nature = new SectionEntity() { SalonYear = lSalonYearNarava2019, SectionType = lSectionTypeNaturePdi };


                        var lSingleYellowRose = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Single Yellow Rose" };
                        var lMossyFrogOnBranch = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Mossy Frog On Branch" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 23.75M,
                                SalonYear = lSalonYearNarava2019,
                                EntryDate = new DateTime(2019, 8, 26),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Open, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Open, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Open, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Open, Image = lSingleYellowRose, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Scapes, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Scapes, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Scapes, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Scapes, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Nature, Image = lContentedOwl, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearNarava2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score=0 },

                                },
                            },
                        });

                        // Lanterna Magica 2019
                        var lSalonLanternaMagica = new SalonEntity { Name = "Lanterna Magica", Website = "https://www.lanternamagica.dk", Country = lCountryDenmark };

                        var lSalonYearLanternaMagica2019 = new SalonYearEntity { Name = "Lanterna Magica", Salon = lSalonLanternaMagica, Year = 2019, ClosingDate = new DateTime(2019, 9, 7), JudgeDate = new DateTime(2019, 9, 22), NotificationDate = new DateTime(2019, 10, 6), CataloguesPostedDate = new DateTime(2019, 12, 1) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/274", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearLanternaMagica2019 },
                            new AccreditationEntity() { SalonNumber = "2019-335", PhotoOrganisation = lPsa, SalonYear = lSalonYearLanternaMagica2019 },
                        });

                        var lSalonYearLanternaMagica2019Colour = new SectionEntity() { SalonYear = lSalonYearLanternaMagica2019, SectionType = lSectionTypeColourPrint };
                        var lSalonYearLanternaMagica2019Mono = new SectionEntity() { SalonYear = lSalonYearLanternaMagica2019, SectionType = lSectionTypeMonoPrint };
                        var lSalonYearLanternaMagica2019Horror = new SectionEntity() { SalonYear = lSalonYearLanternaMagica2019, SectionType = lSectionTypeColourPrint };


                        var lClownOfFear = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Clown  of Fear" };
                        var lMistressOfPain = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Mistress of Pain" };
                        var lZombieLunch = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zombie Lunch" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 27.53M + 4.60M,
                                SalonYear = lSalonYearLanternaMagica2019,
                                EntryDate = new DateTime(2019, 9, 5),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Colour, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Colour, Image = lEnteringTheMaelstrom, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Horror, Image = lClownOfFear, IsAwarded = true, AwardDetails="NFFF HM", IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Horror, Image = lMistressOfPain, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Horror, Image = lTheStuffOfNightmares, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2019Horror, Image = lZombieLunch, IsAwarded = false, IsAccepted = true, Score=0 },

                                },
                            },
                        });

                        // Photo Nature Brazil 2019
                        var lSalonPhotoNature = new SalonEntity { Name = "Photo Nature", Website = "http://photonature.ajac.org.br/", Country = lCountryBrazil };

                        var lSalonYearPhotoNature2019 = new SalonYearEntity { Name = "Photo Nature", Salon = lSalonPhotoNature, Year = 2019, ClosingDate = new DateTime(2019, 9, 15), JudgeDate = new DateTime(2019, 9, 30), NotificationDate = new DateTime(2019, 10, 14), CataloguesPostedDate = new DateTime(2019, 11, 30) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/307", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearPhotoNature2019 },
                            new AccreditationEntity() { SalonNumber = "2019-381", PhotoOrganisation = lPsa, SalonYear = lSalonYearPhotoNature2019 },
                        });

                        var lSalonYearPhotoNature2019Colour = new SectionEntity() { SalonYear = lSalonYearPhotoNature2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoNature2019Mono = new SectionEntity() { SalonYear = lSalonYearPhotoNature2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPhotoNature2019Nature = new SectionEntity() { SalonYear = lSalonYearPhotoNature2019, SectionType = lSectionTypeNaturePdi };


                        var lSymmetricalFlowerInMono = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Symmetrical Flower In Mono" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 14.03M,
                                SalonYear = lSalonYearPhotoNature2019,
                                EntryDate = new DateTime(2019, 9, 9),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Colour, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Colour, Image = lSingleYellowRose, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Mono, Image = lSymmetricalFlowerInMono, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Nature, Image = lContentedOwl, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Nature, Image = lMossyFrogOnBranch, IsAwarded = true, AwardDetails = "Club Diploma", IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNature2019Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score=0 },

                                },
                            },
                        });

                        // Wojnicz 2019
                        var lSalonYearWojnicz2019 = new SalonYearEntity { Name = "Wojnicz", Salon = lSalonWojnicz, Year = 2019, ClosingDate = new DateTime(2019, 9, 30), JudgeDate = new DateTime(2019, 10, 19), NotificationDate = new DateTime(2019, 10, 25), CataloguesPostedDate = new DateTime(2019, 10, 25) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/293", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearWojnicz2019 },
                            new AccreditationEntity() { SalonNumber = "2019-370", PhotoOrganisation = lPsa, SalonYear = lSalonYearWojnicz2019 },
                        });

                        var lSalonYearPhotoWojnicz2019Colour = new SectionEntity() { SalonYear = lSalonYearWojnicz2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoWojnicz2019Mono = new SectionEntity() { SalonYear = lSalonYearWojnicz2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPhotoWojnicz2019Portrait = new SectionEntity() { SalonYear = lSalonYearWojnicz2019, SectionType = lSectionTypePortraitPdi };


                        var lTwoPoppyheads = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Two Poppyheads" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 14.00M,
                                SalonYear = lSalonYearWojnicz2019,
                                EntryDate = new DateTime(2019, 9, 11),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Colour, Image = lTheStuffOfNightmares, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Colour, Image = lAKissByMoonlight, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Colour, Image = lTarantulaWarning, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Mono, Image = lTwoPoppyheads, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Portrait, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Portrait, Image = lByLamplight, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Portrait, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoWojnicz2019Portrait, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = true, Score=0 },

                                },
                            },
                        });

                        // Canvas 2019
                        var lSalonYearCanvas2019 = new SalonYearEntity { Name = "Canvas", Salon = lSalonCanvas, Year = 2019, ClosingDate = new DateTime(2019, 9, 29), JudgeDate = new DateTime(2019, 10, 10), NotificationDate = new DateTime(2019, 10, 15), CataloguesPostedDate = new DateTime(2019, 12, 24) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/405", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearCanvas2019 },
                            new AccreditationEntity() { SalonNumber = "2019-370", PhotoOrganisation = lPsa, SalonYear = lSalonYearCanvas2019 },
                        });

                        var lSalonYearPhotoCanvas2019Colour = new SectionEntity() { SalonYear = lSalonYearCanvas2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoCanvas2019Mono = new SectionEntity() { SalonYear = lSalonYearCanvas2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPhotoCanvas2019Travel = new SectionEntity() { SalonYear = lSalonYearCanvas2019, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearPhotoCanvas2019Nature = new SectionEntity() { SalonYear = lSalonYearCanvas2019, SectionType = lSectionTypeNaturePdi };


                        var lThreeRoses = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Three Roses" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 16.70M,
                                SalonYear = lSalonYearCanvas2019,
                                EntryDate = new DateTime(2019, 9, 28),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Colour, Image = lThreeRoses, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score= 16},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Colour, Image = lByLamplight, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Travel, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score= 16},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score= 20},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Nature, Image = lContentedOwl, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoCanvas2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = false, Score=19 },

                                },
                            },
                        });

                        // MOF 2019
                        var lSalonYearMOF2019 = new SalonYearEntity { Name = "MOF", Salon = lSalonMof, Year = 2019, ClosingDate = new DateTime(2019, 9, 28), JudgeDate = new DateTime(2019, 10, 14), NotificationDate = new DateTime(2019, 10, 31), CataloguesPostedDate = new DateTime(2019, 10, 31) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/348", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearMOF2019 },
                        });

                        var lSalonYearPhotoMof2019Colour = new SectionEntity() { SalonYear = lSalonYearMOF2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoMof2019Mono = new SectionEntity() { SalonYear = lSalonYearMOF2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPhotoMof2019Travel = new SectionEntity() { SalonYear = lSalonYearMOF2019, SectionType = lSectionTypeTravelPdi };
                        var lSalonYearPhotoMof2019Nature = new SectionEntity() { SalonYear = lSalonYearMOF2019, SectionType = lSectionTypeNaturePdi };



                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 23.20M,
                                SalonYear = lSalonYearMOF2019,
                                EntryDate = new DateTime(2019, 9, 28),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Colour, Image = lThreeRoses, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score= 15},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Colour, Image = lByLamplight, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = true, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=15 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Travel, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Travel, Image = lTheRedHut, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = true, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score= 19},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Nature, Image = lContentedOwl, IsAwarded = true, AwardDetails = "Salon Diploma", IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoMof2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = true, Score=21 },

                                },
                            },
                        });

                        // Olympic Circuit
                        var lOlympicCircuit2019 = new CircuitEntity() { Name = "Olympic" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                            lOlympicCircuit2019,
                        });

                        var lTheHallOfGateways = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Hall of Gateways" };
                        var lCityRechargingTower = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "City Recharging Tower" };
                        var lCrestedGeckoOnStump = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Crested Gecko on Stump" };

                        var lSalonOlympicZeus = new SalonEntity { Name = "Olympic - Zeus", Website = "https://olympicphotocircuit.com/", Country = lCountryGreece };

                        var lSalonYearZeus2019 = new SalonYearEntity { Name = "Olympic - Zeus", Salon = lSalonOlympicZeus, Year = 2019, ClosingDate = new DateTime(2019, 10, 6), JudgeDate = new DateTime(2019, 10, 20), NotificationDate = new DateTime(2019, 11, 3), CataloguesPostedDate = new DateTime(2020, 1, 5), Circuit = lOlympicCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/476", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearZeus2019 },
                            new AccreditationEntity() { SalonNumber = "2019-439", PhotoOrganisation = lPsa, SalonYear = lSalonYearZeus2019 },
                            new AccreditationEntity() { SalonNumber = "L190153", PhotoOrganisation = lGpu, SalonYear = lSalonYearZeus2019 },
                        });

                        var lSalonYearZeus2019Colour = new SectionEntity() { SalonYear = lSalonYearZeus2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearZeus2019Mono = new SectionEntity() { SalonYear = lSalonYearZeus2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearZeus2019Nature = new SectionEntity() { SalonYear = lSalonYearZeus2019, SectionType = lSectionTypeNaturePdi };



                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 8.89M,
                                SalonYear = lSalonYearZeus2019,
                                EntryDate = new DateTime(2019, 10, 5),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Colour, Image = lCityRechargingTower, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Nature, Image = lContentedOwl, IsAwarded = true, AwardDetails="Judges Choice", IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearZeus2019Nature, Image = lRedEyedGreenTreeFrog, IsAwarded = false, IsAccepted = false, Score=0 },

                                },
                            },
                        });

                        var lSalonOlympicAphrodite = new SalonEntity { Name = "Olympic - Aphrodite", Website = "https://olympicphotocircuit.com/", Country = lCountryGreece };

                        var lSalonYearAphrodite2019 = new SalonYearEntity { Name = "Olympic - Aphrodite", Salon = lSalonOlympicAphrodite, Year = 2019, ClosingDate = new DateTime(2019, 10, 6), JudgeDate = new DateTime(2019, 10, 20), NotificationDate = new DateTime(2019, 11, 3), CataloguesPostedDate = new DateTime(2020, 1, 5), Circuit = lOlympicCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/477", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearAphrodite2019 },
                            new AccreditationEntity() { SalonNumber = "2019-439", PhotoOrganisation = lPsa, SalonYear = lSalonYearAphrodite2019 },
                            new AccreditationEntity() { SalonNumber = "L190153", PhotoOrganisation = lGpu, SalonYear = lSalonYearAphrodite2019 },
                        });

                        var lSalonYearAphrodite2019Colour = new SectionEntity() { SalonYear = lSalonYearAphrodite2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearAphrodite2019Mono = new SectionEntity() { SalonYear = lSalonYearAphrodite2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearAphrodite2019Nature = new SectionEntity() { SalonYear = lSalonYearAphrodite2019, SectionType = lSectionTypeNaturePdi };



                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 8.89M,
                                SalonYear = lSalonYearAphrodite2019,
                                EntryDate = new DateTime(2019, 10, 5),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Colour, Image = lCityRechargingTower, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Mono, Image = lMirrorOfReminiscence, IsAwarded = true, AwardDetails = "GPU HM", IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Nature, Image = lContentedOwl, IsAwarded = true, AwardDetails="GPU Bronze", IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearAphrodite2019Nature, Image = lRedEyedGreenTreeFrog, IsAwarded = false, IsAccepted = false, Score=0 },

                                },
                            },
                        });

                        var lSalonOlympicHermes = new SalonEntity { Name = "Olympic - Hermes", Website = "https://olympicphotocircuit.com/", Country = lCountryGreece };

                        var lSalonYearHermes2019 = new SalonYearEntity { Name = "Olympic - Hermes", Salon = lSalonOlympicHermes, Year = 2019, ClosingDate = new DateTime(2019, 10, 6), JudgeDate = new DateTime(2019, 10, 20), NotificationDate = new DateTime(2019, 11, 3), CataloguesPostedDate = new DateTime(2020, 1, 5), Circuit = lOlympicCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/478", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearHermes2019 },
                            new AccreditationEntity() { SalonNumber = "2019-439", PhotoOrganisation = lPsa, SalonYear = lSalonYearHermes2019 },
                            new AccreditationEntity() { SalonNumber = "L190153", PhotoOrganisation = lGpu, SalonYear = lSalonYearHermes2019 },
                        });

                        var lSalonYearHermes2019Colour = new SectionEntity() { SalonYear = lSalonYearHermes2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearHermes2019Mono = new SectionEntity() { SalonYear = lSalonYearHermes2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearHermes2019Nature = new SectionEntity() { SalonYear = lSalonYearHermes2019, SectionType = lSectionTypeNaturePdi };



                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 8.89M,
                                SalonYear = lSalonYearHermes2019,
                                EntryDate = new DateTime(2019, 10, 5),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Colour, Image = lCityRechargingTower, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Nature, Image = lContentedOwl, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearHermes2019Nature, Image = lRedEyedGreenTreeFrog, IsAwarded = false, IsAccepted = false, Score=0 },

                                },
                            },
                        });

                        var lSalonOlympicApollo = new SalonEntity { Name = "Olympic - Apollo", Website = "https://olympicphotocircuit.com/", Country = lCountryGreece };

                        var lSalonYearApollo2019 = new SalonYearEntity { Name = "Olympic - Apollo", Salon = lSalonOlympicApollo, Year = 2019, ClosingDate = new DateTime(2019, 10, 6), JudgeDate = new DateTime(2019, 10, 20), NotificationDate = new DateTime(2019, 11, 3), CataloguesPostedDate = new DateTime(2020, 1, 5), Circuit = lOlympicCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/479", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearApollo2019 },
                            new AccreditationEntity() { SalonNumber = "2019-439", PhotoOrganisation = lPsa, SalonYear = lSalonYearApollo2019 },
                            new AccreditationEntity() { SalonNumber = "L190153", PhotoOrganisation = lGpu, SalonYear = lSalonYearApollo2019 },
                        });

                        var lSalonYearApollo2019Colour = new SectionEntity() { SalonYear = lSalonYearApollo2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearApollo2019Mono = new SectionEntity() { SalonYear = lSalonYearApollo2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearApollo2019Nature = new SectionEntity() { SalonYear = lSalonYearApollo2019, SectionType = lSectionTypeNaturePdi };



                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 8.90M,
                                SalonYear = lSalonYearApollo2019,
                                EntryDate = new DateTime(2019, 10, 5),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Colour, Image = lCityRechargingTower, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = true, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Nature, Image = lContentedOwl, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Nature, Image = lPantherChameleonLunch, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = false, Score=0 },
                                    new CompetitionEntryEntity { Section = lSalonYearApollo2019Nature, Image = lRedEyedGreenTreeFrog, IsAwarded = false, IsAccepted = false, Score=0 },

                                },
                            },
                        });


                        // New Zealand 2019
                        var lSalonYearNZIS2019 = new SalonYearEntity { Name = "NZIS", Salon = lSalonNzis, Year = 2019, ClosingDate = new DateTime(2019, 10, 7), JudgeDate = new DateTime(2019, 10, 20), NotificationDate = new DateTime(2019, 10, 26), CataloguesPostedDate = new DateTime(2019, 11, 15) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/396", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearNZIS2019 },
              new AccreditationEntity() { SalonNumber = "2019-418", PhotoOrganisation = lPsa, SalonYear = lSalonYearNZIS2019 },
              new AccreditationEntity() { SalonNumber = "L190118", PhotoOrganisation = lGpu, SalonYear = lSalonYearNZIS2019 },
                        });

                        var lSalonYearPhotoNzis2019Colour = new SectionEntity() { SalonYear = lSalonYearNZIS2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoNzis2019Mono = new SectionEntity() { SalonYear = lSalonYearNZIS2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPhotoNzis2019Creative = new SectionEntity() { SalonYear = lSalonYearNZIS2019, SectionType = lSectionTypeCreativePdi };



                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
              new SubmissionEntity(){
                  IsJudged = true,
                  EntryCost = 16.93M,
                    SalonYear = lSalonYearNZIS2019,
                  EntryDate = new DateTime(2019, 10, 6),
                  Person = lTim,
                  Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score=10},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Colour, Image = lWorkersBreak, IsAwarded = false, IsAccepted = false, Score= 10},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Colour, Image = lTheSeamstressTakesHerFee, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Colour, Image = lTarantulaWarning, IsAwarded = false, IsAccepted = false, Score=10 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=9 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score= 9},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=8 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=7 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=90 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Creative, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = true, Score= 11},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score=12 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoNzis2019Creative, Image = lCityRechargingTower, IsAwarded = false, IsAccepted = false, Score=10 },

                                },
                            },
                        });

                        // ISO 2019
                        var lSalonYearISO2019 = new SalonYearEntity { Name = "ISO", Salon = lSalonIso, Year = 2019, ClosingDate = new DateTime(2019, 10, 20), JudgeDate = new DateTime(2019, 10, 25), NotificationDate = new DateTime(2019, 11, 03), CataloguesPostedDate = new DateTime(2019, 12, 15) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                  new AccreditationEntity() { SalonNumber = "2019/328", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearISO2019 },
                    new AccreditationEntity() { SalonNumber = "2019-379", PhotoOrganisation = lPsa, SalonYear = lSalonYearISO2019 },
                                });

                        var lSalonYearPhotoIso2019Colour = new SectionEntity() { SalonYear = lSalonYearISO2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoIso2019Mono = new SectionEntity() { SalonYear = lSalonYearISO2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPhotoIso2019Creative = new SectionEntity() { SalonYear = lSalonYearISO2019, SectionType = lSectionTypeCreativePdi };
                        var lSalonYearPhotoIso2019Nature = new SectionEntity() { SalonYear = lSalonYearISO2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearPhotoIso2019Photojournalism = new SectionEntity() { SalonYear = lSalonYearISO2019, SectionType = lSectionTypePhotojournalismPdi };
                        var lSalonYearPhotoIso2019Landscapes = new SectionEntity() { SalonYear = lSalonYearISO2019, SectionType = lSectionTypeScapesPdi };

                        var lLeekFlower = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Leek Flower" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                    new SubmissionEntity(){
                        IsJudged = true,
                        EntryCost = 13.89M,
                          SalonYear = lSalonYearISO2019,
                        EntryDate = new DateTime(2019, 10, 13),
                        Person = lTim,
                        Entries = new List<CompetitionEntryEntity> {

                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score=20 },
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Colour, Image = lChrysanthemumCloseUp, IsAwarded = false, IsAccepted = false, Score= 18},
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Colour, Image = lTheSeamstressTakesHerFee, IsAwarded = false, IsAccepted = false, Score=18 },
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Colour, Image = lLeekFlower, IsAwarded = false, IsAccepted = false, Score=17 },
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=17 },
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score= 18},
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Mono, Image = lRealityDysfunction, IsAwarded = false, IsAccepted = false, Score=13 },
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=16 },
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Creative, Image = lPartyAtTheApocalypse, IsAwarded = false, IsAccepted = false, Score=16 },
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Creative, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = true, Score= 21},
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Creative, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score=21 },
                                            new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Creative, Image = lCityRechargingTower, IsAwarded = false, IsAccepted = false, Score=18 },
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=22 },
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = true, Score= 20},
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = false, Score=19 },
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = false, Score=19 },
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Photojournalism, Image = lTourDeYorkshireArt, IsAwarded = false, IsAccepted = true, Score=19 },
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Photojournalism, Image = lLightNightInflatableMen, IsAwarded = false, IsAccepted = false, Score= 16},
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Photojournalism, Image = lItsAllAboutTheHair, IsAwarded = false, IsAccepted = false, Score=18 },
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Photojournalism, Image = lAnimatronicTRex, IsAwarded = false, IsAccepted = false, Score=14 },
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Landscapes, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = true, Score=18 },
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Landscapes, Image = lDerwentwaterBoatHouse, IsAwarded = false, IsAccepted = false, Score= 15},
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Landscapes, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=15 },
                          new CompetitionEntryEntity { Section = lSalonYearPhotoIso2019Landscapes, Image = lTheRedHut, IsAwarded = false, IsAccepted = true, Score=18 },

                                      },
                                  },
                              });


                        // Cross Continental Circuit
                        var lCrossContinentalCircuit2019 = new CircuitEntity() { Name = "Cross Continental" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                        lCrossContinentalCircuit2019,
                                    });

                        var lVictoryLap = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Victory Lap" };
                        var lToDreamOfCalmerShores = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "To Dream of Calmer Shores" };

                        var lSalonCccIndonesia = new SalonEntity { Name = "CCC - Indonesia", Website = "http://www.ccc-photo.de", Country = lCountryIndonesia };

                        var lSalonYearCccIndonesia2019 = new SalonYearEntity { Name = "CCC - Indonesia", Salon = lSalonCccIndonesia, Year = 2019, ClosingDate = new DateTime(2019, 10, 21), JudgeDate = new DateTime(2019, 11, 3), NotificationDate = new DateTime(2019, 11, 8), CataloguesPostedDate = new DateTime(2019, 12, 19), Circuit = lCrossContinentalCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                        new AccreditationEntity() { SalonNumber = "2019/466", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearCccIndonesia2019 },
                                        new AccreditationEntity() { SalonNumber = "2019-477", PhotoOrganisation = lPsa, SalonYear = lSalonYearCccIndonesia2019 },
                                    });

                        var lSalonYearCccIndonesia2019Colour = new SectionEntity() { SalonYear = lSalonYearCccIndonesia2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearCccIndonesia2019Mono = new SectionEntity() { SalonYear = lSalonYearCccIndonesia2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearCccIndonesia2019Movement = new SectionEntity() { SalonYear = lSalonYearCccIndonesia2019, SectionType = lSectionTypeColourPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                        new SubmissionEntity(){
                                            IsJudged = true,
                                            EntryCost = 6.17M,
                                            SalonYear = lSalonYearCccIndonesia2019,
                                            EntryDate = new DateTime(2019, 10, 13),
                                            Person = lTim,
                                            Entries = new List<CompetitionEntryEntity> {

                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score= 0},
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Colour, Image = lTheSeamstressTakesHerFee, IsAwarded = false, IsAccepted = true, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Colour, Image = lLeekFlower, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = true, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score= 0},
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Movement, Image = lVictoryLap, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Movement, Image = lEmergency, IsAwarded = false, IsAccepted = false, Score= 0},
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Movement, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccIndonesia2019Movement, Image = lToDreamOfCalmerShores, IsAwarded = false, IsAccepted = false, Score=0 },

                                            },
                                        },
                                    });

                        var lSalonCccSouthAfrica = new SalonEntity { Name = "CCC - South Africa", Website = "http://www.ccc-photo.de", Country = lCountrySouthAfrica };

                        var lSalonYearCccSouthAfrica2019 = new SalonYearEntity { Name = "CCC - South Africa", Salon = lSalonCccSouthAfrica, Year = 2019, ClosingDate = new DateTime(2019, 10, 21), JudgeDate = new DateTime(2019, 11, 3), NotificationDate = new DateTime(2019, 11, 8), CataloguesPostedDate = new DateTime(2019, 12, 19), Circuit = lCrossContinentalCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                        new AccreditationEntity() { SalonNumber = "2019/467", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearCccSouthAfrica2019 },
                                        new AccreditationEntity() { SalonNumber = "2019-477", PhotoOrganisation = lPsa, SalonYear = lSalonYearCccSouthAfrica2019 },
                                    });

                        var lSalonYearCccSouthAfrica2019Colour = new SectionEntity() { SalonYear = lSalonYearCccSouthAfrica2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearCccSouthAfrica2019Mono = new SectionEntity() { SalonYear = lSalonYearCccSouthAfrica2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearCccSouthAfrica2019Movement = new SectionEntity() { SalonYear = lSalonYearCccSouthAfrica2019, SectionType = lSectionTypeColourPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                        new SubmissionEntity(){
                                            IsJudged = true,
                                            EntryCost = 6.18M,
                                            SalonYear = lSalonYearCccSouthAfrica2019,
                                            EntryDate = new DateTime(2019, 10, 13),
                                            Person = lTim,
                                            Entries = new List<CompetitionEntryEntity> {

                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = true, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Colour, Image = lTheSeamstressTakesHerFee, IsAwarded = false, IsAccepted = true, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Colour, Image = lLeekFlower, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = true, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score= 0},
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Movement, Image = lVictoryLap, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Movement, Image = lEmergency, IsAwarded = false, IsAccepted = false, Score= 0},
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Movement, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccSouthAfrica2019Movement, Image = lToDreamOfCalmerShores, IsAwarded = false, IsAccepted = false, Score=0 },

                                            },
                                        },
                                    });

                        var lSalonCccGermany = new SalonEntity { Name = "CCC - Germany", Website = "http://www.ccc-photo.de", Country = lCountryGermany };

                        var lSalonYearCccGermany2019 = new SalonYearEntity { Name = "CCC - Germany", Salon = lSalonCccGermany, Year = 2019, ClosingDate = new DateTime(2019, 10, 21), JudgeDate = new DateTime(2019, 11, 3), NotificationDate = new DateTime(2019, 11, 8), CataloguesPostedDate = new DateTime(2019, 12, 19), Circuit = lCrossContinentalCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                        new AccreditationEntity() { SalonNumber = "2019/468", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearCccGermany2019 },
                                        new AccreditationEntity() { SalonNumber = "2019-477", PhotoOrganisation = lPsa, SalonYear = lSalonYearCccGermany2019 },
                                    });

                        var lSalonYearCccGermany2019Colour = new SectionEntity() { SalonYear = lSalonYearCccGermany2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearCccGermany2019Mono = new SectionEntity() { SalonYear = lSalonYearCccGermany2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearCccGermany2019Movement = new SectionEntity() { SalonYear = lSalonYearCccGermany2019, SectionType = lSectionTypeColourPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                        new SubmissionEntity(){
                                            IsJudged = true,
                                            EntryCost = 6.18M,
                                            SalonYear = lSalonYearCccGermany2019,
                                            EntryDate = new DateTime(2019, 10, 13),
                                            Person = lTim,
                                            Entries = new List<CompetitionEntryEntity> {

                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = true, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score= 0},
                                    new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Colour, Image = lTheSeamstressTakesHerFee, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Colour, Image = lLeekFlower, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = true, Score= 0},
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = true, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Movement, Image = lVictoryLap, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Movement, Image = lEmergency, IsAwarded = false, IsAccepted = false, Score= 0},
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Movement, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = false, Score=0 },
                                                new CompetitionEntryEntity { Section = lSalonYearCccGermany2019Movement, Image = lToDreamOfCalmerShores, IsAwarded = false, IsAccepted = false, Score=0 },

                                            },
                                        },
                                    });


                        // Photo Click Circuit
                        var lPhotoClickCircuit2019 = new CircuitEntity() { Name = "Photo Click" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                            lOlympicCircuit2019,
                        });

                        var lAWalkWithTheMoon = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "A Walk With The Moon" };
                        var lTranquility = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tranquility" };
                        var lSkyward = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Skyward" };
                        var lTowersInTheSky = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Towers in the Sky" };

                        var lSalonClickTirna = new SalonEntity { Name = "Click - Tirna", Website = "https://click.photofenix.com/", Country = lCountryAlbania };

                        var lSalonYearClickTirna2019 = new SalonYearEntity { Name = "Click - Tirna", Salon = lSalonClickTirna, Year = 2019, ClosingDate = new DateTime(2019, 11, 10), JudgeDate = new DateTime(2019, 11, 30), NotificationDate = new DateTime(2019, 12, 5), CataloguesPostedDate = new DateTime(2020, 1, 20), Circuit = lPhotoClickCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                            new AccreditationEntity() { SalonNumber = "2019/284", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearClickTirna2019 },
                            new AccreditationEntity() { SalonNumber = "2019-344", PhotoOrganisation = lPsa, SalonYear = lSalonYearClickTirna2019 },
                        });

                        var lSalonYearClickTirna2019Colour = new SectionEntity() { SalonYear = lSalonYearClickTirna2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearClickTirna2019Mono = new SectionEntity() { SalonYear = lSalonYearClickTirna2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearClickTirna2019Nature = new SectionEntity() { SalonYear = lSalonYearClickTirna2019, SectionType = lSectionTypeNaturePdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                            new SubmissionEntity(){
                                IsJudged = true,
                                EntryCost = 8.98M,
                                SalonYear = lSalonYearClickTirna2019,
                                EntryDate = new DateTime(2019, 11, 3),
                                Person = lTim,
                                Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Colour, Image = lAWalkWithTheMoon, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Colour, Image = lTranquility, IsAwarded = false, IsAccepted = false, Score= 18},
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Mono, Image = lSkyward, IsAwarded = false, IsAccepted = false, Score= 17},
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = false, Score=16 },
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=21 },
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = false, Score= 16},
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearClickTirna2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=19 },

                                },
                            },
                        });


                        var lSalonClickKorce = new SalonEntity { Name = "Click - Korce", Website = "https://click.photofenix.com/", Country = lCountryAlbania };

                        var lSalonYearClickKorce2019 = new SalonYearEntity { Name = "Click - Korce", Salon = lSalonClickTirna, Year = 2019, ClosingDate = new DateTime(2019, 11, 10), JudgeDate = new DateTime(2019, 11, 30), NotificationDate = new DateTime(2019, 12, 5), CataloguesPostedDate = new DateTime(2020, 1, 20), Circuit = lPhotoClickCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                new AccreditationEntity() { SalonNumber = "2019/285", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearClickKorce2019 },
                                new AccreditationEntity() { SalonNumber = "2019-344", PhotoOrganisation = lPsa, SalonYear = lSalonYearClickKorce2019 },
                            });

                        var lSalonYearClickKorce2019Colour = new SectionEntity() { SalonYear = lSalonYearClickKorce2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearClickKorce2019Mono = new SectionEntity() { SalonYear = lSalonYearClickKorce2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearClickKorce2019Nature = new SectionEntity() { SalonYear = lSalonYearClickKorce2019, SectionType = lSectionTypeNaturePdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 8.98M,
                                    SalonYear = lSalonYearClickKorce2019,
                                    EntryDate = new DateTime(2019, 11, 3),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                    new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Colour, Image = lAWalkWithTheMoon, IsAwarded = false, IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Colour, Image = lTranquility, IsAwarded = true, AwardDetails="PSA HM", IsAccepted = true, Score=23},
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=19 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=20 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=18 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Mono, Image = lSkyward, IsAwarded = false, IsAccepted = true, Score= 21},
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = false, Score=19 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=20 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Nature, Image = lCrestedGeckoTongue, IsAwarded = true, AwardDetails="PSA HM", IsAccepted = true, Score=23 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = true, Score= 21},
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score=21 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickKorce2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=22 },

                                    },
                                },
                            });

                        var lSalonClickUlcinj = new SalonEntity { Name = "Click - Ulcinj", Website = "https://click.photofenix.com/", Country = lCountryMontenegro };

                        var lSalonYearClickUlcinj2019 = new SalonYearEntity { Name = "Click - Ulcinj", Salon = lSalonClickUlcinj, Year = 2019, ClosingDate = new DateTime(2019, 11, 10), JudgeDate = new DateTime(2019, 11, 30), NotificationDate = new DateTime(2019, 12, 5), CataloguesPostedDate = new DateTime(2020, 1, 20), Circuit = lPhotoClickCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                new AccreditationEntity() { SalonNumber = "2019/286", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearClickUlcinj2019 },
                                new AccreditationEntity() { SalonNumber = "2019-344", PhotoOrganisation = lPsa, SalonYear = lSalonYearClickUlcinj2019 },
                            });

                        var lSalonYearClickUlcinj2019Colour = new SectionEntity() { SalonYear = lSalonYearClickUlcinj2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearClickUlcinj2019Mono = new SectionEntity() { SalonYear = lSalonYearClickUlcinj2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearClickUlcinj2019Nature = new SectionEntity() { SalonYear = lSalonYearClickUlcinj2019, SectionType = lSectionTypeNaturePdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 8.98M,
                                    SalonYear = lSalonYearClickUlcinj2019,
                                    EntryDate = new DateTime(2019, 11, 3),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Colour, Image = lAWalkWithTheMoon, IsAwarded = false, IsAccepted = false, Score=18 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Colour, Image = lTranquility, IsAwarded = false, IsAccepted = false, Score= 18},
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=16 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = false, Score=18 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=17 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Mono, Image = lSkyward, IsAwarded = false, IsAccepted = false, Score= 13},
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = false, Score=16 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=17 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=20 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = false, Score= 16},
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score=19 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickUlcinj2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=19 },

                                    },
                                },
                            });

                        var lSalonClickBar = new SalonEntity { Name = "Click - Bar", Website = "https://click.photofenix.com/", Country = lCountryMontenegro };

                        var lSalonYearClickBar2019 = new SalonYearEntity { Name = "Click - Bar", Salon = lSalonClickBar, Year = 2019, ClosingDate = new DateTime(2019, 11, 10), JudgeDate = new DateTime(2019, 11, 30), NotificationDate = new DateTime(2019, 12, 5), CataloguesPostedDate = new DateTime(2020, 1, 20), Circuit = lPhotoClickCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                new AccreditationEntity() { SalonNumber = "2019/287", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearClickBar2019 },
                                new AccreditationEntity() { SalonNumber = "2019-344", PhotoOrganisation = lPsa, SalonYear = lSalonYearClickBar2019 },
                            });

                        var lSalonYearClickBar2019Colour = new SectionEntity() { SalonYear = lSalonYearClickBar2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearClickBar2019Mono = new SectionEntity() { SalonYear = lSalonYearClickBar2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearClickBar2019Nature = new SectionEntity() { SalonYear = lSalonYearClickBar2019, SectionType = lSectionTypeNaturePdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 8.98M,
                                    SalonYear = lSalonYearClickBar2019,
                                    EntryDate = new DateTime(2019, 11, 3),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Colour, Image = lAWalkWithTheMoon, IsAwarded = false, IsAccepted = false, Score=16 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Colour, Image = lTranquility, IsAwarded = false, IsAccepted = false, Score= 18},
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score=17 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score=19 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=15 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Mono, Image = lSkyward, IsAwarded = false, IsAccepted = false, Score= 13},
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = false, Score=13 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=17 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=18 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = false, Score= 18},
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = false, Score=18 },
                                        new CompetitionEntryEntity { Section = lSalonYearClickBar2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=20 },

                                    },
                                },
                            });

                        // Bulgaria 2019

                        var lSalonBulgaria = new SalonEntity { Name = "Bulgaria", Website = "http://photocontestbg.org", Country = lCountryBulgaria };

                        var lSalonYearBulgaria2019 = new SalonYearEntity { Name = "Bulgaria", Salon = lSalonBulgaria, Year = 2019, ClosingDate = new DateTime(2019, 12, 1), JudgeDate = new DateTime(2019, 12, 11), NotificationDate = new DateTime(2019, 12, 19), CataloguesPostedDate = new DateTime(2019, 12, 19) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                        new AccreditationEntity() { SalonNumber = "2019/520", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearBulgaria2019 },
                                new AccreditationEntity() { SalonNumber = "2019-508", PhotoOrganisation = lPsa, SalonYear = lSalonYearBulgaria2019 },
                                        new AccreditationEntity() { SalonNumber = "L190150", PhotoOrganisation = lGpu, SalonYear = lSalonYearBulgaria2019 },
                            });

                        var lSalonYearPhotoBulgaria2019Colour = new SectionEntity() { SalonYear = lSalonYearBulgaria2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoBulgaria2019Mono = new SectionEntity() { SalonYear = lSalonYearBulgaria2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPhotoBulgaria2019Nature = new SectionEntity() { SalonYear = lSalonYearBulgaria2019, SectionType = lSectionTypeNaturePdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                        new SubmissionEntity(){
                            IsJudged = true,
                            EntryCost = 19.79M,
                                SalonYear = lSalonYearBulgaria2019,
                            EntryDate = new DateTime(2019, 11, 9),
                            Person = lTim,
                            Entries = new List<CompetitionEntryEntity> {

                                new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Colour, Image = lLoveLetters, IsAwarded = false, IsAccepted = false, Score=21 },
                                new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Colour, Image = lTranquility, IsAwarded = false, IsAccepted = false, Score= 21},
                                new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Colour, Image = lLeekFlower, IsAwarded = false, IsAccepted = true, Score=23 },
                                new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Colour, Image = lAWalkWithTheMoon, IsAwarded = false, IsAccepted = false, Score=21 },
                                new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=20 },
                                new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Mono, Image = lSkyward, IsAwarded = false, IsAccepted = false, Score= 21},
                                new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = false, Score=21},
                                new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=20 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Nature, Image = lMossyFrogOnBranch, IsAwarded=true, AwardDetails="Salon Gold",  IsAccepted = true, Score=27 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = false, IsAccepted = true, Score= 23},
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Nature, Image = lRedEyedGreenTreeFrog, IsAwarded = false, IsAccepted = true, Score=23 },
                                new CompetitionEntryEntity { Section = lSalonYearPhotoBulgaria2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=25 },

                                            },
                                        },
                                    });



                        // Tramontana 2019
                        var lSalonYearTramontana2019 = new SalonYearEntity { Name = "Tramontana", Salon = lSalonTramontana, Year = 2019, ClosingDate = new DateTime(2019, 10, 27), JudgeDate = new DateTime(2019, 11, 7), NotificationDate = new DateTime(2019, 11, 12), CataloguesPostedDate = new DateTime(2019, 11, 12) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                new AccreditationEntity() { SalonNumber = "2019/502", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearTramontana2019 },
                                                new AccreditationEntity() { SalonNumber = "2019-461", PhotoOrganisation = lPsa, SalonYear = lSalonYearTramontana2019 },
                                    });

                        var lSalonYearPhotoTramontana2019Colour = new SectionEntity() { SalonYear = lSalonYearTramontana2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPhotoTramontana2019Mono = new SectionEntity() { SalonYear = lSalonYearTramontana2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPhotoTramontana2019Nature = new SectionEntity() { SalonYear = lSalonYearTramontana2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearPhotoTramontana2019People = new SectionEntity() { SalonYear = lSalonYearTramontana2019, SectionType = lSectionTypePeoplePdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 17.59M,
                                        SalonYear = lSalonYearTramontana2019,
                                    EntryDate = new DateTime(2019, 10, 14),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Colour, Image = lTheSeamstressTakesHerFee, IsAwarded = false, IsAccepted = false, Score=18 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score= 14 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Colour, Image = lToDreamOfCalmerShores, IsAwarded = false, IsAccepted = false, Score=13 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = false, Score=13 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=16 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 17},
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Mono, Image = lContemplationByStarlight, IsAwarded = false, IsAccepted = false, Score=18 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = false, Score=13 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Nature, Image = lCrestedGeckoOnStump, IsAwarded = true, AwardDetails="PC Perasto Praise", IsAccepted = true, Score=22 },
                                    new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 16 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = false, Score=17 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = false, Score=19 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019People, Image = lJilted, IsAwarded = false, IsAccepted = true, Score=20 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019People, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score= 19},
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019People, Image = lEngineDriver, IsAwarded = false, IsAccepted = false, Score=16 },
                                        new CompetitionEntryEntity { Section = lSalonYearPhotoTramontana2019People, Image = lByLamplight, IsAwarded = false, IsAccepted = false, Score=16 },

                                                    },
                                                },
                                            });


                        // Autumn Circuit 2019
                        var lPhotoAutumnCircuit2019 = new CircuitEntity() { Name = "Autumn Circuit" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                                lPhotoAutumnCircuit2019,
                                            });

                        var lMarbledTreeFrog = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Marbled Tree Frog" };
                        var lStepsOfTheMoon = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Stesp of the Moon" };
                        var lVictorianTraveller = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Victorian Traveller" };
                        var lRailDelay = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Rail Delay" };
                        var lSolentSunset = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Solent Sunset" };
                        var lAlhambraComplex = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Alhambra Complex" };
                        var lAlienEncounter = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Alien Encounter" };


                        var lSalonAutumnElema = new SalonEntity { Name = "Autumn - Elema", Website = "https://www.exhibitions.photo/", Country = lCountryMacedonia };

                        var lSalonYearAutumnElema2019 = new SalonYearEntity { Name = "Autumn - Elema", Salon = lSalonAutumnElema, Year = 2019, ClosingDate = new DateTime(2019, 11, 24), JudgeDate = new DateTime(2019, 12, 5), NotificationDate = new DateTime(2019, 12, 10), CataloguesPostedDate = new DateTime(2020, 2, 18), Circuit = lPhotoAutumnCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2019/554", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearAutumnElema2019 },
                                                    new AccreditationEntity() { SalonNumber = "2019-500", PhotoOrganisation = lPsa, SalonYear = lSalonYearAutumnElema2019 },
                                                });

                        var lSalonYearAutumnElema2019Colour = new SectionEntity() { SalonYear = lSalonYearAutumnElema2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearAutumnElema2019Mono = new SectionEntity() { SalonYear = lSalonYearAutumnElema2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearAutumnElema2019Nature = new SectionEntity() { SalonYear = lSalonYearAutumnElema2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearAutumnElema2019People = new SectionEntity() { SalonYear = lSalonYearAutumnElema2019, SectionType = lSectionTypePeoplePdi };
                        var lSalonYearAutumnElema2019Travel = new SectionEntity() { SalonYear = lSalonYearAutumnElema2019, SectionType = lSectionTypeTravelPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 13.38M,
                                                        SalonYear = lSalonYearAutumnElema2019,
                                                        EntryDate = new DateTime(2019, 11, 20),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Colour, Image = lTranquility, IsAwarded = false, IsAccepted = false, Score=15 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Colour, Image = lAlienEncounter, IsAwarded = false, IsAccepted = false, Score= 17},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Colour, Image = lAWalkWithTheMoon, IsAwarded = false, IsAccepted = false, Score=16 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Colour, Image = lSunflower, IsAwarded = false, IsAccepted = false, Score=14 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Nature, Image = lRedEyedGreenTreeFrog, IsAwarded = false, IsAccepted = false, Score=19 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score= 18},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = false, Score=19 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Nature, Image = lMarbledTreeFrog, IsAwarded = false, IsAccepted = false, Score=16 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Mono, Image = lSkyward, IsAwarded = false, IsAccepted = false, Score=18},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = false, Score= 17},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Mono, Image = lStepsOfTheMoon, IsAwarded = false, IsAccepted = false, Score=13 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Mono, Image = lTwoPoppyheads, IsAwarded = false, IsAccepted = false, Score=14 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019People, Image = lVictorianTraveller, IsAwarded = false, IsAccepted = false, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019People, Image = lWorkersBreak, IsAwarded = false, IsAccepted = false, Score= 14},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019People, Image = lAWalkInTheCountryside, IsAwarded = false, IsAccepted = false, Score=18 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019People, Image = lRailDelay, IsAwarded = false, IsAccepted = false, Score=18 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Travel, Image = lSolentSunset, IsAwarded = false, IsAccepted = false, Score=19 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score= 17},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = true, Score=21 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnElema2019Travel, Image = lAlhambraComplex, IsAwarded = false, IsAccepted = false, Score=14 },

                                                        },
                                                    },
                                                });

                        var lSalonAutumnCacak = new SalonEntity { Name = "Autumn - Cacak", Website = "https://www.exhibitions.photo/", Country = lCountrySerbia };

                        var lSalonYearAutumnCacak2019 = new SalonYearEntity { Name = "Autumn - Cacak", Salon = lSalonAutumnCacak, Year = 2019, ClosingDate = new DateTime(2019, 11, 24), JudgeDate = new DateTime(2019, 12, 5), NotificationDate = new DateTime(2019, 12, 10), CataloguesPostedDate = new DateTime(2020, 2, 18), Circuit = lPhotoAutumnCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2019/555", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearAutumnCacak2019 },
                                                    new AccreditationEntity() { SalonNumber = "2019-500", PhotoOrganisation = lPsa, SalonYear = lSalonYearAutumnCacak2019 },
                                                });

                        var lSalonYearAutumnCacak2019Colour = new SectionEntity() { SalonYear = lSalonYearAutumnCacak2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearAutumnCacak2019Mono = new SectionEntity() { SalonYear = lSalonYearAutumnCacak2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearAutumnCacak2019Nature = new SectionEntity() { SalonYear = lSalonYearAutumnCacak2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearAutumnCacak2019People = new SectionEntity() { SalonYear = lSalonYearAutumnCacak2019, SectionType = lSectionTypePeoplePdi };
                        var lSalonYearAutumnCacak2019Travel = new SectionEntity() { SalonYear = lSalonYearAutumnCacak2019, SectionType = lSectionTypeTravelPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 13.38M,
                                                        SalonYear = lSalonYearAutumnCacak2019,
                                                        EntryDate = new DateTime(2019, 11, 20),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Colour, Image = lTranquility, IsAwarded = false, IsAccepted = false, Score=14 },
                                    new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Colour, Image = lAlienEncounter, IsAwarded = false, IsAccepted = false, Score= 17},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Colour, Image = lAWalkWithTheMoon, IsAwarded = false, IsAccepted = false, Score=18 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Colour, Image = lSunflower, IsAwarded = false, IsAccepted = false, Score=12 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Nature, Image = lRedEyedGreenTreeFrog, IsAwarded = false, IsAccepted = true, Score=21 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score= 16},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = false, Score=18 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Nature, Image = lMarbledTreeFrog, IsAwarded = false, IsAccepted = false, Score=17 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Mono, Image = lSkyward, IsAwarded = false, IsAccepted = false, Score=18 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = false, Score= 14},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Mono, Image = lStepsOfTheMoon, IsAwarded = false, IsAccepted = false, Score=12 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Mono, Image = lTwoPoppyheads, IsAwarded = false, IsAccepted = false, Score=12 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019People, Image = lVictorianTraveller, IsAwarded = false, IsAccepted = false, Score=12 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019People, Image = lWorkersBreak, IsAwarded = false, IsAccepted = false, Score= 15},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019People, Image = lAWalkInTheCountryside, IsAwarded = false, IsAccepted = false, Score=15 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019People, Image = lRailDelay, IsAwarded = false, IsAccepted = false, Score=15 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Travel, Image = lSolentSunset, IsAwarded = false, IsAccepted = false, Score=17 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score= 15},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=15 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnCacak2019Travel, Image = lAlhambraComplex, IsAwarded = false, IsAccepted = false, Score=13 },

                                                        },
                                                    },
                                                });

                        var lSalonAutumnPerasto = new SalonEntity { Name = "Autumn - Perasto", Website = "https://www.exhibitions.photo/", Country = lCountryMontenegro };

                        var lSalonYearAutumnPerasto2019 = new SalonYearEntity { Name = "Autumn - Perasto", Salon = lSalonAutumnPerasto, Year = 2019, ClosingDate = new DateTime(2019, 11, 24), JudgeDate = new DateTime(2019, 12, 5), NotificationDate = new DateTime(2019, 12, 10), CataloguesPostedDate = new DateTime(2020, 2, 18), Circuit = lPhotoAutumnCircuit2019 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2019/556", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearAutumnPerasto2019 },
                                                    new AccreditationEntity() { SalonNumber = "2019-500", PhotoOrganisation = lPsa, SalonYear = lSalonYearAutumnPerasto2019 },
                                                });

                        var lSalonYearAutumnPerasto2019Colour = new SectionEntity() { SalonYear = lSalonYearAutumnPerasto2019, SectionType = lSectionTypeColourPdi };
                        var lSalonYearAutumnPerasto2019Mono = new SectionEntity() { SalonYear = lSalonYearAutumnPerasto2019, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearAutumnPerasto2019Nature = new SectionEntity() { SalonYear = lSalonYearAutumnPerasto2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearAutumnPerasto2019People = new SectionEntity() { SalonYear = lSalonYearAutumnPerasto2019, SectionType = lSectionTypePeoplePdi };
                        var lSalonYearAutumnPerasto2019Travel = new SectionEntity() { SalonYear = lSalonYearAutumnPerasto2019, SectionType = lSectionTypeTravelPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 13.38M,
                                                        SalonYear = lSalonYearAutumnPerasto2019,
                                                        EntryDate = new DateTime(2019, 11, 20),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Colour, Image = lTranquility, IsAwarded = false, IsAccepted = false, Score=17 },
                                    new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Colour, Image = lAlienEncounter, IsAwarded = false, IsAccepted = false, Score= 16},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Colour, Image = lAWalkWithTheMoon, IsAwarded = false, IsAccepted = true, Score=21 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Colour, Image = lSunflower, IsAwarded = false, IsAccepted = false, Score=14 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Nature, Image = lRedEyedGreenTreeFrog, IsAwarded = false, IsAccepted = false, Score=15 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score= 17},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = false, Score=15},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Nature, Image = lMarbledTreeFrog, IsAwarded = false, IsAccepted = false, Score=17},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Mono, Image = lSkyward, IsAwarded = false, IsAccepted = false, Score=17 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = false, Score= 17},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Mono, Image = lStepsOfTheMoon, IsAwarded = false, IsAccepted = false, Score=13 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Mono, Image = lTwoPoppyheads, IsAwarded = false, IsAccepted = false, Score=12 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019People, Image = lVictorianTraveller, IsAwarded = false, IsAccepted = false, Score=16 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019People, Image = lWorkersBreak, IsAwarded = false, IsAccepted = true, Score= 20},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019People, Image = lAWalkInTheCountryside, IsAwarded = false, IsAccepted = false, Score=18 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019People, Image = lRailDelay, IsAwarded = false, IsAccepted = false, Score=18 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Travel, Image = lSolentSunset, IsAwarded = false, IsAccepted = false, Score=17 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Travel, Image = lIceBeachWaves, IsAwarded = false, IsAccepted = false, Score= 14},
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Travel, Image = lGrassIceland, IsAwarded = false, IsAccepted = false, Score=17 },
                                                            new CompetitionEntryEntity { Section = lSalonYearAutumnPerasto2019Travel, Image = lAlhambraComplex, IsAwarded = false, IsAccepted = false, Score=15 },

                                                        },
                                                    },
                                                });

                        // Yorkshire 2019
                        var lSalonYearYorkshire2019 = new SalonYearEntity { Name = "Yorkshire", Salon = lSalonYorkshire, Year = 2019, ClosingDate = new DateTime(2019, 12, 9), JudgeDate = new DateTime(2019, 12, 15), NotificationDate = new DateTime(2019, 12, 24), CataloguesPostedDate = new DateTime(2020, 1, 14) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                            new AccreditationEntity() { SalonNumber = "2019/458", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearYorkshire2019 },
                                                            new AccreditationEntity() { SalonNumber = "2019-513", PhotoOrganisation = lPsa, SalonYear = lSalonYearYorkshire2019 },
                                                });

                        var lSalonYearPhotoYorkshire2019Colour = new SectionEntity() { SalonYear = lSalonYearYorkshire2019, SectionType = lSectionTypeColourPrint };
                        var lSalonYearPhotoYorkshire2019Mono = new SectionEntity() { SalonYear = lSalonYearYorkshire2019, SectionType = lSectionTypeMonoPrint };
                        var lSalonYearPhotoYorkshire2019Nature = new SectionEntity() { SalonYear = lSalonYearYorkshire2019, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearPhotoYorkshire2019OpenPdi = new SectionEntity() { SalonYear = lSalonYearYorkshire2019, SectionType = lSectionTypeColourPdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                            new SubmissionEntity(){
                                                IsJudged = true,
                                                EntryCost = 13M,
                                                    SalonYear = lSalonYearYorkshire2019,
                                                EntryDate = new DateTime(2019, 12, 3),
                                                Person = lTim,
                                                Entries = new List<CompetitionEntryEntity> {

                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score=13 },
                                              new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = false, Score= 10 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Colour, Image = lAWalkWithTheMoon, IsAwarded = false, IsAccepted = true, Score=13 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Colour , Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = false, Score=9 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = false, Score=9 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Mono, Image = lMirrorOfReminiscence, IsAwarded = false, IsAccepted = false, Score= 11},
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = false, Score=9 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Mono, Image = lTheFinalGateway, IsAwarded = false, IsAccepted = true, Score=12 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = false, Score=9 },
                                                  new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Nature, Image = lRoughFrilledTreeFrogOnFlower, IsAwarded = false, IsAccepted = false, Score= 9 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = false, Score=10 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=11 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019OpenPdi, Image = lJilted, IsAwarded = false, IsAccepted = false, Score=11 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019OpenPdi, Image = lQueenOfTheCastle, IsAwarded = false, IsAccepted = true, Score= 12},
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019OpenPdi, Image = lProtectors, IsAwarded = false, IsAccepted = false, Score=9 },
                                                    new CompetitionEntryEntity { Section = lSalonYearPhotoYorkshire2019OpenPdi, Image = lTimeFlies, IsAwarded = false, IsAccepted = false, Score=9 },

                                                                },
                                                            },
                                                        });

                        // Pamir 2020
                        var lSalonPamir = new SalonEntity { Name = "Pamir", Website = "http://pamirexhibition.com/", Country = lCountryTajikistan };


                        var lSalonYearPamir2020 = new SalonYearEntity { Name = "Pamir", Salon = lSalonPamir, Year = 2020, ClosingDate = new DateTime(2020, 03, 19), JudgeDate = new DateTime(2020, 4, 9), NotificationDate = new DateTime(2020, 04, 23), CataloguesPostedDate = new DateTime(2020, 6, 25) };

                        var lGhostOfTheCorridor = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Ghost of the Corridor" };
                        var lClockworkOwl = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Clockwork Owl" };
                        var lContemplationInTheGrove = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Contemplation in the Grove" };
                        var lTwoRosesInRed = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Two Roses In Red" };
                        var lRagMan = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Rag Man" };
                        var lMidnightVoyage = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Midnight Voyage" };
                        var lVictorianRailwayTravel = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Victorial Railway Travel" };
                        var lBridgewaterPlaceAndCanal = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Bridgewater Place And Canal" };
                        var lATexturedTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "A Textured Tree" };
                        var lATowerByTheSea = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tower By The Sea" };
                        var lCommonToadOnRock = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Common Toad on Rock" };
                        var lChileanRoseTarantulaOnTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Chilean Rose Tarantula On Tree" };
                        var lLeopardGecko = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Leopard Gecko" };
                        var lCityscapeSymmetry = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Cityscape Symmetry" };
                        var lTheDoorInTheTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Door in The Tree" };


                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                                    new AccreditationEntity() { SalonNumber = "2020/236", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearPamir2020 },
                                                                    new AccreditationEntity() { SalonNumber = "2020-091", PhotoOrganisation = lPsa, SalonYear = lSalonYearPamir2020 },
                                                        });

                        var lSalonYearPamir2020Mono = new SectionEntity() { SalonYear = lSalonYearPamir2020, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearPamir2020Colour = new SectionEntity() { SalonYear = lSalonYearPamir2020, SectionType = lSectionTypeColourPdi };
                        var lSalonYearPamir2020Portrait = new SectionEntity() { SalonYear = lSalonYearPamir2020, SectionType = lSectionTypePortraitPdi };
                        var lSalonYearPamir2020Landscape = new SectionEntity() { SalonYear = lSalonYearPamir2020, SectionType = lSectionTypeScapesPdi };
                        var lSalonYearPamir2020Nature = new SectionEntity() { SalonYear = lSalonYearPamir2020, SectionType = lSectionTypeNaturePdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                            new SubmissionEntity(){
                                                            IsJudged = true,
                                                            EntryCost = 23.92M,
                                                            SalonYear = lSalonYearPamir2020,
                                                            EntryDate = new DateTime(2020, 3, 1),
                                                            Person = lTim,
                                                            Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Mono, Image = lGhostOfTheCorridor, IsAwarded = false, IsAccepted = true, Score=31 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Mono, Image = lClockworkOwl, IsAwarded = false, IsAccepted = false, Score= 26 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Mono, Image = lCityscapeSymmetry, IsAwarded = false, IsAccepted = false, Score=27 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Mono , Image = lContemplationInTheGrove, IsAwarded = false, IsAccepted = false, Score=25 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Colour, Image = lTheDoorInTheTree, IsAwarded = false, IsAccepted = false, Score=26 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Colour, Image = lTwoRosesInRed, IsAwarded = false, IsAccepted = true, Score= 33 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Colour, Image = lRagMan, IsAwarded = false, IsAccepted = false, Score=27 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Colour , Image = lMidnightVoyage, IsAwarded = false, IsAccepted = false, Score=25 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Portrait, Image = lByLamplight, IsAwarded = true, AwardDetails="HM", IsAccepted = true, Score=33 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Portrait, Image = lvictorianRailwayWorker, IsAwarded = false, IsAccepted = false, Score= 28 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Portrait, Image = lEngineDriver, IsAwarded = false, IsAccepted = false, Score=26 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Portrait , Image = lVictorianRailwayTravel, IsAwarded = false, IsAccepted = false, Score=26 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Landscape, Image = lBridgewaterPlaceAndCanal, IsAwarded = false, IsAccepted = false, Score=24 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Landscape, Image = lATexturedTree, IsAwarded = false, IsAccepted = false, Score= 27 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Landscape, Image = lPagoda, IsAwarded = false, IsAccepted = false, Score=24 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Landscape , Image = lATowerByTheSea, IsAwarded = false, IsAccepted = false, Score=27 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Nature, Image = lMarbledTreeFrog, IsAwarded = false, IsAccepted = false, Score=25 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Nature, Image = lCommonToadOnRock, IsAwarded = false, IsAccepted = false, Score= 27 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Nature, Image = lChileanRoseTarantulaOnTree, IsAwarded = false, IsAccepted = false, Score=26 },
                                                            new CompetitionEntryEntity { Section = lSalonYearPamir2020Nature , Image = lLeopardGecko, IsAwarded = false, IsAccepted = false, Score=27 },


                                                                        },
                                                                    },
                                                                });

                        // Swedish Small Print 2020
                        var lSalonSwedishSmallPrint = new SalonEntity { Name = "Swedish Small Print", Website = "http://swipa.dinstudio.se/filearea_29.html", Country = lCountrySweden };


                        var lSalonYearSwedishSmallPrint2020 = new SalonYearEntity { Name = "Swedish Small Print", Salon = lSalonSwedishSmallPrint, Year = 2020, ClosingDate = new DateTime(2020, 04, 14), JudgeDate = new DateTime(2020, 04, 18), NotificationDate = new DateTime(2020, 04, 25), CataloguesPostedDate = new DateTime(2020, 6, 21) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                                            new AccreditationEntity() { SalonNumber = "2020/102", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearSwedishSmallPrint2020 },
                                                                            new AccreditationEntity() { SalonNumber = "2020-168", PhotoOrganisation = lPsa, SalonYear = lSalonYearSwedishSmallPrint2020 },
                                                                });

                        var lSalonYearSwedishSmallPrint2020Colour = new SectionEntity() { SalonYear = lSalonYearSwedishSmallPrint2020, SectionType = lSectionTypeColourPrint };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                                    new SubmissionEntity(){
                                                                    IsJudged = true,
                                                                    EntryCost = 18.62M,
                                                                    SalonYear = lSalonYearSwedishSmallPrint2020,
                                                                    EntryDate = new DateTime(2020, 3, 1),
                                                                    Person = lTim,
                                                                    Entries = new List<CompetitionEntryEntity> {

                                                                            new CompetitionEntryEntity { Section = lSalonYearSwedishSmallPrint2020Colour, Image = lBetwixtRealities, IsAwarded = false, IsAccepted = true, Score=11 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearSwedishSmallPrint2020Colour, Image = lEnteringTheMaelstrom, IsAwarded = true, AwardDetails="PSA Ribbon", IsAccepted = true, Score= 12 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearSwedishSmallPrint2020Colour, Image = lIUsedToDreamIdMarryAPrince, IsAwarded = false, IsAccepted = true, Score=10 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearSwedishSmallPrint2020Colour , Image = lJilted, IsAwarded = false, IsAccepted = false, Score=8 },


                                                                                   },
                                                                            },
                                                                        });

						// Good Light 2020

						var lGlowingRose = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Glowing Rose" };
						var lPyramidSwirl = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Pyramind Swirl" };
						var lIncomingRain = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Incoming Rain" };
						var lZigZagShadow = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Zig Zag Shadow" };
						var lUninterestingView = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Uninteresting View" };
						var lHogOnCar = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Hog On Car" };
						var lPurpleBloom = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Purple Bloom" };
						var lAMeetingOfMinds = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "A Meeting of Minds" };
						var lTheSummoning = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Summoning" };
						var lMaskedRed = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Masked Red" };
						var lThreeLeavesMono = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Three Leaves Mono" };
						var lNighttimeExcursions = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Nighttime Excursions" };

                        var lSalonYearGoodLight2020 = new SalonYearEntity { Name = "Good Light", Salon = lSalonGoodLight, Year = 2020, ClosingDate = new DateTime(2020, 5, 8), JudgeDate = new DateTime(2020, 05, 23), NotificationDate = new DateTime(2020, 05, 30), CataloguesPostedDate = new DateTime(2020, 7, 1) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                                            new AccreditationEntity() { SalonNumber = "2020/119", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearGoodLight2020 },
                                                                            new AccreditationEntity() { SalonNumber = "2020-162", PhotoOrganisation = lPsa, SalonYear = lSalonYearGoodLight2020 },
                                                                });

                        var lSalonYearGoodLight2020GoodLight = new SectionEntity() { SalonYear = lSalonYearGoodLight2020, SectionType = lSectionTypeGoodLightPdi };
						var lSalonYearGoodLight2020Life = new SectionEntity() { SalonYear = lSalonYearGoodLight2020, SectionType = lSectionTypePhotojournalismPdi };
						var lSalonYearGoodLight2020Nature = new SectionEntity() { SalonYear = lSalonYearGoodLight2020, SectionType = lSectionTypeNaturePdi };
						var lSalonYearGoodLight2020Colour = new SectionEntity() { SalonYear = lSalonYearGoodLight2020, SectionType = lSectionTypeColourPdi };
						var lSalonYearGoodLight2020Mono = new SectionEntity() { SalonYear = lSalonYearGoodLight2020, SectionType = lSectionTypeMonoPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                                    new SubmissionEntity(){
                                                                    IsJudged = true,
                                                                    EntryCost = 18.35M,
                                                                    SalonYear = lSalonYearGoodLight2020,
                                                                    EntryDate = new DateTime(2020, 5, 1),
                                                                    Person = lTim,
                                                                    Entries = new List<CompetitionEntryEntity> {

                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020GoodLight, Image = lGlowingRose, IsAwarded = false, IsAccepted = false, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020GoodLight, Image = lPyramidSwirl, IsAwarded = false, IsAccepted = false, Score= 0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020GoodLight, Image = lIncomingRain, IsAwarded = false, IsAccepted = false, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020GoodLight , Image = lZigZagShadow, IsAwarded = false, IsAccepted = false, Score=0 },
 																			new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Life, Image = lUninterestingView, IsAwarded = false, IsAccepted = false, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Life, Image = lHogOnCar, IsAwarded = false, IsAccepted = false, Score= 0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Life, Image = lLoversInAndalucia, IsAwarded = false, IsAccepted = false, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Life , Image = lSolentSunset, IsAwarded = false, IsAccepted = true, Score=0 },
 																			new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Nature, Image = lMarbledTreeFrog, IsAwarded = false, IsAccepted = false, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Nature, Image = lCommonToadOnRock, IsAwarded = false, IsAccepted = false, Score= 0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Nature, Image = lLeopardGecko, IsAwarded = false, IsAccepted = false, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Nature , Image = lChileanRoseTarantulaOnTree, IsAwarded = false, IsAccepted = true, Score=0 },
 																			new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Colour, Image = lPurpleBloom, IsAwarded = false, IsAccepted = false, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Colour, Image = lAMeetingOfMinds, IsAwarded = false, IsAccepted = false, Score= 0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Colour, Image = lTheSummoning, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Colour , Image = lMaskedRed, IsAwarded = false, IsAccepted = false, Score=0 },
 																			new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Mono, Image = lADaisyInMono, IsAwarded = false, IsAccepted = false, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Mono, Image = lNighttimeExcursions, IsAwarded = false, IsAccepted = false, Score= 0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                            new CompetitionEntryEntity { Section = lSalonYearGoodLight2020Mono , Image = lThreeLeavesMono, IsAwarded = false, IsAccepted = false, Score=0 },


                                                                                   },
                                                                            },
                                                                        });


                                        // Fotogram 2020
						                var lSalonFotogram = new SalonEntity { Name = "Fotogram", Website = "http://fotogram.in.rs/", Country = lCountrySerbia };
                                        var lSalonYearFotogram2020 = new SalonYearEntity { Name = "Fotogram", Salon = lSalonFotogram, Year = 2020, ClosingDate = new DateTime(2020, 5, 8), JudgeDate = new DateTime(2020, 05, 23), NotificationDate = new DateTime(2020, 05, 30), CataloguesPostedDate = new DateTime(2020, 7, 1) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/132", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearFotogram2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-148", PhotoOrganisation = lPsa, SalonYear = lSalonYearFotogram2020 },
                                        });

                                        var lSalonYearFotogram2020Colour = new SectionEntity() { SalonYear = lSalonYearFotogram2020, SectionType = lSectionTypeColourPdi };
                            						var lSalonYearFotogram2020Mono = new SectionEntity() { SalonYear = lSalonYearFotogram2020, SectionType = lSectionTypeMonoPdi };


                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 20.17M,
                                                    SalonYear = lSalonYearFotogram2020,
                                                    EntryDate = new DateTime(2020, 6, 1),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearFotogram2020Colour, Image = lByLamplight, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearFotogram2020Mono, Image = lThreeLeavesMono, IsAwarded = false, IsAccepted = true, Score= 0 },
                                                                   },
                                                            },
                                                        });

                        // Manhattan 2020
						var lMemento = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Memento" };
						var lTheInfinityDevice = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Infinity Device" };
                                        var lSalonYearManhattan2020 = new SalonYearEntity { Name = "Manhattan", Salon = lSalonManhattan, Year = 2020, ClosingDate = new DateTime(2020, 5, 25), JudgeDate = new DateTime(2020, 6, 1), NotificationDate = new DateTime(2020, 6, 15), CataloguesPostedDate = new DateTime(2020, 6, 15) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/265", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearManhattan2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-011", PhotoOrganisation = lPsa, SalonYear = lSalonYearManhattan2020 },
                                        });

                                        var llSalonYearManhattan2020Colour = new SectionEntity() { SalonYear = lSalonYearManhattan2020, SectionType = lSectionTypeColourPdi };
                            			var llSalonYearManhattan20200Mono = new SectionEntity() { SalonYear = lSalonYearManhattan2020, SectionType = lSectionTypeMonoPdi };


                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 8.55M,
                                                    SalonYear = lSalonYearManhattan2020,
                                                    EntryDate = new DateTime(2020, 5, 25),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearFotogram2020Colour, Image = lMemento, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearFotogram2020Mono, Image = lTheInfinityDevice, IsAwarded = false, IsAccepted = true, Score= 0 },
                                                                   },
                                                            },
                                                        });

                             // Midland 2020
                             var lSalonYearMidland2020 = new SalonYearEntity { Name = "Midland", Salon = lSalonMidlandCounties, Year = 2020, ClosingDate = new DateTime(2020, 6, 25), JudgeDate = new DateTime(2020, 7, 1), NotificationDate = new DateTime(2020, 7, 15), CataloguesPostedDate = new DateTime(2020, 7, 15) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/246", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearMidland2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-267", PhotoOrganisation = lPsa, SalonYear = lSalonYearMidland2020 },
                                                    new AccreditationEntity() { SalonNumber = "L200073-M6G", PhotoOrganisation = lGpu, SalonYear = lSalonYearMidland2020 },
                                        });

                                        var llSalonYeaMidland2020Creative = new SectionEntity() { SalonYear = lSalonYearMidland2020, SectionType = lSectionTypeCreativePdi };


                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 21.00M,
                                                    SalonYear = lSalonYearMidland2020,
                                                    EntryDate = new DateTime(2020, 6, 23),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = llSalonYeaMidland2020Creative, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });


                            // Gradac 2020
                            var lTwinIsolation = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Twin Isolation" };
						     var lSalonYearGradac2020 = new SalonYearEntity { Name = "Gradac", Salon = lSalonGradac, Year = 2020, ClosingDate = new DateTime(2020, 6, 25), JudgeDate = new DateTime(2020, 7, 1), NotificationDate = new DateTime(2020, 7, 15), CataloguesPostedDate = new DateTime(2020, 7, 15) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/017", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearGradac2020 },
                                        });

                                        var llSalonYeaGradac2020Mono = new SectionEntity() { SalonYear = lSalonYearGradac2020, SectionType = lSectionTypeMonoPdi };


                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 18.89M,
                                                    SalonYear = lSalonYearGradac2020,
                                                    EntryDate = new DateTime(2020, 7, 1),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = llSalonYeaGradac2020Mono, Image = lTwinIsolation, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });

                            // ISSYK-KUL 2020
                             var lHalfTheWorldIsUpsideDown = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Half The World Is Upside Down" };
                             var lVermodalen = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Vermodalen" };
                             var lIsolation = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Isolation" };
						     var lSalonIssykKul = new SalonEntity { Name = "Issyk Kul", Website = "http://issyk-kulexhibition.com/", Country = lCountryKyrgystan };
                             var lSalonYearIssykKul2020 = new SalonYearEntity { Name = "Issyk Kul", Salon = lSalonIssykKul, Year = 2020, ClosingDate = new DateTime(2020, 6, 26), JudgeDate = new DateTime(2020, 7, 1), NotificationDate = new DateTime(2020, 7, 15), CataloguesPostedDate = new DateTime(2020, 7, 15) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/316", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearIssykKul2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-151", PhotoOrganisation = lPsa, SalonYear = lSalonYearIssykKul2020 },
                                        });

                                        var lSalonYearIssykKul2020Colour = new SectionEntity() { SalonYear = lSalonYearIssykKul2020, SectionType = lSectionTypeColourPdi };
                                        var lSalonYearIssykKul2020Sea = new SectionEntity() { SalonYear = lSalonYearIssykKul2020, SectionType = lSectionTypeColourPdi };


                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 21.12M,
                                                    SalonYear = lSalonYearIssykKul2020,
                                                    EntryDate = new DateTime(2020, 7, 1),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearIssykKul2020Colour, Image = lHalfTheWorldIsUpsideDown, IsAwarded = false, IsAccepted = true, Score=19 },
                                                            new CompetitionEntryEntity { Section = lSalonYearIssykKul2020Colour, Image = lVermodalen, IsAwarded = false, IsAccepted = true, Score=19 },
                                                            new CompetitionEntryEntity { Section = lSalonYearIssykKul2020Sea, Image = lWatchingTheWind, IsAwarded = false, IsAccepted = true, Score=19 },
                                                            new CompetitionEntryEntity { Section = lSalonYearIssykKul2020Sea, Image = lIsolation, IsAwarded = false, IsAccepted = true, Score=18},
                                                                   },
                                                            },
                                                        });                   

                        // Danube Circuit 2020
                        var lDanubeCircuit2020 = new CircuitEntity() { Name = "Danube Circuit" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                                lDanubeCircuit2020,
                                            });

                        var lDandelionTurbulance = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Dandelion Turbulance" };
                   
                        var lSalonDanubeRomania = new SalonEntity { Name = "Danube - Romania", Website = "http://photoclub-danube.com/", Country = lCountryRomania};
                        var lSalonDanubeBulgaria = new SalonEntity { Name = "Danube - Bulgaria", Website = "http://photoclub-danube.com/", Country = lCountryBulgaria};

                        var lSalonYearDanubeRomania2020 = new SalonYearEntity { Name = "Danube - Romania", Salon = lSalonAutumnElema, Year = 2020, ClosingDate = new DateTime(2020, 6, 27), JudgeDate = new DateTime(2020, 7, 1), NotificationDate = new DateTime(2020, 7, 15), CataloguesPostedDate = new DateTime(2020, 7, 15), Circuit = lDanubeCircuit2020 };
                        var lSalonYearDanubeBulgaria2020 = new SalonYearEntity { Name = "Danube - Bulgaria", Salon = lSalonAutumnElema, Year = 2020, ClosingDate = new DateTime(2020, 6, 27), JudgeDate = new DateTime(2020, 7, 1), NotificationDate = new DateTime(2020, 7, 15), CataloguesPostedDate = new DateTime(2020, 7, 15), Circuit = lDanubeCircuit2020 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/248", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearDanubeRomania2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-264", PhotoOrganisation = lPsa, SalonYear = lSalonYearDanubeRomania2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/249", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearDanubeBulgaria2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-264", PhotoOrganisation = lPsa, SalonYear = lSalonYearDanubeBulgaria2020 },
                                                });                                                

                        var lSalonYearDanubeRomania2020Water = new SectionEntity() { SalonYear = lSalonYearDanubeRomania2020, SectionType = lSectionTypeColourPdi };
                        var lSalonYearDanubeRomania2020Colour = new SectionEntity() { SalonYear = lSalonYearDanubeRomania2020, SectionType = lSectionTypeColourPdi };
                        var lSalonYearDanubeBulgaria2020Nature = new SectionEntity() { SalonYear = lSalonYearDanubeBulgaria2020, SectionType = lSectionTypeNaturePdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 15.00M,
                                                        SalonYear = lSalonYearDanubeRomania2020,
                                                        EntryDate = new DateTime(2020, 06, 01),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearDanubeRomania2020Water, Image = lGrasmereRocks, IsAwarded = false, IsAccepted = true, Score=20 },
                                                            new CompetitionEntryEntity { Section = lSalonYearDanubeRomania2020Colour, Image = lDandelionTurbulance, IsAwarded = false, IsAccepted = true, Score= 21},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 18.15M,
                                                        SalonYear = lSalonYearDanubeBulgaria2020,
                                                        EntryDate = new DateTime(2020, 06, 01),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearDanubeBulgaria2020Nature, Image = lCommonToadOnRock, IsAwarded = false, IsAccepted = true, Score=22 },

                                                        },
                                                    },
                                                });                                                


                            // PhotoStatic 2020
                            var lMonkPortal = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Monk Portal" };
                            var lSalonPhotoStatic = new SalonEntity { Name = "Photo Static", Website = "http://www.photostatic.in/", Country = lCountryIndia };
						     var lSalonYearPhotoStatic2020 = new SalonYearEntity { Name = "Photo Static", Salon = lSalonPhotoStatic, Year = 2020, ClosingDate = new DateTime(2020, 7, 27), JudgeDate = new DateTime(2020, 7, 9), NotificationDate = new DateTime(2020, 7, 15), CataloguesPostedDate = new DateTime(2020, 7, 15) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/407", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearPhotoStatic2020 },
                                        });

                                        var lSalonYearPhotoStatic2020Mono = new SectionEntity() { SalonYear = lSalonYearPhotoStatic2020, SectionType = lSectionTypeMonoPdi };


                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 18.79M,
                                                    SalonYear = lSalonYearPhotoStatic2020,
                                                    EntryDate = new DateTime(2020, 7, 26),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearPhotoStatic2020Mono, Image = lMonkPortal, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });

                        // Queensland Circuit 2020
                        var lQueenslandCircuit2020 = new CircuitEntity() { Name = "Queensland Circuit" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                                lQueenslandCircuit2020,
                                            });

                        var lSecondSummoning = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Second Summoning" };
                        var lBlueFeather = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Blue Feather" };
                   
                        var lSalonYearGoldCoastQld2020 = new SalonYearEntity { Name = "Queensland - Gold Coast", Salon = lSalonGoldCoast, Year = 2020, ClosingDate = new DateTime(2020, 8, 10), JudgeDate = new DateTime(2020, 8, 23), NotificationDate = new DateTime(2020, 9, 6), CataloguesPostedDate = new DateTime(2020, 11, 10), Circuit = lQueenslandCircuit2020 };
                        var lSalonYearMaryboroughQld2020 = new SalonYearEntity { Name = "Queensland - Maryborough", Salon = lSalonMarybourgh, Year = 2020, ClosingDate = new DateTime(2020, 8, 10), JudgeDate = new DateTime(2020, 8, 23), NotificationDate = new DateTime(2020, 9, 6), CataloguesPostedDate = new DateTime(2020, 11, 10), Circuit = lQueenslandCircuit2020 };
                        var lSalonYearMtGravattQld2020 = new SalonYearEntity { Name = "Queensland - Mt Gravatt", Salon = lSalonMtGravatt, Year = 2020, ClosingDate = new DateTime(2020, 8, 10), JudgeDate = new DateTime(2020, 8, 23), NotificationDate = new DateTime(2020, 9, 6), CataloguesPostedDate = new DateTime(2020, 11, 10), Circuit = lQueenslandCircuit2020 };
                        var lSalonYeartownsvilleQld2020 = new SalonYearEntity { Name = "Queensland - Townsville", Salon = lSalonTownsville, Year = 2020, ClosingDate = new DateTime(2020, 8, 10), JudgeDate = new DateTime(2020, 8, 23), NotificationDate = new DateTime(2020, 9, 6), CataloguesPostedDate = new DateTime(2020, 11, 10), Circuit = lQueenslandCircuit2020 };


                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/145", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearGoldCoastQld2020 },
                                                    new AccreditationEntity() { SalonNumber = "20120-181", PhotoOrganisation = lPsa, SalonYear = lSalonYearGoldCoastQld2020 },
                                                    new AccreditationEntity() { SalonNumber = "L200049", PhotoOrganisation = lGpu, SalonYear = lSalonYearGoldCoastQld2020 },
                                                });


                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/146", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearMaryboroughQld2020 },
                                                    new AccreditationEntity() { SalonNumber = "20120-181", PhotoOrganisation = lPsa, SalonYear = lSalonYearMaryboroughQld2020 },
                                                    new AccreditationEntity() { SalonNumber = "L200049", PhotoOrganisation = lGpu, SalonYear = lSalonYearMaryboroughQld2020 },
                                                });


                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/147", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearMtGravattQld2020 },
                                                    new AccreditationEntity() { SalonNumber = "20120-181", PhotoOrganisation = lPsa, SalonYear = lSalonYearMtGravattQld2020 },
                                                    new AccreditationEntity() { SalonNumber = "L200049", PhotoOrganisation = lGpu, SalonYear = lSalonYearMtGravattQld2020 },
                                                });


                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/148", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYeartownsvilleQld2020 },
                                                    new AccreditationEntity() { SalonNumber = "20120-181", PhotoOrganisation = lPsa, SalonYear = lSalonYeartownsvilleQld2020 },
                                                    new AccreditationEntity() { SalonNumber = "L200049", PhotoOrganisation = lGpu, SalonYear = lSalonYeartownsvilleQld2020 },
                                                });
                        
                        var lSalonYearGoldCoast2020Colour = new SectionEntity() { SalonYear = lSalonYearGoldCoastQld2020, SectionType = lSectionTypeColourPdi };
                        var lSalonYearMtGravatt2020Colour = new SectionEntity() { SalonYear = lSalonYearMtGravattQld2020, SectionType = lSectionTypeColourPdi };

                        var lSalonYearMtGravatt2020Action = new SectionEntity() { SalonYear = lSalonYearMtGravattQld2020, SectionType = lSectionTypeActionMovementSportPdi };
                        var lSalonYearTownsville2020Action = new SectionEntity() { SalonYear = lSalonYeartownsvilleQld2020, SectionType = lSectionTypeActionMovementSportPdi };

                        var lSalonYearGoldCoast2020Mono = new SectionEntity() { SalonYear = lSalonYearGoldCoastQld2020, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearMaryborough2020Mono = new SectionEntity() { SalonYear = lSalonYearMaryboroughQld2020, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearMtGravatt2020Mono = new SectionEntity() { SalonYear = lSalonYearMtGravattQld2020, SectionType = lSectionTypeMonoPdi };

                        var lSalonYearMaryborough2020Nature = new SectionEntity() { SalonYear = lSalonYearMaryboroughQld2020, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearMtGravatt2020Nature = new SectionEntity() { SalonYear = lSalonYearMtGravattQld2020, SectionType = lSectionTypeNaturePdi };
                        var lSalonYearTownsville2020Nature = new SectionEntity() { SalonYear = lSalonYeartownsvilleQld2020, SectionType = lSectionTypeNaturePdi };


                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 12.32M,
                                                        SalonYear = lSalonYearGoldCoastQld2020,
                                                        EntryDate = new DateTime(2020, 09, 08),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearGoldCoast2020Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearGoldCoast2020Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = true, Score= 0},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 12.32M,
                                                        SalonYear = lSalonYearMaryboroughQld2020,
                                                        EntryDate = new DateTime(2020, 09, 08),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearMaryborough2020Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearMaryborough2020Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score= 0},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 12.32M,
                                                        SalonYear = lSalonYearMtGravattQld2020,
                                                        EntryDate = new DateTime(2020, 09, 08),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearMtGravatt2020Colour, Image = lSecondSummoning, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearMtGravatt2020Colour, Image = lTheSeamstressTakesHerFee, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearMtGravatt2020Colour, Image = lBlueFeather, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearMtGravatt2020Action, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = true, Score= 0},
                                                            new CompetitionEntryEntity { Section = lSalonYearMtGravatt2020Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = true, Score= 0},
                                                            new CompetitionEntryEntity { Section = lSalonYearMtGravatt2020Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score= 0},
                                                            new CompetitionEntryEntity { Section = lSalonYearMtGravatt2020Nature, Image = lMarbledTreeFrog, IsAwarded = false, IsAccepted = true, Score= 0},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 12.33M,
                                                        SalonYear = lSalonYeartownsvilleQld2020,
                                                        EntryDate = new DateTime(2020, 09, 08),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearTownsville2020Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearTownsville2020Action, Image = lTourDeYorkshire2019, IsAwarded = false, IsAccepted = true, Score= 0},
                                                        },
                                                    },
                                                });

                        // lanterna magica
                        var lBaronBone = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Baron Bone" };
                        
                        var lSalonYearLanternaMagica2020 = new SalonYearEntity { Name = "Lanterna Magica", Salon = lSalonLanternaMagica, Year = 2020, ClosingDate = new DateTime(2020, 9, 7), JudgeDate = new DateTime(2020, 9, 20), NotificationDate = new DateTime(2020, 10, 04), CataloguesPostedDate = new DateTime(2020, 11, 29) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/229", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearLanternaMagica2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-266", PhotoOrganisation = lPsa, SalonYear = lSalonYearLanternaMagica2020 },
                                        });

                                        var lSalonYearLanternaMagica2020Mono = new SectionEntity() { SalonYear = lSalonYearLanternaMagica2020, SectionType = lSectionTypeMonoPdi };
                                        var lSalonYearLanternaMagica2020LanternaMagica = new SectionEntity() { SalonYear = lSalonYearLanternaMagica2020, SectionType = lSectionTypeColourPdi };


                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 0M,
                                                    SalonYear = lSalonYearLanternaMagica2020,
                                                    EntryDate = new DateTime(2020, 9, 1),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2020Mono, Image = lMonkPortal, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2020Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2020LanternaMagica, Image = lTheSummoning, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonYearLanternaMagica2020LanternaMagica, Image = lBaronBone, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });


                        // Summer, Sea, Sun 2020
                        var lRailwayChildren = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Railway Children" };
                        var lEngineDriversSon = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Engine Driver's Son" };
                        var lDomi = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Domi" };
                        var lMajesty = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Majesty" };
                        var lDomiAtTheBall = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Domi At The Ball" };
                        var lWindswept = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Windswept" };

                        var lSalonSummerSeaSun = new SalonEntity { Name = "Summer, Sea, Sun", Website = "https://summerseasun.fotoklubkrk.hr/", Country = lCountryRomania};
                        var lSalonSummerSeaSun2020 = new SalonYearEntity { Name = "Summer, Sea, Sun", Salon = lSalonSummerSeaSun, Year = 2020, ClosingDate = new DateTime(2020, 9, 20), JudgeDate = new DateTime(2020, 9, 27), NotificationDate = new DateTime(2020, 10, 5), CataloguesPostedDate = new DateTime(2020, 10, 27) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/287", PhotoOrganisation = lFiapLevels, SalonYear = lSalonSummerSeaSun2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-310", PhotoOrganisation = lPsa, SalonYear = lSalonSummerSeaSun2020 },
                                        });

                                        var lSalonSummerSeaSun2020Child = new SectionEntity() { SalonYear = lSalonSummerSeaSun2020, SectionType = lSectionTypeChildPdi };
                                        var lSalonSummerSeaSun2020Portrait = new SectionEntity() { SalonYear = lSalonSummerSeaSun2020, SectionType = lSectionTypePortraitPdi };
                                        var lSalonSummerSeaSun2020Nature = new SectionEntity() { SalonYear = lSalonSummerSeaSun2020, SectionType = lSectionTypeNaturePdi };
                                        var lSalonSummerSeaSun2020Colour = new SectionEntity() { SalonYear = lSalonSummerSeaSun2020, SectionType = lSectionTypeColourPdi };
                                        var lSalonSummerSeaSun2020Mono = new SectionEntity() { SalonYear = lSalonSummerSeaSun2020, SectionType = lSectionTypeMonoPdi };


                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 24.06M,
                                                    SalonYear = lSalonSummerSeaSun2020,
                                                    EntryDate = new DateTime(2020, 9, 19),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Child, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Child, Image = lRailwayChildren, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Child, Image = lEngineDriversSon, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Portrait, Image = lDomi, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Portrait, Image = lMajesty, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Portrait, Image = lDomiAtTheBall, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Nature, Image = lGargoyleGecko, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Nature, Image = lCrestedGeckoTongue, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Colour, Image = lWindswept, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonSummerSeaSun2020Mono, Image = lTwinIsolation, IsAwarded = true, AwardDetails="Silver", IsAccepted = true, Score=0 },                                                            
                                                                   },
                                                            },
                                                        });

                        // child circuit
                        var lChildCircuit2020 = new CircuitEntity() { Name = "Child Circuit" };

                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                                lChildCircuit2020,
                                            });

                        var lSwordInTheStone = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Sword In The Stone" };
                        var lTranquil = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Tranquil" };
                   
                        var lSalonChildSerbia = new SalonEntity { Name = "Child - Zajecar", Website = "http://photoclub-danube.com/", Country = lCountrySerbia};
                        var lSalonChildRussia = new SalonEntity { Name = "Child - Penza", Website = "http://photoclub-danube.com/", Country = lCountryRussia};

                        var lSalonYearChildSerbia2020 = new SalonYearEntity { Name = "Child - Zajecar", Salon = lSalonChildSerbia, Year = 2020, ClosingDate = new DateTime(2020, 9, 16), JudgeDate = new DateTime(2020, 10, 1), NotificationDate = new DateTime(2020, 10, 11), CataloguesPostedDate = new DateTime(2020, 10, 11), Circuit = lChildCircuit2020 };
                        var lSalonYearChildRussia2020 = new SalonYearEntity { Name = "Child - Penza", Salon = lSalonChildRussia, Year = 2020, ClosingDate = new DateTime(2020, 9, 16), JudgeDate = new DateTime(2020, 10, 1), NotificationDate = new DateTime(2020, 10, 11), CataloguesPostedDate = new DateTime(2020, 10, 11), Circuit = lChildCircuit2020 };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/374", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearChildSerbia2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-347", PhotoOrganisation = lPsa, SalonYear = lSalonYearChildSerbia2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/376", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYearChildRussia2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-347", PhotoOrganisation = lPsa, SalonYear = lSalonYearChildRussia2020 },
                                                });                                                

                        var lSalonYearChildSerbia2020People = new SectionEntity() { SalonYear = lSalonYearChildSerbia2020, SectionType = lSectionTypePeoplePdi };
                        var lSalonYearChildSerbia2020Mono = new SectionEntity() { SalonYear = lSalonYearChildSerbia2020, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearChildRussia2020Child = new SectionEntity() { SalonYear = lSalonYearChildRussia2020, SectionType = lSectionTypeChildPdi };
                        var lSalonYearChildRussia2020Mono = new SectionEntity() { SalonYear = lSalonYearChildRussia2020, SectionType = lSectionTypeMonoPdi };
                        var lSalonYearChildRussia2020Colour = new SectionEntity() { SalonYear = lSalonYearChildRussia2020, SectionType = lSectionTypeColourPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 16.84M,
                                                        SalonYear = lSalonYearChildSerbia2020,
                                                        EntryDate = new DateTime(2020, 10, 16),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearChildSerbia2020People, Image = lMajesty, IsAwarded = false, IsAccepted = true, Score=24 },
                                                            new CompetitionEntryEntity { Section = lSalonYearChildSerbia2020People, Image = lDomiAtTheBall, IsAwarded = false, IsAccepted = true, Score= 24},
                                                            new CompetitionEntryEntity { Section = lSalonYearChildSerbia2020Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = true, Score= 23},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 16.84M,
                                                        SalonYear = lSalonYearChildRussia2020,
                                                        EntryDate = new DateTime(2020, 10, 16),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYearChildRussia2020Child, Image = lRailwayChildren, IsAwarded = false, IsAccepted = true, Score=18 },
                                                            new CompetitionEntryEntity { Section = lSalonYearChildRussia2020Mono, Image = lTwinIsolation, IsAwarded = false, IsAccepted = true, Score=20 },
                                                            new CompetitionEntryEntity { Section = lSalonYearChildRussia2020Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = true, Score=17 },
                                                            new CompetitionEntryEntity { Section = lSalonYearChildRussia2020Mono, Image = lSwordInTheStone, IsAwarded = false, IsAccepted = true, Score=17 },
                                                            new CompetitionEntryEntity { Section = lSalonYearChildRussia2020Colour, Image = lTranquil, IsAwarded = false, IsAccepted = true, Score=18 },

                                                        },
                                                    },
                                                });     

                        // finland circuit                                           
                        var lFinlandCircuit2020 = new CircuitEntity() { Name = "Finland International Circuit" };
                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                                 lFinlandCircuit2020,
                                             });

                        var lSalonKouvolaFinland = new SalonEntity { Name = "Finland - Kouvola", Website = "http://www.finlandcircuit.fi/", Country = lCountryFinland };
                        var lSalonKuopioFinland = new SalonEntity { Name = "Finland - Kuopio", Website = "http://www.finlandcircuit.fi/", Country = lCountryFinland };
                        var lSalonTampereFinland = new SalonEntity { Name = "Finland - Tampere", Website = "http://www.finlandcircuit.fi/", Country = lCountryFinland };
                        var lSalonYivieskaFinland = new SalonEntity { Name = "Finland - Ylivieska", Website = "http://www.finlandcircuit.fi/", Country = lCountryFinland };
                        var lSalonVihtiFinland = new SalonEntity { Name = "Finland - Vihti", Website = "http://www.finlandcircuit.fi/", Country = lCountryFinland };

                        var lSalonKouvolaFinland2020 = new SalonYearEntity { Name = "Finland - Kouvola", Salon = lSalonKouvolaFinland, Year = 2020, ClosingDate = new DateTime(2020, 10, 19), JudgeDate = new DateTime(2020, 11, 1), NotificationDate = new DateTime(2020, 1, 5), CataloguesPostedDate = new DateTime(2020, 11, 5), Circuit = lFinlandCircuit2020 };
                        var lSalonKuopioFinland2020 = new SalonYearEntity { Name = "Finland - Kuopio", Salon = lSalonKuopioFinland, Year = 2020, ClosingDate = new DateTime(2020, 10, 19), JudgeDate = new DateTime(2020, 11, 1), NotificationDate = new DateTime(2020, 1, 5), CataloguesPostedDate = new DateTime(2020, 11, 5), Circuit = lFinlandCircuit2020 };
                        var lSalonTampereFinland2020 = new SalonYearEntity { Name = "Finland - Tampere", Salon = lSalonTampereFinland, Year = 2020, ClosingDate = new DateTime(2020, 10, 19), JudgeDate = new DateTime(2020, 11, 1), NotificationDate = new DateTime(2020, 1, 5), CataloguesPostedDate = new DateTime(2020, 11, 5), Circuit = lFinlandCircuit2020 };
                        var lSalonYivieskaFinland2020 = new SalonYearEntity { Name = "Finland - Ylivieska", Salon = lSalonYivieskaFinland, Year = 2020, ClosingDate = new DateTime(2020, 10, 19), JudgeDate = new DateTime(2020, 11, 1), NotificationDate = new DateTime(2020, 1, 5), CataloguesPostedDate = new DateTime(2020, 11, 5), Circuit = lFinlandCircuit2020 };
                        var lSalonVihtiFinland2020 = new SalonYearEntity { Name = "Finland - Vihti", Salon = lSalonVihtiFinland, Year = 2020, ClosingDate = new DateTime(2020, 10, 19), JudgeDate = new DateTime(2020, 11, 1), NotificationDate = new DateTime(2020, 1, 5), CataloguesPostedDate = new DateTime(2020, 11, 5), Circuit = lFinlandCircuit2020 };
                       
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/432", PhotoOrganisation = lFiapLevels, SalonYear = lSalonKouvolaFinland2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/433", PhotoOrganisation = lFiapLevels, SalonYear = lSalonKuopioFinland2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/434", PhotoOrganisation = lFiapLevels, SalonYear = lSalonTampereFinland2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/435", PhotoOrganisation = lFiapLevels, SalonYear = lSalonYivieskaFinland2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                  new AccreditationEntity() { SalonNumber = "2020/436", PhotoOrganisation = lFiapLevels, SalonYear = lSalonVihtiFinland2020 },
                                               });

                        var lSalonKouvolaFinland2020Colour = new SectionEntity() { SalonYear = lSalonKouvolaFinland2020, SectionType = lSectionTypeColourPdi };
                        var lSalonKouvolaFinland2020Nature = new SectionEntity() { SalonYear = lSalonKouvolaFinland2020, SectionType = lSectionTypeNaturePdi };
                        var lSalonKuopioFinland2020Mono = new SectionEntity() { SalonYear = lSalonKuopioFinland2020, SectionType = lSectionTypeMonoPdi };
                        var lSalonKuopioFinland2020Nature = new SectionEntity() { SalonYear = lSalonKuopioFinland2020, SectionType = lSectionTypeNaturePdi };
                        var lSalonTampereFinland2020Colour = new SectionEntity() { SalonYear = lSalonTampereFinland2020, SectionType = lSectionTypeColourPdi };
                        var lSalonTampereFinland2020Mono = new SectionEntity() { SalonYear = lSalonTampereFinland2020, SectionType = lSectionTypeMonoPdi };
                        var lSalonTampereFinland2020Nature = new SectionEntity() { SalonYear = lSalonTampereFinland2020, SectionType = lSectionTypeNaturePdi };
                        var lSalonYivieskaFinland2020Nature = new SectionEntity() { SalonYear = lSalonYivieskaFinland2020, SectionType = lSectionTypeNaturePdi };
                        var lSalonVihtiFinland2020Nature = new SectionEntity() { SalonYear = lSalonVihtiFinland2020, SectionType = lSectionTypeNaturePdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 7.57M,
                                                        SalonYear = lSalonKouvolaFinland2020,
                                                        EntryDate = new DateTime(2020, 10, 18),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonKouvolaFinland2020Colour, Image = lMajesty, IsAwarded = false, IsAccepted = true, Score=20 },
                                                            new CompetitionEntryEntity { Section = lSalonKouvolaFinland2020Nature, Image = lNorthernWhiteFacedOwl, IsAwarded = false, IsAccepted = true, Score= 22},
                                                            new CompetitionEntryEntity { Section = lSalonKouvolaFinland2020Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score= 19},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 7.57M,
                                                        SalonYear = lSalonKuopioFinland2020,
                                                        EntryDate = new DateTime(2020, 10, 18),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonKuopioFinland2020Mono, Image = lTwinIsolation, IsAwarded = false, IsAccepted = true, Score=21 },
                                                            new CompetitionEntryEntity { Section = lSalonKuopioFinland2020Nature, Image = lRedKiteCall, IsAwarded = false, IsAccepted = true, Score= 21},
                                                            new CompetitionEntryEntity { Section = lSalonKuopioFinland2020Nature, Image = lPeacockTreeFrogTrio, IsAwarded = true, AwardDetails="HM", IsAccepted = true, Score= 24},
                                                            new CompetitionEntryEntity { Section = lSalonKuopioFinland2020Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score= 24},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 7.57M,
                                                        SalonYear = lSalonTampereFinland2020,
                                                        EntryDate = new DateTime(2020, 10, 18),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonTampereFinland2020Colour, Image = lMajesty, IsAwarded = false, IsAccepted = true, Score=19 },
                                                            new CompetitionEntryEntity { Section = lSalonTampereFinland2020Mono, Image = lTowersInTheSky, IsAwarded = true, AwardDetails="HM", IsAccepted = true, Score= 22},
                                                            new CompetitionEntryEntity { Section = lSalonTampereFinland2020Mono, Image = lTwinIsolation, IsAwarded = false, IsAccepted = true, Score= 19},
                                                            new CompetitionEntryEntity { Section = lSalonTampereFinland2020Nature, Image = lNorthernWhiteFacedOwl, IsAwarded = false, IsAccepted = true, Score=19 },
                                                            new CompetitionEntryEntity { Section = lSalonTampereFinland2020Nature, Image = lPeacockTreeFrogTrio, IsAwarded = true, AwardDetails = "HM", IsAccepted = true, Score= 22},
                                                            new CompetitionEntryEntity { Section = lSalonTampereFinland2020Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score= 21},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 7.57M,
                                                        SalonYear = lSalonYivieskaFinland2020,
                                                        EntryDate = new DateTime(2020, 10, 18),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonYivieskaFinland2020Nature, Image = lRedKiteCall, IsAwarded = false, IsAccepted = true, Score=16 },
                                                            new CompetitionEntryEntity { Section = lSalonYivieskaFinland2020Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score= 17},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 7.57M,
                                                        SalonYear = lSalonVihtiFinland2020,
                                                        EntryDate = new DateTime(2020, 10, 18),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonVihtiFinland2020Nature, Image = lRedKiteCall, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonVihtiFinland2020Nature, Image = lMossyFrogOnBranch, IsAwarded = false, IsAccepted = true, Score= 0},
                                                        },
                                                    },
                                                });


                        // desire circuit
                        var lDesireCircuit2020 = new CircuitEntity() { Name = "Desire Circuit" };
                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                                 lDesireCircuit2020,
                                             });

                        var lSalonBorDesire = new SalonEntity { Name = "Desire - Bor", Website = "http://photobalkan.com", Country = lCountrySerbia };
                        var lSalonLiassolDesire = new SalonEntity { Name = "Desire - Limassol", Website = "http:/photobalkan.com", Country = lCountryCyprus};
                        var lSalonOradeaDesire = new SalonEntity { Name = "Desire - Oradea", Website = "http://photobalkan.com", Country = lCountryRomania };
                        var lSalonResiteDesire = new SalonEntity { Name = "Desire - Resita", Website = "http://photobalkan.com", Country = lCountryRomania};


                        var lSalonBorDesire2020 = new SalonYearEntity { Name = "Desire - Bor", Salon = lSalonBorDesire, Year = 2020, ClosingDate = new DateTime(2020, 10, 18), JudgeDate = new DateTime(2020, 11, 1), NotificationDate = new DateTime(2020, 11, 11), CataloguesPostedDate = new DateTime(2020, 11, 11), Circuit = lDesireCircuit2020 };
                        var lSalonLiassolDesire2020 = new SalonYearEntity { Name = "Desire - Limassol", Salon = lSalonLiassolDesire, Year = 2020, ClosingDate = new DateTime(2020, 10, 18), JudgeDate = new DateTime(2020, 11, 1), NotificationDate = new DateTime(2020, 11, 11), CataloguesPostedDate = new DateTime(2020, 11, 11), Circuit = lDesireCircuit2020 };
                        var lSalonOradeaDesire2020 = new SalonYearEntity { Name = "Desire - Oradea", Salon = lSalonOradeaDesire, Year = 2020, ClosingDate = new DateTime(2020, 10, 18), JudgeDate = new DateTime(2020, 11, 1), NotificationDate = new DateTime(2020, 11, 11), CataloguesPostedDate = new DateTime(2020, 11, 11), Circuit = lDesireCircuit2020 };
                        var lSalonResiteDesire2020 = new SalonYearEntity { Name = "Desire - Resita", Salon = lSalonResiteDesire, Year = 2020, ClosingDate = new DateTime(2020, 10, 18), JudgeDate = new DateTime(2020, 11, 1), NotificationDate = new DateTime(2020, 11, 11), CataloguesPostedDate = new DateTime(2020, 11, 11), Circuit = lDesireCircuit2020 };
                       
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/394", PhotoOrganisation = lFiapLevels, SalonYear = lSalonBorDesire2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/395", PhotoOrganisation = lFiapLevels, SalonYear = lSalonLiassolDesire2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/396", PhotoOrganisation = lFiapLevels, SalonYear = lSalonOradeaDesire2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/397", PhotoOrganisation = lFiapLevels, SalonYear = lSalonResiteDesire2020 },
                                               });

                        var lCaveOfTheYeti = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Cave Of The Yeti" };
                        var lTreeline = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Treeline" };
                        var lSummit = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Summit" };
                        var lSnowPeak = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Snow Peak" };

                        var lSalonBorDesire2020Nature = new SectionEntity() { SalonYear = lSalonKouvolaFinland2020, SectionType = lSectionTypeNaturePdi };
                        var lSalonBorDesire2020Mountain = new SectionEntity() { SalonYear = lSalonKouvolaFinland2020, SectionType = lSectionTypeColourPdi };
                        var lSalonLiassolDesire2020Mono = new SectionEntity() { SalonYear = lSalonKuopioFinland2020, SectionType = lSectionTypeMonoPdi };
                        var lSalonOradeaDesire2020Nature = new SectionEntity() { SalonYear = lSalonKuopioFinland2020, SectionType = lSectionTypeNaturePdi };
                        var lSalonOradeaDesire2020Mountain = new SectionEntity() { SalonYear = lSalonTampereFinland2020, SectionType = lSectionTypeColourPdi };
                        var lSalonResiteDesire2020Nature = new SectionEntity() { SalonYear = lSalonTampereFinland2020, SectionType = lSectionTypeNaturePdi };
                        var lSalonResiteDesire2020Mountain = new SectionEntity() { SalonYear = lSalonTampereFinland2020, SectionType = lSectionTypeColourPdi };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 8.28M,
                                                        SalonYear = lSalonBorDesire2020,
                                                        EntryDate = new DateTime(2020, 10, 17),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonBorDesire2020Nature, Image = lRedKiteCall, IsAwarded = false, IsAccepted = true, Score=23 },
                                                            new CompetitionEntryEntity { Section = lSalonBorDesire2020Nature, Image = lRedFox, IsAwarded = false, IsAccepted = true, Score= 23},
                                                            new CompetitionEntryEntity { Section = lSalonBorDesire2020Nature, Image = lNorthernWhiteFacedOwl, IsAwarded = false, IsAccepted = true, Score= 24},
                                                            new CompetitionEntryEntity { Section = lSalonBorDesire2020Mountain, Image = lCaveOfTheYeti, IsAwarded = false, IsAccepted = true, Score=23 },
                                                            new CompetitionEntryEntity { Section = lSalonBorDesire2020Mountain, Image = lTreeline, IsAwarded = false, IsAccepted = true, Score= 23},
                                                            new CompetitionEntryEntity { Section = lSalonBorDesire2020Mountain, Image = lSummit, IsAwarded = false, IsAccepted = true, Score= 25},
                                                            new CompetitionEntryEntity { Section = lSalonBorDesire2020Mountain, Image = lSnowPeak, IsAwarded = false, IsAccepted = true, Score=23 },

                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 8.28M,
                                                        SalonYear = lSalonLiassolDesire2020,
                                                        EntryDate = new DateTime(2020, 10, 17),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonLiassolDesire2020Mono, Image = lTwinIsolation, IsAwarded = false, IsAccepted = true, Score=21 },

                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 8.28M,
                                                        SalonYear = lSalonOradeaDesire2020,
                                                        EntryDate = new DateTime(2020, 10, 17),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonOradeaDesire2020Nature, Image = lNorthernWhiteFacedOwl, IsAwarded = false, IsAccepted = true, Score=23 },
                                                            new CompetitionEntryEntity { Section = lSalonOradeaDesire2020Mountain, Image = lCaveOfTheYeti, IsAwarded = false,IsAccepted = true, Score= 22},
                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 8.28M,
                                                        SalonYear = lSalonResiteDesire2020,
                                                        EntryDate = new DateTime(2020, 10, 17),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonResiteDesire2020Nature, Image = lWindsweptLittleOwl, IsAwarded = false, IsAccepted = true, Score=21 },
                                                            new CompetitionEntryEntity { Section = lSalonResiteDesire2020Nature, Image = lRedKiteCall, IsAwarded = false, IsAccepted = true, Score=21 },
                                                            new CompetitionEntryEntity { Section = lSalonResiteDesire2020Nature, Image = lNorthernWhiteFacedOwl, IsAwarded = false, IsAccepted = true, Score=22 },
                                                            new CompetitionEntryEntity { Section = lSalonResiteDesire2020Mountain, Image = lCaveOfTheYeti, IsAwarded = false, IsAccepted = true, Score= 20},
                                                            new CompetitionEntryEntity { Section = lSalonResiteDesire2020Mountain, Image = lSummit, IsAwarded = true, AwardDetails="Gold", IsAccepted = true, Score= 23},
                                                        },
                                                    },
                                                });


                        // nordic circuit
                        var lNordicCircuit2020 = new CircuitEntity() { Name = "Nordic Circuit" };
                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                                 lNordicCircuit2020,
                                             });

                        var lSalonNordicNorwegian = new SalonEntity { Name = "Nordic - Bergen", Website = "https://nordic.photo/n/nordic-circuit-international/", Country = lCountryNorway };
                        var lSalonNordicDanish = new SalonEntity { Name = "Nordic - Copenhagen", Website = "https://nordic.photo/n/nordic-circuit-international/", Country = lCountryDenmark};
                        

                        var lSalonNordicNorwegian2020 = new SalonYearEntity { Name = "Nordic - Bergen", Salon = lSalonNordicNorwegian, Year = 2020, ClosingDate = new DateTime(2020, 10, 18), JudgeDate = new DateTime(2020, 11, 5), NotificationDate = new DateTime(2020, 11, 11), CataloguesPostedDate = new DateTime(2020, 11, 11), Circuit = lNordicCircuit2020 };
                        var lSalonNordicDanish2020 = new SalonYearEntity { Name = "Nordic - Copenhagen", Salon = lSalonNordicDanish, Year = 2020, ClosingDate = new DateTime(2020, 10, 18), JudgeDate = new DateTime(2020, 11, 5), NotificationDate = new DateTime(2020, 11, 11), CataloguesPostedDate = new DateTime(2020, 11, 11), Circuit = lNordicCircuit2020 };
                       
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/453", PhotoOrganisation = lFiapLevels, SalonYear = lSalonNordicNorwegian2020 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/455", PhotoOrganisation = lFiapLevels, SalonYear = lSalonNordicDanish2020 },
                                                });
                       
                        var lHilltopRendezvous = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Hilltop Rendezvous" };

                        var lSalonNordicNorwegian2020Colour = new SectionEntity() { SalonYear = lSalonNordicNorwegian2020, SectionType = lSectionTypeColourPdi };
                        var lSalonNordicNorwegian2020Mono = new SectionEntity() { SalonYear = lSalonNordicNorwegian2020, SectionType = lSectionTypeMonoPdi };
                        var lSalonNordicDanish2020Mono = new SectionEntity() { SalonYear = lSalonNordicDanish2020, SectionType = lSectionTypeMonoPdi };
                     

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 21.29M,
                                                        SalonYear = lSalonNordicNorwegian2020,
                                                        EntryDate = new DateTime(2020, 10, 25),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonNordicNorwegian2020Colour, Image = lTheHallOfGateways, IsAwarded = false, IsAccepted = true, Score=20 },
                                                            new CompetitionEntryEntity { Section = lSalonNordicNorwegian2020Colour, Image = lHilltopRendezvous, IsAwarded = false, IsAccepted = true, Score= 18 },
                                                            new CompetitionEntryEntity { Section = lSalonNordicNorwegian2020Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score= 17},
                                                           

                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 21.29M,
                                                        SalonYear = lSalonNordicDanish2020,
                                                        EntryDate = new DateTime(2020, 10, 25),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonNordicDanish2020Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=20 },
                                                            new CompetitionEntryEntity { Section = lSalonNordicDanish2020Mono, Image = lTowersInTheSky, IsAwarded = false, IsAccepted = true, Score=17 },

                                                        },
                                                    },
                                                });

                        var lSalonVenera = new SalonEntity { Name = "Venera", Website = "http://www.jadran-foto.com/", Country = lCountryBosniaAndHerzegovina};
                        var lSalonVenera2020 = new SalonYearEntity { Name = "Venera", Salon = lSalonVenera, Year = 2020, ClosingDate = new DateTime(2020, 10, 20), JudgeDate = new DateTime(2020, 10, 11), NotificationDate = new DateTime(2020, 11, 20), CataloguesPostedDate = new DateTime(2020, 11, 20) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/516", PhotoOrganisation = lFiapLevels, SalonYear = lSalonVenera2020 },
                                        });

                                        var lSalonVenera2020ManWomanChildren = new SectionEntity() { SalonYear = lSalonVenera2020, SectionType = lSectionTypeChildPdi };
                                        var lSalonVenera2020Nature = new SectionEntity() { SalonYear = lSalonVenera2020, SectionType = lSectionTypeNaturePdi };


                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 22.68M,
                                                    SalonYear = lSalonVenera2020,
                                                    EntryDate = new DateTime(2020, 10, 20),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonVenera2020ManWomanChildren, Image = lComfortInAHarshWorld, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonVenera2020ManWomanChildren, Image = lRailwayChildren, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonVenera2020ManWomanChildren, Image = lEngineDriversSon, IsAwarded = true, AwardDetails="Salon HM", IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonVenera2020Nature, Image = lNorthernWhiteFacedOwl, IsAwarded = true, AwardDetails="FIAP HM", IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });

                        // autumn circuit
                        var lAutumnCircuit2020 = new CircuitEntity() { Name = "Autumn Circuit" };
                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                                 lAutumnCircuit2020,
                                             });

                        var lSalonAutumnMladost = new SalonEntity { Name = "Autumn - Mladost", Website = "https://victory-photo.club/", Country = lCountrySerbia };
                        

                        var lSalonAutumnMladost2020 = new SalonYearEntity { Name = "Autumn - Mladost", Salon = lSalonAutumnMladost, Year = 2020, ClosingDate = new DateTime(2020, 11, 8), JudgeDate = new DateTime(2020, 11, 19), NotificationDate = new DateTime(2020, 11, 20), CataloguesPostedDate = new DateTime(2020, 11, 20), Circuit = lAutumnCircuit2020 };
                        
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/490", PhotoOrganisation = lFiapLevels, SalonYear = lSalonAutumnMladost2020 },
                                                });
                       
                        var lSalonAutumnMladost2020People = new SectionEntity() { SalonYear = lSalonAutumnMladost2020, SectionType = lSectionTypePeoplePdi };
                        var lSalonAutumnMladost2020Nature = new SectionEntity() { SalonYear = lSalonAutumnMladost2020, SectionType = lSectionTypeNaturePdi };
                     

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 31.98M,
                                                        SalonYear = lSalonAutumnMladost2020,
                                                        EntryDate = new DateTime(2020, 11, 8),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonAutumnMladost2020People, Image = lDomiAtTheBall, IsAwarded = false, IsAccepted = true, Score=21 },
                                                            new CompetitionEntryEntity { Section = lSalonAutumnMladost2020Nature, Image = lRedFox, IsAwarded = false, IsAccepted = true, Score= 21 },
                                 
                                                           

                                                        },
                                                    },
                                                });

                        // FAF
                        var lQueenDomi = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Queen Domi" };

                        var lSalonFaf = new SalonEntity { Name = "FAF", Website = "http://www.faf-internacional.com/?lg=en", Country = lCountryArgentina };
                        var lSalonFaf2020 = new SalonYearEntity { Name = "FAF", Salon = lSalonFaf, Year = 2020, ClosingDate = new DateTime(2020, 11, 23), JudgeDate = new DateTime(2020, 11, 29), NotificationDate = new DateTime(2020, 12, 7), CataloguesPostedDate = new DateTime(2020, 12, 7) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/531", PhotoOrganisation = lFiapLevels, SalonYear = lSalonFaf2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-485", PhotoOrganisation = lPsa, SalonYear = lSalonFaf2020 },
                                        });

                                        var lSalonFaf2020Colour = new SectionEntity() { SalonYear = lSalonFaf2020, SectionType = lSectionTypeColourPdi };
                                       

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 14.12M,
                                                    SalonYear = lSalonFaf2020,
                                                    EntryDate = new DateTime(2020, 11, 22),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonFaf2020Colour, Image = lQueenDomi, IsAwarded = false, IsAccepted = true, Score=20 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });

                        // Fidelity
                        var lEdibleFrog = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Edible Frog" };

                        var lSalonFidelity = new SalonEntity { Name = "Fidelity", Website = "http://sopronifotoklub.hu/", Country = lCountryArgentina };
                        var lSalonFidelity2020 = new SalonYearEntity { Name = "Fidelity", Salon = lSalonFidelity, Year = 2020, ClosingDate = new DateTime(2020, 11, 23), JudgeDate = new DateTime(2020, 11, 28), NotificationDate = new DateTime(2020, 12, 8), CataloguesPostedDate = new DateTime(2020, 12, 8) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/532", PhotoOrganisation = lFiapLevels, SalonYear = lSalonFidelity2020 },
                                        });

                                        var lSalonFidelity2020Nature = new SectionEntity() { SalonYear = lSalonFidelity2020, SectionType = lSectionTypeNaturePdi };
                                       

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 18.62M,
                                                    SalonYear = lSalonFidelity2020,
                                                    EntryDate = new DateTime(2020, 11, 22),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonFidelity2020Nature, Image = lEdibleFrog, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });



                        // Vision
                        var lSalonVision = new SalonEntity { Name = "Vision", Website = "http://vision.photoart.cz/", Country = lCountryCzechRep };
                        var lSalonVision2020 = new SalonYearEntity { Name = "Vision", Salon = lSalonVision, Year = 2020, ClosingDate = new DateTime(2020, 12, 7), JudgeDate = new DateTime(2020, 12, 19), NotificationDate = new DateTime(2020, 12, 24), CataloguesPostedDate = new DateTime(2020, 12, 24) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2020/449", PhotoOrganisation = lFiapLevels, SalonYear = lSalonVision2020 },
                                                    new AccreditationEntity() { SalonNumber = "2020-472", PhotoOrganisation = lPsa, SalonYear = lSalonVision2020 },
                                        });

                                        var lSalonVision2020Mono = new SectionEntity() { SalonYear = lSalonVision2020, SectionType = lSectionTypeMonoPdi };
                                        var lSalonVision2020Nature = new SectionEntity() { SalonYear = lSalonVision2020, SectionType = lSectionTypeNaturePdi };
                                        var lSalonVision2020Woman = new SectionEntity() { SalonYear = lSalonVision2020, SectionType = lSectionTypeWomanPdi };
                                       

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 32.97M,
                                                    SalonYear = lSalonVision2020,
                                                    EntryDate = new DateTime(2020, 12, 6),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonVision2020Mono, Image = lEdibleFrog, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonVision2020Nature, Image = lDomiAtTheBall, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonVision2020Woman, Image = lATowerByTheSea, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });

                        // Boka
                        var lIceLeaf = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Ice Leaf" };

                        var lSalonBoka = new SalonEntity { Name = "Boka", Website = "https://falconero.club/entry-rules/", Country = lCountryMontenegro };
                        var lSalonBoka2020 = new SalonYearEntity { Name = "Boka", Salon = lSalonBoka, Year = 2021, ClosingDate = new DateTime(2021, 1, 25), JudgeDate = new DateTime(2021, 2, 8), NotificationDate = new DateTime(2021, 2, 22), CataloguesPostedDate = new DateTime(2020, 2, 22) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/035", PhotoOrganisation = lFiapLevels, SalonYear = lSalonBoka2020 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1057", PhotoOrganisation = lPsa, SalonYear = lSalonBoka2020 },
                                        });

                                        var lSalonBoka2020Mono = new SectionEntity() { SalonYear = lSalonBoka2020, SectionType = lSectionTypeMonoPdi };
                                       

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 18.58M,
                                                    SalonYear = lSalonBoka2020,
                                                    EntryDate = new DateTime(2021, 1, 24),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonBoka2020Mono, Image = lIceLeaf, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });
                        // victory circuit
                        var lGlacierWalkers = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Glacier Walkers" };
                        var lVictoryCircuit2021 = new CircuitEntity() { Name = "Victory Circuit" };
                        lContext.Circuits.AddRange(new List<CircuitEntity> {
                                                 lVictoryCircuit2021,
                                             });

                        var lSalonVictoryPerasto = new SalonEntity { Name = "Victory - Perasto", Website = "https://victory-photo.club/", Country = lCountryMontenegro };
                        var lSalonVictoryCacak = new SalonEntity { Name = "Victory - Cacak", Website = "https://victory-photo.club/", Country = lCountrySerbia };
                        var lSalonVictoryMladost = new SalonEntity { Name = "Victory - Mladost", Website = "https://victory-photo.club/", Country = lCountryMontenegro };
                        

                        var lSalonVictoryPerasto2021 = new SalonYearEntity { Name = "Victory - Perasto", Salon = lSalonVictoryPerasto, Year = 2021, ClosingDate = new DateTime(2021, 2, 7), JudgeDate = new DateTime(2021, 2, 17), NotificationDate = new DateTime(2021, 2, 23), CataloguesPostedDate = new DateTime(2021, 2, 23), Circuit = lVictoryCircuit2021 };
                        var lSalonVictoryCacak2021 = new SalonYearEntity { Name = "Victory - Cacak", Salon = lSalonVictoryCacak, Year = 2021, ClosingDate = new DateTime(2021, 2, 7), JudgeDate = new DateTime(2021, 2, 17), NotificationDate = new DateTime(2021, 2, 23), CataloguesPostedDate = new DateTime(2021, 2, 23), Circuit = lVictoryCircuit2021 };
                        var lSalonVictoryMladost2021 = new SalonYearEntity { Name = "Victory - Mladost", Salon = lSalonVictoryMladost, Year = 2021, ClosingDate = new DateTime(2021, 2, 7), JudgeDate = new DateTime(2021, 2, 17), NotificationDate = new DateTime(2021, 2, 23), CataloguesPostedDate = new DateTime(2021, 2, 23), Circuit = lVictoryCircuit2021 };
                        
                        
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/131", PhotoOrganisation = lFiapLevels, SalonYear = lSalonVictoryPerasto2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1099", PhotoOrganisation = lPsa, SalonYear = lSalonVictoryPerasto2021 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/132", PhotoOrganisation = lFiapLevels, SalonYear = lSalonVictoryCacak2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1099", PhotoOrganisation = lPsa, SalonYear = lSalonVictoryCacak2021 },
                                                });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/133", PhotoOrganisation = lFiapLevels, SalonYear = lSalonVictoryMladost2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1099", PhotoOrganisation = lPsa, SalonYear = lSalonVictoryMladost2021 },
                                                });
                       
                        var lSalonVictoryCacak2021Nature = new SectionEntity() { SalonYear = lSalonVictoryCacak2021, SectionType = lSectionTypeNaturePdi };
                        var lSalonVictoryCacak2021Mono = new SectionEntity() { SalonYear = lSalonVictoryCacak2021, SectionType = lSectionTypeMonoPdi };

                        var lSalonVictoryMladost2021Travel = new SectionEntity() { SalonYear = lSalonVictoryMladost2021, SectionType = lSectionTypeTravelPdi };
                        var lSalonVictoryPerasto2021Travel = new SectionEntity() { SalonYear = lSalonVictoryPerasto2021, SectionType = lSectionTypeTravelPdi };
                     

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 11M,
                                                        SalonYear = lSalonVictoryCacak2021,
                                                        EntryDate = new DateTime(2021, 2, 6),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonVictoryCacak2021Nature, Image = lEdibleFrog, IsAwarded = false, IsAccepted = true, Score=22 },
                                                            new CompetitionEntryEntity { Section = lSalonVictoryCacak2021Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=  23},
                                                            new CompetitionEntryEntity { Section = lSalonVictoryCacak2021Mono, Image = lATowerByTheSea, IsAwarded = false, IsAccepted = true, Score= 21 },
                                 
                                                           

                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 11M,
                                                        SalonYear = lSalonVictoryMladost2021,
                                                        EntryDate = new DateTime(2021, 2, 6),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonVictoryMladost2021Travel, Image = lUninterestingView, IsAwarded = false, IsAccepted = true, Score=21 },
                                 
                                                           

                                                        },
                                                    },
                                                });

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                        IsJudged = true,
                                                        EntryCost = 11M,
                                                        SalonYear = lSalonVictoryPerasto2021,
                                                        EntryDate = new DateTime(2021, 2, 6),
                                                        Person = lTim,
                                                        Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonVictoryPerasto2021Travel, Image = lGlacierWalkers, IsAwarded = true, AwardDetails="HM", IsAccepted = true, Score=21 },
                                 
                                                           

                                                        },
                                                    },
                                                });                                                                                                

   

                        // Naryn
                        var lMoonrise = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Moonrise" };
                        var lTheCagedKey = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Caged Key" };
                        var lRedDamselfly = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Red Damselfly" };
                        var lALightAgainstTheDark = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "A Light Against The Dark" };
                        var lSalonNaryn = new SalonEntity { Name = "Naryn", Website = "", Country = lCountryKyrgystan };
                        var lSalonNaryn2020 = new SalonYearEntity { Name = "Naryn", Salon = lSalonNaryn, Year = 2021, ClosingDate = new DateTime(2021, 2, 22), JudgeDate = new DateTime(2021, 3, 15), NotificationDate = new DateTime(2021, 3, 29), CataloguesPostedDate = new DateTime(2021, 3, 29) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/164", PhotoOrganisation = lFiapLevels, SalonYear = lSalonNaryn2020 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1083", PhotoOrganisation = lPsa, SalonYear = lSalonNaryn2020 },
                                        });

                                        var lSalonNaryn2020Life = new SectionEntity() { SalonYear = lSalonNaryn2020, SectionType = lSectionTypePeoplePdi };
                                        var lSalonNaryn2020AlteredReality = new SectionEntity() { SalonYear = lSalonNaryn2020, SectionType = lSectionTypeCreativePdi };
                                       

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 24.41M,
                                                    SalonYear = lSalonNaryn2020,
                                                    EntryDate = new DateTime(2021, 2, 21),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonNaryn2020Life, Image = lContentedOwl, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonNaryn2020AlteredReality, Image = lMoonrise, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonNaryn2020AlteredReality, Image = lTheCagedKey, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });

                        // Sombrero
                        var lSalonSombrero = new SalonEntity { Name = "Sombrero", Website = "", Country = lCountryGuatamala };
                        var lSalonSombrero2020 = new SalonYearEntity { Name = "Sombrero", Salon = lSalonSombrero, Year = 2021, ClosingDate = new DateTime(2021, 2, 22), JudgeDate = new DateTime(2021, 3, 15), NotificationDate = new DateTime(2021, 3, 29), CataloguesPostedDate = new DateTime(2021, 3, 29) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/233", PhotoOrganisation = lFiapLevels, SalonYear = lSalonSombrero2020 },
                                        });

                                        var lSlSalonSombrero2020Travel = new SectionEntity() { SalonYear = lSalonSombrero2020, SectionType = lSectionTypePeoplePdi };
                                        var llSalonSombrero2020Nature = new SectionEntity() { SalonYear = lSalonSombrero2020, SectionType = lSectionTypeCreativePdi };
                                        var llSalonSombrero2020Mono = new SectionEntity() { SalonYear = lSalonSombrero2020, SectionType = lSectionTypeCreativePdi };
                                       

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 14.42M,
                                                    SalonYear = lSalonSombrero2020,
                                                    EntryDate = new DateTime(2021, 2, 21),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSlSalonSombrero2020Travel, Image = lUninterestingView, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = llSalonSombrero2020Nature, Image = lRedDamselfly, IsAwarded = true, AwardDetails="DIPLOMA", IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = llSalonSombrero2020Mono, Image = lALightAgainstTheDark, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });

                        // Good Light 2021
                        var lGoodLight2021 = new SalonYearEntity { Name = "Good Light", Salon = lSalonGoodLight, Year = 2021, ClosingDate = new DateTime(2021, 5, 8), JudgeDate = new DateTime(2021, 5, 20), NotificationDate = new DateTime(2021, 5, 20), CataloguesPostedDate = new DateTime(2021, 6, 1) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                    new AccreditationEntity() { SalonNumber = "2021/050", PhotoOrganisation = lFiapLevels, SalonYear = lGoodLight2021 },
                                    new AccreditationEntity() { SalonNumber = "2021-1103", PhotoOrganisation = lPsa, SalonYear = lGoodLight2021 },
                        });

                        var lSalonGoodLight2021Nature = new SectionEntity() { SalonYear = lGoodLight2021, SectionType = lSectionTypeNaturePdi };
                        var lSalonGoodLight2021Colour = new SectionEntity() { SalonYear = lGoodLight2021, SectionType = lSectionTypeColourPdi };
                        
                        var lForestGlow = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Forest Glow" };
                        var lDeepForestFunk = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Deep Forest Funk" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                    new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 18.13M,
                                    SalonYear = lGoodLight2021,
                                    EntryDate = new DateTime(2021, 5, 8),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                            new CompetitionEntryEntity { Section = lSalonGoodLight2021Nature, Image = lContentedOwl, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonGoodLight2021Nature, Image = lEdibleFrog, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonGoodLight2021Colour, Image = lForestGlow, IsAwarded = true, AwardDetails="DIPA Ribbon", IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonGoodLight2021Colour, Image = lDeepForestFunk, IsAwarded = false, IsAccepted = true, Score=0 },

                                                    },
                                            },
                                        });

                        // Photo Grafis 2021
                        var lSalonPhotoGrafis = new SalonEntity { Name = "Photo Grafis", Website = "", Country = lCountryMontenegro };
                        var lPhotoGrafis2021 = new SalonYearEntity { Name = "Photo Grafis", Salon = lSalonPhotoGrafis, Year = 2021, ClosingDate = new DateTime(2021, 5, 8), JudgeDate = new DateTime(2021, 5, 20), NotificationDate = new DateTime(2021, 5, 20), CataloguesPostedDate = new DateTime(2021, 6, 1) };

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                    new AccreditationEntity() { SalonNumber = "2021/167", PhotoOrganisation = lFiapLevels, SalonYear = lPhotoGrafis2021 },
                                    new AccreditationEntity() { SalonNumber = "2021-1268", PhotoOrganisation = lPsa, SalonYear = lPhotoGrafis2021 },
                        });

                        var lPhotoGrafis2021Colour = new SectionEntity() { SalonYear = lPhotoGrafis2021, SectionType = lSectionTypeColourPdi };
                        
                        var lPortalEight = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Portal Eight" };
                        var lMemoriesOfATatteredShadow = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Memories of a Tattered Shadow" };

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                    new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 13.61M,
                                    SalonYear = lPhotoGrafis2021,
                                    EntryDate = new DateTime(2021, 5, 8),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                            new CompetitionEntryEntity { Section = lPhotoGrafis2021Colour, Image = lPortalEight, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lPhotoGrafis2021Colour, Image = lMemoriesOfATatteredShadow, IsAwarded = false, IsAccepted = true, Score=0 },
                                          
                                                    },
                                            },
                                        });

                        // Issyk Kul 2021
                        var lWaterfallPower = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Waterfall Power" };

                        var lIssykKul2021 = new SalonYearEntity { Name = "Issyk Kul", Salon = lSalonIssykKul, Year = 2021, ClosingDate = new DateTime(2021, 2, 22), JudgeDate = new DateTime(2021, 3, 15), NotificationDate = new DateTime(2021, 3, 29), CataloguesPostedDate = new DateTime(2021, 3, 29) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/176", PhotoOrganisation = lFiapLevels, SalonYear = lIssykKul2021 },
                                        });

                                        var lIssykKul2021Water = new SectionEntity() { SalonYear = lIssykKul2021, SectionType = lSectionTypeColourPdi };
                                      

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 24.52M,
                                                    SalonYear = lIssykKul2021,
                                                    EntryDate = new DateTime(2021, 2, 21),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lIssykKul2021Water, Image = lWaterfallPower, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lIssykKul2021Water, Image = lBirdAndWaterfall, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });             

                        // Varna 2021
                        var lFox = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Fox" };
                        var lSalonVarna = new SalonEntity { Name = "Varna", Website = "", Country = lCountryBulgaria };
                        var lVarna2021 = new SalonYearEntity { Name = "Varna", Salon = lSalonVarna, Year = 2021, ClosingDate = new DateTime(2021, 2, 22), JudgeDate = new DateTime(2021, 3, 15), NotificationDate = new DateTime(2021, 3, 29), CataloguesPostedDate = new DateTime(2021, 3, 29) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/175", PhotoOrganisation = lFiapLevels, SalonYear = lVarna2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021/1284", PhotoOrganisation = lPsa, SalonYear = lVarna2021 },
                                        });

                                        var lVarna2021Nature = new SectionEntity() { SalonYear = lVarna2021, SectionType = lSectionTypeNaturePdi };
                                      

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 23.30M,
                                                    SalonYear = lVarna2021,
                                                    EntryDate = new DateTime(2021, 2, 21),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lVarna2021Nature, Image = lFox, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lVarna2021Nature, Image = lContentedOwl, IsAwarded = true, AwardDetails="Gold", IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });       

                        // Quillat 2021
                        var lTwoTreeTriptych = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Two Tree Triptych" };
                        var lWaterfallMoon = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Waterfall Moon" };
                        var lWoodlandBubbles = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Woodland Bubbles" };
                        var lRavenQueen = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Raven Queen" };
                        
                        var lQuillat = new SalonEntity { Name = "Quillat", Website = "", Country = lCountrySpain };
                        var lQuillat2021 = new SalonYearEntity { Name = "Quillat", Salon = lQuillat, Year = 2021, ClosingDate = new DateTime(2021, 2, 22), JudgeDate = new DateTime(2021, 3, 15), NotificationDate = new DateTime(2021, 3, 29), CataloguesPostedDate = new DateTime(2021, 3, 29) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/239", PhotoOrganisation = lFiapLevels, SalonYear = lQuillat2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021/?", PhotoOrganisation = lPsa, SalonYear = lQuillat2021 },
                                        });

                                        var lQuillat2021Colour = new SectionEntity() { SalonYear = lQuillat2021, SectionType = lSectionTypeColourPdi };
                                        var lQuillat2021Mono = new SectionEntity() { SalonYear = lQuillat2021, SectionType = lSectionTypeMonoPdi };
                                        var lQuillat2021Creative = new SectionEntity() { SalonYear = lQuillat2021, SectionType = lSectionTypeCreativePdi };
                                        var lQuillat2021Portait = new SectionEntity() { SalonYear = lQuillat2021, SectionType = lSectionTypePortraitPdi };
                                        var lQuillat2021StillLife= new SectionEntity() { SalonYear = lQuillat2021, SectionType = lSectionTypeColourPdi };
                                      

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 22.41M,
                                                    SalonYear = lQuillat2021,
                                                    EntryDate = new DateTime(2021, 2, 21),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lQuillat2021Colour, Image = lTwoTreeTriptych, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lQuillat2021Mono, Image = lTheWishingTree, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lQuillat2021Creative, Image = lForestGlow, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lQuillat2021Creative, Image = lWaterfallMoon, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lQuillat2021Creative, Image = lWoodlandBubbles, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lQuillat2021Portait, Image = lRavenQueen, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lQuillat2021StillLife, Image = lTwoRosesInRed, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });             
      
                        // Queensland Circuit 2021
                        var lSiloStepShadows = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Silo Step Shadows" };
                        var lPyramidOverTheValley = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Pyramid Over The Valley" };
                        var lPreparingToPlay = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Preparing To Play" };
                        
                        var lGoldCoast2021 = new SalonYearEntity { Name = "Queensland - Gold Coast", Salon = lSalonGoldCoast, Year = 2021, ClosingDate = new DateTime(2021, 6, 6), JudgeDate = new DateTime(2021, 6, 20), NotificationDate = new DateTime(2021, 7, 4), CataloguesPostedDate = new DateTime(2021, 7, 4) };
                        var lMaryborough2021 = new SalonYearEntity { Name = "Queensland - Maryborough", Salon = lSalonMarybourgh, Year = 2021, ClosingDate = new DateTime(2021, 6, 6), JudgeDate = new DateTime(2021, 6, 20), NotificationDate = new DateTime(2021, 7, 4), CataloguesPostedDate = new DateTime(2021, 7, 4) };
                        var lMountGravatt2021 = new SalonYearEntity { Name = "Queensland - Mount Gravatt", Salon = lSalonMtGravatt, Year = 2021, ClosingDate = new DateTime(2021, 6, 6), JudgeDate = new DateTime(2021, 6, 20), NotificationDate = new DateTime(2021, 7, 4), CataloguesPostedDate = new DateTime(2021, 7, 4) };
                        var lTownsville2021 = new SalonYearEntity { Name = "Queensland - Townsville", Salon = lSalonTownsville, Year = 2021, ClosingDate = new DateTime(2021, 6, 6), JudgeDate = new DateTime(2021, 6, 20), NotificationDate = new DateTime(2021, 7, 4), CataloguesPostedDate = new DateTime(2021, 7, 4) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/155", PhotoOrganisation = lFiapLevels, SalonYear = lGoldCoast2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1232", PhotoOrganisation = lPsa, SalonYear = lGoldCoast2021 },
                                        });
                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/156", PhotoOrganisation = lFiapLevels, SalonYear = lMaryborough2021 },
                                                    new AccreditationEntity() { SalonNumber = "22021-1232", PhotoOrganisation = lPsa, SalonYear = lMaryborough2021 },
                                        });
                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/157", PhotoOrganisation = lFiapLevels, SalonYear = lMountGravatt2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1232", PhotoOrganisation = lPsa, SalonYear = lMountGravatt2021 },
                                        });
                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/158", PhotoOrganisation = lFiapLevels, SalonYear = lTownsville2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1232", PhotoOrganisation = lPsa, SalonYear = lTownsville2021 },
                                        });

                                        var lMaryborough2021Colour = new SectionEntity() { SalonYear = lMaryborough2021, SectionType = lSectionTypeColourPdi };
                                        var llGoldCoast2021Colour = new SectionEntity() { SalonYear = lGoldCoast2021, SectionType = lSectionTypeColourPdi };
                                        var lTownsville2021Colour = new SectionEntity() { SalonYear = lTownsville2021, SectionType = lSectionTypeColourPdi };
                                        var lGoldCoast2021People = new SectionEntity() { SalonYear = lGoldCoast2021, SectionType = lSectionTypePeoplePdi };
                                        var lMaryborough2021People = new SectionEntity() { SalonYear = lMaryborough2021, SectionType = lSectionTypePeoplePdi };
                                        var lTownsville2021People = new SectionEntity() { SalonYear = lTownsville2021, SectionType = lSectionTypePeoplePdi };
                                        var lGoldCoast2021Shadow = new SectionEntity() { SalonYear = lGoldCoast2021, SectionType = lSectionTypeMonoPdi };
                                        var lMaryborough2021Shadow = new SectionEntity() { SalonYear = lMaryborough2021, SectionType = lSectionTypeMonoPdi };
                                        var lMountGravatt2021Shadow = new SectionEntity() { SalonYear = lMountGravatt2021, SectionType = lSectionTypeMonoPdi };
                                        var lTownsville2021Shadow = new SectionEntity() { SalonYear = lTownsville2021, SectionType = lSectionTypeMonoPdi };
                                      
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 12.11M,
                                                    SalonYear = lGoldCoast2021,
                                                    EntryDate = new DateTime(2021, 6, 5),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = llGoldCoast2021Colour, Image = lTwoTreeTriptych, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lGoldCoast2021People, Image = lTheSpectator, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lGoldCoast2021Shadow, Image = lSiloStepShadows, IsAwarded = true, AwardDetails="QUIDC Bronze", IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });   

                                     lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 12.11M,
                                                    SalonYear = lMaryborough2021,
                                                    EntryDate = new DateTime(2021, 6, 5),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lMaryborough2021Colour, Image = lPyramidOverTheValley, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lMaryborough2021People, Image = lTheSpectator, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lMaryborough2021Shadow, Image = lSiloStepShadows, IsAwarded = true, AwardDetails="FIAP HM", IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });  

                                  lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 12.11M,
                                                    SalonYear = lMountGravatt2021,
                                                    EntryDate = new DateTime(2021, 6, 5),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lMountGravatt2021Shadow, Image = lSiloStepShadows, IsAwarded = true, AwardDetails="QUIDC Bronze", IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });  

                                   lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 12.11M,
                                                    SalonYear = lTownsville2021,
                                                    EntryDate = new DateTime(2021, 6, 5),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lTownsville2021Colour, Image = lTwoTreeTriptych, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lTownsville2021People, Image = lPreparingToPlay, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lTownsville2021Shadow, Image = lSiloStepShadows, IsAwarded = false, IsAccepted = true, Score=0 },
                                                          
                                                                                                                    
                                                                   },
                                                            },
                                                        });  
                        // FIAP Biennial
                        var lSalonFiapBiennial = new SalonEntity { Name = "FIAP Colour Biennial", Website = "", Country = lCountryFrance };
                        var lSalonFiapBiennial2020 = new SalonYearEntity { Name = "FIAP Colour Biennial", Salon = lSalonFiapBiennial, Year = 2021, ClosingDate = new DateTime(2021, 7, 2), JudgeDate = new DateTime(2021, 7, 3), NotificationDate = new DateTime(2021, 7, 7), CataloguesPostedDate = new DateTime(2021, 7, 7) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/998", PhotoOrganisation = lFiapLevels, SalonYear = lSalonFiapBiennial2020 },
                                        });

                                        var lSalonFiapBiennial2020Colour = new SectionEntity() { SalonYear = lSalonFiapBiennial2020, SectionType = lSectionTypeColourPrint};
                                       

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 0.00M,
                                                    SalonYear = lSalonFiapBiennial2020,
                                                    EntryDate = new DateTime(2021, 7, 1),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonFiapBiennial2020Colour, Image = lTheRedHut, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });

                        // Danube Circuit
                        var lSalonDanubeSerbia = new SalonEntity { Name = "Danube - Serbia", Website = "", Country = lCountrySerbia };
                        var lSalonDanubeRussia = new SalonEntity { Name = "Danube - Russia", Website = "", Country = lCountryRussia };
                        var lSalonDanubeBelarus = new SalonEntity { Name = "Danube - Belarus", Website = "", Country = lCountryBelarus };
                        var lSalonDanubeSerbia2021 = new SalonYearEntity { Name = "Danube - Serbia", Salon = lSalonDanubeSerbia, Year = 2021, ClosingDate = new DateTime(2021, 6, 26), JudgeDate = new DateTime(2021, 7, 13), NotificationDate = new DateTime(2021, 7, 20), CataloguesPostedDate = new DateTime(2021, 9, 25) };
                        var lSalonDanubeRussia2021 = new SalonYearEntity { Name = "Danube - Russia", Salon = lSalonDanubeRussia, Year = 2021, ClosingDate = new DateTime(2021, 6, 26), JudgeDate = new DateTime(2021, 7, 13), NotificationDate = new DateTime(2021, 7, 20), CataloguesPostedDate = new DateTime(2021, 9, 25) };
                        var lSalonDanubeBulgaria2021 = new SalonYearEntity { Name = "Danube - Bulgaria", Salon = lSalonDanubeBulgaria, Year = 2021, ClosingDate = new DateTime(2021, 6, 26), JudgeDate = new DateTime(2021, 7, 13), NotificationDate = new DateTime(2021, 7, 20), CataloguesPostedDate = new DateTime(2021, 9, 25) };
                        var lSalonDanubeBelarus2021 = new SalonYearEntity { Name = "Danube - Belarus", Salon = lSalonDanubeBelarus, Year = 2021, ClosingDate = new DateTime(2021, 6, 26), JudgeDate = new DateTime(2021, 7, 13), NotificationDate = new DateTime(2021, 7, 20), CataloguesPostedDate = new DateTime(2021, 9, 25) };

                        
                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/229", PhotoOrganisation = lFiapLevels, SalonYear = lSalonDanubeSerbia2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1340", PhotoOrganisation = lPsa, SalonYear = lSalonDanubeSerbia2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021/230", PhotoOrganisation = lFiapLevels, SalonYear = lSalonDanubeRussia2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1340", PhotoOrganisation = lPsa, SalonYear = lSalonDanubeRussia2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021/231", PhotoOrganisation = lFiapLevels, SalonYear = lSalonDanubeBulgaria2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1340", PhotoOrganisation = lPsa, SalonYear = lSalonDanubeBulgaria2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021/232", PhotoOrganisation = lFiapLevels, SalonYear = lSalonDanubeBelarus2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1340", PhotoOrganisation = lPsa, SalonYear = lSalonDanubeBelarus2021 },
                                        });

                                        var lSalonDanubeSerbia2021Mono = new SectionEntity() { SalonYear = lSalonFiapBiennial2020, SectionType = lSectionTypeMonoPdi };
                                        var lSalonDanubeRussia2021Water = new SectionEntity() { SalonYear = lSalonFiapBiennial2020, SectionType = lSectionTypeColourPdi};
                                        var lSalonDanubeRussia2021Colour = new SectionEntity() { SalonYear = lSalonFiapBiennial2020, SectionType = lSectionTypeColourPdi};
                                        var lSalonDanubeBulgaria2021Mono = new SectionEntity() { SalonYear = lSalonFiapBiennial2020, SectionType = lSectionTypeMonoPdi};
                                        var lSalonDanubeBulgaria2021Nature = new SectionEntity() { SalonYear = lSalonFiapBiennial2020, SectionType = lSectionTypeNaturePdi};
                                        var lSalonDanubeBelarus2021Nature = new SectionEntity() { SalonYear = lSalonFiapBiennial2020, SectionType = lSectionTypeNaturePdi};

                                        var lPyramidOfStorm = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Pyramid Of Storm" };
                                        var lPlanetFall = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Planetfall" };
                                        var lPortalBlue = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Portal Blue" };
                                        var lIntoTheWild = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Into The Wild" };

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 7.80M,
                                                    SalonYear = lSalonDanubeSerbia2021,
                                                    EntryDate = new DateTime(2021, 6, 24),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonDanubeSerbia2021Mono, Image = lPyramidOfStorm, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 7.80M,
                                                    SalonYear = lSalonDanubeRussia2021,
                                                    EntryDate = new DateTime(2021, 6, 24),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonDanubeRussia2021Colour, Image = lPlanetFall, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonDanubeRussia2021Colour, Image = lPortalBlue, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonDanubeRussia2021Water, Image = lMoonrise, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 7.80M,
                                                    SalonYear = lSalonDanubeBulgaria2021,
                                                    EntryDate = new DateTime(2021, 6, 24),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonDanubeBulgaria2021Mono, Image = lIntoTheWild, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonDanubeBulgaria2021Nature, Image = lContentedOwl, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonDanubeBulgaria2021Nature, Image = lEdibleFrog, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonDanubeBulgaria2021Nature, Image = lLeopardGecko, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });

                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 7.80M,
                                                    SalonYear = lSalonDanubeBelarus2021,
                                                    EntryDate = new DateTime(2021, 6, 24),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonDanubeBelarus2021Nature, Image = lContentedOwl, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });     

                        // Giraffe
                        var lSalonGiraffe = new SalonEntity { Name = "Giraffe", Website = "", Country = lCountryKenya };
                        var lSalonGiraffe2021 = new SalonYearEntity { Name = "Giraffe", Salon = lSalonGiraffe, Year = 2021, ClosingDate = new DateTime(2021, 7, 12), JudgeDate = new DateTime(2021, 7, 26), NotificationDate = new DateTime(2021, 7, 28), CataloguesPostedDate = new DateTime(2021, 9, 25) };                                                                                                                                                                   
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/318", PhotoOrganisation = lFiapLevels, SalonYear = lSalonGiraffe2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1388", PhotoOrganisation = lPsa, SalonYear = lSalonGiraffe2021 },
                                        });
                        var lSalonGiraffe2021Nature = new SectionEntity() { SalonYear = lSalonGiraffe2021, SectionType = lSectionTypeNaturePdi };
                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 17.91M,
                                                    SalonYear = lSalonGiraffe2021,
                                                    EntryDate = new DateTime(2021, 7, 12),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonGiraffe2021Nature, Image = lLeopardGecko, IsAwarded = true, AwardDetails="Salon Diploma", IsAccepted = true, Score=0 },
                                                                   },
                                                            },
                                                        });

                        // Victor Polynsky 2021
                        var lCouple = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Couple" };
                        var lTheMagiciansHouse = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Magician's House" };
                       
                        var lVictorPolynsky2021 = new SalonYearEntity { Name = "Victor Polynsky", Salon = lSalonVictorPolynsky, Year = 2021, ClosingDate = new DateTime(2021, 6, 30), JudgeDate = new DateTime(2021, 7, 14), NotificationDate = new DateTime(2021, 7, 28), CataloguesPostedDate = new DateTime(2021, 7, 29) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/336", PhotoOrganisation = lFiapLevels, SalonYear = lVictorPolynsky2021 },
                                        });

                                        var lVictorPolynsky2021Portrait = new SectionEntity() { SalonYear = lVictorPolynsky2021, SectionType = lSectionTypePortraitPdi };
                                        var lVictorPolynsky2021Landscape = new SectionEntity() { SalonYear = lVictorPolynsky2021, SectionType = lSectionTypeScapesPdi };
                                        var lVictorPolynsky2021AlteredReality = new SectionEntity() { SalonYear = lVictorPolynsky2021, SectionType = lSectionTypeCreativePdi };
                                    
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 24.21M,
                                                    SalonYear = lVictorPolynsky2021,
                                                    EntryDate = new DateTime(2021, 6, 30),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lVictorPolynsky2021Portrait, Image = lCouple, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lVictorPolynsky2021Portrait, Image = lDomiAtTheBall, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lVictorPolynsky2021Landscape, Image = lIntoTheWild, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lVictorPolynsky2021Landscape, Image = lSummit, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lVictorPolynsky2021AlteredReality, Image = lPyramidOverTheValley, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lVictorPolynsky2021AlteredReality, Image = lTheMagiciansHouse, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                    
                                                                   },
                                                            },
                                                        });             
                                                              

                        // This Is Life Finland 2021
                        var lBeneathTheTexturedTree = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Beneath The Textured Tree" };
                        
                        var lSalonThisIsLife2021 = new SalonYearEntity { Name = "This Is Life", Salon = lSalonThisIsLife, Year = 2021, ClosingDate = new DateTime(2021, 8, 8), JudgeDate = new DateTime(2021, 8, 8), NotificationDate = new DateTime(2021, 8, 8), CataloguesPostedDate = new DateTime(2021, 8, 8) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/118", PhotoOrganisation = lFiapLevels, SalonYear = lSalonThisIsLife2021 },
                                        });

                                        var lSalonThisIsLife2021Mono = new SectionEntity() { SalonYear = lSalonThisIsLife2021, SectionType = lSectionTypeMonoPdi };
                                        var lSalonThisIsLife2021Nature = new SectionEntity() { SalonYear = lSalonThisIsLife2021, SectionType = lSectionTypeNaturePdi };
                                    
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 26.43M,
                                                    SalonYear = lSalonThisIsLife2021,
                                                    EntryDate = new DateTime(2021, 7, 5),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonThisIsLife2021Mono, Image = lBeneathTheTexturedTree, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonThisIsLife2021Nature, Image = lPeacockTreeFrogTrio, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                        
                                                                   },
                                                            },
                                                        });          

                        // BIG NORTH STORY Iceland 2021
                        var lBeacon = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Beacon" };
                        
                        var lSalonBigNorthStory = new SalonEntity { Name = "Big North Story", Website = "", Country = lCountryIceland };
                        var lSalonBigNorthStory2021 = new SalonYearEntity { Name = "Big North Story", Salon = lSalonBigNorthStory, Year = 2021, ClosingDate = new DateTime(2021, 8, 13), JudgeDate = new DateTime(2021, 8, 25), NotificationDate = new DateTime(2021, 8, 27), CataloguesPostedDate = new DateTime(2021, 8, 27) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/500", PhotoOrganisation = lFiapLevels, SalonYear = lSalonBigNorthStory2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-5418", PhotoOrganisation = lPsa, SalonYear = lSalonBigNorthStory2021 },
                                        });

                                        var lSalonBigNorthStory2021Colour = new SectionEntity() { SalonYear = lSalonBigNorthStory2021, SectionType = lSectionTypeColourPdi };
                                        
                                    
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 17.72M,
                                                    SalonYear = lSalonBigNorthStory2021,
                                                    EntryDate = new DateTime(2021, 8, 13),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonThisIsLife2021Mono, Image = lTheMagiciansHouse, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonThisIsLife2021Nature, Image = lBeacon, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                        
                                                                   },
                                                            },
                                                        });                                                                  

                        // Welsh 2021
                        var lMagicalPilgrim = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Magical Pilgrim" };
                        var lATreeOfFireAndWater = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "A Tree Of Fire And Water" };
                        
                        var lSalonWelsh2021 = new SalonYearEntity { Name = "Welsh", Salon = lSalonWelsh, Year = 2021, ClosingDate = new DateTime(2021, 8, 22), JudgeDate = new DateTime(2021, 8, 29), NotificationDate = new DateTime(2021, 9, 12), CataloguesPostedDate = new DateTime(2021, 9, 12) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/428", PhotoOrganisation = lFiapLevels, SalonYear = lSalonWelsh2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1485", PhotoOrganisation = lPsa, SalonYear = lSalonWelsh2021 },
                                        });

                                        var lSalonWelsh2021Colour = new SectionEntity() { SalonYear = lSalonWelsh2021, SectionType = lSectionTypeColourPdi };
                                        var lSalonWelsh2021Creative = new SectionEntity() { SalonYear = lSalonWelsh2021, SectionType = lSectionTypeCreativePdi };
                                        
                                    
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 20M,
                                                    SalonYear = lSalonWelsh2021,
                                                    EntryDate = new DateTime(2021, 8, 22),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonWelsh2021Colour, Image = lTwoTreeTriptych, IsAwarded = true, AwardDetails="Ribbon", IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonWelsh2021Creative, Image = lBeacon, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonWelsh2021Creative, Image = lMagicalPilgrim, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonWelsh2021Creative, Image = lATreeOfFireAndWater, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                        
                                                                   },
                                                            },
                                                        });   

                       // Lanterna Magica 2021
                        var lTheOpening = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Opening" };
                        
                        var lSalonLanternaMagica2021 = new SalonYearEntity { Name = "Lanterna Magica", Salon = lSalonLanternaMagica, Year = 2021, ClosingDate = new DateTime(2021, 8, 22), JudgeDate = new DateTime(2021, 9, 19), NotificationDate = new DateTime(2021, 10, 3), CataloguesPostedDate = new DateTime(2021, 10, 3) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/217", PhotoOrganisation = lFiapLevels, SalonYear = lSalonLanternaMagica2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1335", PhotoOrganisation = lPsa, SalonYear = lSalonLanternaMagica2021 },
                                        });

                                        var lSalonLanternaMagica2021Colour = new SectionEntity() { SalonYear = lSalonLanternaMagica2021, SectionType = lSectionTypeColourPdi };
                                        var lSalonLanternaMagica2021LanternaMagica = new SectionEntity() { SalonYear = lSalonLanternaMagica2021, SectionType = lSectionTypeCreativePdi };
                                        
                                    
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 25.95M,
                                                    SalonYear = lSalonLanternaMagica2021,
                                                    EntryDate = new DateTime(2021, 8, 22),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonLanternaMagica2021Colour, Image = lTheMagiciansHouse, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonLanternaMagica2021LanternaMagica, Image = lMistressOfPain, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonLanternaMagica2021LanternaMagica, Image = lTheOpening, IsAwarded = true, AwardDetails="LM Chairmans Choice", IsAccepted = true, Score=0 },
                                                                                                                         
                                                                   },
                                                            },
                                                        });   

                        // CMYK circuit 2021
                        var lBuildersTea = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Builder's Tea" };
                        
                        var lSalonCmykPerasto = new SalonEntity { Name = "CMYK - Perasto", Website = "", Country = lCountryMontenegro};
                        var lSalonCmykCacak = new SalonEntity { Name = "CMYK - Cacak", Website = "", Country = lCountryMontenegro };

                        var lSalonCmykPerasto2021 = new SalonYearEntity { Name = "CMYK - Perasto", Salon = lSalonCmykPerasto, Year = 2021, ClosingDate = new DateTime(2021, 9, 12), JudgeDate = new DateTime(2021, 9, 30), NotificationDate = new DateTime(2021, 10, 5), CataloguesPostedDate = new DateTime(2021, 10, 5)};
                        var lSalonCmykCacak2021 = new SalonYearEntity { Name = "CMYK - Cacak", Salon = lSalonCmykCacak, Year = 2021, ClosingDate = new DateTime(2021, 9, 12), JudgeDate = new DateTime(2021, 9, 30), NotificationDate = new DateTime(2021, 10, 5), CataloguesPostedDate = new DateTime(2021, 10, 5)};

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                    new AccreditationEntity() { SalonNumber = "2021/474", PhotoOrganisation = lFiapLevels, SalonYear = lSalonCmykPerasto2021 },
                                    new AccreditationEntity() { SalonNumber = "2021-1502", PhotoOrganisation = lPsa, SalonYear = lSalonCmykPerasto2021 },
                        });


                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                    new AccreditationEntity() { SalonNumber = "2021/475", PhotoOrganisation = lFiapLevels, SalonYear = lSalonCmykCacak2021 },
                                    new AccreditationEntity() { SalonNumber = "2021-1502", PhotoOrganisation = lPsa, SalonYear = lSalonCmykCacak2021 },
                        });

                        var lSalonCmykPerasto2021People = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypePeoplePdi };
                        var lSalonCmykCacak2021Colour = new SectionEntity() { SalonYear = lSalonCmykCacak2021, SectionType = lSectionTypeColourPdi };
                        var lSalonCmykCacak2021People = new SectionEntity() { SalonYear = lSalonCmykCacak2021, SectionType = lSectionTypePeoplePdi };
                                        
                                    
                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                    new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 16.55M,
                                    SalonYear = lSalonCmykPerasto2021,
                                    EntryDate = new DateTime(2021, 9, 12),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                            new CompetitionEntryEntity { Section = lSalonCmykPerasto2021People, Image = lByLamplight, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                            
                                                    },
                                            },
                                        });  

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                    new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 16.55M,
                                    SalonYear = lSalonCmykCacak2021,
                                    EntryDate = new DateTime(2021, 9, 12),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                            new CompetitionEntryEntity { Section = lSalonCmykCacak2021Colour, Image = lByLamplight, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonCmykCacak2021People, Image = lBuildersTea, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                            
                                                    },
                                            },
                                        });        

                        // otofocus 2021
                        var llSalonOtoFokus = new SalonEntity { Name = "Otofokus", Website = "", Country = lCountryTurkey };
                        var llSalonOtoFokus2021 = new SalonYearEntity { Name = "Otofokus", Salon = llSalonOtoFokus, Year = 2021, ClosingDate = new DateTime(2021, 9, 25), JudgeDate = new DateTime(2021, 10, 10), NotificationDate = new DateTime(2021, 10, 12), CataloguesPostedDate = new DateTime(2021, 10, 12) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/466", PhotoOrganisation = lFiapLevels, SalonYear = llSalonOtoFokus2021 },
                                        });

                                        var llSalonOtoFokus2021Travel = new SectionEntity() { SalonYear = llSalonOtoFokus2021, SectionType = lSectionTypeTravelPdi };
                                        
                                    
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 15.38M,
                                                    SalonYear = llSalonOtoFokus2021,
                                                    EntryDate = new DateTime(2021, 9, 29),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = llSalonOtoFokus2021Travel, Image = lATowerByTheSea, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                             
                                                                   },
                                                            },
                                                        });    

                        // ISO 2021
                        var lBirdsOnProfile = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Birds On Profile" };
                        var lSalonIso2021 = new SalonYearEntity { Name = "Iso", Salon = lSalonIso, Year = 2021, ClosingDate = new DateTime(2021, 10, 2), JudgeDate = new DateTime(2021, 10, 17), NotificationDate = new DateTime(2021, 10, 25), CataloguesPostedDate = new DateTime(2021, 10, 25) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/325", PhotoOrganisation = lFiapLevels, SalonYear = lSalonIso2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1436", PhotoOrganisation = lPsa, SalonYear = lSalonIso2021 },
                                        });

                                        var lSalonIso2021Colour = new SectionEntity() { SalonYear = lSalonIso2021, SectionType = lSectionTypeColourPdi };
                                        var lSalonIso2021Creative= new SectionEntity() { SalonYear = lSalonIso2021, SectionType = lSectionTypeCreativePdi };
                                        
                                    
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 13.54M,
                                                    SalonYear = lSalonIso2021,
                                                    EntryDate = new DateTime(2021, 10, 2),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonIso2021Colour, Image = lBuildersTea, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonIso2021Creative, Image = lBirdsOnProfile, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                             
                                                                   },
                                                            },
                                                        });    

                        // Wojnicz 2021
                        var lPassingBy = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Passing By" };
                        var lThePowerOfTheSea = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Power Of The Sea" };
                        var lTwoButterflies = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Two Butterflies" };

                        var lSalonWojnicz2021 = new SalonYearEntity { Name = "Wojnicz", Salon = lSalonWojnicz, Year = 2021, ClosingDate = new DateTime(2021, 9, 25), JudgeDate = new DateTime(2021, 10, 23), NotificationDate = new DateTime(2021, 10, 22), CataloguesPostedDate = new DateTime(2021, 10, 22) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/380", PhotoOrganisation = lFiapLevels, SalonYear = lSalonWojnicz2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1444", PhotoOrganisation = lPsa, SalonYear = lSalonWojnicz2021 },
                                        });

                                        var lSalonWojnicz2021Portrait = new SectionEntity() { SalonYear = lSalonWojnicz2021, SectionType = lSectionTypePortraitPdi };
                                        var lSalonWojnicz2021Colour = new SectionEntity() { SalonYear = lSalonWojnicz2021, SectionType = lSectionTypeColourPdi };
                                        
                                    
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 15.27M,
                                                    SalonYear = lSalonWojnicz2021,
                                                    EntryDate = new DateTime(2021, 9, 25),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonWojnicz2021Portrait, Image = lByLamplight, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonWojnicz2021Colour, Image = lPassingBy, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonWojnicz2021Colour, Image = lThePowerOfTheSea, IsAwarded = false, IsAccepted = true, Score=0 },
                                                            new CompetitionEntryEntity { Section = lSalonWojnicz2021Colour, Image = lTwoButterflies, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                             
                                                                   },
                                                            },
                                                        });     

                        // Turkey IFSAK 2021
                        var lDominique = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "Dominique" };

                        var lSalonIfsak = new SalonEntity { Name = "IFSAK", Website = "", Country = lCountryTurkey };
                        var lSalonIfsak2021 = new SalonYearEntity { Name = "IFSAK", Salon = lSalonWojnicz, Year = 2021, ClosingDate = new DateTime(2021, 10, 11), JudgeDate = new DateTime(2021, 11, 6), NotificationDate = new DateTime(2021, 11, 15), CataloguesPostedDate = new DateTime(2021, 11, 15) };

                                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                                    new AccreditationEntity() { SalonNumber = "2021/453", PhotoOrganisation = lFiapLevels, SalonYear = lSalonIfsak2021 },
                                                    new AccreditationEntity() { SalonNumber = "2021-1578", PhotoOrganisation = lPsa, SalonYear = lSalonIfsak2021 },
                                        });

                                        var lSalonIfsak2021Portrait = new SectionEntity() { SalonYear = lSalonIfsak2021, SectionType = lSectionTypePortraitPdi };
                                        
                                        
                                    
                                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                                    new SubmissionEntity(){
                                                    IsJudged = true,
                                                    EntryCost = 19.27M,
                                                    SalonYear = lSalonIfsak2021,
                                                    EntryDate = new DateTime(2021, 10, 11),
                                                    Person = lTim,
                                                    Entries = new List<CompetitionEntryEntity> {

                                                            new CompetitionEntryEntity { Section = lSalonIfsak2021Portrait, Image = lDominique, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                                             
                                                                   },
                                                            },
                                                        });   

                        // Olympic circuit 2021
                        var lTheFirePyramid = new ImageEntity() { ThumbnailLocation = @"C:\SalonImages\NA.jpg", Person = lTim, Name = "The Fire Pyramid" };

                        var lSalonOlympicApollo2021 = new SalonYearEntity { Name = "Olympic - Apollo", Salon = lSalonOlympicApollo, Year = 2021, ClosingDate = new DateTime(2021, 10, 17), JudgeDate = new DateTime(2021, 11, 7), NotificationDate = new DateTime(2021, 11, 21), CataloguesPostedDate = new DateTime(2021, 11, 21)};
                        var lSalonOlympicHermes2021 = new SalonYearEntity { Name = "Olympic - Hermes", Salon = lSalonOlympicApollo, Year = 2021, ClosingDate = new DateTime(2021, 10, 17), JudgeDate = new DateTime(2021, 11, 7), NotificationDate = new DateTime(2021, 11, 21), CataloguesPostedDate = new DateTime(2021, 11, 21)};
                        var lSalonOlympicZeus2021 = new SalonYearEntity { Name = "Olympic - Zeus", Salon = lSalonOlympicApollo, Year = 2021, ClosingDate = new DateTime(2021, 10, 17), JudgeDate = new DateTime(2021, 11, 7), NotificationDate = new DateTime(2021, 11, 21), CataloguesPostedDate = new DateTime(2021, 11, 21)};
                        var lSalonOlympicAphrodite2021 = new SalonYearEntity { Name = "Olympic - Aphrodite", Salon = lSalonOlympicApollo, Year = 2021, ClosingDate = new DateTime(2021, 10, 17), JudgeDate = new DateTime(2021, 11, 7), NotificationDate = new DateTime(2021, 11, 21), CataloguesPostedDate = new DateTime(2021, 11, 21)};

                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                    new AccreditationEntity() { SalonNumber = "2021/385", PhotoOrganisation = lFiapLevels, SalonYear = lSalonOlympicApollo2021 },
                                    new AccreditationEntity() { SalonNumber = "2021-1486", PhotoOrganisation = lPsa, SalonYear = lSalonOlympicApollo2021 },
                        });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                    new AccreditationEntity() { SalonNumber = "2021/384", PhotoOrganisation = lFiapLevels, SalonYear = lSalonOlympicHermes2021 },
                                    new AccreditationEntity() { SalonNumber = "2021-1486", PhotoOrganisation = lPsa, SalonYear = lSalonOlympicHermes2021 },
                        });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                    new AccreditationEntity() { SalonNumber = "2021/382", PhotoOrganisation = lFiapLevels, SalonYear = lSalonOlympicZeus2021 },
                                    new AccreditationEntity() { SalonNumber = "2021-1486", PhotoOrganisation = lPsa, SalonYear = lSalonOlympicZeus2021 },
                        });
                        lContext.Accreditations.AddRange(new List<AccreditationEntity> {
                                    new AccreditationEntity() { SalonNumber = "2021/383", PhotoOrganisation = lFiapLevels, SalonYear = lSalonOlympicAphrodite2021 },
                                    new AccreditationEntity() { SalonNumber = "2021-1486", PhotoOrganisation = lPsa, SalonYear = lSalonOlympicAphrodite2021 },
                        });

                        var lSalonOlympicApollo2021Nature = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypeNaturePdi };
                        var lSalonOlympicApollo2021Travel = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypeTravelPdi };
                        var lSalonOlympicHermes2021Nature = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypeNaturePdi };
                        var lSalonOlympicHermes2021Travel = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypeTravelPdi };
                        var lSalonOlympicHermes2021Colour = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypeColourPdi };
                        var lSalonOlympicZeus2021Travel = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypeTravelPdi };
                        var lSalonOlympicZeus2021Colour = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypeColourPdi };
                        var lSalonOlympicZeus2021Nature = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypeNaturePdi };
                        var lSalonOlympicAphrodite2021Travel = new SectionEntity() { SalonYear = lSalonCmykPerasto2021, SectionType = lSectionTypeTravelPdi };
                                        
                                    
                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                    new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 8.88M,
                                    SalonYear = lSalonOlympicApollo2021,
                                    EntryDate = new DateTime(2021, 10, 17),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                            new CompetitionEntryEntity { Section = lSalonOlympicApollo2021Nature, Image = lHedgehogInLeaves, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonOlympicApollo2021Travel, Image = lGlacierWalkers, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                            
                                                    },
                                            },
                                        });  

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                    new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 8.88M,
                                    SalonYear = lSalonOlympicHermes2021,
                                    EntryDate = new DateTime(2021, 10, 17),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                            new CompetitionEntryEntity { Section = lSalonOlympicHermes2021Nature, Image = lLeopardGecko, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonOlympicHermes2021Travel, Image = lGlacierWalkers, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonOlympicHermes2021Colour, Image = lTwoButterflies, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonOlympicHermes2021Colour, Image = lTheFirePyramid, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                            
                                                    },
                                            },
                                        });  

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                    new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 8.88M,
                                    SalonYear = lSalonOlympicZeus2021,
                                    EntryDate = new DateTime(2021, 10, 17),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                            new CompetitionEntryEntity { Section = lSalonOlympicZeus2021Travel, Image = lATowerByTheSea, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonOlympicZeus2021Travel, Image = lGlacierWalkers, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonOlympicZeus2021Colour, Image = lTwoButterflies, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonOlympicZeus2021Colour, Image = lTheFirePyramid, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonOlympicZeus2021Nature, Image = lHedgehogInLeaves, IsAwarded = false, IsAccepted = true, Score=0 },
                                                                                                            
                                                    },
                                            },
                                        });  

                        lContext.Submissions.AddRange(new List<SubmissionEntity> {
                                    new SubmissionEntity(){
                                    IsJudged = true,
                                    EntryCost = 8.88M,
                                    SalonYear = lSalonOlympicAphrodite2021,
                                    EntryDate = new DateTime(2021, 10, 17),
                                    Person = lTim,
                                    Entries = new List<CompetitionEntryEntity> {

                                            new CompetitionEntryEntity { Section = lSalonOlympicAphrodite2021Travel, Image = lATowerByTheSea, IsAwarded = false, IsAccepted = true, Score=0 },
                                            new CompetitionEntryEntity { Section = lSalonOlympicAphrodite2021Travel, Image = lGlacierWalkers, IsAwarded = true, AwardDetails="GPU HM", IsAccepted = true, Score=0 },
                                                                                                            
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
