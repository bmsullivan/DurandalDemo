define(function(require) {

    return {
        getCustomers: function() {
            return $.get('api/customers');
        },

        getCustomer: function(id) {
            return $.get('api/customers/' + id);
        },

        saveCustomer: function(cust) {
            return $.ajax('api/customers/' + cust.Id, { data: JSON.stringify(cust), contentType: 'application/json', type: 'PUT' });
        }
    };

});