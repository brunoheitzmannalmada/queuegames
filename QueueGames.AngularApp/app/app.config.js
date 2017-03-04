app.config(function ($routeProvider, $locationProvider) {
  //$locationProvider.html5Mode(true);

  $routeProvider
      .when('/', {
        templateUrl: '/app/components/games/GamesView.html',
        controller: 'GamesController'
      })
      .when('/Products', {
        templateUrl: '/app/components/products/ProductsView.html',
        controller: 'ProductsController'
      });
});