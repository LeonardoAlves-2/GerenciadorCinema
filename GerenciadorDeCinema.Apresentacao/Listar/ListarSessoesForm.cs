using GerenciadorDeCinema.Apresentacao.Adicionar;
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
    public partial class ListarSessoesForm : Form
    {
        public ListarSessoesForm()
        {
            InitializeComponent();
            ListarFilmesESalasAsync();
            ListarSessoesAsync();
        }

        private Filme[] filmes;
        private Sala[] salas;

        private readonly string URI = "https://localhost:5001/sessao/listar";
        private async void ListarSessoesAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URI}"))
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
                        IList<Sessao> sessoes = JsonConvert.DeserializeObject<Sessao[]>(JsonString).ToList();
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
                    filmes = JsonConvert.DeserializeObject<Filme[]>(ProdutoJsonString).ToArray();
                }
                using (var response = await client.GetAsync("https://localhost:5001/sala/"))
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    salas = JsonConvert.DeserializeObject<Sala[]>(ProdutoJsonString).ToArray();
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

        private void Remover_Click(object sender, EventArgs e)
        {
            var newForm = new RemoverSessoesForm();
            this.Hide();
            newForm.Show();
        }
    }
}
