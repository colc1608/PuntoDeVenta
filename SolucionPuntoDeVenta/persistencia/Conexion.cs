using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia
{
    public class Conexion
    {
        private SqlConnection con;
        private SqlTransaction transaccion;

        public void abrirConexion()
        {
            String servidor = "(local)";
            String bd = "puntoDeVenta";
            String usuario = "sa";
            String clave = "123456";
            try
            {
                con = new SqlConnection();
                //con.ConnectionString = "Data Source=ppi7dowad9.database.windows.net;Initial Catalog=prodent;Integrated Security=false;User ID=clopezc;Password=123456a+;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
                con.ConnectionString = "Data Source=" + servidor + "; Initial Catalog=" + bd + ";  Integrated Security=true; User ID="+usuario+";  Password="+clave+" ";
                con.Open();
                
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> conexion -> abrir conexion " + err);
                throw err;

            }

        }

        public void cerrarConexion()
        {
            try
            {
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void iniciarTransaccion()
        {
            try
            {
                abrirConexion();
                transaccion = con.BeginTransaction();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void terminarTransaccion()
        {
            try
            {
                transaccion.Commit();
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void cancelarTransaccion()
        {
            try
            {
                transaccion.Rollback();
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlDataReader ejecutarConsulta(String sentenciaSQL)
        {
            try
            {
                SqlCommand comando = con.CreateCommand();
                if (transaccion != null)
                    comando.Transaction = transaccion;
                comando.CommandText = sentenciaSQL;
                comando.CommandType = CommandType.Text;
                SqlDataReader resultado = comando.ExecuteReader();
                return resultado;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlCommand obtenerComandoSQL(String sentenciaSQL)
        {
            try
            {
                SqlCommand comando = con.CreateCommand();
                if (transaccion != null)
                    comando.Transaction = transaccion;
                comando.CommandText = sentenciaSQL;
                comando.CommandType = CommandType.Text;
                return comando;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlCommand obtenerComandoSP(String procedimiento_almacenado)
        {
            try
            {
                SqlCommand comando = con.CreateCommand();
                if (transaccion != null)
                    comando.Transaction = transaccion;
                comando.CommandText = procedimiento_almacenado;
                comando.CommandType = CommandType.StoredProcedure;
                return comando;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }


    

}
