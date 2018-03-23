leagueApp.controller('listController', ['$scope', function ($scope) {

    $scope.Tests = {};
    $scope.Init = function (model) {
        $scope.Players = JSON.parse(model);
    };

    $scope.Redirect = function (url, guid) {
        console.log(url);
        console.log(guid);
        window.localion = url + "/" + guid;
    };
}]);