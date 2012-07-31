using System;
using System.Collections.Generic;
using System.Linq;

namespace Contract.Vortx
{
	public interface IPriced
	{
		decimal Msrp { get; }
		decimal RegularPrice { get; }
		decimal SellingPrice { get; }
	}
}
