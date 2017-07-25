function AddSalonYearModel() {
    var self = this;
    self.salons = ko.observable([]);
    self.countries = ko.observable([]);
    self.salonNameQuery = ko.observable('');
    self.countryNameQuery = ko.observable('');
    self.salonYearNameQuery = ko.observable('');

    self.circuitQuery = ko.observable('');

    self.salonWebsite = ko.observable(null);
    self.salonId = ko.observable(null);
    self.salonYearId = ko.observable(null);

    self.countryId = ko.observable(null);
    self.circuitId = ko.observable(null);
    self.cataloguesPostedDate = ko.observable(null);
    self.closingDate = ko.observable(null);
    self.judgeDate = ko.observable(null);
    self.notificationDate = ko.observable(null);

    self.salonYears = ko.observable([]);
    self.salonYearAccreditations = ko.observable([]);
    self.availableAccreditationOrgs = ko.observable([]);

    self.salonSelect = function (salonItem) {
        self.salonId(salonItem.salonId);
        self.filterSalonYears(salonItem.salonId);      

        return salonItem.salonName;
    };    

    self.filterSalonYears = function (salonId)    {
        var filteredSalonYears = ko.utils.arrayFilter(submissionVm.salonYears(), function (salonYear) {
            return salonYear.salonId == salonId;
        });
        self.salonYears(filteredSalonYears);
    }

    self.salonNameTyping = function () {
        self.salonId(null);
    };   

    self.countrySelect = function (countryItem) {
        self.countryId(countryItem.id);
        return countryItem.name;
    };  

    self.countryNameTyping = function () {
        self.countryId(null);
    };   

    self.salonYearSelect = function (salonYearItem) {
        self.setSalonYearInfo(salonYearItem);
        return salonYearItem.name;
    };

    self.setSalonYearInfo = function (salonYearItem) {
        self.salonYearId(salonYearItem.salonYearId);
        self.salonYearAccreditations(salonYearItem.accreditations);
        self.cataloguesPostedDate(salonYearItem.cataloguesPostedDate);
        self.closingDate(salonYearItem.closingDate);
        self.judgeDate(salonYearItem.judgeDate);
        self.notificationDate(salonYearItem.notificationDate);
        submissionVm.SetSalonYearId(salonYearItem.salonYearId);
    }

    self.salonYearNameTyping = function () {
        self.salonYearId(null);
        self.salonYearAccreditations(null);
        submissionVm.SetSalonYearId(null);
    };   

    self.createSalon = function () {
        var addSalonData = {
            SalonId: self.salonId(),
            SalonName: self.salonNameQuery(),
            CountryId: self.countryId(),
            CountryName: self.countryNameQuery(),
            Website: self.salonWebsite()
        };
        
        $.ajax({
            url: "./AddSalon",
            type: "POST",
            data: JSON.stringify(addSalonData),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (returnedData) {           
                var newSalonId = returnedData.salonId;
                self.salonId(newSalonId);
                self.filterSalonYears(newSalonId);   
            }
        });
    };

    self.createSalonYear = function () {
        var closingDate = self.closingDate();
        closingDate.setHours(12);

        var catalogPostingDate = self.cataloguesPostedDate();
        catalogPostingDate.setHours(12);

        var judgeDate = self.judgeDate();
        judgeDate.setHours(12);

        var notificationDate = self.notificationDate();
        notificationDate.setHours(12);

        var addSalonYearData = {
            SalonId: self.salonId(),
            CircuitId: self.circuitId(),
            Name: self.salonYearNameQuery(),
            Year: submissionVm.year(),
            CataloguesPostedDate: catalogPostingDate,
            ClosingDate: closingDate,
            JudgeDate: judgeDate,
            NotificationDate: notificationDate,
        };
        
        $.ajax({
            url: "./AddSalonYear",
            type: "POST",
            data: JSON.stringify(addSalonYearData),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (returnedData) {
                var newSalonYearId = returnedData.id;
                self.salonYearId(newSalonYearId);
                submissionVm.salonYears.push(returnedData);
                submissionVm.SetSalonYearId(newSalonYearId);
                self.salonYearAccreditations([]);
            }
        });
    };

    self.removeAccreditation = function () {

    };

    $.get('./GetSalons', function (data) { self.salons(data); });
    $.get('./GetCountries', function (data) { self.countries(data); });
}

// Activates knockout.js
ko.applyBindings(new AddSalonYearModel(), document.getElementById("AddSalonYearPopup"));



