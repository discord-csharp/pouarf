(function () {
    'use strict';

    angular
        .module('pouarf.person')
        .component('person', {
            templateUrl: 'app/person/person.component.html',
            controller: [PersonController],
            controllerAs: 'vm',
            bindings: {
                person: '<'
            }
        });

    function PersonController() {
        var vm = this;

        activate();

        function activate() {
            console.log(vm.person);
        }
    }
})();