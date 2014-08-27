using System.Collections.Generic;

namespace AuctionSpa.Models
{
	public class Item
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public decimal StartingBid { get; set; }

		public string PhotoFile { get; set; }
		
		public string ThumbnailFile { get; set; }

		public List<Bid> Bids { get; set; } 

		//public decimal MinimumBid { get; set; }
	}
}