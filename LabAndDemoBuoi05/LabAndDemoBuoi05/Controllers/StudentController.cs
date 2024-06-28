using LabAndDemoBuoi05.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabAndDemoBuoi05.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "student.json");
		public IActionResult Manage(Student model, string Save = "Save Text file")
		{
			if (Save == "Save Json file")
			{
				string jsonStr = System.Text.Json.JsonSerializer.Serialize(model);
				System.IO.File.WriteAllText(jsonPath, jsonStr);
			}

			return View("Index", model);//url vẫn là /Student/Manage
										//return RedirectToAction("Index");//url /Student
		}

		public IActionResult ReadFromFile(string filetype = "TXT")
		{
			if (filetype == "JSON")
			{
				var fileContent = System.IO.File.ReadAllText(jsonPath);
				Student model = System.Text.Json.JsonSerializer.Deserialize<Student>(fileContent) ?? new Student();

				return View("Index", model);//url vẫn là /Student/ReadFromFile
			}
			return NotFound();
		}
	}
}
