app.config(function ($routeProvider, $locationProvider) {
  //$locationProvider.html5Mode(true);

  $routeProvider
      .when('/', {
        templateUrl: '/app/view/GamesView.html',
        controller: 'GamesController'
      })
      .when('/Products', {
        templateUrl: '/app/view/ProductsView.html',
        controller: 'ProductsController'
      });
});