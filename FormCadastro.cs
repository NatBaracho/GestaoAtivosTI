using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoAtivosTI.Models;

namespace GestaoAtivosTI
{
    // Formulário responsável pelo cadastro de equipamentos
    public partial class FormCadastro : Form
    {
        // Repositório onde os equipamentos serão armazenados
        private readonly AtivosRepository _repositorio;

        // Construtor do formulário: recebe o repositório como dependência
        public FormCadastro(AtivosRepository repositorio)
        {
            InitializeComponent(); // Inicializa os componentes visuais (botões, caixas de texto etc.)
            _repositorio = repositorio; // Guarda o repositório para uso posterior
            ConfigurarFormulario(); // Configura aparência e eventos do formulário
        }

        // Método que define a aparência e comportamento do formulário
        private void ConfigurarFormulario()
        {
            this.Text = "Cadastro de Novo Equipamento"; // Título da janela
            this.Size = new System.Drawing.Size(400, 450); // Tamanho da janela
            this.StartPosition = FormStartPosition.CenterParent; // Centraliza na tela
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Impede redimensionamento
            this.MaximizeBox = false; // Remove botão de maximizar

            // Adiciona opções ao ComboBox (Notebook e Servidor)
            cmbTipoEquipamento.Items.AddRange(["Notebook", "Servidor"]);

            // Define que o evento será disparado ao trocar a opção
            cmbTipoEquipamento.SelectedIndexChanged += CmbTipoEquipamento_SelectedIndexChanged;

            // Seleciona "Notebook" por padrão
            cmbTipoEquipamento.SelectedIndex = 0;

            // Define ações dos botões
            btnSalvar.Click += BtnSalvar_Click; // Botão salvar chama método BtnSalvar_Click
            btnCancelar.Click += (s, e) => this.Close(); // Botão cancelar fecha o formulário
        }

        // Evento disparado quando o usuário troca o tipo de equipamento
        private void CmbTipoEquipamento_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Se for Notebook, mostra "Tamanho da Tela", senão mostra "Armazenamento"
            lblEspecifico.Text = cmbTipoEquipamento.SelectedItem?.ToString() == "Notebook"
                ? "Tamanho da Tela (\"):"
                : "Armazenamento (TB):";
        }

        // Evento disparado ao clicar no botão salvar
        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            try
            {
                // Captura os valores digitados pelo usuário
                string numeroSerie = txtNumeroSerie.Text; // Número de série
                string marca = txtMarca.Text; // Marca
                decimal valorAquisicao = decimal.Parse(txtValorAquisicao.Text); // Valor de aquisição

                Equipamento novoEquipamento; // Variável para armazenar o objeto criado

                // Verifica se o tipo selecionado é Notebook
                if (cmbTipoEquipamento.SelectedItem?.ToString() == "Notebook")
                {
                    double tela = double.Parse(txtEspecifico.Text); // Tamanho da tela
                    novoEquipamento = new Notebook(numeroSerie, marca, valorAquisicao, tela);
                }
                else
                {
                    int storage = int.Parse(txtEspecifico.Text); // Armazenamento em TB
                    novoEquipamento = new Servidor(numeroSerie, marca, valorAquisicao, storage);
                }

                // Adiciona o equipamento ao repositório
                _repositorio.Adicionar(novoEquipamento);

                // Exibe mensagem de sucesso com cálculo de depreciação em 3 anos
                MessageBox.Show(
                    $"Cadastrado com sucesso!\nDepreciação projetada (3 anos): {novoEquipamento.CalcularDepreciacao(3):C}",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close(); // Fecha o formulário após salvar
            }
            catch (Exception ex)
            {
                // Caso ocorra erro, mostra mensagem para o usuário
                MessageBox.Show(
                    $"Erro: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Evento disparado quando o formulário é carregado
        private void FormCadastro_Load(object sender, EventArgs e)
        {
            // Pode ser usado para inicializar dados ao abrir o formulário
        }
    }
}
