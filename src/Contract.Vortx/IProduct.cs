using System;
using System.Collections.Generic;
using System.Linq;

namespace Contract.Vortx
{
	public interface IProduct : IIdentified, INamed, IPriced, IInventoried, ISummarized, IDescribed
	{
	}
}
