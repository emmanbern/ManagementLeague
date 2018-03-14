leagueApp.controller('editController', ['$scope', '$http', function ($scope, $http) {

    $scope.Init = function () {
        $scope.Test = {
            Nom: "Toto"
        };
        console.log($scope);
        $http.post('http://league.local/Api/Player/GetValue', {}).then(function (response) {
            console.log(response);
        });
        $http.post('http://league.local/Api/Player/GetOtherValue', {

        }).then(function (response) {
            console.log(response);
        });
    };

    $scope.Log = function (value) {
       
    };
}]);