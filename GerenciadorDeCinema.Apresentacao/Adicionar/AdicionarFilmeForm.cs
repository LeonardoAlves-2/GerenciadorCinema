using GerenciadorDeCinema.Apresentacao.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCinema.Apresentacao.Adicionar
{
    public partial class AdicionarFilmeForm : Form
    {
        private readonly string URI = ConfigurationManager.AppSettings["myUrlFilme"];

        public byte[] ImageBytes { get; set; }

        private async void AdicionarFilmeAsync()
        {
            Filme filme = new Filme
            {
                Imagem = ImageBytes,
                Titulo = TBTitulo.Text,
                Descricao = rTBDescricao.Text,
                Duracao = (int)nUDDuracao.Value
            };

            using (var client = new HttpClient())
            {
                var serialized = JsonConvert.SerializeObject(filme);
                var content = new StringContent(serialized, Encoding.UTF8, "application/json");
                var result = await client.PostAsync($"{URI}/adicionar", content);
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Filme {TBTitulo.Text} adicionado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Não foi possível adicionar o filme\n Rever:\n" + result.Content.ReadAsStringAsync().Result);
                }
            }
        }

        public AdicionarFilmeForm()
        {
            InitializeComponent();
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

        private void AdicionarFilmeForm_Load(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            AdicionarFilmeAsync();
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

        private void SalasBtn_Click(object sender, EventArgs e)
        {
            var newForm = new ListarSalasForm();
            var result = AoFormTrocar();
            if (result == true)
            {
                this.Hide();
                newForm.Show();
            }
        }

        private void FilmesBtn_Click(object sender, EventArgs e)
        {
            var newForm = new ListarFilmesForm();
            var result = AoFormTrocar();
            if (result == true)
            {
                this.Hide();
                newForm.Show();
            }
        }

        private void SessoesBtn_Click(object sender, EventArgs e)
        {
            var newForm = new ListarSessoesForm();
            var result = AoFormTrocar();
            if (result == true)
            {
                this.Hide();
                newForm.Show();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var newForm = new ListarFilmesForm();
            var result = AoFormTrocar();
            if (result == true)
            {
                this.Hide();
                newForm.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecionar Imagens";
            openFileDialog1.InitialDirectory = @"C:\Users\users\Pictures";

            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.PNG,*.TIFF)|*.BMP;*.JPG;*.PNG;";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Image ImagemA = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = ImagemA;
                    pictureBox1.Visible = true;
                    using (MemoryStream mStream = new MemoryStream())
                    {
                        ImagemA.Save(mStream, ImagemA.RawFormat);
                        ImageBytes = mStream.ToArray();
                    }
                    panel2.Visible = false;
                    label8.Visible = false;
                    label7.Visible = false;
                    label6.Visible = false;

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
