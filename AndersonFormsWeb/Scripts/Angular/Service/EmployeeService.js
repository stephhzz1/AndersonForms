(function () {
    'use strict';

    angular
        .module('App')
    .factory('EmployeeService', EmployeeService);

    EmployeeService.$inject = ['$http'];

    function EmployeeService($http) {
        return {
            Create: Create,
            List: List,

        }

        function Create(employee) {
            return $http({
                method: 'POST',
                url: '../Employee/Create',
                data: {
                    employee: employee
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../Employee/List',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }

        //function Update(rollin) {
        //    return $http({
        //        method: 'POST',
        //        url: '../Rollin/Update',
        //        data: {
        //            rollin: rollin
        //        }
        //    });
        //}
        //function Delete(rollin) {
        //    return $http({
        //        method: 'POST',
        //        url: '../Rollin/Delete',
        //        data: {
        //            rollin: rollin
        //        },
        //    })


    }
})();