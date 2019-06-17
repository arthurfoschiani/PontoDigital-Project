using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Ponto_Digital.Models;

namespace Ponto_Digital.Repositorio {
    public class DepoimentoRepositorio : BaseRepositorio {
        private const string SESSION_USUARIO = "_USUARIO";
        private const string PATH = "DataBase/Depoimentos.csv";
        List<DepoimentoModel> listaDeDepoimentos = new List<DepoimentoModel> ();
        List<DepoimentoModel> listaDeAprovados = new List<DepoimentoModel> ();
        public DepoimentoModel Inserir (DepoimentoModel depoimento) {
            if (File.Exists (PATH)) {
                depoimento.Id = File.ReadAllLines (PATH).Length + 1;
            } else {
                depoimento.Id = 1;
            }

            StreamWriter SW = new StreamWriter (PATH, true);
            SW.WriteLine ($"id={depoimento.Id};nome-usuario={depoimento.NomeUsuario};data={depoimento.HorarioPublicacao};depoimento={depoimento.Depoimento};status={depoimento.Status}");
            SW.Close ();
            return depoimento;
        }

        public List<DepoimentoModel> ListarDepoimentos () {

            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {
                DepoimentoModel depoimentos = ConverterEmObjeto (item);
                this.listaDeDepoimentos.Add (depoimentos);
            }
            return this.listaDeDepoimentos;
        }

        public List<DepoimentoModel> ListarAprovados () {
            foreach (var item in listaDeDepoimentos)
            {
                if (item.Status.Equals("Aprovado")) {
                    listaDeAprovados.Add(item);
                }
            }
            return listaDeAprovados;
        }

        private DepoimentoModel ConverterEmObjeto (string registro) {

            DepoimentoModel depoimento = new DepoimentoModel (
                id: int.Parse (ExtrairCampo ("id", registro)),
                nomeUsuario : ExtrairCampo ("nome-usuario", registro),
                horarioPublicacao : DateTime.Parse (ExtrairCampo ("data", registro)),
                depoimento : ExtrairCampo ("depoimento", registro),
                status : ExtrairCampo ("status", registro)
            );
            System.Console.WriteLine ($"REGISTRO:" + registro);

            return depoimento;
        }

        public DepoimentoModel ObterPor (int id) {

            foreach (var item in ObterRegistrosCSV (PATH)) {
                if (id.Equals (int.Parse(ExtrairCampo ("id", item)))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public DepoimentoModel Editar (DepoimentoModel depoimento) {
            string[] linhas = ObterRegistrosCSV (PATH);

            linhas[depoimento.Id - 1] = $"id={depoimento.Id};nome-usuario={depoimento.NomeUsuario};data={depoimento.HorarioPublicacao};depoimento={depoimento.Depoimento};status={depoimento.Status}";

        File.WriteAllLines (PATH, linhas);

        return depoimento;
    }
}
}