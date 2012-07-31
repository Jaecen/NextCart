using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NextCart.Back.Products.Doba
{
	public class DobaProducts
	{
		const string Username = "jo.benson@vortx.com";
		const string Password = "Ashland!789";
		const int RetailerId = 3373330;

		public void Test()
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
			};

			DobaApi.ApiRetailerSearchPortType search = new DobaApi.ApiRetailerSearchPortTypeClient();
			var result = search.getListItems(new DobaApi.getListItemsRequest(req));

			
		}
	}
}
