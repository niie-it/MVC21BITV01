using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manage(StudentInfo model, string savebutton)
        {
            return View();
        }

        public IActionResult ShowInfo(string type)
        {
            return View();
        }
    }
}
