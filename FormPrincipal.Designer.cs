namespace GestaoAtivosTI
{
    partial class FormPrincipal
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
            dgvEquipamentos = new DataGridView();
            btnNovo = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipamentos
            // 
            dgvEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamentos.Location = new Point(12, 12);
            dgvEquipamentos.Name = "dgvEquipamentos";
            dgvEquipamentos.Size = new Size(760, 337);
            dgvEquipamentos.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 399);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(179, 50);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo Equipamento";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(593, 399);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(179, 50);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Dar Baixa (Remover)";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btnRemover);
            Controls.Add(btnNovo);
            Controls.Add(dgvEquipamentos);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)dgvEquipamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEquipamentos;
        private Button btnNovo;
        private Button btnRemover;
    }
}