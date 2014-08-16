var app = angular.module('auctionSpa', ['ngRoute']);

app.config(['$routeProvider', ($routeProvider: ng.route.IRouteProvider) => {

	var templatesUrl = 'app/templates';
	//var controllersUrl = 'app/controllers';

	$routeProvider.when('/', {
		templateUrl: templatesUrl + '/index.html',
		controller: 'indexController'
	}).when('/category', {
		templateUrl: templatesUrl + '/category.html',
		controller: 'categoryController'
	})
	.when('/my-bids', {
		templateUrl: templatesUrl + '/my-bids.html',
		controller: 'myBidsController'
	});
}]);