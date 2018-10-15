using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPS_BugTracker.GUILayer.Helper
{
    class GUIHelper
    {
        private static GUIHelper instance; //Unica instancia de la clase
        public static GUIHelper getHelper()
        {
            if (instance == null)
                instance = new GUIHelper();
            return instance;
        }

        public void llenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
    }
}
