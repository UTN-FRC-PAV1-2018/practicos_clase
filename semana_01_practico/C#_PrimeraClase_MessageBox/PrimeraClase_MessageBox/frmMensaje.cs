using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraClase_MessageBox
{
    public partial class frmMensaje : Form
    {
        public frmMensaje()
        {
            InitializeComponent();
        }

        public void btnMensaje_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;


            //MessageBox.Show("Esto es un ejemplo!", "Título")
            MessageBox.Show(mensaje, "Título");
        }
		
    }
}
