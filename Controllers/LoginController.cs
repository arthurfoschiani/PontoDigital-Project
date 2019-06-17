using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Models;
using Ponto_Digital.Repositorio;

namespace Ponto_Digital.Controllers
{
    public class LoginController : Controller
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_TIPO = "_TIPO";
        private const string SESSION_USUARIO = "_USUARIO";
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Login";
            return View();
        }

        [HttpPost]
        public IActionResult EfetuarLogin(IFormCollection form) {
            var email = form["email"];
            var senha = form["senha"];

            UsuarioModel usuario = usuarioRepositorio.ObterPor(email);

            if (usuario != null && usuario.Email.Equals(email) && usuario.Senha.Equals(senha))
            {
                HttpContext.Session.SetString(SESSION_EMAIL, email);
                HttpContext.Session.SetString(SESSION_USUARIO, usuario.Nome);
                ViewData["Controller"] = HttpContext.Session.GetString(SESSION_USUARIO);
                ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
                ViewData["Tipo"] = HttpContext.Session.GetString(SESSION_TIPO);

                if (usuario.TipoUsuario.Equals("Administrador")){
                    HttpContext.Session.SetString (SESSION_TIPO, "Administrador");
                    return RedirectToAction("Index", "DashBoard");
                } else if (usuario.TipoUsuario.Equals("Comum")) {
                    ViewData["mensagem"] = "Login";
                    return RedirectToAction("Comentario", "Depoimentos");
                }
            }
            return View("Erro");
        }
        public IActionResult EfetuarLogout() {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_USUARIO);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}