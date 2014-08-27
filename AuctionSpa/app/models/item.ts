interface IItem {
	id: number;
	name: string;
	description: string;
	price: number;
	startingBid: number;
	photoFile: string;
	thumbnailFile: string;
	bids: IBid[];
}
