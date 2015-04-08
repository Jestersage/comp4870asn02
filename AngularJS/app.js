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

    var onClientComplete = function (response) {
        console.log(JSON.stringify(response));
        $scope.user = response.data;
        $scope.dump = JSON.stringify(response.data);

    };

    var onError = function (reason) {
        $scope.error = "Could not fetch the Client.";
        $scope.dump = JSON.stringify(response.data);
        //$scope.error = reason;
    };

    $http.get("http://a3.georgeleung.com/api/Clients")
      .then(onClientComplete, onError);

});