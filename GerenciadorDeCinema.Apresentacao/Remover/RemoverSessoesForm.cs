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
    public partial class RemoverSessoesForm : Form
    {
        private IList<Sessao> sessaoEscolhida;
        private readonly string URI = "https://localhost:5001/sessao";


        public RemoverSessoesForm()
        {
            InitializeComponent();
            CBSessoesAsync();
        }

        private async void CBSessoesAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://localhost:5001/sessao/listar"))
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    var objectSessoes = JsonConvert.DeserializeObject<Sessao[]>(ProdutoJsonString).ToList();
                    sessaoEscolhida = objectSessoes;

                    foreach (Sessao sessao in objectSessoes)
                    {
                        CBSessao.Items.Add(sessao.Inicio);
                    }
                }
            }
        }

        private async void RemoverSessao()
        {
            if (CBSessao.Text?.Length == 0)
            {
                MessageBox.Show("Nenhuma sessão para deletar.");
                return;
            }

            Sessao sessao = sessaoEscolhida.FirstOrDefault(c => c.Inicio.Equals(DateTime.Parse(CBSessao.Text)));
            Guid SessaoId = sessao.Id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await
                client.DeleteAsync($"{URI}/remover/{SessaoId}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sessão removida com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao remover a sessão  : " + responseMessage.StatusCode);
                }
            }
        }

        private void RemoverSessoesForm_Load(object sender, EventArgs e)
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

        private void Adicionar_Click(object sender, EventArgs e)
        {
            RemoverSessao();
        }
    }
}
