define(function(require) {

    var customerService = require('services/customerService');

    var ctor = function() {
        var self = this;

        self.customers = ko.observableArray();

        self.activate = function() {
            return customerService.getCustomers().done(function(result) {
                ko.utils.arrayForEach(result, function(cust) {
                    self.customers().push({ id: ko.observable(cust.Id), name: ko.observable(cust.Name), phoneNumber: ko.observable(cust.PhoneNumber) });
                });
            });
        };
    };

    return ctor;

});