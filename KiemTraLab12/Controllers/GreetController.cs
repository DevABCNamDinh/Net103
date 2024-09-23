using Microsoft.AspNetCore.Mvc;

namespace KiemTraLab12.Controllers
{
    public class GreetController : Controller
    {
        public ActionResult ChaoTanSV(string maSV)
        {
            TempData["LoiChao"] = "Xin chào tân sinh viên " + maSV;
            return View();
        }


        public ActionResult Chao()
        {
            string loiChao = "";
            DateTime now = DateTime.Now;

            if (now.Hour >= 6 && now.Hour <= 11)
            {
                loiChao = "Chào buổi sáng!";
            }
            else if (now.Hour >= 11 && now.Hour <= 13)
            {
                loiChao = "Chào buổi trưa!";
            }
            else if (now.Hour >= 13 && now.Hour <= 18)
            {
                loiChao = "Chào buổi chiều!";
            }
            else
            {
                loiChao = "Chào buổi tối!";
            }

            ViewBag.LoiChao = loiChao;
            return View();
        }
    }
}
