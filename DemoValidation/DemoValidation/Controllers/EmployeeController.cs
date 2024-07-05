using DemoValodation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoValodation.Controllers
{
	public class EmployeeController : Controller
	{
		public IActionResult RegisterMember()
		{
			return View();
		}


		public IActionResult CheckEmployeeNo(string EmployeeNo)
		{
			var existedUser = new List<string> { "admin", "hienlth", "hpt7777" };//có thể đọc từ database
			if (existedUser.Contains(EmployeeNo))
			{
				return Json($"Mã {EmployeeNo} đã có");
			}
			return Json(true);
		}

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
