using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NextCart.Front.Api
{
	public class ApiConfig
	{
		public static void ConfigureApi(HttpConfiguration config)
		{
			config.Formatters.Clear();
			config.Formatters.Add(new System.Net.Http.Formatting.JsonMediaTypeFormatter());
		}
	}
}