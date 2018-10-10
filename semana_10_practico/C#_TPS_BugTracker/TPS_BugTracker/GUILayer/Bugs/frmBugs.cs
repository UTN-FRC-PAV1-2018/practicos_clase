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

namespace TPS_BugTracker
{
    public partial class frmBugs : Form
    {
        private BugService oBugService = new BugService();
        internal DataGridViewRow row_selected;

        public frmBugs()
        {
            InitializeComponent();
        }

        private void llenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void frmBugs_Load(object sender, EventArgs e)
        {

            //LLenar combos y limpiar grid
            llenarCombo(cboEstados, BDHelper.getBDHelper().ConsultaSQL("Select * from Estados"), "n_estado", "id_estado");

            llenarCombo(cboPrioridades, BDHelper.getBDHelper().ConsultaSQL("Select * from Prioridades"), "n_prioridad", "id_prioridad");

            llenarCombo(cboCriticidades, BDHelper.getBDHelper().ConsultaSQL("Select * from Criticidades"), "n_criticidad", "id_criticidad");

            llenarCombo(cboAsignadoA, BDHelper.getBDHelper().ConsultaSQL("Select * from users"), "n_usuario", "id_usuario");

            llenarCombo(cboProductos, BDHelper.getBDHelper().ConsultaSQL("Select * from Productos"), "nombre", "id_producto");

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
            
            dgvBugs.DataSource = oBugService.consultarBugsConFiltros( parametros);
            if(dgvBugs.Rows.Count == 0) 
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvBugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row_selected = dgvBugs.CurrentRow;
            btn_detalle_bug.Enabled = true;
            btn_pasar_a_te.Enabled = true;
            btn_cerrar.Enabled = true;
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
            btn_detalle_bug.Enabled = true;
            btn_pasar_a_te.Enabled = true;
            btn_cerrar.Enabled = true;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
