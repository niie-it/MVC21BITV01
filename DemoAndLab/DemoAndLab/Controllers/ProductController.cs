using DemoAndLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoAndLab.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name="Iphone 13", Price=22909000},
            new Product { Id = 2, Name="Iphone 15", Price=2999000},
            new Product { Id = 3, Name="SS Galaxy S24", Price=2899000}
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
    }
}
