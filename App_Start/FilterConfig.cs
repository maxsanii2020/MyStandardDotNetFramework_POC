﻿using System.Web;
using System.Web.Mvc;

namespace MyStandardFramework_POC
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
