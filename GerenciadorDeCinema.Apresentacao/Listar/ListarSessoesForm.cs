using GerenciadorDeCinema.Apresentacao.Adicionar;
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
    public partial class ListarSessoesForm : Form
    {
        private IList<Filme> filmes;
        private IList<Sala> salas;
        private IList<Sessao> sessoes;
        public ListarSessoesForm()
        {
            InitializeComponent();
            ListarFilmesESalasAsync();
            ListarSessoesAsync();
        }


        private readonly string URI = "https://localhost:5001/sessao";
        private async void ListarSessoesAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URI}/listar"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Início", typeof(DateTime));
                        dt.Columns.Add("Final", typeof(DateTime));
                        dt.Columns.Add("Valor do ingresso", typeof(decimal));
                        dt.Columns.Add("Tipo da animação", typeof(string));
                        dt.Columns.Add("Tipo do áudio", typeof(string));
                        dt.Columns.Add("Sala", typeof(string));
                        dt.Columns.Add("Filme", typeof(string));

                        var JsonString = await response.Content.ReadAsStringAsync();
                        sessoes = JsonConvert.DeserializeObject<Sessao[]>(JsonString).ToList();
                        foreach(Sessao sessao in sessoes)
                        {
                            Sala salaEscolhida = salas.FirstOrDefault(c => c.Id.Equals(sessao.SalaId));
                            Filme filmeEscolhido = filmes.FirstOrDefault(c => c.Id.Equals(sessao.FilmeId));
                            string Audio;
                            if (sessao.Audio.Equals(1))
                                Audio = "Dublado";
                            else
                                Audio = "Original";

                            dt.Rows.Add(sessao.Inicio, sessao.Final, sessao.ValorIngresso, $"{sessao.Animacao}d", Audio, salaEscolhida.Nome, filmeEscolhido.Titulo);
                        }

                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível listar as sessões : " + response.StatusCode);
                    }
                }
            }
        }

        private async void ListarFilmesESalasAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:5001/filme/listar"))
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    filmes = JsonConvert.DeserializeObject<Filme[]>(ProdutoJsonString).ToList();
                }
                using (var response = await client.GetAsync("https://localhost:5001/sala/"))
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    salas = JsonConvert.DeserializeObject<Sala[]>(ProdutoJsonString).ToList();
                }
            }
        }

        private void ListarSessoesForm_Load(object sender, EventArgs e)
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
            var newForm = new AdicionarSessaoForm();
            this.Hide();
            newForm.Show();
        }

        private async void Remover_Click(object sender, EventArgs e)
        {
            var selecionada = dataGridView1.CurrentRow;
            if (selecionada != null)
            {
                Sessao sessao = sessoes.FirstOrDefault(c => c.Inicio.Equals(selecionada.Cells[0].Value));

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URI);
                    HttpResponseMessage responseMessage = await client.DeleteAsync($"{URI}/remover/{sessao.Id}");
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sessão removida com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao remover a sessão  : " + responseMessage.StatusCode + "\n Rever:\n" + responseMessage.Content.ReadAsStringAsync().Result);
                    }
                }
            }
        }
    }
}
