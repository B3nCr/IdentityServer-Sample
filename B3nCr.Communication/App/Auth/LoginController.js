'use strict';

angular.module('myApp.auth')

.controller('LoginController', ['$window', function ($window) {

    var init = function () {

        var url = new URI($window.location);
        var fragment = url.fragment();

        var cleanQuery = new URI(fragment).normalizeSearch().search(true);

        var token = cleanQuery.id_token;
        var code = cleanQuery.code;

        console.log(token);
        console.log(code);
    };

    init();
}]);