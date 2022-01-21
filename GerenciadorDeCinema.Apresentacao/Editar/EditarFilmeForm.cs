﻿using GerenciadorDeCinema.Apresentacao.Entidades;
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

namespace GerenciadorDeCinema.Apresentacao.Editar
{
    public partial class EditarFilmeForm : Form
    {
        private readonly string URI = ConfigurationManager.AppSettings["myUrlFilme"];
        public byte[] ImageBytes { get; set; }
        private readonly Guid _filmeId;

        public EditarFilmeForm(Guid filmeId)
        {
            _filmeId = filmeId;
            CarregarFilme();
            InitializeComponent();
        }

        private async void CarregarFilme()
        {
            Filme _filme;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"{URI}/listar"))
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    IList <Filme> filmes = JsonConvert.DeserializeObject<Filme[]>(ProdutoJsonString).ToList();
                    _filme = filmes.FirstOrDefault(c => c.Id.Equals(_filmeId));
                }
            }
            TBTitulo.Text = _filme.Titulo;
            rTBDescricao.Text = _filme.Descricao;
            nUDDuracao.Value = _filme.Duracao;
            ImageBytes = _filme.Imagem;
        }

        private async void EditarFilme()
        {
            var filmeId = _filmeId;
            Filme filme = new Filme
            {
                Imagem = ImageBytes,
                Titulo = TBTitulo.Text,
                Descricao = rTBDescricao.Text,
                Duracao = (int)nUDDuracao.Value
            };

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync($"{URI}/editar/{_filmeId}", filme);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Filme editado");
                }
                else
                {
                    MessageBox.Show("Falha ao editar o filme : " + responseMessage.StatusCode + "\n Rever:\n" + responseMessage.Content.ReadAsStringAsync().Result);
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
        private void EditarFilmeForm_Load(object sender, EventArgs e)
        {

        }

        private void Remover_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            EditarFilme();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var newForm = new ListarFilmesForm();
            this.Hide();
            newForm.Show();
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
