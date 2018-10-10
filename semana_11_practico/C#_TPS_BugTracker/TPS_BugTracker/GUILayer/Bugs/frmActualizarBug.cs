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

namespace TPS_BugTracker.GUILayer.Bugs
{
    public partial class frmActualizarBug : Form
    {
        public frmActualizarBug()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void btn_aceptar_Click(System.Object sender, System.EventArgs e)
        {
            Bug oBug;
            HistorialBug oHistorialBug;
            BugService oBugService = new BugService();

            if (string.IsNullOrEmpty(txt_nombre.Text) | string.IsNullOrEmpty(cbo_productos.Text))
            {
                MessageBox.Show("Debe completar todos los campos indicados con (*).", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }
            else
            {
                oBug = new Bug();
                oBug.titulo = txt_nombre.Text;
                oBug.descripcion = txt_descri.Text;
                oBug.id_producto = (int) cbo_productos.SelectedValue;
                oBug.id_prioridad = (int)cbo_prioridades.SelectedValue;
                oBug.id_criticidad = (int) cbo_criticidades.SelectedValue;
                oHistorialBug = new HistorialBug();
                oHistorialBug.estado = 1;
                oHistorialBug.responsable = frmPrincipal.obtenerUsuarioLogin().id_usuario;
                oBug.addHistorial(oHistorialBug);

                if (oBugService.create(oBug))
                {
                    MessageBox.Show("Bug registrado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Ha ocurrido un error al registrar el bug. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_actualizar_bug_Load(System.Object sender, System.EventArgs e)
        {
            ProductoService oProductoService = new ProductoService();
            PrioridadService oPrioridadService = new PrioridadService();
            CriticidadService oCriticidadService = new CriticidadService();


            frmBugs.llenarCombo(cbo_prioridades, oPrioridadService.consultarPrioridades(), "nombre", "id_prioridad");
            frmBugs.llenarCombo(cbo_criticidades, oCriticidadService.consultarCriticidades(), "nombre", "id_criticidad");
            frmBugs.llenarCombo(cbo_productos, oProductoService.consultarProductos(), "nombre", "id_producto");
        }
    }
}
