(function () {
    'use strict';
    angular
        .module('App')
        .factory('ByodService', ByodService);
    ByodService.$inject = ['$http'];

    function ByodService($http) {
        return {
            ReadForApproval: ReadForApproval,
            ReadRequested: ReadRequested,
            Delete: Delete
        }

        function ReadForApproval() {
            return $http({
                method: 'POST',
                url: '../Byod/ReadForApproval',
            })
        }

        function ReadRequested() {
            return $http({
                method: 'POST',
                url: '../Byod/ReadRequested',
            })
        }

        function Delete(byod) {
            return $http({
                method: 'POST',
                url: '../Byod/Delete',
                data: {
                    byod: byod
                },
            })
        }

        function Approve(byod) {
            return $http({
                method: 'POST',
                url: '../Byod/Approve',
                data: {
                    byod: byod
                },
            })
        }
    }
})();