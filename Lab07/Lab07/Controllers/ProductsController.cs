using Lab07.Data;
using Lab07.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lab07.Controllers
{
	public class ProductsController : Controller
	{
		private readonly MvcNiieLabContext _context;

		public ProductsController(MvcNiieLabContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var data = _context.Products.Include(p => p.Category).Include(sp => sp.Supplier);
			return View(data);
		}

		#region Create Product
		[HttpGet]
		public IActionResult Create()
		{
			ViewBag.CategoryId = new SelectList(_context.Categories.ToList(), "Id", "NameVN");
			ViewBag.SupplierId = new SelectList(_context.Suppliers.ToList(), "Id", "Name");

			return View();
		}

		[HttpPost]
		public IActionResult Create(Product model)
		{
			return View();
		}
		#endregion

		[HttpGet("/Products/Filters/{mancc}")]
		public IActionResult GetProductBySuplliers(string mancc)
		{
			var data = _context.Products
				.Include(p => p.Supplier)
				.Include(p => p.Category)
				.Where(p => p.SupplierId == mancc)
				.Select(p => new ProductBySupplier
				{
					ProductId = p.Id, ProductName = p.Name, Price = p.UnitPrice,
					Category = p.Category.Name, Supplier = p.Supplier.Name
				}).ToList();
			return View(data);
		}
	}
}
