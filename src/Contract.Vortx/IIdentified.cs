using System;
using System.Collections.Generic;
using System.Linq;

namespace Contract.Vortx
{
	public interface IIdentified
	{
		Guid Id { get; }
	}
}
