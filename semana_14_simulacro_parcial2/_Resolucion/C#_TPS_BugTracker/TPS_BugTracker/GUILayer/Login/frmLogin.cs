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
using TPS_BugTracker.BusinessLayer.Services;

namespace TPS_BugTracker.GUILayer.Login
{
    public partial class frmLogin : Form
    {
        private frmPrincipal frmPrincipal;
        public frmLogin(frmPrincipal principal)
        {
            InitializeComponent();
            frmPrincipal = principal;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioService oUsuarioService = new UsuarioService();
            Usuario oUsuario = null/* TODO Change to default(_) if this is not a reference type */;

            // Validamos que las cajas no esten vacías
            // If String.IsNullOrEmpty(txt_password.Text) Or String.IsNullOrEmpty(txt_usuario.Text) Then
            if (txtPassword.Text == string.Empty | txtUsuario.Text == string.Empty)
                MessageBox.Show("Olvidó ingresar usuario y/o password", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                oUsuario = oUsuarioService.validarUsuario(txtUsuario.Text, txtPassword.Text);
                if (oUsuario != null)
                {
                    frmPrincipal.actualizarUsuarioLogueado(oUsuario);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrectos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Limpiamos las cajas de texto y dejamos el cursor sobre el control: txt_usuario.
                    txtPassword.Text = string.Empty;
                    txtUsuario.Text = string.Empty;
                    txtUsuario.Focus();
                }
            }
        }
    }
}
