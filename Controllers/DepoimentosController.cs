using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Models;
using Ponto_Digital.Repositorio;
using Ponto_Digital.ViewModel;

namespace Ponto_Digital.Controllers
{
    public class DepoimentosController : Controller
    {
        DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_TIPO = "_TIPO";
        private const string SESSION_USUARIO = "_USUARIO";

        public IActionResult Comentario()
        {
            ViewData["Controller"] = HttpContext.Session.GetString(SESSION_USUARIO);
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            ViewData["Tipo"] = HttpContext.Session.GetString(SESSION_TIPO);
            ViewData["NomeView"] = "Comentar";
            return View();
        }
        public IActionResult Index()
        {
            DepoimentoViewModel depoimento = new DepoimentoViewModel();
            depoimento.Depoimentos = depoimentoRepositorio.ListarDepoimentos();
            depoimento.DepoimentosAprovados = depoimentoRepositorio.ListarAprovados();
            depoimento.DepoimentosAprovados.Reverse();
            depoimento.Depoimentos.Reverse();
            ViewData["Controller"] = HttpContext.Session.GetString(SESSION_USUARIO);
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            ViewData["Tipo"] = HttpContext.Session.GetString(SESSION_TIPO);
            ViewData["NomeView"] = "Depoimentos";
            return View(depoimento);
        }

        [HttpPost]
        public IActionResult EfetuarDepoimentos (IFormCollection form) {
            string comentario = form["depoimento"];

            DepoimentoModel depoimento = new DepoimentoModel(
                nomeUsuario: HttpContext.Session.GetString(SESSION_USUARIO),
                horarioPublicacao: DateTime.Now,
                depoimento: comentario,
                status: "Aguardando"
            );

            DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
            depoimentoRepositorio.Inserir(depoimento);
            return RedirectToAction ("Index", "Depoimentos");
        }
        
        public IActionResult Aprovar (IFormCollection form, int id) {
            DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
            DepoimentoModel ComentarioRecuperado = depoimentoRepositorio.ObterPor(id);
            if (ComentarioRecuperado != null && ComentarioRecuperado.Id.Equals(id)){
                ComentarioRecuperado.Status = "Aprovado";
            }

            depoimentoRepositorio.Editar(ComentarioRecuperado);

            return RedirectToAction ("Index", "Depoimentos");
        }

        public IActionResult Reprovar (IFormCollection form, int id) {
            DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
            DepoimentoModel ComentarioRecuperado = depoimentoRepositorio.ObterPor(id);
            if (ComentarioRecuperado.Id.Equals(id)){
                ComentarioRecuperado.Status = "Reprovado";
            }
            depoimentoRepositorio.Editar(ComentarioRecuperado);

            return RedirectToAction ("Index", "Depoimentos");
        }
    }
}