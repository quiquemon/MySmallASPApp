using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySmallASPApp.Controllers
{
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