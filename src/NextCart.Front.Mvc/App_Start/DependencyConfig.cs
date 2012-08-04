using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Builder;
using Autofac.Integration.Mvc;

namespace NextCart.Front.Mvc
{
	// Just an ugly hack until the Autofac MVC4 Nuget package gets updated for RC.
	public class AutofacDependencyResolverHack : AutofacDependencyResolver, System.Web.Http.Dependencies.IDependencyResolver
	{
		public AutofacDependencyResolverHack(ILifetimeScope container)
			: base(container)
		{ }

		public System.Web.Http.Dependencies.IDependencyScope BeginScope()
		{
			return this.BeginScope();
		}

		public void Dispose()
		{
			this.Dispose();
		}
	}

	public class DependencyConfig
	{
		public static void ConfigureDependencies(HttpConfiguration configuration)
		{
			var builder = new ContainerBuilder();

			// Register API controllers using assembly scanning.
			builder.RegisterControllers(System.Reflection.Assembly.GetExecutingAssembly());

			// Register API controller dependencies per request.
			//builder.Register<ILogger>(c => new Logger()).InstancePerApiRequest();
			builder
				.Register(c => NextCart.Middle.Binding.TypeBinder.GenerateProxy<NextCart.Contract.Adnsf.IStructureStore>())
				.As<NextCart.Contract.Adnsf.IStructureStore>();

			var container = builder.Build();

			// Set the dependency resolver implementation.
			configuration.DependencyResolver = new AutofacDependencyResolverHack(container);
		}
	}
}