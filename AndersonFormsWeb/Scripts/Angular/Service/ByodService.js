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

            Approve: Approve,

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

        function Approve(byodId) {
            return $http({
                method: 'POST',
                url: '../Byod/Approve/' + byodId
            })
        }

        function Delete(byodId) {
            return $http({
                method: 'Delete',
                url: '../Byod/Delete/' + byodId
            })
        }
    }
})();