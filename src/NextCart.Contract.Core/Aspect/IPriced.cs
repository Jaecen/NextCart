using System;
using System.Collections.Generic;
using System.Linq;

namespace NextCart.Contract.Core
{
	public interface IPriced
	{
		decimal Msrp { get; }
		decimal RegularPrice { get; }
		decimal SellingPrice { get; }
	}
}
