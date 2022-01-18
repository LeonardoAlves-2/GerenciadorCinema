using GerenciadorDeCinema.Apresentacao.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCinema.Apresentacao.Metodos
{
    public class MetodosFilme
    {
        private readonly string URI = "https://localhost:5001/filme";
        private async void ListarFilmesAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URI}/listar"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    //    dgv.DataSource = JsonConvert.DeserializeObject<Filme[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível listar os filmes : " + response.StatusCode);
                    }
                }
            }
        }

        private async void AdicionarFilmeAsync()
        {
            Filme filme = new Filme();
            filme.Titulo = "";
            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(filme);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync($"{URI}/filme/adicionar", content);
            }
        }

        private async void RemoverFilme(Guid idFilme)
        {
            Guid FilmeId = idFilme;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await
                client.DeleteAsync($"{URI}/remover/{idFilme}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Filme removido com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao removido o filme  : " + responseMessage.StatusCode);
                }
            }
        }

        private async void EditarFilme(Guid filmeId)
        {
            Filme filme = new Filme();
            filme.Id = filmeId;
            filme.Titulo = "";

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync($"{URI}/editar/{filmeId}", filme);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Filme editado");
                }
                else
                {
                    MessageBox.Show("Falha ao editar o filme : " + responseMessage.StatusCode);
                }
            }
        }
    }
}
