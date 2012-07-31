using System;
using System.Collections.Generic;
using System.Linq;
using Contract.Vortx.Aspect;

namespace Contract.Vortx.Entity
{
	public interface IProduct : IIdentified, INamed, IPriced, IInventoried, ISummarized, IDescribed, IUrled
	{
		string Sku { get; }
	}
}
