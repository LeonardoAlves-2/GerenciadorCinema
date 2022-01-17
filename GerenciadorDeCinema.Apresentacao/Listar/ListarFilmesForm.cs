using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCinema.Apresentacao
{
    public partial class ListarFilmesForm : Form
    {
        public ListarFilmesForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ListarFilmesForm_Load(object sender, EventArgs e)
        {

        }

        private void FilmesBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new ListarFilmesForm());
        }

        private void SalasBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new ListarFilmesForm());
        }

        private void SessoesBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new ListarSessoesForm());
        }
    }
}
