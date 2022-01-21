
namespace GerenciadorDeCinema.Apresentacao
{
    partial class ListarSessoesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Remover = new System.Windows.Forms.Button();
            this.CriarNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sessões";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(618, 351);
            this.dataGridView1.TabIndex = 21;
            // 
            // Remover
            // 
            this.Remover.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Remover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Remover.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.Remover.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Remover.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Remover.Location = new System.Drawing.Point(504, 413);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(60, 25);
            this.Remover.TabIndex = 26;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = false;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // CriarNovo
            // 
            this.CriarNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CriarNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CriarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CriarNovo.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.CriarNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CriarNovo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CriarNovo.Location = new System.Drawing.Point(570, 413);
            this.CriarNovo.Name = "CriarNovo";
            this.CriarNovo.Size = new System.Drawing.Size(60, 25);
            this.CriarNovo.TabIndex = 25;
            this.CriarNovo.Text = "Nova";
            this.CriarNovo.UseVisualStyleBackColor = false;
            this.CriarNovo.Click += new System.EventHandler(this.CriarNovo_Click);
            // 
            // ListarSessoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.CriarNovo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ListarSessoesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de cinema - Sessões";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AoFormClosing);
            this.Load += new System.EventHandler(this.ListarSessoesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.Button CriarNovo;
    }
}