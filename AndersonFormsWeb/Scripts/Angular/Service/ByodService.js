(function () {
    'use strict';
    angular
        .module('myApp')
        .factory('ByodService', ByodService);
    ByodService.$inject = ['$http'];

    function ByodService($http) {
        return {
            List: List,
            List2: List2,
            Add: Add,
            Delete: Delete
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Byod/List',
            })
        }

        function List2() {
            return $http({
                method: 'POST',
                url: '../Byod/List2',
            })
        }

        function Add(byod) {
            return $http({
                method: 'POST',
                url: '../Byod/Add',
                data: {
                    byod: byod
                },
            })
        }       
        function Update(byod) {
            return $http({
                method: 'POST',
                url: '../Byod/Update',
                data: {
                    byod: byod
                },
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