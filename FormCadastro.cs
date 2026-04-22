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
    public partial class FormCadastro : Form
    {
        private readonly AtivosRepository _repositorio;

        public FormCadastro(AtivosRepository repositorio)
        {
            InitializeComponent();
            _repositorio = repositorio;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Cadastro de Novo Equipamento";
            this.Size = new System.Drawing.Size(400, 450);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            cmbTipoEquipamento.Items.AddRange(["Notebook", "Servidor"]);
            //Mudar a ordem para que o texto já apareça no campo específico e quando for alterado ele irá mudar normalmente 
            cmbTipoEquipamento.SelectedIndexChanged += CmbTipoEquipamento_SelectedIndexChanged;
            cmbTipoEquipamento.SelectedIndex = 0;
            

            btnSalvar.Click += BtnSalvar_Click;
            btnCancelar.Click += (s, e) => this.Close();
        }

        private void CmbTipoEquipamento_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lblEspecifico.Text = cmbTipoEquipamento.SelectedItem?.ToString() == "Notebook"
                ? "Tamanho da Tela (\"):" : "Armazenamento (TB):";
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            try
            {
                string numeroSerie = txtNumeroSerie.Text;
                string marca = txtMarca.Text;
                decimal valorAquisicao = decimal.Parse(txtValorAquisicao.Text);

                Equipamento novoEquipamento;

                if (cmbTipoEquipamento.SelectedItem?.ToString() == "Notebook")
                {
                    double tela = double.Parse(txtEspecifico.Text);
                    novoEquipamento = new Notebook(numeroSerie, marca, valorAquisicao, tela);
                }
                else
                {
                    int storage = int.Parse(txtEspecifico.Text);
                    novoEquipamento = new Servidor(numeroSerie, marca, valorAquisicao, storage);
                }

                _repositorio.Adicionar(novoEquipamento);

                MessageBox.Show($"Cadastrado com sucesso!\nDepreciação projetada (3 anos): {novoEquipamento.CalcularDepreciacao(3):C}",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
