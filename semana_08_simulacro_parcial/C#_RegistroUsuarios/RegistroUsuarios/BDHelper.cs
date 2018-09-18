using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
public class BDHelper
{
    private string string_conexion = "Data Source=maquis;Initial Catalog=DB_Usuarios;User id=avisuales;Password=avisuales;";

    private static BDHelper instance; //Unica instancia de la clase
    public static BDHelper getBDHelper()
    {
        if (instance == null)
            instance = new BDHelper();
        return instance;
    }

}