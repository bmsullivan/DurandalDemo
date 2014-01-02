define(function() {

    var MyLibrary = function() {
        this.showMessage = function() {
            alert('Hello, constructor!');
        };
    };

    return MyLibrary;
});