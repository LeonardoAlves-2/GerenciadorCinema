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

namespace GerenciadorDeCinema.Apresentacao.Adicionar
{
    public partial class AdicionarSessaoForm : Form
    {
        private readonly string URI = ConfigurationManager.AppSettings["myUrlSessao"];
        private readonly string URIFilme = ConfigurationManager.AppSettings["myUrlFilme"];
        private readonly string URISala = ConfigurationManager.AppSettings["myUrlSala"];
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

            if (CBFilme.Text.Equals(string.Empty))
            {
                MessageBox.Show("Filme inválido.");
                return;
            }

            if (CBSala.Text.Equals(string.Empty))
            {
                MessageBox.Show("Sala inválida");
                return;
            }

            int animacao;
            if (CBAnimacao.Text.Equals(string.Empty))
            {
                MessageBox.Show("Tipo de animação inválido.");
                return;
            }
            else if (CBAnimacao.Text.Equals("2d"))
                animacao = 2;
            else
                animacao = 3;

            int audio;
            if (CBAudio.Text.Equals(string.Empty))
            {
                MessageBox.Show("Tipo de áudio inválido.");
                return;
            }
            else if (CBAudio.Text.Equals("Dublado"))
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
                    MessageBox.Show("Não foi possível adicionar a sessão \nRever:\n" + result.Content.ReadAsStringAsync().Result);
                }
            }
        }

        private async void CBFilmesESalasAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URIFilme}/listar"))
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    var objectFilmes = JsonConvert.DeserializeObject<Filme[]>(ProdutoJsonString).ToList();
                    filmeEscolhido = objectFilmes;

                    foreach (Filme filme in objectFilmes)
                    {
                        CBFilme.Items.Add(filme.Titulo);
                    }
                }
                using (var response = await client.GetAsync($"{URISala}/"))
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

        private bool AoFormTrocar()
        {
            var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return false;
            }
            return true;
        }


        private void AdicionarSessaoForm_Load(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            AdicionarSessaoAsync();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            ListarSessoesForm newForm = new ListarSessoesForm();
            var result = AoFormTrocar();
            if (result == true)
            {
                this.Hide();
                newForm.Show();
            }
        }
    }
}
