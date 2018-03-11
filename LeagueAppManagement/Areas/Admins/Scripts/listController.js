leagueApp.controller('listController', ['$scope', function ($scope) {

    $scope.Init = function () {
        $scope.Test = {
            Nom: "Toto"
        };
        console.log($scope);
    };

    $scope.log = function () {
        console.log("GOOD!");
    };
    $scope.log();
}]);