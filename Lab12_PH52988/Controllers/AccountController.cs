using Microsoft.AspNetCore.Mvc;

namespace Lab12_PH52988.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
