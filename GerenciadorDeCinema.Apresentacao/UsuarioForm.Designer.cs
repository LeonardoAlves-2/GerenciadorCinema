
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioForm));
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SenhaLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            resources.ApplyResources(this.EmailLabel, "EmailLabel");
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EmailLabel.Name = "EmailLabel";
            // 
            // SenhaLabel
            // 
            resources.ApplyResources(this.SenhaLabel, "SenhaLabel");
            this.SenhaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SenhaLabel.Name = "SenhaLabel";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.EmailTextBox, "EmailTextBox");
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTextBox.Name = "EmailTextBox";
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Entrar, "Entrar");
            this.Entrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Entrar.Name = "Entrar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // UsuarioForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SenhaLabel);
            this.Controls.Add(this.EmailLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UsuarioForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label SenhaLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.TextBox textBox1;
    }
}