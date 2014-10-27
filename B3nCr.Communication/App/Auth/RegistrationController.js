'use strict';

angular.module('myApp.auth')

.controller('RegistrationController', ['$scope', '$window', function ($scope, $window) {
    $scope.date = new Date();

    $scope.login = function () {
        var uri = URI('https://b3ncr.auth:44340/identity/connect/authorize')
            .addSearch('client_id', 'txtm8')
            .addSearch('scope', 'openid profile')
            .addSearch('redirect_uri', 'https://b3ncr.comms:44341/#/loggedin?')
            .addSearch('response_type', 'code id_token');
        $window.location.href = uri;
    };

    $scope.logout = function () {
        var uri = URI('https://b3ncr.auth:44340/identity/logout');
        $window.location.href = uri;
    };
}]);