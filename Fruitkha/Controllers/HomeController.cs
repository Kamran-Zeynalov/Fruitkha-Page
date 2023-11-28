using Fruitkha.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fruitkha.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Notfound()
		{
			return View();
		}

	}
}