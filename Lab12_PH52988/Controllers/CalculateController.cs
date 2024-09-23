using Microsoft.AspNetCore.Mvc;

namespace Lab12_PH52988.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Sum(int a, int b)
        {
            int result = a + b;
            return View(result);
        }

        public IActionResult SumString(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return View(0);

            var numbers = s.Split(',').Select(int.Parse);
            int result = numbers.Sum();
            return View(result);
        }

        public IActionResult Power(int a, int b)
        {
            double result = Math.Pow(a, b);
            return View(result);
        }
    }
}
