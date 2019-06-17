using System.Collections.Generic;
using Ponto_Digital.Models;

namespace Ponto_Digital.ViewModel
{
    public class DepoimentoViewModel
    {
        public List<DepoimentoModel> Depoimentos {get;set;}
        public List<DepoimentoModel> DepoimentosAprovados {get;set;}
        public List<UsuarioModel> Usuarios {get;set;}
        public List<PlanoModel> Plano {get;set;}

        public List<DepoimentoModel> UltimosDepoimentos {get;set;}
        public List<UsuarioModel> UltimosUsuarios {get;set;}
        public int NumUsuarios {get;set;}
        public int NumDepoimentos {get;set;}
        public int NumDepoimentosAprovados {get;set;}
        public int NumDepoimentosReprovados {get;set;}
    }
}