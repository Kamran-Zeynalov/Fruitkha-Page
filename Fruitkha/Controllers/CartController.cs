using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
