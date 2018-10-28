using Microsoft.Reporting.WinForms;
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

namespace TPS_BugTracker.GUILayer.Reports
{
    public partial class frmReportBugs : Form
    {

        private BugService oBugService = new BugService();

        private CriticidadService criticidadService = new CriticidadService();
        private PrioridadService prioridadService = new PrioridadService();
        private ProductoService productoService = new ProductoService();
        private UsuarioService usuarioService = new UsuarioService();
        private EstadoService estadoService = new EstadoService();

        public frmReportBugs()
        {
            InitializeComponent();
            //LLenar combos y limpiar grid
            GUIHelper.getHelper().llenarCombo(cboEstados, estadoService.consultarEstados(), "nombre", "id_estado");

            GUIHelper.getHelper().llenarCombo(cboPrioridades, prioridadService.consultarPrioridades(), "nombre", "id_prioridad");

            GUIHelper.getHelper().llenarCombo(cboCriticidades, criticidadService.consultarCriticidades(), "nombre", "id_criticidad");

            GUIHelper.getHelper().llenarCombo(cboAsignadoA, usuarioService.consultarUsuarios(), "nombre", "id_usuario");

            GUIHelper.getHelper().llenarCombo(cboProductos, productoService.consultarProductos(), "nombre", "id_producto");
        }

        private void frmReportBugs_Load(object sender, EventArgs e)
        {

            this.reporteBugs.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Set the processing mode for the ReportViewer to Local  
            reporteBugs.ProcessingMode = ProcessingMode.Local;
     
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<object> parametros = new List<object>();

            DateTime fechaDesde;
            DateTime fechaHasta;
            if (DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) &&
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
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
            
            BugBindingSource.DataSource = oBugService.consultarBugsConFiltros(parametros);

            // Refresh the report  
            reporteBugs.RefreshReport();
        }
    }
}
