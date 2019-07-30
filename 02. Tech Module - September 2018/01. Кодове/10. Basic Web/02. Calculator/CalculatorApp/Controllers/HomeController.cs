using Microsoft.AspNetCore.Mvc;
using CalculatorApp.Models;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        public IActionResult Calculate(Calculator calculator)
        {
            calculator.CalculateResult();
            return RedirectToAction("Index", calculator);
        }

    }
}
