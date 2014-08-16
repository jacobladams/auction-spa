using System;

namespace AuctionSpa.Models
{
	public class Bid
	{
		public decimal Amount { get; set; }

		public int UserId { get; set; }
		
		public DateTime TimeStamp { get; set; }

		//public AuctionItem Item{ get; set; }
	}
}