(function () {
    'use strict';

    angular
        .module('App')
    .factory('RequestedItemService', RequestedItemService);

    RequestedItemService.$inject = ['$http'];

    function RequestedItemService($http) {
        return {
            Create: Create,
            List: List,

        }

        function Create(requestedItem) {
            return $http({
                method: 'POST',
                url: '../RequestedItem/Create',
                data: {
                    requestedItem: requestedItem
                }
            });
        }

        function List() {
            return $http({
                method: 'POST',
                url: '../RequestedItem/List',
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