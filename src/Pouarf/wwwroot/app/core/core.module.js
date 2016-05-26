(function () {
    'use strict';

    var module = angular.module('pouarf', [
        'ngComponentRouter',
        'pouarf.person'
    ]);

    module.config(function ($locationProvider) {
        $locationProvider.html5Mode(true);
    });

    module.value('$routerRootComponent', 'pouarfApp');

})();