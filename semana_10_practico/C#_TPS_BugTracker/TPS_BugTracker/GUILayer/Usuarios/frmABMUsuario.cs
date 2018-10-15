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
using TPS_BugTracker.BusinessLayer.Services;

namespace TPS_BugTracker.GUILayer.Usuarios
{
    public partial class frmABMUsuario : Form
    {
        public frmABMUsuario()
        {
            InitializeComponent();
        }

        public enum Opcion
        {
            insert,
            update,
            delete
        }

        private Opcion _action = Opcion.insert;
        private UsuarioService oUsuarioService = new UsuarioService();
        private Usuario oUsuarioSelected;

        private void frmABMUsuario_Load(System.Object sender, System.EventArgs e)
        {
            llenarCombo(cbo_perfil, BDHelper.getBDHelper().ConsultaSQL("SELECT * From Perfiles WHERE id_perfil <> 1"), "n_perfil", "id_perfil");
            switch (_action)
            {
                case Opcion.insert:
                    {
                        this.Text = "Nuevo Usuario";
                        break;
                    }

                case Opcion.update:
                    {
                        this.Text = "Actualizar Usuario";
                        // Recuperar usuario seleccionado en la grilla 
                        mostrar_datos();
                        txt_nombre.Enabled = true;
                        txt_email.Enabled = true;
                        txt_email.Enabled = true;
                        txt_password.Enabled = true;
                        txt_confirmar_pass.Enabled = true;
                        cbo_perfil.Enabled = true;
                        break;
                    }

                case Opcion.delete:
                    {
                        mostrar_datos();
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        txt_nombre.Enabled = false;
                        txt_email.Enabled = false;
                        txt_email.Enabled = false;
                        txt_password.Enabled = false;
                        cbo_perfil.Enabled = false;
                        txt_confirmar_pass.Enabled = false;
                        break;
                    }
            }
        }

        private void btn_salir_Click(System.Object sender, System.EventArgs e)
        {
            this.Dispose();
        }


        public void seleccionar_usuario(Opcion op, Usuario usuarioSelected)
        {
            _action = op;
            oUsuarioSelected = usuarioSelected;
        }

        private void mostrar_datos()
        {
            if (oUsuarioSelected != null)
            {
                txt_nombre.Text = oUsuarioSelected.nombre;
                txt_email.Text = oUsuarioSelected.email;
                txt_password.Text = oUsuarioSelected.password;
                txt_confirmar_pass.Text = txt_password.Text;
                cbo_perfil.Text = oUsuarioSelected.perfil;
            }
        }

        private void btn_aceptar_Click(System.Object sender, System.EventArgs e)
        {
            string str_sql = "";
            Usuario oUsuario;

            switch (_action)
            {
                case Opcion.insert:
                    {
                        if (existe_nombre() == false)
                        {
                            if (validar_campos())
                            {
                                oUsuario = new Usuario();
                                oUsuario.nombre = txt_nombre.Text;
                                oUsuario.password = txt_password.Text;
                                oUsuario.email = txt_email.Text;
                                oUsuario.id_perfil = cbo_perfil.SelectedValue.ToString();
                                oUsuario.estado = "S";

                                if (oUsuarioService.crearUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case Opcion.update:
                    {
                        if (validar_campos())
                        {
                            oUsuarioSelected.nombre = txt_nombre.Text;
                            oUsuarioSelected.password = txt_password.Text;
                            oUsuarioSelected.email = txt_email.Text;
                            oUsuarioSelected.id_perfil = cbo_perfil.SelectedValue.ToString();

                            if (oUsuarioService.actualizarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case Opcion.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oUsuarioSelected.estado == "N")
                                oUsuarioSelected.estado = "S";
                            else
                                oUsuarioSelected.estado = "N";

                            if (oUsuarioService.modificarEstadoUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private bool validar_campos()
        {
            // campos obligatorios
            if (txt_nombre.Text == string.Empty)
            {
                txt_nombre.BackColor = Color.Red;
                txt_nombre.Focus();
                return false;
            }
            else
                txt_nombre.BackColor = Color.White;

            if (txt_password.Text == string.Empty)
            {
                txt_password.BackColor = Color.Red;
                txt_password.Focus();
                return false;
            }
            else
                txt_password.BackColor = Color.White;

            if (txt_confirmar_pass.Text == string.Empty)
            {
                txt_confirmar_pass.BackColor = Color.Red;
                txt_confirmar_pass.Focus();
                return false;
            }
            else
                txt_confirmar_pass.BackColor = Color.White;

            if (cbo_perfil.Text == string.Empty)
            {
                cbo_perfil.BackColor = Color.Red;
                cbo_perfil.Focus();
                return false;
            }
            else
                cbo_perfil.BackColor = Color.White;

            if (txt_confirmar_pass.Text != txt_password.Text)
            {
                txt_confirmar_pass.BackColor = Color.Red;
                txt_password.BackColor = Color.Red;
                txt_confirmar_pass.Focus();
                return false;
            }
            else
            {
                txt_confirmar_pass.BackColor = Color.White;
                txt_password.BackColor = Color.White;
            }

            return true;
        }

        private bool existe_nombre()
        {
            return (oUsuarioService.validarNombreUsuario(txt_nombre.Text) != null);
        }


        private void llenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
