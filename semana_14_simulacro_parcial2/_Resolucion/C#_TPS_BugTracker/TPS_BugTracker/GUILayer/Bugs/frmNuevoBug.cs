using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPS_BugTracker.BusinessLayer.Entities;
using TPS_BugTracker.BusinessLayer.Services;
using TPS_BugTracker.DataLayer.DAOs;
using TPS_BugTracker.GUILayer.Helper;

namespace TPS_BugTracker.GUILayer.Bugs
{
    public partial class frmNuevoBug : Form
    {
        private PrioridadService prioridadService = new PrioridadService();
        private ProductoService productoService = new ProductoService();
        private CriticidadService criticidadService = new CriticidadService();

        private BugService bugService = new BugService();

        public frmNuevoBug()
        {
            InitializeComponent();

            GUIHelper.getHelper().llenarCombo(cboPrioridad, prioridadService.consultarPrioridades(), "nombre", "id_prioridad");

            GUIHelper.getHelper().llenarCombo(cboCriticidad, criticidadService.consultarCriticidades(), "nombre", "id_criticidad");

            GUIHelper.getHelper().llenarCombo(cboProducto, productoService.consultarProductos(), "nombre", "id_producto");
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    //Creamos una instancia de Bug

                    Bug nuevoBug = new Bug();
                    nuevoBug.titulo = txtTitulo.Text;
                    nuevoBug.descripcion = txtDescripcion.Text;

                    nuevoBug.id_estado = 1; // Estado  "Nuevo"
                    nuevoBug.id_prioridad = (int)cboPrioridad.SelectedValue;
                    nuevoBug.id_criticidad = (int)cboCriticidad.SelectedValue;
                    nuevoBug.id_producto = (int)cboProducto.SelectedValue;

                    HistorialBug historial = new HistorialBug();
                    historial.responsable = frmPrincipal.obtenerUsuarioLogin().id_usuario;
                    historial.fecha = DateTime.Now;

                    nuevoBug.addHistorial(historial);

                    if (bugService.crearBug(nuevoBug))
                    {
                        MessageBox.Show("El bug se creó correctamente", "Nuevo Bug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No pudo crear el Bug", "Nuevo Bug", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error al crear un bug: " + ex.Message, "Error creando Bug", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("El campo Título es obligatorio.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            if (cboProducto.SelectedIndex < 0)
            {
                MessageBox.Show("El campo Producto es obligatorio.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
