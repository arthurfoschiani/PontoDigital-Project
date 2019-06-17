using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital.Models;
using Ponto_Digital.Repositorio;
using Ponto_Digital.ViewModel;

namespace Ponto_Digital.Controllers
{
    public class DashBoardController : Controller
    {
        DepoimentoViewModel infos = new DepoimentoViewModel();
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_TIPO = "_TIPO";
        private const string SESSION_USUARIO = "_USUARIO";
        List<DepoimentoModel> depoimentos = new List<DepoimentoModel>();
        List<DepoimentoModel> aprovados = new List<DepoimentoModel>();
        List<DepoimentoModel> rejeitados = new List<DepoimentoModel>();
        List<UsuarioModel> usuarios = new List<UsuarioModel>();
        List<DepoimentoModel> UltimosComentarios = new List<DepoimentoModel>();
        List<UsuarioModel> UltimosUsuarios = new List<UsuarioModel>();
        public IActionResult Index() {
            usuarios = usuarioRepositorio.ListarUsuarios();
            depoimentos = depoimentoRepositorio.ListarDepoimentos();
            depoimentos.Reverse();
            usuarios.Reverse();
            int contador = 0;

            foreach (var item in depoimentos) {
                if(item.Status.Equals("Aprovado")) {
                    aprovados.Add(item);
                } else if (item.Status.Equals("Reprovado")) {
                    rejeitados.Add(item);
                }

                if (contador < 10) {
                    UltimosComentarios.Add(item);
                    contador ++;
                }
            }

            contador = 0;
            foreach (var item in usuarios)
            {
                if (contador < 10) {
                    UltimosUsuarios.Add(item);
                    contador ++;
                }
            }

            ViewData["Controller"] = HttpContext.Session.GetString(SESSION_USUARIO);
            ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            ViewData["Tipo"] = HttpContext.Session.GetString(SESSION_TIPO);

            infos.NumDepoimentosAprovados = aprovados.Count;
            infos.NumDepoimentosReprovados = rejeitados.Count;
            infos.NumUsuarios = usuarios.Count;
            infos.NumDepoimentos = depoimentos.Count;

            infos.UltimosDepoimentos = UltimosComentarios;
            infos.UltimosUsuarios = UltimosUsuarios;


            ViewData["NomeView"] = "DashBoard";
            return View(infos);
        }
    }
}