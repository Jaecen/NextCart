using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contract.Vortx.Entity;

namespace NextCart.Back.Products.Doba
{
	class Product : IProduct
	{
		public string Sku 
		{ get; set; }

		public string Id
		{ get; set; }

		public string Name
		{ get; set; }

		public decimal Msrp
		{ get; set; }

		public decimal RegularPrice
		{ get; set; }

		public decimal SellingPrice
		{ get; set; }

		public int InventoryOnHand
		{ get; set; }

		public int InventoryOnOrder
		{ get; set; }

		public string Summary
		{ get; set; }

		public string Description
		{ get; set; }

		public string Url
		{ get; set; }
	}
}
