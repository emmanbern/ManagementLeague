leagueApp.controller('editController', ['$scope', '$http','$location', function ($scope, $http, $location) {

    $scope.Init = function (model) {
        $scope.Player = JSON.parse(model);
    };

    $scope.Submit = function (url) {
        var number = $scope.Player.PhoneNumber;
        number = number.split("-").join("");
        var formatedPhoneNumer = number.substring(0, 3) + "-" + number.substring(3, 6) + "-" + number.substring(6, number.length);

        $http.post('http://league.local/Api/Player/Create', {
            FirstName: $scope.Player.FirstName,
            LastName: $scope.Player.LastName,
            Grade: $scope.Player.GradeEnum,
            PhoneNumber: formatedPhoneNumer
        }).then(function (response) {
            window.location = "http://league.local" + url;
        });
       
    };
}]);