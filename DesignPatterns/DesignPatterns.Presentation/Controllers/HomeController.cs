using DesignPatterns.Application;
using DesignPatterns.Application.AbstractFactory;
using DesignPatterns.Application.FactoryMethod;
using DesignPatterns.Presentation.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace DesignPatterns.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPatternLoader _patternLoader;

        public HomeController(IPatternLoader patternLoader)
        {
            _patternLoader = patternLoader;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pattern(string name)
        {
            var pattern = _patternLoader.GetPatterns().FirstOrDefault(p => p.GetType().Name.Equals(name, StringComparison.OrdinalIgnoreCase) );

            if (pattern == null)
                return NotFound();

            string viewName = $"/Views/Home/{pattern.GetType().Name}.cshtml";

            return View(viewName, pattern);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}