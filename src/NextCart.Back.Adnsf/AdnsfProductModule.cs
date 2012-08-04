using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NextCart.Contract.Adnsf;
using NextCart.Contract.Core;

namespace NextCart.Back.AdnsfDatabase
{
	public class AdnsfProductModule : IProductStore
	{
		public IEnumerable<IProduct> GetProducts(IEnumerable<IIdentified> identifiers)
		{
			return Enumerable.Empty<IProduct>();
		}
	}

	public class AdnsfStructureModule : IStructureStore
	{
		public IEnumerable<IStructureItem> GetRootStructureItems()
		{
			return Enumerable.Empty<IStructureItem>();
		}

		public IEnumerable<IStructureItem> GetChildren(IIdentified nodeIdentifier)
		{
			return Enumerable.Empty<IStructureItem>();
		}
	}
}
