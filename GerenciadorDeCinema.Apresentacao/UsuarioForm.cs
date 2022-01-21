using GerenciadorDeCinema.Apresentacao.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCinema.Apresentacao
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private async void EntrarAsync()
        {
            Usuario usuario = new Usuario
            {
                Email = TBEmail.Text,
                Senha = TBSenha.Text
            };
            using (var client = new HttpClient())
            {
                var serialized = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(serialized, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("https://localhost:5001/login", content);
                if (result.IsSuccessStatusCode)
                {
                    var newForm = new ListarSalasForm();
                    this.Hide();
                    newForm.Show();
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado");
                }
            }
        }
        private void Entrar_Click(object sender, EventArgs e)
        {
            EntrarAsync();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
