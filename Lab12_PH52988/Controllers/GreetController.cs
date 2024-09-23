using Microsoft.AspNetCore.Mvc;

namespace Lab12_PH52988.Controllers
{
    public class GreetController : Controller
    {
        public IActionResult Join(string maSV)
        {
            ViewData["Message"] = "Xin chào " + maSV;
            return RedirectToAction("Index", "Home");
        }

        public IActionResult SessionDay()
        {
            string greeting;
            int hour = DateTime.Now.Hour;

            if (hour >= 6 && hour < 11)
                greeting = "Buổi sáng";
            else if (hour >= 11 && hour < 13)
                greeting = "Buổi trưa";
            else if (hour >= 13 && hour < 18)
                greeting = "Buổi chiều";
            else
                greeting = "Buổi tối";

            ViewData["Greeting"] = greeting;
            return View();
        }
    }
}
