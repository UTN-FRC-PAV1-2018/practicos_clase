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

namespace TPS_BugTracker.GUILayer.Bugs
{
    public partial class frmDetalleBug : Form
    {
        public frmDetalleBug()
        {
            InitializeComponent();
        }

        internal void mostrarBug(Bug oBugSelected)
        {
            txtNroBug.Text = oBugSelected.id_bug.ToString();
            txtTitulo.Text = oBugSelected.titulo;
            txtProducto.Text = oBugSelected.n_producto;
            txtFechaAlta.Text = oBugSelected.fecha_alta.ToString();
            txtDescripcion.Text = oBugSelected.descripcion;
            txtEstado.Text = oBugSelected.estado;
            txtPrioridad.Text = oBugSelected.n_prioridad;
            txtCriticidad.Text = oBugSelected.n_criticidad;

            dgv_historiales.Rows.Clear();
            foreach (HistorialBug oHistorialBug in oBugSelected.historial)
                dgv_historiales.Rows.Add(new string[] { oHistorialBug.fecha.ToString("dd/MM/yyyy"), oHistorialBug.n_responsable, oHistorialBug.n_estado, oHistorialBug.n_asignado_a });
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
