using System;
using System.Collections.Generic;
using System.Linq;
using Contract.Vortx.Aspect;

namespace Contract.Vortx.Entity
{
	public interface ICategory : IIdentified, INamed, ISummarized, IUrled
	{
		IEnumerable<ICategoryEntry> Entries { get; }
	}
}
