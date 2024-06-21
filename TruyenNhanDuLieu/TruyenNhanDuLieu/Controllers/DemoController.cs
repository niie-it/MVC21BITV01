using Microsoft.AspNetCore.Mvc;

namespace TruyenNhanDuLieu.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult NhapThongTin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KetQua(string HoTen, int NamSinh)
        {
            //Gửi dữ liệu qua View để hiển thị
            ViewBag.HoTen = HoTen;
            ViewBag.NamSinh = NamSinh;

            return View();
        }
    }
}
