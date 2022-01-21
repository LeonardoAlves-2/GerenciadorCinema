
namespace GerenciadorDeCinema.Apresentacao.Adicionar
{
    partial class AdicionarFilmeForm
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
            this.Adicionar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBTitulo = new System.Windows.Forms.TextBox();
            this.rTBDescricao = new System.Windows.Forms.RichTextBox();
            this.nUDDuracao = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDuracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filmes";
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Adicionar.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.Adicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Adicionar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Adicionar.Location = new System.Drawing.Point(570, 413);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(60, 25);
            this.Adicionar.TabIndex = 15;
            this.Adicionar.Text = "Salvar";
            this.Adicionar.UseVisualStyleBackColor = false;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelar.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancelar.Location = new System.Drawing.Point(504, 413);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(60, 25);
            this.Cancelar.TabIndex = 16;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label3.Location = new System.Drawing.Point(15, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label4.Location = new System.Drawing.Point(406, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Duração";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label5.Location = new System.Drawing.Point(499, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "Imagem";
            // 
            // TBTitulo
            // 
            this.TBTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTitulo.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.TBTitulo.Location = new System.Drawing.Point(20, 142);
            this.TBTitulo.MaxLength = 100;
            this.TBTitulo.Name = "TBTitulo";
            this.TBTitulo.Size = new System.Drawing.Size(385, 23);
            this.TBTitulo.TabIndex = 21;
            // 
            // rTBDescricao
            // 
            this.rTBDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTBDescricao.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.rTBDescricao.Location = new System.Drawing.Point(20, 220);
            this.rTBDescricao.Name = "rTBDescricao";
            this.rTBDescricao.Size = new System.Drawing.Size(473, 137);
            this.rTBDescricao.TabIndex = 22;
            this.rTBDescricao.Text = "";
            // 
            // nUDDuracao
            // 
            this.nUDDuracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUDDuracao.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.nUDDuracao.Location = new System.Drawing.Point(411, 142);
            this.nUDDuracao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDDuracao.Name = "nUDDuracao";
            this.nUDDuracao.Size = new System.Drawing.Size(82, 23);
            this.nUDDuracao.TabIndex = 23;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Apenas imagens (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp;" +
    " *.png\"";
            this.openFileDialog1.InitialDirectory = "c://Desktop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(503, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(504, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 215);
            this.panel2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label8.Location = new System.Drawing.Point(29, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "a imagem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label7.Location = new System.Drawing.Point(1, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "para selecionar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.label6.Location = new System.Drawing.Point(14, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Clique aqui";
            // 
            // AdicionarFilmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nUDDuracao);
            this.Controls.Add(this.rTBDescricao);
            this.Controls.Add(this.TBTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AdicionarFilmeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de cinema - Adicionar Filmes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AoFormClosing);
            this.Load += new System.EventHandler(this.AdicionarFilmeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDDuracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBTitulo;
        private System.Windows.Forms.RichTextBox rTBDescricao;
        private System.Windows.Forms.NumericUpDown nUDDuracao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}