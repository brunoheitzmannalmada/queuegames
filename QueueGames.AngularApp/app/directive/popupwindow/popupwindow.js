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
                scope.dataSource = data.data;
                scope.validationFunction = data.validationFunction;
                event.promise = def.promise;
            });

            scope.$on('closePopupWindow', function (event, data) {
                saveButton.removeAttr('disabled');
                popupWindow.modal('hide');

                if (data.successMessage) {
                    messageBox.css('display', 'block');
                    scope.successMessage = data.successMessage;

                    setTimeout(function () {
                        messageBox.css('display', 'none');
                    }, 3000);
                };
            });

            popupWindow.on('hide.bs.modal', function (e) {
                def.resolve();
                def = null;
            });

            scope.$on('showError', function (event, data) {
                scope.errorMessage = data.errorMessage;
                saveButton.removeAttr('disabled');
            });

            saveButton.bind('click', function () {
                scope.errorMessage = '';
                saveButton.attr('disabled', 'disabled')
                def.notify(scope.dataSource);
            });
        }
    };
}]);