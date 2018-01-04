(function () {
    'use strict';

    angular
        .module('App')
        .controller('ByodController', ByodController);

    ByodController.$inject = ['ByodService'];

    function ByodController(ByodService) {
        var vm = this;
        //variables
        vm.ListType;
        //object List
        vm.ListTypes = [];
        vm.Byods = [];
        //declared Read
        vm.Initialise = Initialise;
        vm.Read = Read;
        //declared Update
        vm.Approve = Approve;
        //declared Delete
        vm.Delete = Delete;
        //function global Read
        function Initialise() {
            vm.ListTypes = [
                { ListTypeId: "1", Description: "Requested" },
                { ListTypeId: "2", Description: "For Approval" }
            ];
            vm.ListType = vm.ListTypes[0];
            Read();
        }

        function Read() {

            if (vm.ListType.ListTypeId == 1) {
                ByodService.ReadRequested(vm.ListType)
                    .then(function (response) {
                        vm.Byods = response.data;
                    })
                    .catch(function (data, status) {

                    });
            }
            else {
                ByodService.ReadForApproval(vm.ListType)
                    .then(function (response) {
                        vm.Byods = response.data;
                    })
                    .catch(function (data, status) {

                    });
            }
        }

        //function global Update
        function Approve(byodId) {
            ByodService.Approve(byodId)
                .then(function (response) {
                    if (response.data === true) {
                        Read();
                    }
                })
                .catch(function (data, status) {
                });
        }

        //function global Delete
        function Delete(byodId) {
            ByodService.Delete(byodId)
                .then(function (response) {
                    if (response.data === true) {
                        Read();
                    }
                })
                .catch(function (data, status) {
                });
        }
    }

})();

