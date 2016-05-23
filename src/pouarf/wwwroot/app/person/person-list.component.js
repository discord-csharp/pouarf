(function () {
    'use strict';

    angular
        .module('pouarf.person')
        .component('personList', {
            templateUrl: 'app/person/person-list.component.html',
            controller: ['people.service', PersonController],
            controllerAs: 'vm'
        });

    function PersonController(PeopleService) {
        var vm = this;
        vm.people = [];

        activate();

        function activate() {
            return PeopleService.getPeople()
                .then(function (data) {
                    vm.people = data;
                    return vm.people;
                });
        }
    }
})();