using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MySmallASPApp
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			// Specific matches
			routes.MapRoute(
				name: "Locales",
				url: "Language/{locale}/{year}",
				defaults: new { locale = "EN-US", year = DateTime.Now.Year },
				constraints: new RouteValueDictionary {
								{ "locale", "[a-z]{2}-[a-z]{2}" },
								{ "year", @"\d{4}" }
				}
			);

			// Defaults
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
