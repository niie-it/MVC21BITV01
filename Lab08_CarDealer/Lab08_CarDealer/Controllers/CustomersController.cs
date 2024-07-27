using Lab08_CarDealer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Lab08_CarDealer.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CarDealerContext _ctx;

        public CustomersController(CarDealerContext ctx)
        {
            _ctx = ctx;
        }

        #region Order by Customer - 1.3.1.1
        [HttpGet("/customers/all/ascending")]
        public IActionResult CustomerAscending()
        {
            var data = _ctx.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => !c.IsYoungDriver)
                .ToList();
            return View(data);
        }
        [HttpGet("/customers/all/descending")]
        public IActionResult CustomerDescending()
        {
            var data = _ctx.Customers
                .OrderByDescending(c => c.BirthDate)
                .ThenBy(c => !c.IsYoungDriver)
                .ToList();
            return View("CustomerAscending", data);
        }

        #endregion

        //1.3.1.2
        [HttpGet("/cars/{make}")]
        public IActionResult GetCarsByMake(string make)
        {
            if(string.IsNullOrEmpty(make))
            {
                return NotFound();
            }
            var data = _ctx.Cars
                        .Where(c => c.Make == make)
                        .OrderBy(c => c.Model)
                        .ThenByDescending(c => c.TravelledDistance) .ToList();
            return View(data);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
