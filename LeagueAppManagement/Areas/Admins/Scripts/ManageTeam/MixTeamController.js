leagueApp.controller('MixTeamController', ['$scope', '$http', '$location', function ($scope, $http, $location) {

    $scope.SelectedPlayers = [];
    $scope.WhiteTeam = {};
    $scope.OrangeTeam = {};

    $scope.Init = function (model) {

        var parsedModel = JSON.parse(model);
        $scope.Players = parsedModel.Players;
        $scope.SelectedCount = 0;
    };

    $scope.TogglePalyerToList = function (player) {

        if ($scope.SelectedPlayers.length > 0) {
            var index = $scope.SelectedPlayers.indexOf(player);
            if (index != -1) {
                RemovePlayerToSelectedList(player, index);
            }
            else {
                AddPlayerToSelectedList(player);
            }
        }
        else {
            AddPlayerToSelectedList(player);
        }
    };

    $scope.CreateTeams = function () {
        $scope.SelectedPlayers
        var guids = [];
        for (var i = 0; i < $scope.SelectedPlayers.length; i++) {
            guids.push($scope.SelectedPlayers[i].Guid);
        }

        $http.post('http://league.local/Api/Team/CreateTeams', {
            Guids: guids
        }).then(function (response) {
            $scope.Teams = response.data;
            $scope.TeamCreated = true;
        });

    };

    $scope.ReRoll = function()
    {
        $scope.TeamCreated = false;
        $scope.Teams = {};
    }

    function AddPlayerToSelectedList(player) {
        $("." + player.Guid).removeClass("btn-default").addClass("btn-success");
        $scope.SelectedCount += 1;
        $scope.SelectedPlayers.push(player);
    };

    function RemovePlayerToSelectedList(player, index) {
        $scope.SelectedPlayers.splice(index, 1);
        $("." + player.Guid).removeClass("btn-success").addClass("btn-defautl");
        $scope.SelectedCount -= 1;
    };
}]);