using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionSpa.Models
{
	public class TestRepository : IAuctionRepository
	{
		private readonly List<Category> _categories; 

		public TestRepository()
		{
			_categories =
				Enumerable.Range(1, 10).Select(i => new Category {Id = i, Name = string.Format("Category {0}", i)}).ToList();
		}

		#region IAuctionRepository Members

		public List<Category> GetCategories()
		{
			return _categories;
		}

		public List<Item> GetItemsByCategoryId(int categoryId)
		{
			throw new NotImplementedException();
		}

		public List<Item> AddBid(Bid bid)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}