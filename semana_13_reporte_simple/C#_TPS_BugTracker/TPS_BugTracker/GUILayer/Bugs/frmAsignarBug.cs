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
using TPS_BugTracker.GUILayer.Helper;

namespace TPS_BugTracker.GUILayer.Bugs
{
    public partial class frmAsignarBug : Form
    {
        private UsuarioService usuarioService = new UsuarioService();
     

        private Bug oBugSelected;
        private BugService oBugService;
        public frmAsignarBug()
        {
            InitializeComponent();

            oBugService = new BugService();

            GUIHelper.getHelper().llenarCombo(cbo_desa, usuarioService.consultarDesarrolladores(), "nombre", "id_usuario");
        }

        internal void mostrarBug(Bug bugSelected)
        {
            oBugSelected = bugSelected;
            txtIdBug.Text = oBugSelected.id_bug.ToString();
            txtTitulo.Text = oBugSelected.titulo;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {   
            if (oBugSelected != null)            
            {
                HistorialBug historial = new HistorialBug();

                historial.asignado_a = (int) cbo_desa.SelectedValue;
                historial.fecha = DateTime.Now;
                historial.estado = 2;
                historial.responsable = oBugSelected.historial.Last().responsable;
                oBugSelected.addHistorial(historial);
                // Si tenemos un bug seleccionado significa que vamos a actualizar los cambios
                

                oBugService.actualizarBug(oBugSelected);
            }

            this.Close();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
