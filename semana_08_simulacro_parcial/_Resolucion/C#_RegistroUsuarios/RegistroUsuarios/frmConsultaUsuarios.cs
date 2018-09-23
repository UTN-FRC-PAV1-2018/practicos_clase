using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RegistroUsuarios.GUILayer
{
    public partial class frmConsultaUsuarios : Form
    {
        string idUsuarioSeleccionado = string.Empty;
        public frmConsultaUsuarios()
        {
            InitializeComponent();
            btnDetalleUsuario.Enabled = false;
        }

        private void frmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            // Se creo un nuevo GUIHelper para definir logica de capa de presentación.
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL("SELECT n_perfil, id_perfil FROM Perfiles");
            GUIHelper.getGUIHelper().llenarCombo(cboPerfiles, tabla, "n_perfil", "id_perfil");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT id_usuario, nombre_usuario,correo_electronico," +
                              "       (select n_perfil from Perfiles where id_perfil = u.id_perfil) nombre_perfil" +
                              "  FROM Usuarios u WHERE 1=1";

            if (!chkTodos.Checked)
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    consulta += " AND nombre_usuario LIKE '%" + txtNombre.Text + "%'";
                }
                else if (!string.IsNullOrEmpty(cboPerfiles.Text))
                {
                    consulta += " AND id_perfil = " + cboPerfiles.SelectedValue;
                }
                else
                {
                    MessageBox.Show("Complete algún filtro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consulta);
            if (tabla.Rows.Count > 0)
            {
                dgvUsuarios.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("No se encontraron registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            idUsuarioSeleccionado = null;
            btnDetalleUsuario.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnDetalleUsuario_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado != string.Empty)
            {
                frmDetalleUsuario detalleUsuario = new frmDetalleUsuario(idUsuarioSeleccionado);
                detalleUsuario.ShowDialog();
            }

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtNombre.Enabled = false;
                cboPerfiles.Enabled = false;
                cboPerfiles.SelectedIndex = -1;
            }
            else
            {
                txtNombre.Enabled = true;
                cboPerfiles.Enabled = true;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Para que no falle cuando hacemos click en el titulo de la grilla.
            if (e.RowIndex >= 0)
            {
                idUsuarioSeleccionado = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                btnDetalleUsuario.Enabled = true;
            }
        }

    }
}
