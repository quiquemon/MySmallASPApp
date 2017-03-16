using System.Collections.Generic;
using System.Web.Mvc;

namespace MySmallASPApp.Controllers
{
	public sealed class Test
	{
		public string Name { get; }
		public string Url { get; }

		private Test(string name, string url)
		{
			Name = name;
			Url = url;
		}

		public static List<Test> GetTests()
		{
			return new List<Test> {
				new Test("First Test - 1", "https://stackoverflow.com"),
				new Test("Second Test - 2", null),
				new Test("Third Test - 3", "https://stackoverflow.com"),
				new Test("Fourth Test - 4", null),
				new Test("Fifth Test - 5", "https://stackoverflow.com"),
				new Test("Sixth Test - 6", null),
				new Test("Seventh Test - 7", "https://stackoverflow.com"),
				new Test("Eighth Test - 8", null),
				new Test("Ninth Test - 9", "https://stackoverflow.com"),
				new Test("Tenth Test - 10", null),
			};
		}
	}

	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Index";
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Title = "About Us";
			ViewBag.Message = "Your application description page.";
			ViewBag.Tests = Test.GetTests();
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Title = "Contact Us!";
			ViewBag.Message = "Your contact page.";
			return View();
		}
	}
}