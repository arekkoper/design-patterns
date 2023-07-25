using DesignPatterns.Application;
using DesignPatterns.Application.AbstractFactory;
using DesignPatterns.Application.FactoryMethod;
using DesignPatterns.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DesignPatterns.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly Dictionary<string, IPattern> _patterns = new();

        public HomeController()
        {
            _patterns.Add("FactoryMethod", new FactoryMethodPattern());
            _patterns.Add("AbstractFactory", new AbstractFactoryPattern());
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FactoryMethod()
        {
            var pattern = _patterns["FactoryMethod"];

            return View(pattern);
        }

        public IActionResult AbstractFactory()
        {
            var pattern = _patterns["AbstractFactory"];

            return View(pattern);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}