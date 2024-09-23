using Microsoft.AspNetCore.Mvc;

namespace Lab12_PH52988.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login(string userName, string passWord)
        {//  khi mới bật view lên thì userName và pass không có gì
            if (string.IsNullOrEmpty(userName)&& string.IsNullOrEmpty(passWord))
            {
                return View();

            }else 
            {
                if (userName.ToLower() == "admin" && passWord.Trim().Length > 0)
                {
                    TempData["message"] = "Bạn đã đăng nhập với userName:" + userName;//key = message, value = giá trị truyền vào
                    return RedirectToAction("Index", "Home");
                }
                else return RedirectToAction("Privacy","Home");
            
            }
            // truyền dữ liệu với teampdata/viewBag/ViewData
            // TeamData sẽ cho phép lưu tạm dữ liệu xuyên xuốt giữa 2 repuest(yêu cầu)
            //teamData hoạt động theo cơ chế key_value
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
