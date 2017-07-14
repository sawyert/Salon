function AddSalonYearModel() {
    var self = this;
    self.salons = ko.observable([]);
    self.salonNamesList = ko.computed(function () {

        var lReturn = [];
        for (var i = 0; i < self.salons().length; i++) {
            console.log(i, self.salons()[i]);
            lReturn.push(self.salons()[i].salonName);
        }
        console.log(lReturn);

        return lReturn;
    }, this);

    $.get('./GetSalons', function (data) { self.salons(data); });

    submissionVm.SetSalonYearId(30);

}

// Activates knockout.js
ko.applyBindings(new AddSalonYearModel(), document.getElementById("AddSalonYearPopup"));
