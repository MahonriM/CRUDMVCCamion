using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public static class BaseHelper
{
    public static DataTable ejecutarSelect(string query, CommandType tipo, List<SqlParameter> parametros = null)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataAdapter adaptador = new SqlDataAdapter();
        DataTable datos = new DataTable();
        try
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            con.Open();
            comando.Connection = con;
            comando.CommandType = tipo;
            comando.CommandText = query;
            if (parametros != null)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }
            adaptador.SelectCommand = comando;
            adaptador.Fill(datos);

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            con.Close();
        }
        return datos;
    }

    public static int ejecutarSentencia(string query, CommandType tipo, List<SqlParameter> parametros = null)
    {
        int r = -1;
        SqlConnection con = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        try
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            con.Open();
            comando.Connection = con;
            comando.CommandType = tipo;
            comando.CommandText = query;
            if (parametros != null)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }
            r = comando.ExecuteNonQuery();
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            con.Close();
        }
        return r;
    }
}