function AddSubmissionModel() {
    var self = this;
    self.year = ko.observable(2017);
    self.SalonId = ko.observable();
    self.CircuitId = ko.observable();
    self.Circuits = ko.observableArray([]);
    self.salonYears = ko.observableArray([]);
    self.SelectedCircuit = ko.observable();
    self.SalonYear = ko.observable();
    self.SalonYearId = ko.observable();

    this.SalonYear.subscribe(function (salonYear) {
        if (salonYear) {
            self.SalonYearId(salonYear.salonYearId);
        }
        else {
            self.SalonYearId(null);
        }
    });

    this.SelectedCircuit.subscribe(function (circuit) {
        if (circuit) {
            self.CircuitId(circuit.id);
        }
        else
        {
            self.CircuitId(null);
        }
    });



    $.get('./GetSalonYears', { pYear: this.year }, self.salonYears);
    $.get('./GetCircuits', {}, self.Circuits);

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
