app.controller('GamesController', ['$rootScope', '$http', 'API_ADDRESS', function ($rootScope, $http, apiAddress) {
    var gamesCtrl = this;
    this.listOfGames = [];
    this.Games = [];
    this.ApiRoute = 'Games';
    this.error = false;

    this.init = function () {
        console.log('Init games controller');
        $http.get(apiAddress + this.ApiRoute)
        .then(function successCallback(result) {
            gamesCtrl.Games = JSON.parse(result.data);
        }, function errorCallback(result) {
            gamesCtrl.error = true;
        });
    };

    this.like = function (game) {
        gamesCtrl.listOfGames.splice(0, 0, new QueueItem(game.Name,
            'Like',
            $http.post(apiAddress + 'Like', game))
        );
        $rootScope.$broadcast('openQueueManager', {});
    };

    this.buy = function (game) {
        gamesCtrl.listOfGames.splice(0, 0, new QueueItem(game.Name,
            'Buy',
            $http.post(apiAddress + 'Buy', game))
        );
        $rootScope.$broadcast('openQueueManager', {});
    };

    this.new = function () {
        var apiRoute = this.ApiRoute;
        var promise = $rootScope.$broadcast('openPopupWindow', {
            data: {
                Name: '',
                YearLaunch: '',
                Developer: '',
                Platform: ''
            },
            validationFunction: function (validateIt) {
                return validateIt.Name == '' || validateIt.YearLaunch == '' && validateIt.Developer == '' || validateIt.Platform == '';
            }
        }).promise;

        promise.then(function successCallback(result) { },
            function errorCallback(result) { },
            function notificationCallback(result) {
                var gameToBeAdded = result;
                $http.post(apiAddress + apiRoute, result)
                .then(function successCallback(result) {
                    $rootScope.$broadcast('closePopupWindow', { successMessage: 'The game was added!' });
                    gameToBeAdded.Id = result.data;
                    gamesCtrl.Games.push(gameToBeAdded);
                },
                function errorCallback(result) {
                    $rootScope.$broadcast('showError', { errorMessage: 'There was an error saving the game' });
                });
            });
    };

    this.edit = function (game) {
        var apiRoute = this.ApiRoute;
        var currentGame = game;
        var promise = ($rootScope.$broadcast('openPopupWindow', {
            data: {
                Id: game.Id,
                Name: game.Name,
                YearLaunch: game.YearLaunch,
                Developer: game.Developer,
                Platform: game.Platform
            },
            validationFunction: function (validateIt) {
                return (validateIt.Name == '' || validateIt.YearLaunch == '' || validateIt.Developer == '' || validateIt.Platform == '');
            }
        })).promise;

        promise.then(function successCallback(result) { },
            function errorCallback(result) { },
            function notificationCallback(result) {
                var gameFromPopup = result;
                $http.put(apiAddress + apiRoute + '/put/?id=' + currentGame.Id, JSON.stringify(result))
                .then(function successCallback(result) {
                    currentGame.Name = gameFromPopup.Name;
                    currentGame.YearLaunch = gameFromPopup.YearLaunch;
                    currentGame.Developer = gameFromPopup.Developer;
                    currentGame.Platform = gameFromPopup.Platform;
                    $rootScope.$broadcast('closePopupWindow', { successMessage: 'The game was edited!' });
                },
                function errorCallback(result) {
                    $rootScope.$broadcast('showError', { errorMessage: 'There was an error saving the game' });
                });
            });
    };

    this.delete = function (game) {
        var fnCallback = function () {
            gamesCtrl.Games.splice(gamesCtrl.Games.indexOf(game), 1);
        };
        this.listOfGames.splice(0, 0, new QueueItem(game.Name,
            'Delete',
            $http.delete(apiAddress + gamesCtrl.ApiRoute + '/delete/' + game.Id),
            fnCallback
            )
        );
        $rootScope.$broadcast('openQueueManager', {});
    };

    this.Include = function () {
        return '/app/view/GamesCreateEdit.html';
    };
}]);