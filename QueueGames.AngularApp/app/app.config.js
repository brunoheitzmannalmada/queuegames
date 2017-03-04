app.config(["$routeProvider", "$locationProvider", function (routeProvider, locationProvider) {
  routeProvider
      .when('/Games', {
        templateUrl: '/app/components/games/GamesView.html',
        controller: 'GamesController'
      })
      .when('/Products', {
        templateUrl: '/app/components/products/ProductsView.html',
        controller: 'ProductsController'
      })
      .otherwise({
        templateUrl: '/app/components/games/GamesView.html',
        controller: 'GamesController'
      });

    locationProvider.html5Mode(true);
}]);