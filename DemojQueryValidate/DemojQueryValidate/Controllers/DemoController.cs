using Microsoft.AspNetCore.Mvc;

namespace DemojQueryValidate.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string CheckExistedEmail(string Email)
        {
            var dsEmail = new List<string>
            {
                "admin@admin.com", "teo@teo.co"
            };
            return dsEmail.Contains(Email) ? "true" : "false";
        }
    }
}
