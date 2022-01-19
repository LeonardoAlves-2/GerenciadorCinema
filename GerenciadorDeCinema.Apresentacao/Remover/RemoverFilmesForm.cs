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

namespace GerenciadorDeCinema.Apresentacao.Remover
{
    public partial class RemoverFilmesForm : Form
    {
        private IList<Filme> filmeEscolhido;
        private readonly string URI = "https://localhost:5001/filme";


        public RemoverFilmesForm()
        {
            InitializeComponent();
            CBFilmesAsync();
        }

        private async void CBFilmesAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:5001/filme/listar"))
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    var objectFilmes = JsonConvert.DeserializeObject<Filme[]>(ProdutoJsonString).ToList();
                    filmeEscolhido = objectFilmes;

                    foreach (Filme filme in objectFilmes)
                    {
                        CBFilme.Items.Add(filme.Titulo);
                    }
                }
            }
        }

        private async void RemoverFilme()
        {
            if (CBFilme.Text?.Length == 0)
            {
                MessageBox.Show("Nenhum filme para deletar.");
                return;
            }

            var idFilme = filmeEscolhido.FirstOrDefault(c => c.Titulo.Equals(CBFilme.Text));
            Guid FilmeId = idFilme.Id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await
                client.DeleteAsync($"{URI}/remover/{FilmeId}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Filme removido com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao remover o filme  : " + responseMessage.StatusCode);
                }
            }
        }

        private void RemoverFilmesForm_Load(object sender, EventArgs e)
        {

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
        private void CBFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            RemoverFilme();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var newForm = new ListarFilmesForm();
            this.Hide();
            newForm.Show();
        }
    }
}
