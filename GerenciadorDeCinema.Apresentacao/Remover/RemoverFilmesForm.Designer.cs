
namespace GerenciadorDeCinema.Apresentacao.Remover
{
    partial class RemoverFilmesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilmesBtn = new System.Windows.Forms.Button();
            this.SessoesBtn = new System.Windows.Forms.Button();
            this.SalasBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Adicionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filmes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(182, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Qual filme deseja remover?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(213, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelar.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancelar.Location = new System.Drawing.Point(371, 413);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(171, 25);
            this.Cancelar.TabIndex = 26;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Adicionar.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.Adicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Adicionar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Adicionar.Location = new System.Drawing.Point(617, 413);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(171, 25);
            this.Adicionar.TabIndex = 25;
            this.Adicionar.Text = "Remover";
            this.Adicionar.UseVisualStyleBackColor = false;
            // 
            // RemoverFilmesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RemoverFilmesForm";
            this.Text = "RemoverFilmesForm";
            this.Load += new System.EventHandler(this.RemoverFilmesForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FilmesBtn;
        private System.Windows.Forms.Button SessoesBtn;
        private System.Windows.Forms.Button SalasBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Adicionar;
    }
}