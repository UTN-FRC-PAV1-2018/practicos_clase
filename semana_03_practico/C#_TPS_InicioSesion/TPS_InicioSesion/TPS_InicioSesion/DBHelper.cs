using System;
using System.Data;
using System.Data.SqlClient;
public class DBHelper
{

    private string string_conexion = "Data Source=.\\sqlexpress;Initial Catalog=DB_Bugs;Integrated Security=True";


    public DataTable ConsultaSQL(string strSql)
    {
        //  Se utiliza para sentencias SQL del tipo Select
        //  La funci�n recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            conexion.ConnectionString = string_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            //  El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos

            tabla.Load (cmd.ExecuteReader());
            //  La funci�n retorna el objeto datatable con 0, 1 o mas registros
            return tabla;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conex�n
            conexion.Dispose();
        }

    }
}