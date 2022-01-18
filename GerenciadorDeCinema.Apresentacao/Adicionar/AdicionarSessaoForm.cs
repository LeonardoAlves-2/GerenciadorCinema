using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeCinema.Apresentacao.Adicionar
{
    public partial class AdicionarSessaoForm : Form
    {
        public AdicionarSessaoForm()
        {
            InitializeComponent();
        }

        private void AdicionarSessaoForm_Load(object sender, EventArgs e)
        {

        }

        private void FilmesBtn_Click(object sender, EventArgs e)
        {
            ListarFilmesForm newForm = new ListarFilmesForm();
            this.Hide();
            newForm.Show();
        }

        private void SessoesBtn_Click(object sender, EventArgs e)
        {
            ListarSessoesForm newForm = new ListarSessoesForm();
            this.Hide();
            newForm.Show();
        }

        private void SalasBtn_Click(object sender, EventArgs e)
        {
            ListarSalasForm newForm = new ListarSalasForm();
            this.Hide();
            newForm.Show();
        }
    }
}
