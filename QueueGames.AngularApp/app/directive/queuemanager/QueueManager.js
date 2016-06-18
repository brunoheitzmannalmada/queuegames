app.directive('queueManager', function () {
    return {
        restrict: 'E',
        templateUrl: '/app/directive/queuemanager/queue-manager-view.html',
        link: function (scope, element, attrs) {
            var mainWindow = angular.element(angular.element(element).find('.queueManager')[0]);
            var commandBar = angular.element(angular.element(element).find('.command')[0]);
            var closeButton = angular.element(angular.element(element).find('.closeButton')[0]);
            var minimizeButton = angular.element(angular.element(element).find('.minimizeButton')[0]);
            var list = angular.element(angular.element(element).find('.list')[0]);
            scope.dataSrc = [];

            var minimizeFn = function () {
                if (list.css('overflow-y') == 'scroll') {
                    list.css('overflow-y', 'hidden');
                    list.css('height', '0px');
                    return;
                }

                if (list.css('overflow-y') == 'hidden') {
                    list.css('overflow-y', 'scroll');
                    list.css('height', '250px');
                    return;
                }
            };

            scope.$on('openQueueManager', function (event, data) {
                mainWindow.css('display', 'block');
                list.css('overflow-y', 'scroll');
                list.css('height', '250px');
                scope.dataSrc.splice(0, 0, data);
            });

            closeButton.bind('click', function () {
                mainWindow.css('display', 'none');
                scope.dataSrc = [];
            });

            minimizeButton.bind('click', minimizeFn);
        }
    };
});