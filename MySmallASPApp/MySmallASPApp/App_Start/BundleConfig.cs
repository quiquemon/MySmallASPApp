using System.Web;
using System.Web.Optimization;

namespace MySmallASPApp
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Scripts/jquery-3.1.1.min.js",
				"~/Scripts/jquery.validate.min.js",
				"~/Scripts/jquery.validate.unobtrusive.min.js"
			));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
				"~/Scripts/bootstrap.min.js",
				"~/Scripts/respond.min.js"
			));

			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/bootstrap.min.css",
				"~/Content/bootstrap-theme.min.css",
				"~/Content/site.css"
			));
		}
	}
}
