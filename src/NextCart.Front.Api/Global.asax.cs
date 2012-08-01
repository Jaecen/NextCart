using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace NextCart.Front.Api
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			ApiConfig.ConfigureApi(GlobalConfiguration.Configuration);
		}
	}
}