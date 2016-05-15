app.directive('queueManager', function () {
    return {
        restrict: 'E',
        templateUrl: '/app/directive/queuemanager/queue-manager-view.html',
        scope: {
            dataSource: '=src'
        },
        link: function (scope, element, attrs) {
            var mainWindow = angular.element(angular.element(element).find('.queueManager')[0]);
            var commandBar = angular.element(angular.element(element).find('.command')[0]);
            var closeButton = angular.element(angular.element(element).find('.closeButton')[0]);
            var minimizeButton = angular.element(angular.element(element).find('.minimizeButton')[0]);
            var list = angular.element(angular.element(element).find('.list')[0]);

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
            });

            closeButton.bind('click', function () {
                mainWindow.css('display', 'none');
            });

            minimizeButton.bind('click', minimizeFn);
        }
    };
});