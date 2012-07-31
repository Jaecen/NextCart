using System;
using System.Collections.Generic;
using System.Linq;

namespace Contract.Vortx
{
	public interface IInventoryQuery
	{
		int? InventoryOnHand { get; }
		int? InventoryOnOrder { get; }
	}
}
