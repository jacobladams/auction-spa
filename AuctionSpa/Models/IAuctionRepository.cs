using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionSpa.Models
{
	public interface IAuctionRepository
	{
		List<Category> GetCategories();

		List<Item> GetItemsByCategoryId(int categoryId);

		List<Item> AddBid (Bid bid);
	}
}
