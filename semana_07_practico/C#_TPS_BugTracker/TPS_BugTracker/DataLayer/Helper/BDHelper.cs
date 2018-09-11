using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
public class BDHelper
{
    private string string_conexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=DB_Bugs;User id=admin;Password=admin123;";

    private static BDHelper instance; //Unica instancia de la clase
    public static BDHelper getBDHelper()
    {
        if (instance == null)
            instance = new BDHelper();
        return instance;
    }

    public DataTable ConsultaSQL(string strSql)
    {
        //  Se utiliza para sentencias SQL del tipo Select
        //  La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
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

            tabla.Load(cmd.ExecuteReader());
            //  La función retorna el objeto datatable con 0, 1 o mas registros
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

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
        }

    }

    public DataTable ConsultaSQLConParametros(string strSql, List<object> sqlParam)
    {
        //  Se utiliza para sentencias SQL del tipo Select
        //  La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
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

            var indice = 0;
            foreach (var param in sqlParam)
            {
                if (param != null)
                {
                    var n_param = "param" + Convert.ToString(indice + 1);
                    cmd.Parameters.AddWithValue(n_param, param);
                }
                indice++;
            }

            tabla.Load(cmd.ExecuteReader());
            //  La función retorna el objeto datatable con 0, 1 o mas registros
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

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
        }

    }

    public int EjecutarSQL(string strSql)
    {
        // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlTransaction t = null/* TODO Change to default(_) if this is not a reference type */;
        int rtdo = 0;

        // Try Catch Finally
        // Trata de ejecutar el código contenido dentro del bloque Try - Catch
        // Si hay error lo capta a través de una excepción
        // Si no hubo error
        try
        {
            // Establece que conexión usar
            conexion.ConnectionString = string_conexion;
            // Abre la conexión
            conexion.Open();
            t = conexion.BeginTransaction();
            cmd.Connection = conexion;
            cmd.Transaction = t;
            cmd.CommandType = CommandType.Text;
            // Establece la instrucción a ejecutar
            cmd.CommandText = strSql;
            // Retorna el resultado de ejecutar el comando

            rtdo = cmd.ExecuteNonQuery();
            t.Commit();
        }
        catch (Exception ex)
        {
            if (t != null)
                t.Rollback();
        }
        finally
        {
            // Cierra la conexión 
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            conexion.Dispose();
        }
        return rtdo;
    }

}