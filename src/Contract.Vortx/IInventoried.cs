using System;
using System.Collections.Generic;
using System.Linq;

namespace Contract.Vortx
{
	public interface IInventoried
	{
		int InventoryOnHand { get; }
		int InventoryOnOrder { get; }
	}
}
