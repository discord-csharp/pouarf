(function () {
    'use strict';

    angular
        .module('pouarf.person')
        .factory('people.service', ['$http', PeopleService]);

    function PeopleService($http) {
        var service = {
            getPeople: getPeople
        };

        return service;

        function getPeople() {
            return $http.get('/api/people')
                .then(getPeopleComplete);
        }

        function getPeopleComplete(response) {
            return response.data;
        }
    }
})();