'use strict';

angular.module('myApp.auth', ['ngRoute'])

.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/register', {
            templateUrl: 'App/Auth/Register.html',
            controller: 'RegistrationController'
        })
        .when('/loggedin', {
            templateUrl: 'App/Auth/LoggedIn.html',
            controller: 'LoginController'
        });
}]);