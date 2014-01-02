requirejs.config({    
   paths: {
       'knockout': 'knockout-3.0.0'
   } 
});


define(function(require) {

    var ko = require('knockout');
    
    var ViewModel = function() {
        var self = this;

        self.message = ko.observable('foo');

        self.changeMessage = function() {
            self.message('bar');
        };

        self.things = ko.observableArray([{ text: 'first' }, { text: 'second' }, { text: 'third' }]);

        self.addThing = function() {
            self.things.push({ text: 'another' });
        };

        self.numberOfThings = ko.computed(function() {
            return self.things().length;
        });
    };

    var vm = new ViewModel();

    ko.applyBindings(vm);
});