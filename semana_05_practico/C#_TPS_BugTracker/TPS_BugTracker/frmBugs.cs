using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPS_BugTracker
{
    public partial class frmBugs : Form
    {
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
            string strSql = "SELECT TOP 20 * FROM bugs WHERE 1=1 ";
            List<string> parametros = new List<string>();

            DateTime fechaDesde;
            DateTime fechaHasta;
            if(DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) && 
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta)){
                    strSql += " AND (fecha_alta>=@param1 AND fecha_alta<=@param2) ";
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
                strSql += "AND (id_estado=@param3) ";
                parametros.Add(idEstado);
            }
            else
            {
                parametros.Add(null);
            }

            if (!string.IsNullOrEmpty(cboAsignadoA.Text))
            {
                var asignadoA = cboAsignadoA.SelectedValue.ToString();
                strSql += "AND (asignado_a=@param4) ";
                parametros.Add(asignadoA);
            }
            else
            {
                parametros.Add(null);
            }

            if (!string.IsNullOrEmpty(cboPrioridades.Text))
            {
                var prioridad = cboPrioridades.SelectedValue.ToString();
                strSql += "AND (id_prioridad=@param5) ";
                parametros.Add(prioridad);
            }
            else
            {
                parametros.Add(null);
            }

            if (!string.IsNullOrEmpty(cboCriticidades.Text))
            {
                var criticidad = cboCriticidades.SelectedValue.ToString();
                strSql += "AND (id_criticidad=@param6) ";
                parametros.Add(criticidad);
            }
            else
            {
                parametros.Add(null);
            }

            if (!string.IsNullOrEmpty(cboProductos.Text))
            {
                var producto = cboProductos.SelectedValue.ToString();
                strSql += "AND (id_producto=@param7) ";
                parametros.Add(producto);
            }
            else
            {
                parametros.Add(null);
            }

            strSql += " ORDER BY fecha_alta DESC";
            dgvBugs.DataSource = BDHelper.getBDHelper().ConsultaSqlConParametros(strSql, parametros);
            if(dgvBugs.Rows.Count == 0) 
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
