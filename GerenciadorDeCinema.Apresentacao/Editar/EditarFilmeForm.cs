using GerenciadorDeCinema.Apresentacao.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCinema.Apresentacao.Editar
{
    public partial class EditarFilmeForm : Form
    {
        private IList<Filme> filmeEscolhido;
        public byte[] ImageBytes { get; set; }

        public EditarFilmeForm()
        {
            InitializeComponent();
            CBFilmesAsync();
        }

        private async void CBFilmesAsync()
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
            }
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

        private void EditarFilmeForm_Load(object sender, EventArgs e)
        {

        }

        private void Remover_Click(object sender, EventArgs e)
        {
            if (CBFilme.Text?.Length == 0)
            {
                MessageBox.Show("Nenhum filme para editar.");
                return;
            }
            CBFilme.Hide();
            LBFilme.Hide();
            Editar.Hide();

            button1.Visible = true;
            LBTitulo.Visible = true;
            TBTitulo.Visible = true;
            LBDescricao.Visible = true;
            rTBDescricao.Visible = true;
            LBDuracao.Visible = true;
            nUDDuracao.Visible = true;
            LBFilme.Visible = true;
            CBFilme.Visible = true;
            LBImagem.Visible = true;
            button1.Visible = true;
            Salvar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
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
                string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                Path.Text = path;
                Path.Visible = true;

                try
                {
                    Image ImagemA = Image.FromFile(openFileDialog1.FileName);

                    using (MemoryStream mStream = new MemoryStream())
                    {
                        ImagemA.Save(mStream, ImagemA.RawFormat);
                        ImageBytes = mStream.ToArray();
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
