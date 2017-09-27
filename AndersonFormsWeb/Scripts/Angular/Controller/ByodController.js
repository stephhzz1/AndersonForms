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
        vm.Byods = [];
        //declared Read
        vm.Initialise = Initialise;
        vm.Read = Read;
        //function global Read
        function Initialise() {
            vm.ListType = 2;
            Read();
        }

        function Read() {
            if (vm.ListType == 1) {
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
    }

})();

