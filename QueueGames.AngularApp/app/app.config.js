app.config(function ($routeProvider, $locationProvider) {
  //$locationProvider.html5Mode(true);

  $routeProvider
      .when('/', {
        templateUrl: '/app/view/queueListView.html',
        controller: 'QueueListController'
      })
      .when('/Products', {
        templateUrl: '/app/view/ProductsView.html',
        controller: 'ProductsController'
      });
});