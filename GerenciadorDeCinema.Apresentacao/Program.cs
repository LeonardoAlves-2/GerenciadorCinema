using GerenciadorDeCinema.Apresentacao.Adicionar;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Configuration;

namespace GerenciadorDeCinema.Apresentacao
{
    public static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var MyUrl = ConfigurationManager.AppSettings["myURL"];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm: new UsuarioForm());
        }
    }
}
