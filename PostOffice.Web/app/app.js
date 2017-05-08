/// <reference path="/Assets/admin/libs/angular/angular.js" />

angular.module('postoffice',
            [                
                'postoffice.services',
                'postoffice.service_groups',                
                'angular-loading-bar',
                'LocalStorageModule',
                'ngCookies',
                'datatables',
                'postoffice.common'
            ])

    .config(function ($stateProvider, $urlRouterProvider, $locationProvider) {
        //$locationProvider.html5Mode({
        //    enabled: true, 
        //    requireBase: false,
        //    hashPrefix: ''
        //})
           
        $stateProvider
            .state('base', {
                url: '',
                templateUrl: '/app/shared/views/baseView.html',
                abstract: true
            }).state('login', {
                url: "/login",
                templateUrl: "/app/components/login/loginView.html",
                controller: "loginController"
            })
            .state('home', {
                url: "/admin",
                parent: 'base',
                templateUrl: "/app/components/home/homeView.html",
                controller: "homeController"
            });
        $urlRouterProvider.otherwise('/home');
    })

    //.config(function ($httpProvider) {
    //    $httpProvider.interceptors.push('authInterceptorService');
    //})

    //.run(['authService', function (authService) {
    //    authService.fillAuthData()
    //}])

    .config(['cfpLoadingBarProvider', function(cfpLoadingBarProvider) {
        cfpLoadingBarProvider.includeBar = true;
        cfpLoadingBarProvider.includeSpinner = true;
    }])

  

