using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPS_BugTracker.BusinessLayer.Services;
using TPS_BugTracker.GUILayer.Helper;

namespace TPS_BugTracker.GUILayer.Bugs
{
    public partial class frmBugs : Form
    {
        private BugService oBugService = new BugService();

        private CriticidadService criticidadService = new CriticidadService();
        private PrioridadService prioridadService = new PrioridadService();
        private ProductoService productoService = new ProductoService();
        private UsuarioService usuarioService = new UsuarioService();
        private EstadoService estadoService = new EstadoService();

        internal DataGridViewRow row_selected;

        public frmBugs()
        {
            InitializeComponent();
            dgvBugs.AutoGenerateColumns = false;

        }

    
        private void frmBugs_Load(object sender, EventArgs e)
        {

            //LLenar combos y limpiar grid
            GUIHelper.getHelper().llenarCombo(cboEstados, estadoService.consultarEstados(), "nombre", "id_estado");

            GUIHelper.getHelper().llenarCombo(cboPrioridades, prioridadService.consultarPrioridades(), "nombre", "id_prioridad");

            GUIHelper.getHelper().llenarCombo(cboCriticidades, criticidadService.consultarCriticidades(), "nombre", "id_criticidad");

            GUIHelper.getHelper().llenarCombo(cboAsignadoA, usuarioService.consultarUsuarios(), "nombre", "id_usuario");

            GUIHelper.getHelper().llenarCombo(cboProductos, productoService.consultarProductos(), "nombre", "id_producto");

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<object> parametros = new List<object>();

            DateTime fechaDesde;
            DateTime fechaHasta;
            if(DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) && 
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta)){
                parametros.Add(txtFechaDesde.Text);
                parametros.Add(txtFechaHasta.Text);
                }
            else
            {
                parametros.Add(null);
                parametros.Add(null);
            }

            if (!string.IsNullOrEmpty(cboPrioridades.Text))
            {
                var prioridad = cboPrioridades.SelectedValue.ToString();
                parametros.Add(prioridad);
            }
            else
            {
                parametros.Add(null);
            }

            if (!string.IsNullOrEmpty(cboCriticidades.Text))
            {
                var criticidad = cboCriticidades.SelectedValue.ToString();
                parametros.Add(criticidad);
            }
            else
            {
                parametros.Add(null);
            }

            if (!string.IsNullOrEmpty(cboProductos.Text))
            {
                var producto = cboProductos.SelectedValue.ToString();
                parametros.Add(producto);
            }
            else
            {
                parametros.Add(null);
            }


            if (!string.IsNullOrEmpty(cboEstados.Text))
            {
                var idEstado = cboEstados.SelectedValue.ToString();
                parametros.Add(idEstado);
            }
            else
            {
                parametros.Add(null);
            }

            if (!string.IsNullOrEmpty(cboAsignadoA.Text))
            {
                var asignadoA = cboAsignadoA.SelectedValue.ToString();
                parametros.Add(asignadoA);
            }
            else
            {
                parametros.Add(null);
            }
            
            dgvBugs.DataSource = oBugService.consultarBugsConFiltros( parametros);
            if(dgvBugs.Rows.Count == 0) 
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btn_asignar.Enabled = false;
                btn_editar.Enabled = false;
                btn_detalle_bug.Enabled = false;
                btn_pasar_a_te.Enabled = false;
                btn_cerrar.Enabled = false;
            }

        }

        private void btn_detalle_bug_Click(object sender, EventArgs e)
        {
            int id;
            if (row_selected.Index != -1)
            {
                id = Convert.ToInt32(row_selected.Cells["id_bug_col"].Value);
                frmDetalleBug frmDetalle = new frmDetalleBug();
                frmDetalle.mostrarBug(oBugService.consultarBugsPorId(id));
                frmDetalle.ShowDialog();
            }
        }

        private void dgvBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_selected = dgvBugs.CurrentRow;
            btn_asignar.Enabled = true;
            btn_editar.Enabled = true;
            btn_detalle_bug.Enabled = true;
            btn_cerrar.Enabled = true;
        }
        
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int id;
            if (row_selected.Index != -1)
            {
                id = Convert.ToInt32(row_selected.Cells["id_bug_col"].Value);
                frmActualizarBug frmActualizar = new frmActualizarBug();
                frmActualizar.mostrarBug(oBugService.consultarBugsPorId(id));
                frmActualizar.ShowDialog();

                btnConsultar_Click(sender, e);
            }
        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            int id;
            if (row_selected.Index != -1)
            {
                id = Convert.ToInt32(row_selected.Cells["id_bug_col"].Value);
                frmAsignarBug frmAsignar = new frmAsignarBug();
                frmAsignar.mostrarBug(oBugService.consultarBugsPorId(id));
                frmAsignar.ShowDialog();
            }
        }
    }
}
