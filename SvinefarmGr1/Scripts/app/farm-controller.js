angular.module('FarmApp', [])
    .controller('FarmCtrl', function ($scope, $http) {

        $scope.CreateFarm = function () {

            $http({
                method: 'POST',
                url: 'api/farm',
                data: "=" + $scope.name,
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            }).success(function (data, status, headers, config) {
                $scope.title = "Hurray";
            }).error(function (data, status, headers, config) {
                $scope.title = "Oops... something went wrong";

            });
        };


    });


