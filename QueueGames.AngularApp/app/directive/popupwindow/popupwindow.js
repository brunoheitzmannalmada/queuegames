app.directive('popupWindow', ['$q', function ($q) {
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
            var saveButton = angular.element(angular.element(element).find('#btnSave')[0]);
            var messageBox = angular.element(angular.element(element).find('.popupmessage')[0]);
            var def;

            scope.$on('openPopupWindow', function (event, data) {
                scope.errorMessage = '';
                def = $q.defer();
                popupWindow.modal();
                scope.dataSource = data;
                event.promise = def.promise;
            });

            scope.$on('closePopupWindow', function (event, data) {
                popupWindow.modal('hide');

                if (data.successMessage) {
                    messageBox.css('display', 'block');
                    scope.successMessage = data.successMessage;

                    setTimeout(function () {
                        messageBox.css('display', 'none');
                    }, 3000);
                };
            });

            scope.$on('showError', function (event, data) {
                scope.errorMessage = data.errorMessage;
            });

            saveButton.bind('click', function () {
                scope.errorMessage = '';
                def.notify(scope.dataSource);
            });
        }
    };
}]);