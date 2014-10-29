'use strict';

angular.module('myApp.auth')

.controller('RegistrationController', ['$scope', '$window', function ($scope, $window) {
    $scope.date = new Date();

    $scope.login = function () {
        var uri = URI('https://b3ncr.auth:44340/identity/connect/authorize')
            .addSearch('response_type', 'code id_token token')
            .addSearch('client_id', 'grptxt')
            .addSearch('scope', 'openid profile sampleApi')
            .addSearch('redirect_uri', 'https://b3ncr.comms:44341/#/loggedin?')
            .addSearch('nonce',  Math.floor( Math.random()*99999 ));
        $window.location.href = uri;
    };

    $scope.logout = function () {
        var uri = URI('https://b3ncr.auth:44340/identity/logout');
        $window.location.href = uri;
    };
}]);