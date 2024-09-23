using Microsoft.AspNetCore.Mvc;

namespace Lab12_PH52988.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Login()
        {
            return View();//trả về view tương ứng với tên của action
        }
        public IActionResult Register()
        {
            return View();//trả về view tương ứng với tên của action
        }
        public IActionResult GoHome()
        {
            //return RedirectToAction("Index","Home");// điều hướng tới action mà bạn cần
           
            return Redirect("/Home/index");// trỏ trực tiếp tới view mà bạn cần, nếu không có logic nào chả
        }
        
    }
}
