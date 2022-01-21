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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        private void Principal_Load(object sender, EventArgs e)
        {

        }
        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new ListarSalasForm();
            newForm.Show();
            newForm.Focus();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new ListarFilmesForm();
            newForm.Show();
            newForm.Focus();
        }

        private void sessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new ListarSessoesForm();
            newForm.Show();
            newForm.Focus();
        }
    }
}
