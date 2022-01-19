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
    public partial class AdicionarSessaoForm : Form
    {
        private readonly string URI = "https://localhost:5001/sessao";
        private IList<Filme> filmeEscolhido;
        private IList<Sala> salaEscolhida;


        public AdicionarSessaoForm()
        {
            InitializeComponent();
            CBFilmesESalasAsync();
        }

        private async void AdicionarSessaoAsync()
        {
            DateTime inicio = DataInicio.Value.AddHours(HoraInicio.Value.Hour).AddMinutes(HoraInicio.Value.Minute);
            Filme filme = filmeEscolhido.FirstOrDefault(c => c.Titulo.Equals(CBFilme.Text));
            Sala sala = salaEscolhida.FirstOrDefault(c => c.Nome.Equals(CBSala.Text));
            bool cvt = decimal.TryParse(mTBIngresso.Text, out decimal Ingresso);
            if(cvt == false)
            {
                MessageBox.Show("Valor do ingresso inválido.");
                return;
            }

            int animacao;
            if (CBAnimacao.Text.Equals("2d"))
                animacao = 2;
            else
                animacao = 3;
            int audio;
            if (CBAudio.Text.Equals("Dublado"))
                audio = 1;
            else
                audio = 2;

            Sessao sessao = new Sessao
            {
                Inicio = inicio,
                FilmeId = filme.Id,
                SalaId = sala.Id,
                ValorIngresso = Ingresso,
                Audio = audio,
                Animacao = animacao,
            };

            using (var client = new HttpClient())
            {
                var serialized = JsonConvert.SerializeObject(sessao);
                var content = new StringContent(serialized, Encoding.UTF8, "application/json");
                var result = await client.PostAsync($"{URI}/adicionar", content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sessão adicionada com sucesso.");
                }
                else
                {
                    MessageBox.Show("Não foi possível adicionar a sessão : " + result.StatusCode + "\n");
                }
            }
        }

        private async void CBFilmesESalasAsync()
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
                using (var response = await client.GetAsync("https://localhost:5001/sala/"))
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    var objectSalas = JsonConvert.DeserializeObject<Sala[]>(ProdutoJsonString).ToList();
                    salaEscolhida = objectSalas;

                    foreach (Sala sala in objectSalas)
                    {
                        CBSala.Items.Add(sala.Nome);
                    }
                }
            }
        }

        private void AdicionarSessaoForm_Load(object sender, EventArgs e)
        {

        }

        private void FilmesBtn_Click(object sender, EventArgs e)
        {
            ListarFilmesForm newForm = new ListarFilmesForm();
            this.Hide();
            newForm.Show();
        }

        private void SessoesBtn_Click(object sender, EventArgs e)
        {
            ListarSessoesForm newForm = new ListarSessoesForm();
            this.Hide();
            newForm.Show();
        }

        private void SalasBtn_Click(object sender, EventArgs e)
        {
            ListarSalasForm newForm = new ListarSalasForm();
            this.Hide();
            newForm.Show();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            AdicionarSessaoAsync();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            ListarSessoesForm newForm = new ListarSessoesForm();
            this.Hide();
            newForm.Show();
        }
    }
}
