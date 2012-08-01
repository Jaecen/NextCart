using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Builder;
using Autofac.Integration.WebApi;

namespace NextCart.Front.Api.App_Start
{
	public class DependencyConfig
	{
		public static void ConfigureDependencies(HttpConfiguration configuration)
		{
			var builder = new ContainerBuilder();

			// Register API controllers using assembly scanning.
			builder.RegisterApiControllers(System.Reflection.Assembly.GetExecutingAssembly());

			// Register API controller dependencies per request.
			//builder.Register<ILogger>(c => new Logger()).InstancePerApiRequest();

			var container = builder.Build();

			// Set the dependency resolver implementation.
			var resolver = new AutofacWebApiDependencyResolver(container);
			configuration.DependencyResolver = resolver;

		}
	}
}