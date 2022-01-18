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

namespace GerenciadorDeCinema.Apresentacao.Adicionar
{
    public partial class AdicionarFilmeForm : Form
    {
        private readonly string URI = "https://localhost:5001/filme";
        private async void AdicionarFilmeAsync()
        {
            Filme filme = new Filme();
            filme.Titulo = TBTitulo.Text;
            filme.Descricao = rTBDescricao.Text;
            filme.Duracao = (int)nUDDuracao.Value;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(filme);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync($"{URI}/filme/adicionar", content);
            }
        }

        public AdicionarFilmeForm()
        {
            InitializeComponent();
        }

        private void AdicionarFilmeForm_Load(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            AdicionarFilmeAsync();
        }

        private void SalasBtn_Click(object sender, EventArgs e)
        {
            var newForm = new ListarSalasForm();
            this.Hide();
            newForm.Show();
        }

        private void FilmesBtn_Click(object sender, EventArgs e)
        {
            var newForm = new ListarFilmesForm();
            this.Hide();
            newForm.Show();
        }

        private void SessoesBtn_Click(object sender, EventArgs e)
        {
            var newForm = new ListarSessoesForm();
            this.Hide();
            newForm.Show();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var newForm = new ListarFilmesForm();
            this.Hide();
            newForm.Show();
        }
    }
}
