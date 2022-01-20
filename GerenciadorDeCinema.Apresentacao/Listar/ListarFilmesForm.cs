using GerenciadorDeCinema.Apresentacao.Adicionar;
using GerenciadorDeCinema.Apresentacao.Editar;
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
    public partial class ListarFilmesForm : Form
    {
        IList<Filme> filmes;
        public ListarFilmesForm()
        {
            InitializeComponent();
            ListarFilmesAsync();
        }

        private readonly string URI = "https://localhost:5001/filme";
        private async void ListarFilmesAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URI}/listar"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Imagem", typeof(byte[]));
                        dt.Columns.Add("Titulo", typeof(string));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Duração", typeof(int));

                        var JsonString = await response.Content.ReadAsStringAsync();
                        filmes = JsonConvert.DeserializeObject<Filme[]>(JsonString).ToList();
                        foreach (Filme filme in filmes)
                            dt.Rows.Add(filme.Imagem, filme.Titulo, filme.Descricao, filme.Duracao);

                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível listar os filmes : " + response.StatusCode);
                    }
                }
            }
        }

        private void ListarFilmesForm_Load(object sender, EventArgs e)
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

        private void CriarNovo_Click(object sender, EventArgs e)
        {
            var newForm = new AdicionarFilmeForm();
            this.Hide();
            newForm.Show();
        }

        private async void Remover_Click(object sender, EventArgs e)
        {
            var selecionada = dataGridView1.CurrentRow;
            if(selecionada != null)
            {
                Filme filme = filmes.FirstOrDefault(c => c.Titulo.Equals(selecionada.Cells[1].Value));

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URI);
                    HttpResponseMessage responseMessage = await client.DeleteAsync($"{URI}/remover/{filme.Id}");
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Filme removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao remover o filme  : " + responseMessage.StatusCode + "\n Rever:\n" + responseMessage.Content.ReadAsStringAsync().Result);
                    }
                }
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            var selecionada = dataGridView1.CurrentRow;
            if (selecionada != null)
            {
                Filme filme = filmes.FirstOrDefault(c => c.Titulo.Equals(selecionada.Cells[1].Value));

                var newForm = new EditarFilmeForm(filme.Id);
                this.Hide();
                newForm.Show();
            }
        }
    }
}
