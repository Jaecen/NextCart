using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contract.Product.Doba;

namespace NextCart.Back.Doba
{
	public class ProductStore : IProductSource
	{
		// This would be config'd in admin
		const string Username = "jo.benson@vortx.com";
		const string Password = "Ashland!789";
		const int RetailerId = 3373330;

		public IEnumerable<IProduct> GetProductsByListId(int listId)
		{
			var auth = new DobaApi.ApiRetailerAuthenticationInfo
			{
				username = Username,
				password = Password,
			};

			var req = new DobaApi.ApiRetailerGetListItemsRequest
			{
				authentication = auth,
				retailer_id = RetailerId,
				list_id = listId,
			};

			DobaApi.ApiRetailerSearchPortType search = new DobaApi.ApiRetailerSearchPortTypeClient();
			var result = search.getListItems(new DobaApi.getListItemsRequest(req));

			return result.getListItemsReturn.items
				.Select(itemDetail => new Product
				{
					Id = itemDetail.item_id.ToString(),
					Sku = itemDetail.sku,
					Name = itemDetail.item_name,
					Description = itemDetail.description,
					Msrp = (decimal)itemDetail.msrp,
					SellingPrice = (decimal)itemDetail.price,
					InventoryOnHand = itemDetail.qty_avail,
				});
		}
	}
}
