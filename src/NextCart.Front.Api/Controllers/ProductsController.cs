using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Reflection;
using System.Reflection.Emit;

namespace NextCart.Front.Api.Controllers
{
    public class ProductsController : ApiController
    {
        public dynamic Get(int? id)
        {
			dynamic q = new
			{
				This = "is",
				The = "one",
				Id = id,
			};

			return q;
        }
    }
}
