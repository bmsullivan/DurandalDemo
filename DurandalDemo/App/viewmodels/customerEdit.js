define(function(require) {
    var customerService = require('services/customerService');

    var CustomerEdit = function(cust) {
        var self = this;

        self.customer = cust;

        self.save = function() {
            customerService.getCustomer(self.customer.id()).done(function(custFromDB) {
                custFromDB.Name = self.customer.name();
                custFromDB.PhoneNumber = self.customer.phoneNumber();
                customerService.saveCustomer(custFromDB).done(function() {
                    alert('Customer saved!');
                });
            });
        };
    };

    return CustomerEdit;
});