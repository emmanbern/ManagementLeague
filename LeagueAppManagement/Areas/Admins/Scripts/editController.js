leagueApp.controller('editController', ['$scope', function ($scope) {

    $scope.Init = function () {
        $scope.Test = {
            Nom: "Toto"
        };
        console.log($scope);
    };

    $scope.Log = function (value) {
        console.log(value);
        console.log($scope);
    };
}]);