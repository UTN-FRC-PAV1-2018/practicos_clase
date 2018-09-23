using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroUsuarios.GUILayer
{
    public partial class frmDetalleUsuario : Form
    {
        private string idUsuario = string.Empty;
        
        public frmDetalleUsuario(string id)
        {
            InitializeComponent();
            idUsuario = id;
        }

        private void frmDetalleUsuario_Load(object sender, EventArgs e)
        {
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL("SELECT id_perfil, n_perfil FROM Perfiles");
            GUIHelper.getGUIHelper().llenarCombo(cboPerfil, tabla, "n_perfil", "id_perfil");
            string consulta = "SELECT * FROM Usuarios WHERE id_usuario = " + idUsuario;
            DataTable usuario = BDHelper.getBDHelper().ConsultaSQL(consulta);
            txtNombre.Text = usuario.Rows[0].ItemArray[1].ToString();
            txtCorreoElectronico.Text = usuario.Rows[0].ItemArray[3].ToString();
            txtPassword.Text = usuario.Rows[0].ItemArray[2].ToString();
            txtConfirmarPassword.Text = usuario.Rows[0].ItemArray[2].ToString();
            cboPerfil.SelectedValue = usuario.Rows[0].ItemArray[4].ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
