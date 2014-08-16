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

		public string PhotoFilePath { get; set; }
		
		public string ThumbnailFilePath { get; set; }

		public List<Bid> Bids { get; set; } 

		//public decimal MinimumBid { get; set; }


		//name, decription, price, start bid, image thumnail
		//bids: amount, userid, item, id, timestamp, last modified?
		//category: id, description, photo

		//m.itemid, 
		//Description, 
		//Price,
		//StartBid,
		//PhotoFilePath,
		//ThumbnailPath,
		//item_name,
		//isnull(BidAmt,0) as BidAmt, isnull(BidID,0) as BidID, 
		//isnull(b.UserID,'') as UserID,
		//isnull(case when p.Employee_name = ''  then '' else case 
		//when charindex(', ',p.Employee_name) > 0 
		//then substring(p.Employee_name,charindex(', ',p.Employee_name)+ 1,len(p.Employee_name) - charindex(', ',p.Employee_name)) 
		//else p.Employee_name end end + ' ' + case 
		//when p.Employee_name = '' then '' else case when charindex(', ',p.Employee_name) > 0 then substring(p.Employee_name,1,charindex(', ',p.Employee_name) - 1) else p.Employee_name end end , '') as EmployeeName FROM actnm_main m  left outer join actnm_bids b on b.ItemID = m.ItemID left outer join  CMSOPEN.dbo.HBM_PERSNL p on b.UserID = p.login  WHERE CategoryID = " & catID & " and isnull(BidAmt,0) = isnull((select max(BidAmt) 
		//	from  actnm_bids where itemID = b.itemID),0) ORDER BY m.ItemID"
		//			Dim sQLString As String = "SELECT m.itemid, Description, Price,StartBid,PhotoFilePath,ThumbnailPath,item_name,isnull(BidAmt,0) as BidAmt, isnull(BidID,0) as BidID, isnull(b.UserID,'') as UserID FROM actnm_main m  left outer join actnm_bids b on b.ItemID = m.ItemID  Where m.itemID in ( select distinct(itemid) from actnm_bids where userid= '" & userID & "') and bidid = (select max(bidid)from actnm_bids where itemID = b.itemID) ORDER BY bidID Desc"
	}
}