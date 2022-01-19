
namespace GerenciadorDeCinema.Apresentacao.Editar
{
    partial class EditarFilmeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilmesBtn = new System.Windows.Forms.Button();
            this.SessoesBtn = new System.Windows.Forms.Button();
            this.SalasBtn = new System.Windows.Forms.Button();
            this.CBFilme = new System.Windows.Forms.ComboBox();
            this.LBFilme = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nUDDuracao = new System.Windows.Forms.NumericUpDown();
            this.rTBDescricao = new System.Windows.Forms.RichTextBox();
            this.TBTitulo = new System.Windows.Forms.TextBox();
            this.LBImagem = new System.Windows.Forms.Label();
            this.LBDuracao = new System.Windows.Forms.Label();
            this.LBDescricao = new System.Windows.Forms.Label();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 44);
            this.label1.TabIndex = 24;
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
            this.panel1.TabIndex = 23;
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
            // CBFilme
            // 
            this.CBFilme.FormattingEnabled = true;
            this.CBFilme.Location = new System.Drawing.Point(325, 214);
            this.CBFilme.Name = "CBFilme";
            this.CBFilme.Size = new System.Drawing.Size(313, 21);
            this.CBFilme.TabIndex = 26;
            // 
            // LBFilme
            // 
            this.LBFilme.AutoSize = true;
            this.LBFilme.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold);
            this.LBFilme.Location = new System.Drawing.Point(320, 155);
            this.LBFilme.Name = "LBFilme";
            this.LBFilme.Size = new System.Drawing.Size(312, 27);
            this.LBFilme.TabIndex = 25;
            this.LBFilme.Text = "Qual filme deseja editar?";
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
            this.Cancelar.TabIndex = 28;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Editar.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.Editar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Editar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Editar.Location = new System.Drawing.Point(617, 413);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(171, 25);
            this.Editar.TabIndex = 27;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = false;
            this.Editar.Click += new System.EventHandler(this.Remover_Click);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Salvar.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.Salvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Salvar.Location = new System.Drawing.Point(617, 413);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(171, 25);
            this.Salvar.TabIndex = 29;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Visible = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.Font = new System.Drawing.Font("Century", 11F);
            this.Path.Location = new System.Drawing.Point(566, 304);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(41, 18);
            this.Path.TabIndex = 38;
            this.Path.Text = "Path";
            this.Path.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(569, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "Escolher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nUDDuracao
            // 
            this.nUDDuracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUDDuracao.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.nUDDuracao.Location = new System.Drawing.Point(569, 142);
            this.nUDDuracao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDDuracao.Name = "nUDDuracao";
            this.nUDDuracao.Size = new System.Drawing.Size(63, 23);
            this.nUDDuracao.TabIndex = 36;
            this.nUDDuracao.Visible = false;
            // 
            // rTBDescricao
            // 
            this.rTBDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTBDescricao.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.rTBDescricao.Location = new System.Drawing.Point(178, 263);
            this.rTBDescricao.Name = "rTBDescricao";
            this.rTBDescricao.Size = new System.Drawing.Size(233, 74);
            this.rTBDescricao.TabIndex = 35;
            this.rTBDescricao.Text = "";
            this.rTBDescricao.Visible = false;
            // 
            // TBTitulo
            // 
            this.TBTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTitulo.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.TBTitulo.Location = new System.Drawing.Point(178, 142);
            this.TBTitulo.MaxLength = 100;
            this.TBTitulo.Name = "TBTitulo";
            this.TBTitulo.Size = new System.Drawing.Size(174, 23);
            this.TBTitulo.TabIndex = 34;
            this.TBTitulo.Visible = false;
            // 
            // LBImagem
            // 
            this.LBImagem.AutoSize = true;
            this.LBImagem.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold);
            this.LBImagem.Location = new System.Drawing.Point(564, 225);
            this.LBImagem.Name = "LBImagem";
            this.LBImagem.Size = new System.Drawing.Size(84, 27);
            this.LBImagem.TabIndex = 33;
            this.LBImagem.Text = "Imagem";
            this.LBImagem.Visible = false;
            // 
            // LBDuracao
            // 
            this.LBDuracao.AutoSize = true;
            this.LBDuracao.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold);
            this.LBDuracao.Location = new System.Drawing.Point(564, 112);
            this.LBDuracao.Name = "LBDuracao";
            this.LBDuracao.Size = new System.Drawing.Size(96, 27);
            this.LBDuracao.TabIndex = 32;
            this.LBDuracao.Text = "Duração";
            this.LBDuracao.Visible = false;
            // 
            // LBDescricao
            // 
            this.LBDescricao.AutoSize = true;
            this.LBDescricao.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold);
            this.LBDescricao.Location = new System.Drawing.Point(173, 225);
            this.LBDescricao.Name = "LBDescricao";
            this.LBDescricao.Size = new System.Drawing.Size(120, 27);
            this.LBDescricao.TabIndex = 31;
            this.LBDescricao.Text = "Descrição";
            this.LBDescricao.Visible = false;
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold);
            this.LBTitulo.Location = new System.Drawing.Point(173, 112);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(84, 27);
            this.LBTitulo.TabIndex = 30;
            this.LBTitulo.Text = "Titulo";
            this.LBTitulo.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditarFilmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBFilme);
            this.Controls.Add(this.LBFilme);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nUDDuracao);
            this.Controls.Add(this.rTBDescricao);
            this.Controls.Add(this.TBTitulo);
            this.Controls.Add(this.LBImagem);
            this.Controls.Add(this.LBDuracao);
            this.Controls.Add(this.LBDescricao);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "EditarFilmeForm";
            this.Text = "EditarFilmeForm";
            this.Load += new System.EventHandler(this.EditarFilmeForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUDDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FilmesBtn;
        private System.Windows.Forms.Button SessoesBtn;
        private System.Windows.Forms.Button SalasBtn;
        private System.Windows.Forms.ComboBox CBFilme;
        private System.Windows.Forms.Label LBFilme;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nUDDuracao;
        private System.Windows.Forms.RichTextBox rTBDescricao;
        private System.Windows.Forms.TextBox TBTitulo;
        private System.Windows.Forms.Label LBImagem;
        private System.Windows.Forms.Label LBDuracao;
        private System.Windows.Forms.Label LBDescricao;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}