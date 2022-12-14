using CalculatorMG.Models;
using CalculatorMG.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace CalculatorMG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalculatorService _calculatorService;

        public HomeController(ILogger<HomeController> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            _calculatorService = calculatorService;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Process(Calculator calculator, string calculate)
        {
            var result = new Calculator();

            switch (calculate)
            {
                case "addition":
                    result = await _calculatorService.Addition(calculator);
                    break;

                case "subtraction":
                    result = await _calculatorService.Subtraction(calculator);
                    break;

                case "multiplication":
                    result = await _calculatorService.Multiplication(calculator);
                    break;

                case "division":
                    result = await _calculatorService.Division(calculator);
                    break;
            }
            return View("Index", result);
        }
    }
}