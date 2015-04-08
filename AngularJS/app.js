var app = angular.module('plunker', []);

app.controller('MainCtrl', function ($scope) {
    $scope.name = 'World';
});

app.controller('ClientController', function ($scope, $http) {
    $http.get("/api/Client")
      .success(function (response) { $scope.clients = response; });
});

var app = angular.module('myApp', []);

app.controller('MainController', function ($scope, $http) {
    var onUserComplete = function (response) {
        $scope.user = response.data;
    };

    var onError = function (reason) {
        $scope.error = "Could not fetch the GitHub user.";
        //$scope.error = reason;
    };

    $http.get("https://api.github.com/users/shanselman")
      .then(onUserComplete, onError);

    $scope.message = "Hello, Angular!";
});


app.controller('ClientController', function ($scope, $http) {

    var onUserComplete = function (response) {
        $scope.user = response.data;
    };

    var onError = function (reason) {
        $scope.error = "Could not fetch the Client.";
        //$scope.error = reason;
    };

    var promise = $http.get("/api/Client");
    promise.success(function (response) {
        $scope.clients = response.data;
    });

});