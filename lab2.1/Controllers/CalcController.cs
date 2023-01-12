using lab2._1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab2._1.Controllers
{
    public class CalcServiceController : Controller
    {
        private readonly ILogger<CalcServiceController> _logger;

        public CalcServiceController(ILogger<CalcServiceController> logger)
        {
            _logger = logger;
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            CalcModel PUM = new CalcModel();
            PUM.Calculator();
            return View(PUM);
        }
        public IActionResult PassUsingViewBag()
        {
            ViewBag.PUM = new CalcModel();
            ViewBag.PUM.Calculator();
            return View();
        }
        public IActionResult PassUsingViewData()
        {
            CalcModel PUM = new CalcModel();
            PUM.Calculator();
            ViewData["PUM"] = PUM;
            return View();
        }
    }
}