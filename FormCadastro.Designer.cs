namespace GestaoAtivosTI
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbTipoEquipamento = new ComboBox();
            txtNumeroSerie = new TextBox();
            txtMarca = new TextBox();
            txtValorAquisicao = new TextBox();
            txtEspecifico = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblEspecifico = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cmbTipoEquipamento
            // 
            cmbTipoEquipamento.FormattingEnabled = true;
            cmbTipoEquipamento.Location = new Point(23, 32);
            cmbTipoEquipamento.Name = "cmbTipoEquipamento";
            cmbTipoEquipamento.Size = new Size(153, 23);
            cmbTipoEquipamento.TabIndex = 0;
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.Location = new Point(23, 125);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(153, 23);
            txtNumeroSerie.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(204, 125);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(144, 23);
            txtMarca.TabIndex = 2;
            // 
            // txtValorAquisicao
            // 
            txtValorAquisicao.Location = new Point(28, 245);
            txtValorAquisicao.Name = "txtValorAquisicao";
            txtValorAquisicao.Size = new Size(148, 23);
            txtValorAquisicao.TabIndex = 3;
            // 
            // txtEspecifico
            // 
            txtEspecifico.Location = new Point(204, 245);
            txtEspecifico.Name = "txtEspecifico";
            txtEspecifico.Size = new Size(144, 23);
            txtEspecifico.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 107);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 6;
            label2.Text = "Numero de Série";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 107);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 227);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor da Aquisição";
            // 
            // lblEspecifico
            // 
            lblEspecifico.AutoSize = true;
            lblEspecifico.Location = new Point(204, 227);
            lblEspecifico.Name = "lblEspecifico";
            lblEspecifico.Size = new Size(0, 15);
            lblEspecifico.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(28, 330);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(104, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(244, 330);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 411);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblEspecifico);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEspecifico);
            Controls.Add(txtValorAquisicao);
            Controls.Add(txtMarca);
            Controls.Add(txtNumeroSerie);
            Controls.Add(cmbTipoEquipamento);
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoEquipamento;
        private TextBox txtNumeroSerie;
        private TextBox txtMarca;
        private TextBox txtValorAquisicao;
        private TextBox txtEspecifico;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblEspecifico;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}