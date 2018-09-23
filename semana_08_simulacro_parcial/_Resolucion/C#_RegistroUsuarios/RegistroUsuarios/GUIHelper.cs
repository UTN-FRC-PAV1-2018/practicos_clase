using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
public class GUIHelper
{
    private static GUIHelper instance; //Unica instancia de la clase
    public static GUIHelper getGUIHelper()
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