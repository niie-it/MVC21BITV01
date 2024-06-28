using Microsoft.AspNetCore.Mvc;

namespace LabAndDemoBuoi05.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
