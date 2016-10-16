(function () {
  'use strict';

  angular.module('demoApp', ['ui.tree', 'ngRoute', 'ui.bootstrap'])

    .config(['$routeProvider', '$compileProvider', function ($routeProvider, $compileProvider) {
        $routeProvider
        .when('/uitree', {
            controller: 'BasicExampleCtrl',
            templateUrl: '/App/UiTree/views/basic-example.html'
        })
        .when('/uitree/basic-example', {
          controller: 'BasicExampleCtrl',
          templateUrl: '/App/UiTree/views/basic-example.html'
        })
        .when('/uitree/cloning', {
          controller: 'CloningCtrl',
          templateUrl: '/App/UiTree/views/cloning.html'
        })
        .when('/uitree/connected-trees', {
          controller: 'ConnectedTreesCtrl',
          templateUrl: '/App/UiTree/views/connected-trees.html'
        })
        .when('/uitree/filter-nodes', {
          controller: 'FilterNodesCtrl',
          templateUrl: '/App/UiTree/views/filter-nodes.html'
        })
        .when('/uitree/nodrop', {
          controller: 'BasicExampleCtrl',
          templateUrl: '/App/UiTree/views/nodrop.html'
        })
        .when('/uitree/table-example', {
          controller: 'TableExampleCtrl',
          templateUrl: '/App/UiTree/views/table-example.html'
        })
        .when('/uitree/drop-confirmation', {
          controller: 'DropConfirmationCtrl',
          templateUrl: '/App/UiTree/views/drop-confirmation.html'
        })
        .when('/uitree/expand-on-hover', {
          controller: 'ExpandOnHoverCtrl',
          templateUrl: '/App/UiTree/views/expand-on-hover.html'
        })
        .otherwise({
            redirectTo: '/uitree'
        });

      // testing issue #521
      $compileProvider.debugInfoEnabled(false);
    }]);
})();
