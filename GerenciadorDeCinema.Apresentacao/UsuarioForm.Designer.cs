
namespace GerenciadorDeCinema.Apresentacao
{
    partial class UsuarioForm
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
            this.Entrar = new System.Windows.Forms.Button();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Entrar.Font = new System.Drawing.Font("Cascadia Code", 8.25F);
            this.Entrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Entrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Entrar.Location = new System.Drawing.Point(12, 256);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(213, 41);
            this.Entrar.TabIndex = 16;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // TBEmail
            // 
            this.TBEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBEmail.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.TBEmail.Location = new System.Drawing.Point(12, 135);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(213, 23);
            this.TBEmail.TabIndex = 17;
            // 
            // TBSenha
            // 
            this.TBSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBSenha.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.TBSenha.Location = new System.Drawing.Point(12, 211);
            this.TBSenha.Name = "TBSenha";
            this.TBSenha.Size = new System.Drawing.Size(213, 23);
            this.TBSenha.TabIndex = 18;
            this.TBSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 44);
            this.label3.TabIndex = 30;
            this.label3.Text = "Gerenciador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(21, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 44);
            this.label4.TabIndex = 31;
            this.label4.Text = "de Cinema";
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 309);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBSenha);
            this.MaximizeBox = false;
            this.Name = "UsuarioForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de cinema - Login";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}