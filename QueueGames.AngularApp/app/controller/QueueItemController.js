app.controller('QueueListController', ['$rootScope', '$http', 'API_ADDRESS', function ($rootScope, $http, apiAddress) {
    var queueCtrl = this;
    this.listOfItems = [];
    this.currrentItem = {};
    this.ApiRoute = 'Games';

    this.Save = function () {
        this.listOfItems.splice(0, 0, new QueueItem(queueCtrl.currrentItem.Name,
            queueCtrl.currrentItem.Developer,
            $http.post(apiAddress + this.ApiRoute, queueCtrl.currrentItem))
        );

        $rootScope.$broadcast('openQueueManager', {});
        this.CleanCurrentItem();
    };

    this.RetrieveNextItem = function () {

    };

    this.CleanCurrentItem = function () {
        this.currrentItem = {
            Name: '',
            YearLaunch: '',
            Developer: '',
            Platform: ''
        };
    };

    this.isFormValid = function () {
        return (this.currrentItem.Name == '' || this.currrentItem.YearLaunch == '' || this.currrentItem.Developer == '' || this.currrentItem.Platform == '');
    }

    this.CleanCurrentItem();
}]);