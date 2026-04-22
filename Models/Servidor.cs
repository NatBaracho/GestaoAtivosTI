using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAtivosTI.Models
{
    public class Servidor(string numeroSerie, string marca, decimal valorAquisicao, int capacidadeArmazenamentoTB)
        : Equipamento(numeroSerie, marca, valorAquisicao)
    {
        public int CapacidadeArmazenamentoTB { get; set; } = capacidadeArmazenamentoTB;

        public override decimal CalcularDepreciacao(int anosDeUso)
        {
            decimal taxaDepreciacaoAno = ValorAquisicao * 0.15m;
            decimal custoManutencaoDisco = (50.00m * CapacidadeArmazenamentoTB) * anosDeUso;
            decimal depreciacaoTotal = (taxaDepreciacaoAno * anosDeUso) + custoManutencaoDisco;
            return Math.Min(depreciacaoTotal, ValorAquisicao);
        }

        public override string ObterDescricao() => $"{base.ObterDescricao()} | Discos: {CapacidadeArmazenamentoTB} TB";
    }
}