using DemoValodation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoValodation.Controllers
{
	public class EmployeeController : Controller
	{
		public IActionResult Demo()
		{
			return View();
		}

		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(Employee emp)
		{
			if (ModelState.IsValid)
			{
				//save/process...
			}
			return View();
		}

		[HttpPost]
		public IActionResult Demo(EmployeeInfo emp)
		{
			if (ModelState.IsValid)
			{
				ModelState.AddModelError("message", "Hết lỗi rồi");
			}
			return View();
		}
	}
}
