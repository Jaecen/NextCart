using System;
using System.Collections.Generic;

namespace Contract.Product.Doba
{
	public interface IProductSource
	{
		IEnumerable<IProduct> GetProductsByListId(int listId);
	}
}
