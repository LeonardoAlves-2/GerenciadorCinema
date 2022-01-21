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
    public partial class ListarSalasForm : Form
    {
        private readonly string URI = ConfigurationManager.AppSettings["myURLSala"];
        private async void ListarSalasAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URI}/"))
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
                        MessageBox.Show("Não foi possível listar as salas");
                    }
                }
            }
        }

        public ListarSalasForm()
        {
            InitializeComponent();
            ListarSalasAsync();
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

        private void ListarSalasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
