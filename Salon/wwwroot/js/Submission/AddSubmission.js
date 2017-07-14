function AddSubmissionModel() {
    var self = this;
    self.year = ko.observable(2017);
    self.SalonId = ko.observable();
    self.CircuitId = ko.observable();
    self.SalonYearId = ko.observable();

    self.salonYears = ko.observable();
    self.selectedSalonYear = ko.observable();


    $.get('./GetSalonYears', { pYear: this.year }, self.salonYears);

    self.AddSalonYear = function () {
        $("#AddSalonYearPopup").modal('show');
    };

    self.SetSalonYearId = function (id) {
        self.SalonYearId(id);
    };
}
var submissionVm = new AddSubmissionModel();
// Activates knockout.js
ko.applyBindings(submissionVm, document.getElementById("AddSubmission"));
