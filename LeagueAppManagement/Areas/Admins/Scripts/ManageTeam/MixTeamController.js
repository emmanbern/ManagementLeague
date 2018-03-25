leagueApp.controller('MixTeamController', ['$scope', '$http', '$location', function ($scope, $http, $location) {

    $scope.SelectedPlayers = [];

    $scope.Init = function (model) {

        var parsedModel = JSON.parse(model);
        $scope.Players = parsedModel.Players;
        $scope.SelectedCount = 0;
        console.log($scope); 
    };

    $scope.TogglePalyerToList = function (player) {

        $("." + player.Guid).removeClass("btn-default").addClass("btn-success");
        $scope.SelectedCount += 1;
        $scope.SelectedPlayers.push(player);
    }
   
}]);