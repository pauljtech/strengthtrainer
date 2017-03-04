angular.module('WorkoutApp', [])
    .constant("dataUrl", "http://localhost/strengthtrainer/api")
    .controller('WorkoutCtrl', function ($scope, $http) {
        $scope.data = {};
        $scope.loadSet = function () {

            $http.get("http://localhost/strengthtrainer/api/sets/" + $scope.setId)
                .then(function (response) {
                    $scope.data.errorMessage = "";
                    $scope.data.id = response.data.id;
                    $scope.data.number = response.data.number;
                    $scope.data.reps = response.data.reps;
                    $scope.data.weight = response.data.weight;
                    $scope.data.weightType = response.data.weightType;
                    $scope.data.startDateTime = response.data.startDateTime;
                    $scope.data.notes = response.data.notes;
                })
                .catch(function (response) {
                    $scope.data = {};
                    $scope.data.errorMessage = "The requested data was not found.";
                    console.error('Get Set error', response.status, response.data);
                })
                .finally(function () {
                    console.log("Finally - Get Set");
                });
        };
    });
