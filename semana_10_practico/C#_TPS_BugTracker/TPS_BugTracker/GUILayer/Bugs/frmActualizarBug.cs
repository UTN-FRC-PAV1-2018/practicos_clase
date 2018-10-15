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
using TPS_BugTracker.DataLayer.DAOs;
using TPS_BugTracker.GUILayer.Helper;

namespace TPS_BugTracker.GUILayer.Bugs
{
    public partial class frmActualizarBug : Form
    {
        private Bug oBugSelected;
        private BugDao BugDao;
        public frmActualizarBug()
        {
            InitializeComponent();
            
            BugDao = new BugDao();
        
            GUIHelper.getHelper().llenarCombo(cboPrioridad, BDHelper.getBDHelper().ConsultaSQL("Select * from Prioridades"), "n_prioridad", "id_prioridad");

            GUIHelper.getHelper().llenarCombo(cboCriticidad, BDHelper.getBDHelper().ConsultaSQL("Select * from Criticidades"), "n_criticidad", "id_criticidad");

            GUIHelper.getHelper().llenarCombo(cboProducto, BDHelper.getBDHelper().ConsultaSQL("Select * from Productos"), "nombre", "id_producto");
        }

        internal void mostrarBug(Bug bugSelected)
        {
            oBugSelected = bugSelected;
            txtTitulo.Text = oBugSelected.titulo;
            txtDescripcion.Text = oBugSelected.n_producto;
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

                BugDao.updateBug(oBugSelected);
            }

            this.Close();
        }

    }
}
