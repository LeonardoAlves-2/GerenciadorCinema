using GerenciadorDeCinema.Apresentacao.Adicionar;
using GerenciadorDeCinema.Apresentacao.Editar;
using GerenciadorDeCinema.Apresentacao.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        private readonly string URI = ConfigurationManager.AppSettings["myUrlFilme"];
        private async void ListarFilmesAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URI}/listar"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Titulo", typeof(string));
                        dt.Columns.Add("Descrição", typeof(string));
                        dt.Columns.Add("Duração", typeof(int));

                        var JsonString = await response.Content.ReadAsStringAsync();
                        filmes = JsonConvert.DeserializeObject<Filme[]>(JsonString).ToList();
                        foreach (Filme filme in filmes)
                            dt.Rows.Add(filme.Titulo, filme.Descricao, filme.Duracao);

                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível listar os filmes : " + response.StatusCode);
                    }
                }
            }
        }

        private void AoFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
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
                Filme filme = filmes.FirstOrDefault(c => c.Titulo.Equals(selecionada.Cells[0].Value));
                var result = MessageBox.Show("Você tem certeza que quer remover o filme?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    return;
                }

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
            else
            {
                MessageBox.Show("Selecione pelo menos uma linha para deletar");
            }
            ListarFilmesAsync();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            var selecionada = dataGridView1.CurrentRow;
            if (selecionada != null)
            {
                Filme filme = filmes.FirstOrDefault(c => c.Titulo.Equals(selecionada.Cells[0].Value));

                var newForm = new EditarFilmeForm(filme.Id);
                this.Hide();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Selecione pelo menos uma linha para editar");
            }
            ListarFilmesAsync();
        }
    }
}
