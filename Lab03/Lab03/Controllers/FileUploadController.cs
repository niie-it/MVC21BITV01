using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
	public class FileUploadController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult UploadFile(IFormFile file)
		{
			//Lưu file vô thư mục Data của wwwroot
			var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", file.FileName);

			using (var myfile = new FileStream(fullPath, FileMode.CreateNew))
			{
				file.CopyTo(myfile);
			}

			return RedirectToAction("Index");
		}


        [HttpPost]
        public IActionResult UploadFiles(List<IFormFile> files)
        {
			foreach (var file in files)
			{
				//Lưu file vô thư mục Data của wwwroot
				var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", file.FileName);

				using (var myfile = new FileStream(fullPath, FileMode.CreateNew))
				{
					file.CopyTo(myfile);
				}
			}

            return RedirectToAction("Index");
        }
    }
}
