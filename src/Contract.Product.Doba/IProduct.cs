using System;
using Contract.Vortx.Aspect;

namespace Contract.Product.Doba
{
	public interface IProduct : IIdentified, INamed, IPriced
	{ }
}
