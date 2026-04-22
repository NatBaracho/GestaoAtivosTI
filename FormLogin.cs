using System;
using System.Windows.Forms;

namespace GestaoAtivosTI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        //
        private void ConfigurarFormulario()
        {
            this.Text = "Login Sistema de Ativos";
            this.Size = new System.Drawing.Size(240, 260);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            btnEntrar.Click += BtnEntrar_Click;
        }

        private void BtnEntrar_Click(object? sender, EventArgs e)
        {
            // Validação hardcoded simples (sem banco de dados)
            if (txtUsuario.Text == "admin" && txtSenha.Text == "1234")
            {
                this.Hide(); // Esconde a tela de login.
                var telaPrincipal = new FormPrincipal();

                // Garante que o aplicativo feche completamente quando a tela principal for fechada
                telaPrincipal.FormClosed += (s, args) => this.Close();
                telaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro de Acesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
