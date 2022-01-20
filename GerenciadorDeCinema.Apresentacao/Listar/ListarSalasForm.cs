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
    public partial class ListarSalasForm : Form
    {
        private readonly string URI = "https://localhost:5001/sala";
        private async void ListarSalasAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URI}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("Quantidade de assentos", typeof(int));

                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        IList<Sala> salas = JsonConvert.DeserializeObject<Sala[]>(ProdutoJsonString).ToList();
                        foreach (Sala sala in salas)
                            dt.Rows.Add(new object[] { sala.Nome, sala.QuantidadeDeAssentos });

                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível listar as salas : " + response.StatusCode);
                    }
                }
            }
        }

        public ListarSalasForm()
        {
            InitializeComponent();
            ListarSalasAsync();
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

        private void ListarSalasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
