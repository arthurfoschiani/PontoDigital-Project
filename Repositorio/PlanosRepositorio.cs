using System.Collections.Generic;
using System.IO;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorio
{
    public class PlanosRepositorio
    {
        private const string PATH = "DataBase/Planos.csv";
        private List<PlanoModel> Planos = new List<PlanoModel>();
        public List<PlanoModel> Listar() {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros) {
                PlanoModel plano = new PlanoModel();
                plano.Nome = item;

                Planos.Add(plano);
            }
            return Planos;
        }
    }
}