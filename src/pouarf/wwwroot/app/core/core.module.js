(function () {
    'use strict';

    var module = appangular.module('pouarf', [
        'ngComponentRouter',
        'pouarf.person'
    ]);

    module.value('$routerRootComponent', 'pouarfApp');
})();