using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestaoAtivosTI.Models
{
    public class AtivosRepository
    {
        // Garante que o arquivo seja salvo exatamente na mesma pasta onde o executável da aplicação está rodando
        private readonly string _caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados_ativos_ti.json");
        private List<Equipamento> _equipamentos;
        private readonly JsonSerializerOptions _jsonOptions;

        public AtivosRepository()
        {
            _jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            _equipamentos = CarregarDoDisco();
        }

        public void Adicionar(Equipamento equipamento)
        {
            _equipamentos.Add(equipamento);
            SalvarNoDisco();
        }

        public void Remover(Guid id)
        {
            var equipamento = _equipamentos.FirstOrDefault(e => e.Id == id);
            if (equipamento != null)
            {
                _equipamentos.Remove(equipamento);
                SalvarNoDisco();
            }
        }

        public IEnumerable<Equipamento> ObterTodos() => _equipamentos.AsReadOnly();

        private void SalvarNoDisco()
        {
            string json = JsonSerializer.Serialize(_equipamentos, _jsonOptions);
            File.WriteAllText(_caminhoArquivo, json);
        }

        private List<Equipamento> CarregarDoDisco()
        {
            // Cria o arquivo fisicamente no momento em que o sistema roda pela primeira vez
            if (!File.Exists(_caminhoArquivo))
            {
                File.WriteAllText(_caminhoArquivo, "[]");
                return [];
            }
            string json = File.ReadAllText(_caminhoArquivo);
            if (string.IsNullOrWhiteSpace(json)) return [];
            return JsonSerializer.Deserialize<List<Equipamento>>(json, _jsonOptions) ?? [];
        }
    }
}