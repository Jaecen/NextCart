using System;
using System.Collections.Generic;
using System.Linq;

namespace NextCart.Contract.Core
{
	public interface IInventoried
	{
		int InventoryOnHand { get; }
		int InventoryOnOrder { get; }
	}
}
