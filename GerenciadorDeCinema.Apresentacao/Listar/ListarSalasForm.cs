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
    public partial class ListarSalasForm : Form
    {
        public ListarSalasForm()
        {
            InitializeComponent();
        }

        private void SalasBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new ListarSalasForm());
        }

        private void FilmesBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new ListarFilmesForm());
        }

        private void SessoesBtn_Click(object sender, EventArgs e)
        {
            Application.Run(new ListarSessoesForm());
        }
    }
}
