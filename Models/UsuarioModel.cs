using System;

namespace Ponto_Digital.Models
{
    public class UsuarioModel
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public PlanoModel Plano {get;set;}
        public DateTime DataNascimento {get;set;}
        public string TipoUsuario {get;set;}
    }
}