app.directive('popupWindow', function () {
    return {
        restrict: 'E',
        templateUrl: '/app/directive/popupwindow/popup-window.html',
        scope: {
            dataSource: '=src',
            path: '=path',
            popupTitle: '=popupTitle'
        },
        link: function (scope, element, attrs) {
            var popupWindow = angular.element(angular.element(element).find('#popupWindow')[0]);
            
            scope.$on('openPopupWindow', function (event, data) {
                popupWindow.modal();
                scope.dataSource = data;
            });
        }
    }
});