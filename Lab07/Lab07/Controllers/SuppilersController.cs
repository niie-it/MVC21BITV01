using Lab07.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab07.Controllers
{
	public class SuppilersController : Controller
	{
		private readonly MvcNiieLabContext _context;

		public SuppilersController(MvcNiieLabContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var data = _context.Suppliers != null ? _context.Suppliers.ToList() : new List<Supplier>();
			return View(data);

		}
	}
}
