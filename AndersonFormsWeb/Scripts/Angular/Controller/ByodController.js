(function () {
    'use strict';

    angular
        .module('myApp')
        .controller('ByodController', ByodController);

    ByodController.$inject = ['ByodService'];

    function ByodController(ByodService) {
        var vm = this;
        vm.Byods = [];
        vm.List = List;
        vm.Delete = Delete;

        function List() {
            ByodService.List()
                .then(function (response) {
                    vm.Byods = response.data;
                })
                .catch(function (response) {
                });
        }

        function List2() {
            ByodService.List()
                .then(function (response) {
                    vm.Byods = response.data;
                })
                .catch(function (response) {
                });
        }

        function Add(byod) {
            ByodService.Create(byod)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }
        function Update(byod) {
            ByodService.Update(byod)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }
        function Approve(byod) {
            ByodService.Approve(byod)
                .then(function (response) {
                    List("");
                })
                .catch(function (response) {
                });
        }
        function Delete(byod) {
            ByodService.Delete(byod)
                .then(function (response) {
                    List();
                })
                .catch(function (response) {
                });
        }
    }

})();

