using System.Web;
using System.Web.Mvc;

// comment 3

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
