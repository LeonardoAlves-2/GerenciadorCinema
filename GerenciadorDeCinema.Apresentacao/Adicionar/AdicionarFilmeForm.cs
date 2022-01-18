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
    public partial class AdicionarFilmeForm : Form
    {
        public AdicionarFilmeForm()
        {
            InitializeComponent();
        }

        private void AdicionarFilmeForm_Load(object sender, EventArgs e)
        {

        }

        private void FilmesBtn_Click(object sender, EventArgs e)
        {
            var newForm = new ListarFilmesForm();
            newForm.ShowDialog();
        }

        private void SalasBtn_Click(object sender, EventArgs e)
        {
            var newForm = new ListarSalasForm();
            newForm.ShowDialog();
        }

        private void SessoesBtn_Click(object sender, EventArgs e)
        {
            var newForm = new ListarSessoesForm();
            newForm.ShowDialog();
        }
    }
}
