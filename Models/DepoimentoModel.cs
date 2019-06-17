using System;

namespace Ponto_Digital.Models
{
    public class DepoimentoModel
    {
        public int Id {get;set;}
        public string NomeUsuario {get;set;}
        public DateTime HorarioPublicacao {get;set;}
        public string Depoimento {get;set;}
        public string Status {get;set;}

        public DepoimentoModel (string depoimento, string status) {
            this.Depoimento = depoimento;
            this.Status = status;
        }
        public DepoimentoModel (string nomeUsuario, DateTime horarioPublicacao, string depoimento, string status) {
            this.NomeUsuario = nomeUsuario;
            this.HorarioPublicacao = horarioPublicacao;
            this.Depoimento = depoimento;
            this.Status = status;
        }
        public DepoimentoModel (int id, string nomeUsuario, DateTime horarioPublicacao, string depoimento, string status) {
            this.Id = id;
            this.NomeUsuario = nomeUsuario;
            this.HorarioPublicacao = horarioPublicacao;
            this.Depoimento = depoimento;
            this.Status = status;
        }
    }
}