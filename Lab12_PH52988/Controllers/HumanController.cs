using Lab12_PH52988.Models.TestModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab12_PH52988.Controllers
{
    public class HumanController : Controller
    {
        public IActionResult Index()
        {
            Human hm = new Human()
            {
                CCCD = "0010001234",
                SDT = "09998999",
                Ten="Bậc Thầy C#",
                Tuoi=19              
            };
            // truyền sự liệu sang view bằng các đưa vào phương thức view
            Animal am = new Animal()
            {
                Ten = "Chó",
                SoChan = 4
            };
            //viewData hoạt động theo cơ chế key-value như TemData
            //nhưng nó chỉ tồn tại trong 1 request khác với tempdata sẽ tồn tịa giữa 2 request
            //ViewData được truyền dữ liệu từ controll sang view tương ứng
            //với tên của Action tương ứng, dồng nghĩ với việc nó chỉ dùng được trong 1 view
            ViewData["animal"] = am;
            return View(hm);
        }
    }
}
