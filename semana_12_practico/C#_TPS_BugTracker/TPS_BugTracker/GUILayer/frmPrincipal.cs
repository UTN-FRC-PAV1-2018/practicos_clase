using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPS_BugTracker.BusinessLayer;
using TPS_BugTracker.BusinessLayer.Entities;
using TPS_BugTracker.GUILayer;
using TPS_BugTracker.GUILayer.Bugs;
using TPS_BugTracker.GUILayer.Login;
using TPS_BugTracker.GUILayer.Usuarios;

namespace TPS_BugTracker
{
    public partial class frmPrincipal : Form
    {
        private static Usuario userLogin = null/* TODO Change to default(_) if this is not a reference type */;

        public frmPrincipal()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(this);
            login.ShowDialog();
        }


        public void actualizarUsuarioLogueado(Usuario user)
        {
            toolStripStatusLabel1.Text = "Usuario: " + user.nombre + " | Perfil: " + user.perfil;
            // Asignamos en userLogin el usuario recibido desde el login y lo dejamos como atributo del formulario principal
            // Podemos simular una sesión de usuario y a partir de este momento desde cualquier ventana podemos obtener
            // el usuario logueado mendiante el método obtenerUsuarioLogin de esta clase.
            userLogin = user;
            Mnu_principal.Visible = true;
        }

        private void ConsultaDeBugsToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            frmBugs Bugs = new frmBugs();
            Bugs.ShowDialog();
        }

        private void SalirToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void UsuariosToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        public static Usuario obtenerUsuarioLogin()
        {
            return userLogin;
        }


        
    }
}
