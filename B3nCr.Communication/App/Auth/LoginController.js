'use strict';

angular.module('myApp.auth')

.controller('LoginController', ['$window', '$scope', '$http', function ($window, $scope, $http) {

    $scope.callApi = function () {
        $scope.claims = [];
        $http.get('https://b3ncr.comms.api:44342/api/Identity')
            .success(function (data) {
                $scope.claims = data;
            })
            .error(function (data) {
                console.log(data);
            });
    };

    $scope.localGet = function () {
        $scope.claims = [];
        $http.get('/data')
            .success(function (data) {
                $scope.claims = data;
            })
            .error(function (data) {
                console.log(data);
            });
    }

    var init = function () {

        var url = new URI($window.location);
        var fragment = url.fragment();

        var cleanQuery = new URI(fragment).normalizeSearch().search(true);

        $scope.token = cleanQuery.access_token;

        $http.defaults.headers.common.Authorization = 'Bearer ' + $scope.token;

        console.log($scope.token);
    };

    init();
}]);