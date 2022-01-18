
namespace GerenciadorDeCinema.Apresentacao
{
    partial class ListarFilmesForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilmesBtn = new System.Windows.Forms.Button();
            this.SessoesBtn = new System.Windows.Forms.Button();
            this.SalasBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(216, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filmes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.FilmesBtn);
            this.panel1.Controls.Add(this.SessoesBtn);
            this.panel1.Controls.Add(this.SalasBtn);
            this.panel1.Location = new System.Drawing.Point(-3, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 532);
            this.panel1.TabIndex = 21;
            // 
            // FilmesBtn
            // 
            this.FilmesBtn.BackColor = System.Drawing.SystemColors.Window;
            this.FilmesBtn.FlatAppearance.BorderSize = 0;
            this.FilmesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FilmesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilmesBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmesBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FilmesBtn.Location = new System.Drawing.Point(3, 221);
            this.FilmesBtn.Name = "FilmesBtn";
            this.FilmesBtn.Size = new System.Drawing.Size(164, 53);
            this.FilmesBtn.TabIndex = 19;
            this.FilmesBtn.Text = "Filmes";
            this.FilmesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilmesBtn.UseVisualStyleBackColor = false;
            this.FilmesBtn.Click += new System.EventHandler(this.FilmesBtn_Click);
            // 
            // SessoesBtn
            // 
            this.SessoesBtn.BackColor = System.Drawing.SystemColors.Window;
            this.SessoesBtn.FlatAppearance.BorderSize = 0;
            this.SessoesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SessoesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessoesBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessoesBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SessoesBtn.Location = new System.Drawing.Point(3, 280);
            this.SessoesBtn.Name = "SessoesBtn";
            this.SessoesBtn.Size = new System.Drawing.Size(164, 53);
            this.SessoesBtn.TabIndex = 4;
            this.SessoesBtn.Text = "Sessões";
            this.SessoesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SessoesBtn.UseVisualStyleBackColor = false;
            this.SessoesBtn.Click += new System.EventHandler(this.SessoesBtn_Click);
            // 
            // SalasBtn
            // 
            this.SalasBtn.BackColor = System.Drawing.SystemColors.Window;
            this.SalasBtn.FlatAppearance.BorderSize = 0;
            this.SalasBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SalasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalasBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SalasBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalasBtn.Location = new System.Drawing.Point(3, 162);
            this.SalasBtn.Name = "SalasBtn";
            this.SalasBtn.Size = new System.Drawing.Size(164, 53);
            this.SalasBtn.TabIndex = 15;
            this.SalasBtn.Text = "Salas";
            this.SalasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalasBtn.UseVisualStyleBackColor = false;
            this.SalasBtn.Click += new System.EventHandler(this.SalasBtn_Click);
            // 
            // ListarFilmesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.Name = "ListarFilmesForm";
            this.ShowIcon = false;
            this.Text = "Filmes";
            this.Load += new System.EventHandler(this.ListarFilmesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FilmesBtn;
        private System.Windows.Forms.Button SessoesBtn;
        private System.Windows.Forms.Button SalasBtn;
    }
}