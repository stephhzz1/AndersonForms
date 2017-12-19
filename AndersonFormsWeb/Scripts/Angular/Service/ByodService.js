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
            Read: Read,
            Approve: Approve,
            Update: Update,
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

        function Read() {
            return $http({
                method: 'POST',
                url: '../Byod/Read',
            })
        }

        function Approve(byodId) {
            return $http({
                method: 'POST',
                url: '../Byod/Approve/' + byodId
            })
        }

        function Update(byodId) {
            return $http({
                method: 'POST',
                url: '../Byod/Update/' + byodId
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