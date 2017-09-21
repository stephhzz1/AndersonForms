(function () {
    'use strict';

    angular
    .module('myApp')
    .controller('EmployeeController', EmployeeController);

    EmployeeController.$inject = ['EmployeeService'];

    function EmployeeController(EmployeeService) {
        var vm = this;

        vm.Employee;

        vm.Employees = [];

        vm.List = List;
        vm.Create = Create;
        vm.CreateModal = CreateModal;
        //vm.Update = Update;
        //vm.UpdateModal = UpdateModal;
        //vm.Delete = Delete;
        //vm.Details = Details;

        function Create() {
            EmployeeService.Create(vm.Employee)
            .then(function (response) {
                List();
                angular.element('#EmployeeModal').modal('hide');

                new PNotify({
                    title: 'Success',
                    text: 'Employee Created',
                    type: 'success',
                    hide: true,
                    addclass: "stack-bottomright"
                });

            })
            .catch(function (data, status) {


            });
        }

        function CreateModal(employee) {
            vm.Employee = {
                EmployeeId: '',
                ManagerEmployeeId: '',
                FirstName: '',
                MiddleName: '',
                LastName: '',
                Department: '',
                JobTitle: '',
                HiringDate: '',
                StartingDate: '',
            };
        }

        function List() {
            EmployeeService.List()
            .then(function (response) {
                vm.Employees = response.data;
            })
            .catch(function (data, status) {


            });
        }

    }
})();