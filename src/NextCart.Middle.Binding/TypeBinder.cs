using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using ImpromptuInterface;

namespace NextCart.Middle.Binding
{
	public class TypeBinder
	{
		public static T GenerateProxy<T>()
			where T: class
		{
			return new QueryProxy().ActLike<T>();
		}
	}

	/// <summary>
	/// Takes an arbitrary service call and creates a query message
	/// </summary>
	public class QueryProxy : DynamicObject
	{
		string WhatHappened;

		public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
		{
			WhatHappened = String.Format("Called {0} expecting a {1} with params {2}", binder.Name, binder.ReturnType, String.Join(",", args.Select(o => o.GetType().Name)));

			// Generate the message

			// Connect to the middle and send the message

			// Await a response

			// Return the value

			result = null;
			return true;
		}
	}
}
