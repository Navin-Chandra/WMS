var homecontrollers = angular.module("homecontrollers", []);

homecontrollers.controller("homecontrollers", function GetStatesList($scope, $http) {

    //defualt date in datepicker
    var date = new Date();
    var day = date.getDate();
    var month = date.getMonth() + 1;
    var year = date.getFullYear();
    if (month < 10) month = "0" + month;
    if (day < 10) day = "0" + day;

    var today = year + "-" + month + "-" + day;
    $("#currentDateTb").attr("value", today);


    // get state list
    $http.get('/Home/StateList').success(function (data) {
        $scope.states = data;
    });


    // get city list based on state id
    $scope.getCityList = function (stateId) {
        var url = '/Home/CityList/' + stateId;
        $http.get(url).success(function (data) {
            $scope.cityList = data;
        });
    };

    // Check variance in actual amd predicted speed
    $scope.checkVariance = function () {
        
        if ($scope.actualSpeed != "") {
            $scope.variance = $scope.predictedSpeed - $scope.actualSpeed;
            $scope.colorName = " ";

            if ($scope.variance == 1 || $scope.variance == -1) {
                $scope.colorName = "blackColor";
            }
            else if ($scope.variance == 3 || $scope.variance == -3) {
                $scope.colorName = "purpleColor";
            } else if ($scope.variance <= -5 || $scope.variance >= 5) {
                $scope.colorName = "redColor";
            }
        }else
        {
            $scope.variance = "";
        }
    };

    // get city list based on state id
    $scope.getStationCode = function (cityId) {
        var url = '/Home/StationList/' + cityId;
        $http.get(url).success(function (data) {
            $scope.stationCode = data.StationCode;
            $scope.predictedSpeed = data.PredictedSpeed;
        });
    };

    //state change event
    $scope.StateChange = function () {
        $scope.getCityList($scope.selectedState.StateId);
    };
    
    //city change event
    $scope.CityChange = function () {
        $scope.getStationCode($scope.selectedCity.CityId)
       
    };

    

})