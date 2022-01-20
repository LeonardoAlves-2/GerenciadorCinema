using GerenciadorDeCinema.Apresentacao.Adicionar;
using GerenciadorDeCinema.Apresentacao.Editar;
using GerenciadorDeCinema.Apresentacao.Entidades;
using GerenciadorDeCinema.Apresentacao.Remover;
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
        public ListarFilmesForm()
        {
            InitializeComponent();
            ListarFilmesAsync();
        }

        private readonly string URI = "https://localhost:5001/filme/listar";
        private async void ListarFilmesAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URI}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Imagem", typeof(byte[]));
                        dt.Columns.Add("Titulo", typeof(string));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Duração", typeof(int));

                        var JsonString = await response.Content.ReadAsStringAsync();
                        IList<Filme> filmes = JsonConvert.DeserializeObject<Filme[]>(JsonString).ToList();
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

        private void Remover_Click(object sender, EventArgs e)
        {
            var newForm = new RemoverFilmesForm();
            this.Hide();
            newForm.Show();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            var newForm = new EditarFilmeForm();
            this.Hide();
            newForm.Show();
        }
    }
}
