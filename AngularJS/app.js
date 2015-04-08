var app = angular.module('plunker', []);

app.controller('MainCtrl', function ($scope) {
    $scope.name = 'World';
});

app.controller('ClientController', function ($scope, $http) {
    $http.get("/api/Client")
      .success(function (response) { $scope.clients = response; });
});