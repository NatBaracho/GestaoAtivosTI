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
    public partial class FormPrincipal : Form
    {
        private AtivosRepository _repositorio;
        private BindingSource _bindingSource;

        public FormPrincipal()
        {
            InitializeComponent();
            _repositorio = new AtivosRepository();
            _bindingSource = new BindingSource();
            ConfigurarFormulario();
            CarregarDados();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Dashboard Principal Ativos de TI";
            this.Size = new System.Drawing.Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            btnNovo.Click += BtnNovo_Click;
            btnRemover.Click += BtnRemover_Click;

            dgvEquipamentos.DataSource = _bindingSource;
            dgvEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipamentos.ReadOnly = true;
        }

        private void CarregarDados()
        {
            var equipamentos = _repositorio.ObterTodos();
            _bindingSource.DataSource = equipamentos.ToList();
            _bindingSource.ResetBindings(false);
        }

        private void BtnNovo_Click(object? sender, EventArgs e)
        {
            using (var telaCadastro = new FormCadastro(_repositorio))
            {
                telaCadastro.ShowDialog(); // Trava esta tela até o cadastro fechar
            }
            CarregarDados();
        }

        private void BtnRemover_Click(object? sender, EventArgs e)
        {
            if (dgvEquipamentos.CurrentRow?.DataBoundItem is Equipamento equipamentoSelecionado)
            {
                var confirmacao = MessageBox.Show($"Deseja realmente remover {equipamentoSelecionado.NumeroSerie}?",
                                                  "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.Yes)
                {
                    _repositorio.Remover(equipamentoSelecionado.Id);
                    CarregarDados();
                }
            }
            else
            {
                MessageBox.Show("Selecione um equipamento na grade para remover.");
            }
        }
    }
}
