using Lab07.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lab07.Controllers
{
	public class Products : Controller
	{
		private readonly MvcNiieLabContext _context;

		public Products(MvcNiieLabContext context)
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
	}
}
