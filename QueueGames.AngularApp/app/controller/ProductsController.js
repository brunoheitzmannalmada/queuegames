app.controller('ProductsController', ['$rootScope', '$http', 'API_ADDRESS', function ($rootScope, $http, apiAddress) {
    var productsCtrl = this;
    this.listOfItems = [];
    this.Products = [];
    this.currrentItem = {};
    this.ApiRoute = 'Products';

    this.init = function () {
        console.log('Init products controller');
        $http.get(apiAddress + this.ApiRoute)
        .then(function successCallback(result) {
            //console.log();
            productsCtrl.Products = JSON.parse(result.data);
        }, function errorCallback(result) {

        });
    };

    this.like = function (product) {
        console.log('Like product');
        this.listOfItems.splice(0, 0, new QueueItem(product.ProductName,
            'Like',
            $http.post(apiAddress + this.ApiRoute + '/Like', product))
        );
        $rootScope.$broadcast('openQueueManager', {});
    };

    this.buy = function (product) {
        console.log('Buy product');
        this.listOfItems.splice(0, 0, new QueueItem(product.ProductName,
            'Buy',
            $http.post(apiAddress + this.ApiRoute, product))
        );
        $rootScope.$broadcast('openQueueManager', {});
    };
}]);