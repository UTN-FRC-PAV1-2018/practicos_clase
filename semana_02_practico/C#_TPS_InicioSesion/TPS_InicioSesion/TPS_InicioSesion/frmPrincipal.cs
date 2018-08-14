using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPS_InicioSesion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Credenciales Hardcodeadas!!
        public string usuario = "test";
        public string password = "test";

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        public bool ValidarCredenciales(string pUsuario, string pPassword)
        {
            if (pUsuario == usuario & pPassword == password)
                return true;
            else
                return false;
        }

    }
}
