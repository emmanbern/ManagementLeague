leagueApp.controller('listController', ['$scope','$location', function ($scope, $location) {

    $scope.Tests = {};
    $scope.Init = function (model) {
        $scope.Players = JSON.parse(model);
    };

    $scope.Redirect = function (url, guid) {
       
        window.location = "http://league.local" + url + "/" + guid;
    };
}]);