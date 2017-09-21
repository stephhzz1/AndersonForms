(function () {
    'use strict';

    angular
    .module('myApp')
    .controller('RequestedItemController', RequestedItemController);

    RequestedItemController.$inject = ['RequestedItemService'];

    function RequestedItemController(RequestedItemService) {
        var vm = this;

        vm.RequestedItem;

        vm.RequestedItems = [];

        vm.List = List;
        vm.Create = Create;
        vm.CreateModal = CreateModal;


        function Create() {
            RequestedItemService.Create(vm.RequestedItem)
            .then(function (response) {
                List();
                angular.element('#RequestedItemModal').modal('hide');

                //new PNotify({
                //    title: 'Success',
                //    text: 'RequestedItem Created',
                //    type: 'success',
                //    hide: true,
                //    addclass: "stack-bottomright"
                //});

            })
            .catch(function (data, status) {


            });
        }

        function CreateModal(requestedItem) {
            vm.RequestedItem = {
                DepartmentId: '',
                EmployeeId: '',
                RemovedBy: '',
                ImplementedBy: '',
                RequestedItemId: '',
                Comment: '',
            };
        }

        function List() {
            RequestedItemService.List()
             .then(function (response) {
                 vm.RequestedItems = response.data;
             })
             .catch(function (data, status) {


             });
        }

    }
})();