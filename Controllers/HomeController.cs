using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Models;

namespace Ponto_Digital.Controllers
{
    public class HomeController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_TIPO = "_TIPO";
        private const string SESSION_USUARIO = "_USUARIO";
        public IActionResult Index()
        {
            ViewData["Controller"] = HttpContext.Session.GetString(SESSION_USUARIO);
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            ViewData["Tipo"] = HttpContext.Session.GetString(SESSION_TIPO);
            ViewData["NomeView"] = "Home";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
    }
}
