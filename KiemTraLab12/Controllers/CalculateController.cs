using Microsoft.AspNetCore.Mvc;

namespace KiemTraLab12.Controllers
{
    public class CalculateController : Controller
    {
        // Hiển thị form để nhập 3 cạnh tam giác
        public ActionResult TamGiac()
        {
            return View();
        }

        // Xử lý khi form được submit
        [HttpPost]
        public ActionResult TamGiac(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                ViewBag.Loi = "Cạnh không âm";

                return View();
            }

            if (a+b<=c&&a+c<=b&&c+b<=a)
            {
                ViewBag.Loi = "Không phải 3 cạnh của một tam giác";

                return View();
            }
                        // Tính chu vi
            double chuVi = a + b + c;

            // Tính diện tích theo công thức Heron
            double p = chuVi / 2;
            double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Truyền kết quả ra View bằng ViewBag
            ViewBag.ChuVi = chuVi;
            ViewBag.DienTich = dienTich;

            return View();
        }
    }
}
