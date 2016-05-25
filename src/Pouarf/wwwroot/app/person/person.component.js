(function () {
    'use strict';

    angular
        .module('pouarf.person')
        .component('person', {
            templateUrl: 'app/person/person.component.html',
            controller: PersonController,
            controllerAs: 'vm'
        });

    function PersonController() {
        var vm = this;
        vm.name = '';

        activate();

        function activate() {
            console.log('PersonComponent activated!')
        }
    }
})();