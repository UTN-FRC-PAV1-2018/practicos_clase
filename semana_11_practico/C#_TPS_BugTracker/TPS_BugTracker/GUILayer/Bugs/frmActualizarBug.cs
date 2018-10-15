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
    public partial class frmActualizarBug : Form
    {

        private PrioridadService prioridadService = new PrioridadService();
        private ProductoService productoService = new ProductoService();
        private CriticidadService criticidadService = new CriticidadService();

        private Bug oBugSelected;
        private BugService oBugService;
        public frmActualizarBug()
        {
            InitializeComponent();

            oBugService = new BugService();

            GUIHelper.getHelper().llenarCombo(cboPrioridad, prioridadService.consultarPrioridades(), "nombre", "id_prioridad");

            GUIHelper.getHelper().llenarCombo(cboCriticidad, criticidadService.consultarCriticidades(), "nombre", "id_criticidad");

            GUIHelper.getHelper().llenarCombo(cboProducto, productoService.consultarProductos(), "nombre", "id_producto");
        }

        internal void mostrarBug(Bug bugSelected)
        {
            oBugSelected = bugSelected;
            txtTitulo.Text = oBugSelected.titulo;
            txtDescripcion.Text = oBugSelected.descripcion;

            cboPrioridad.SelectedValue = oBugSelected.id_prioridad;
            cboCriticidad.SelectedValue = oBugSelected.id_criticidad;
            cboProducto.SelectedValue = oBugSelected.id_producto;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {   
            if (oBugSelected != null)            
            {
                // Si tenemos un bug seleccionado significa que vamos a actualizar los cambios
                oBugSelected.titulo = txtTitulo.Text;
                oBugSelected.descripcion = txtDescripcion.Text;

                oBugSelected.id_prioridad = (int)cboPrioridad.SelectedValue;
                oBugSelected.id_criticidad = (int)cboCriticidad.SelectedValue;
                oBugSelected.id_producto = (int)cboProducto.SelectedValue;

                oBugService.actualizarBug(oBugSelected);
            }

            this.Close();
        }

    }
}
