(function () {
    'use strict';

    angular
        .module('pouarf')
        .component('pouarfApp', {
            templateUrl: 'app/core/pouarf-app.component.html',
            $routeConfig: [
                { path: '/', component: 'personList', name: 'List' },
                { path: '/**', redirectTo: ['List'] }
            ]
        });
})();