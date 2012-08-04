using System;
using System.Collections.Generic;

namespace NextCart.Contract.Doba
{
	public interface IProductSource
	{
		IEnumerable<IProduct> GetProductsByListId(int listId);
	}
}
