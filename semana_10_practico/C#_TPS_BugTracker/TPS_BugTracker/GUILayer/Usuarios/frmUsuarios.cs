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
using TPS_BugTracker.BusinessLayer;
using TPS_BugTracker.BusinessLayer.Services;

namespace TPS_BugTracker.GUILayer.Usuarios
{
    public partial class frmUsuarios : Form
    {

        private UsuarioService oUsuarioService;

        public frmUsuarios()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            llenarCombo(cbo_perfiles, BDHelper.getBDHelper().ConsultaSQL("SELECT * From Perfiles WHERE id_perfil <> 1"), "n_perfil", "id_perfil");
        }

        private void llenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            formulario.ShowDialog();
            btn_consultar_Click(sender, e);
        }

        private void chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chk_todos.Checked)
                {
                    txt_nombre.Enabled = false;
                    cbo_perfiles.Enabled = false;
                }
                else
                {
                    txt_nombre.Enabled = true;
                    cbo_perfiles.Enabled = true;
                }
            }
        }

        private void btn_salir_Click(System.Object sender, System.EventArgs e)
        {
            // Confirmación de salida.
            if (MessageBox.Show("Seguro que desea salir?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                this.Close();
        }

        private void btn_consultar_Click(System.Object sender, System.EventArgs e)
        {
            List<object> filters = new List<object>();
            bool flag_filtros = false;

            if (!chk_todos.Checked)
            {
                // Validar si el combo 'Perfiles' esta seleccionado.
                if (cbo_perfiles.Text != string.Empty)
                {
                    // Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add(cbo_perfiles.SelectedValue);
                    flag_filtros = true;
                }
                else
                    filters.Add(null);

                // Validar si el textBox 'Nombre' esta vacio.
                if (txt_nombre.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add(txt_nombre.Text);
                    flag_filtros = true;
                }
                else
                    filters.Add(null);

                if (flag_filtros)
                    llenarGrilla(oUsuarioService.consultarUsuariosConFiltros(filters));
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                llenarGrilla(oUsuarioService.consultarUsuarios());
        }

        private void llenarGrilla(IList<Usuario> source)
        {
            dgv_users.Rows.Clear();
            foreach (Usuario oUsuario in source)
                dgv_users.Rows.Add(new string[] { oUsuario.nombre, oUsuario.id_perfil, oUsuario.email, oUsuario.perfil, oUsuario.id_usuario.ToString(), oUsuario.password });
        }

        private void btn_editar_Click(System.Object sender, System.EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            formulario.seleccionar_usuario(frmABMUsuario.Opcion.update, map_usuario_fila());
            formulario.ShowDialog();
            btn_consultar_Click(sender, e);
        }

        private void dgv_users_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            btn_editar.Enabled = true;
            btn_quitar.Enabled = true;
        }

        private void btn_quitar_Click(System.Object sender, System.EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            formulario.seleccionar_usuario(frmABMUsuario.Opcion.delete, map_usuario_fila());
            formulario.ShowDialog();
            btn_consultar_Click(sender, e);
        }

        private Usuario map_usuario_fila()
        {
            Usuario oUsuario = new Usuario();
            oUsuario.nombre = dgv_users.CurrentRow.Cells["col_nombre"].Value.ToString();
            oUsuario.perfil = dgv_users.CurrentRow.Cells["col_perfil"].Value.ToString();
            oUsuario.password = dgv_users.CurrentRow.Cells["col_pass"].Value.ToString();
            oUsuario.email = dgv_users.CurrentRow.Cells["col_email"].Value.ToString();
            oUsuario.id_usuario = int.Parse( dgv_users.CurrentRow.Cells["col_id"].Value.ToString());
            oUsuario.id_perfil = dgv_users.CurrentRow.Cells["id_perfil_col"].Value.ToString();
            return oUsuario;
        }
    }
}
