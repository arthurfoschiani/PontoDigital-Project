using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Models;
using Ponto_Digital.Repositorio;
using Ponto_Digital.ViewModel;

namespace Ponto_Digital.Controllers
{
    public class CadastroController : Controller
    {
        PlanosRepositorio planosRepositorio = new PlanosRepositorio();
        DepoimentoViewModel depoimentos = new DepoimentoViewModel();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_TIPO = "_TIPO";
        private const string SESSION_USUARIO = "_USUARIO";
        [HttpGet]
        public IActionResult Index()
        {
            depoimentos.Plano = planosRepositorio.Listar();
            ViewData["Controller"] = HttpContext.Session.GetString(SESSION_USUARIO);
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            ViewData["Tipo"] = HttpContext.Session.GetString(SESSION_TIPO);

            ViewData["NomeView"] = "Cadastro";
            return View(depoimentos);
        }

        [HttpPost]
        public IActionResult EfetuarCadastro (IFormCollection form) {
            string nome = form["nome"];
            string email = form["email"];
            string senha = form["senha"];
            string plano = form["plano"];
            string confirmaçãoSenha = form["confirmarsenha"];
            DateTime dataDeNascimento = DateTime.Parse(form["data-nascimento"]);

            if (nome.Contains(" ") && senha.Length >= 8 && senha.Equals(confirmaçãoSenha) && dataDeNascimento.AddYears(18) < DateTime.Now) {

                PlanoModel planos = new PlanoModel();
                planos.Nome = plano;

                UsuarioModel usuario = new UsuarioModel();
                usuario.Nome = nome;
                usuario.Email = email;
                usuario.Senha = senha;
                usuario.Plano = planos;
                usuario.DataNascimento = dataDeNascimento;

                UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
                usuarioRepositorio.Inserir(usuario);
                ViewData["mensagem"] = "Cadastro";
                return View("Sucesso");
            } else {
                return View("Error");
            }
            
        }
    }
}