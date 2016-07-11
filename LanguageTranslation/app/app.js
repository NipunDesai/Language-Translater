var myApp = angular.module('myApp', ['ngResource', 'ngRoute', 'pascalprecht.translate']);

myApp.config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/home',
        {
            templateUrl: '/Templates/Dashboard.html'
        });
    }
]);


myApp.config(['$translateProvider', function ($translateProvider) {
    // add translation tables
    var translation = { "uname": "اسم المستخدم" };
    $translateProvider
    .translations('lang', translation)
    .preferredLanguage('lang');
}]);


myApp.controller("homeController", ['$scope', '$rootScope', function ($scope, $rootScope) {
    $scope.name = "test";
    $rootScope.language = { "uname": "اسم المستخدم" };
}])