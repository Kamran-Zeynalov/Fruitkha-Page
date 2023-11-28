using Fruitkha.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			List<Product> products = new()
			{
				new()
				{
					Name="Ciyelek",
					Image="product-img-1.jpg",
					KiloGram="Per kg",
					Price =70.00m
				},
				new()
				{
					Name="Ciyelek",
					Image="product-img-2.jpg",
					KiloGram="Per kg",
					Price =70.00m
				},
				new()
				{
					Name="Ciyelek",
					Image="product-img-3.jpg",
					KiloGram="Per kg",
					Price =70.00m
				},
				new()
				{
					Name="Ciyelek",
					Image="product-img-4.jpg",
					KiloGram="Per kg",
					Price =70.00m
				},
				new()
				{
					Name="Ciyelek",
					Image="product-img-5.jpg",
					KiloGram="Per kg",
					Price =70.00m
				},
				new()
				{
					Name="Ciyelek",
					Image="product-img-6.jpg",
					KiloGram="Per kg",
					Price =70.00m
				},
			};
			return View(products);
		}
		public IActionResult Detail()
		{
			return View();
		}

	}
}
