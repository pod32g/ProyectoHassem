(function () {
	'use strict';
	angular.module('utj', [])
	.controller('utj-controller', ['$scope', '$log',
		function($scope, $log) {
			$scope.getResults = function() {
				alert("test")
			}
		}])
})