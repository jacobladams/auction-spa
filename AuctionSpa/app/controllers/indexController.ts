angular.module('auctionSpa').controller('indexController', ['$scope', '$resource', ($scope:any, $resource: ng.resource.IResourceService) => {
	$scope.message = 'hello';
	var auction:any = {};

	var categoryResource: ng.resource.IResourceClass<ICategory> = $resource<ICategory>('api/Category');
	auction.categories = categoryResource.query();

	$scope.auction = auction;
}]);