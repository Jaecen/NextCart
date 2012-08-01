using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace NextCart.Front.Api
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "{controller}"
			);
		}
	}
}