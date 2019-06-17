using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio
    {
        List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        private const string PATH = "DataBase/Usuarios.csv";
        public UsuarioModel Inserir (UsuarioModel usuario) {
            if (File.Exists (PATH)) {
                usuario.Id = File.ReadAllLines (PATH).Length + 1;
            } else {
                usuario.Id = 1;
            }
            usuario.TipoUsuario = "Comum";

            StreamWriter SW = new StreamWriter (PATH, true);
            SW.WriteLine ($"id={usuario.Id};nome={usuario.Nome};email={usuario.Email};senha={usuario.Senha};plano={usuario.Plano.Nome};data-nascimento={usuario.DataNascimento.ToShortDateString()};tipo-usuario={usuario.TipoUsuario}");
            SW.Close();
            return usuario;
        }

        public UsuarioModel ObterPor (string email) {
            foreach (var item in ObterRegistrosCSV(PATH))
            {
                if (email.Equals (ExtrairCampo ("email", item))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        private UsuarioModel ConverterEmObjeto (string registro) {
            PlanoModel plano = new PlanoModel();

            UsuarioModel usuario = new UsuarioModel();
                usuario.Id = int.Parse(ExtrairCampo("id", registro));
                usuario.Nome = ExtrairCampo("nome", registro);
                usuario.Email = ExtrairCampo("email", registro);
                usuario.Senha = ExtrairCampo("senha", registro);
                plano.Nome = ExtrairCampo("plano", registro);
                usuario.Plano = plano;
                usuario.DataNascimento = DateTime.Parse(ExtrairCampo("data-nascimento", registro));
                usuario.TipoUsuario = ExtrairCampo("tipo-usuario", registro);
            System.Console.WriteLine($"REGISTRO:" + registro);

            return usuario;
        }

        public List<UsuarioModel> ListarUsuarios() {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {
                UsuarioModel usuario = ConverterEmObjeto (item);
                listaDeUsuarios.Add (usuario);
            }
            return listaDeUsuarios;
        }
    }
}