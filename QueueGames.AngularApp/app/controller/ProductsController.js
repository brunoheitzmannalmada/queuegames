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
            productsCtrl.Products = JSON.parse(result.data);
        }, function errorCallback(result) {

        });
    };

    this.like = function (product) {
        console.log('Like product');
        this.listOfItems.splice(0, 0, new QueueItem(product.ProductName,
            'Like',
            $http.post(apiAddress + this.ApiRoute, product))
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

    this.edit = function (product) {
        var apiRoute = this.ApiRoute;
        var currentProduct = product;
        var promise = ($rootScope.$broadcast('openPopupWindow', {
            ProductName: product.ProductName,
            QuantityPerUnit: product.QuantityPerUnit,
            UnitPrice: product.UnitPrice
        })).promise;

        promise.then(function successCallback(result) { },
            function errorCallback(result) { },
            function notificationCallback(result) {
                var productFromPopup = result;
                $http.post(apiAddress + apiRoute, result)
                .then(function successCallback(result) {
                    currentProduct.ProductName = productFromPopup.ProductName;
                    currentProduct.QuantityPerUnit = productFromPopup.QuantityPerUnit;
                    currentProduct.UnitPrice = productFromPopup.UnitPrice;
                    $rootScope.$broadcast('closePopupWindow', { successMessage: 'The product was edited!' });
                },
                function errorCallback(result) {
                    $rootScope.$broadcast('showError', { errorMessage: 'There was an error saving the product' });
                });
        });
    };

    this.newProduct = function () {
        var apiRoute = this.ApiRoute;
        var promise = $rootScope.$broadcast('openPopupWindow', {
            ProductName: '',
            QuantityPerUnit: '',
            UnitPrice: ''
        }).promise;

        promise.then(function successCallback(result) { },
            function errorCallback(result) { },
            function notificationCallback(result) {
                $http.post(apiAddress + apiRoute, result)
                .then(function successCallback(result) {
                    $rootScope.$broadcast('closePopupWindow', { successMessage: 'The product was added!' });
                },
                function errorCallback(result) {
                    $rootScope.$broadcast('showError', { errorMessage: 'There was an error saving the product' });
                });
            }
        );
    };

    this.Include = function () {
        return '/app/view/ProductEdit.html';
    };
}]);