using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
	public class NewsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Detail()
		{
			return View();
		}
	}
}
