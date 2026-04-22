using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAtivosTI.Models
{
    public class Notebook(string numeroSerie, string marca, decimal valorAquisicao, double tamanhoTelaPolegadas)
        : Equipamento(numeroSerie, marca, valorAquisicao)
    {
        public double TamanhoTelaPolegadas { get; set; } = tamanhoTelaPolegadas;

        public override decimal CalcularDepreciacao(int anosDeUso)
        {
            decimal taxaDepreciacaoAno = ValorAquisicao * 0.20m;
            decimal desgasteBateria = 150.00m * anosDeUso;
            decimal depreciacaoTotal = (taxaDepreciacaoAno * anosDeUso) + desgasteBateria;
            return Math.Min(depreciacaoTotal, ValorAquisicao);
        }

        public override string ObterDescricao() => $"{base.ObterDescricao()} | Tela: {TamanhoTelaPolegadas}\"";
    }
}