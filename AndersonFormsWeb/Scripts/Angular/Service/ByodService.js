(function () {
    'use strict';
    angular
        .module('myApp')
        .factory('ByodService', ByodService);
    ByodService.$inject = ['$http'].h;

    function ByodService($http) {
        return {
            List: List,
            Add: Add,
            Delete: Delete
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Byod/List',
            });
        }
        function Add(byod) {
            return $http({
                method: 'POST',
                url: '../Byod/Add',
                data: {
                    byod: byod
                },
            });
        }       
        function Update(byod) {
            return $http({
                method: 'POST',
                url: '../Byod/Update',
                data: {
                    byod: byod
                },
            });
        }
        function Delete(byod) {
            return $http({
                method: 'POST',
                url: '../Byod/Delete',
                data: {
                    byod: byod
                },
            });
        }

    }
})();