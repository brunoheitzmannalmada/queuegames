app.controller('ProductsController', ['$rootScope', '$http', 'API_ADDRESS', function ($rootScope, $http, apiAddress) {
    var productsCtrl = this;
    this.listOfItems = [];
    this.Products = [];
    this.currrentItem = {};
    this.ApiRoute = 'Products';
    this.error = false;

    var validateProductForm = function (validateIt) {
        return (validateIt.ProductName == '' ||
            validateIt.ProductName == null ||
            validateIt.QuantityPerUnit == '' ||
            validateIt.QuantityPerUnit == null ||
            validateIt.UnitPrice == '' ||
            validateIt.UnitPrice == null ||
            isNaN(validateIt.UnitPrice));
    };

    this.init = function () {
        $http.get(apiAddress + this.ApiRoute)
        .then(function successCallback(result) {
            productsCtrl.Products = JSON.parse(result.data);
        }, function errorCallback(result) {
            productsCtrl.error = true;
        });
    };

    this.like = function (product) {
        $rootScope.$broadcast('openQueueManager', new QueueItem(product.ProductName,
            'Like',
            $http.post(apiAddress + 'Like', product))
        );
    };

    this.buy = function (product) {
        $rootScope.$broadcast('openQueueManager', new QueueItem(product.ProductName,
            'Buy',
            $http.post(apiAddress + 'Buy', product))
        );
    };

    this.edit = function (product) {
        var apiRoute = this.ApiRoute;
        var currentProduct = product;
        var promise = ($rootScope.$broadcast('openPopupWindow', {
            data: {
                ProductID: product.ProductID,
                ProductName: product.ProductName,
                SupplierID: product.SupplierID,
                CategoryID: product.CategoryID,
                QuantityPerUnit: product.QuantityPerUnit,
                UnitPrice: product.UnitPrice,
                UnitsInStock: product.UnitsInStock,
                UnitsOnOrder: product.UnitsOnOrder,
                ReorderLevel:product.ReorderLevel,
                Discontinued: product.Discontinued
            },
            validationFunction: validateProductForm
        })).promise;

        promise.then(function successCallback(result) { },
            function errorCallback(result) { },
            function notificationCallback(result) {
                var productFromPopup = result;
                $http.put(apiAddress + apiRoute + '/put/?id=' + productFromPopup.ProductID, JSON.stringify(result))
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
            data: {
                ProductName: '',
                QuantityPerUnit: '',
                UnitPrice: ''
            },
            validationFunction: validateProductForm
        }).promise;

        promise.then(function successCallback(result) { },
            function errorCallback(result) { },
            function notificationCallback(result) {
                var productToBeAdded = result;
                $http.post(apiAddress + apiRoute, result)
                .then(function successCallback(result) {
                    $rootScope.$broadcast('closePopupWindow', { successMessage: 'The product was added!' });
                    productToBeAdded.ProductID = result.data;
                    productsCtrl.Products.push(productToBeAdded);
                },
                function errorCallback(result) {
                    $rootScope.$broadcast('showError', { errorMessage: 'There was an error saving the product' });
                });
            }
        );
    };

    this.delete = function (product) {
        var fnCallback = function () {
            productsCtrl.Products.splice(productsCtrl.Products.indexOf(product), 1);
        };
        $rootScope.$broadcast('openQueueManager', new QueueItem(product.ProductName,
            'Delete',
            $http.delete(apiAddress + productsCtrl.ApiRoute + '/delete/' + product.ProductID),
            fnCallback)
        );
    };

    this.Include = function () {
        return '/app/view/ProductEdit.html';
    };
}]);