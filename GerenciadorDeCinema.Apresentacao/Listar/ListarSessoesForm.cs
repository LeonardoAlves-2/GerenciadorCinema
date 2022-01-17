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
    public partial class ListarSessoesForm : Form
    {
        public ListarSessoesForm()
        {
            InitializeComponent();
        }

        private void SessoesBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new ListarSessoesForm());
        }

        private void FilmesBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new ListarFilmesForm());
        }

        private void SalasBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new ListarSalasForm());
        }
    }
}
