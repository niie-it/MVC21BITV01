using DemoAndLabs.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoAndLabs.Controllers
{
	public class ProductController : Controller
	{
		static List<Product> products = new List<Product>()
		{
			new Product { Id = 1, Name="Iphone 15", Price=27990, Quantity=3},
			new Product { Id = 2, Name="SS Note 24", Price=29990, Quantity=13},
			new Product { Id = 3, Name="Ipad Mini 6", Price=17990, Quantity=5},
		};

		public IActionResult Index()
		{
			return View(products);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Product product)
		{
			products.Add(product);

			return View("Index", products);
		}

		public IActionResult Delete(int id)
		{
			var product = products.SingleOrDefault(p => p.Id == id);
			if (product != null)
			{
				products.Remove(product);
			}
			return View("Index", products);
		}
	}
}
