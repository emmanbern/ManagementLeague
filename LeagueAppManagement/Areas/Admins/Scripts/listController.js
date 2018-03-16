leagueApp.controller('listController', ['$scope', function ($scope) {

    $scope.Tests = {};
    $scope.Init = function (model) {
        $scope.Players = JSON.parse(model);
        console.log($scope);
    };

    $scope.log = function () {
        console.log("GOOD!");
    };
    $scope.log();
}]);