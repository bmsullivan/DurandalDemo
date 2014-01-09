define(function(require) {
    var dialog = require('plugins/dialog');

    var MyDialog = function(cust) {
        var self = this;

        self.message = 'Customer ' + cust.name() + ' saved!';

        self.close = function() {
            dialog.close(self);
        };
    };

    return MyDialog;
});