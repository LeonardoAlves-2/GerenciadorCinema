
using System.Windows.Forms;

namespace GerenciadorDeCinema.Apresentacao.Adicionar
{
    partial class AdicionarSessaoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Adicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mTBIngresso = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBAudio = new System.Windows.Forms.ComboBox();
            this.CBAnimacao = new System.Windows.Forms.ComboBox();
            this.CBFilme = new System.Windows.Forms.ComboBox();
            this.CBSala = new System.Windows.Forms.ComboBox();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.HoraInicio = new System.Windows.Forms.DateTimePicker();
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
            this.label1.TabIndex = 18;
            this.label1.Text = "Sessões";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label2.Location = new System.Drawing.Point(15, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Início";
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
            this.Cancelar.TabIndex = 22;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
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
            this.Adicionar.TabIndex = 21;
            this.Adicionar.Text = "Salvar";
            this.Adicionar.UseVisualStyleBackColor = false;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label3.Location = new System.Drawing.Point(15, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "Valor do ingresso";
            // 
            // mTBIngresso
            // 
            this.mTBIngresso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTBIngresso.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.mTBIngresso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mTBIngresso.Location = new System.Drawing.Point(24, 244);
            this.mTBIngresso.Mask = "999.00";
            this.mTBIngresso.Name = "mTBIngresso";
            this.mTBIngresso.Size = new System.Drawing.Size(248, 23);
            this.mTBIngresso.TabIndex = 25;
            this.mTBIngresso.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label4.Location = new System.Drawing.Point(15, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Filme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label5.Location = new System.Drawing.Point(297, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label6.Location = new System.Drawing.Point(244, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 28;
            this.label6.Text = "Animação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label7.Location = new System.Drawing.Point(443, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 29;
            this.label7.Text = "Áudio";
            // 
            // CBAudio
            // 
            this.CBAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAudio.FormattingEnabled = true;
            this.CBAudio.Items.AddRange(new object[] {
            "Original",
            "Dublado"});
            this.CBAudio.Location = new System.Drawing.Point(448, 175);
            this.CBAudio.Name = "CBAudio";
            this.CBAudio.Size = new System.Drawing.Size(182, 21);
            this.CBAudio.TabIndex = 31;
            // 
            // CBAnimacao
            // 
            this.CBAnimacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAnimacao.FormattingEnabled = true;
            this.CBAnimacao.Items.AddRange(new object[] {
            "2d",
            "3d"});
            this.CBAnimacao.Location = new System.Drawing.Point(249, 175);
            this.CBAnimacao.Name = "CBAnimacao";
            this.CBAnimacao.Size = new System.Drawing.Size(182, 21);
            this.CBAnimacao.TabIndex = 32;
            // 
            // CBFilme
            // 
            this.CBFilme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilme.FormattingEnabled = true;
            this.CBFilme.Location = new System.Drawing.Point(25, 118);
            this.CBFilme.Name = "CBFilme";
            this.CBFilme.Size = new System.Drawing.Size(605, 21);
            this.CBFilme.TabIndex = 34;
            // 
            // CBSala
            // 
            this.CBSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSala.FormattingEnabled = true;
            this.CBSala.Location = new System.Drawing.Point(302, 246);
            this.CBSala.Name = "CBSala";
            this.CBSala.Size = new System.Drawing.Size(328, 21);
            this.CBSala.TabIndex = 35;
            // 
            // DataInicio
            // 
            this.DataInicio.CalendarFont = new System.Drawing.Font("Cascadia Code", 10F);
            this.DataInicio.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicio.Location = new System.Drawing.Point(20, 175);
            this.DataInicio.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(107, 21);
            this.DataInicio.TabIndex = 36;
            this.DataInicio.Value = new System.DateTime(2022, 1, 19, 0, 0, 0, 0);
            // 
            // HoraInicio
            // 
            this.HoraInicio.CalendarFont = new System.Drawing.Font("Cascadia Code", 10F);
            this.HoraInicio.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.HoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraInicio.Location = new System.Drawing.Point(133, 175);
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ShowUpDown = true;
            this.HoraInicio.Size = new System.Drawing.Size(94, 21);
            this.HoraInicio.TabIndex = 37;
            this.HoraInicio.Value = new System.DateTime(2022, 1, 19, 0, 0, 0, 0);
            // 
            // AdicionarSessaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.HoraInicio);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.CBSala);
            this.Controls.Add(this.CBFilme);
            this.Controls.Add(this.CBAnimacao);
            this.Controls.Add(this.CBAudio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mTBIngresso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AdicionarSessaoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de cinema - Adicionar Sessões";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AoFormClosing);
            this.Load += new System.EventHandler(this.AdicionarSessaoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mTBIngresso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBAudio;
        private System.Windows.Forms.ComboBox CBAnimacao;
        private System.Windows.Forms.ComboBox CBFilme;
        private System.Windows.Forms.ComboBox CBSala;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.DateTimePicker HoraInicio;
    }
}