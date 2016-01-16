using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importando librerias
using interfaz;
using dominio;
using System.Data.SqlClient;

namespace persistencia
{
    public class AreaDAO : AreaInterfaz
    {
        private Conexion con;


        public AreaDAO(Conexion cn)
        {
            con = cn;
        }

        public bool registrarArea(Area area)
        {
            String sentenciaSQL = "insert into area (descripcion) values (@descripcion);";
            try
            {
                SqlCommand comando = con.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@descripcion", area.Descripcion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> AreaDAO -> registrar " + err + "\n");
                throw err;
            }
            return false;
        }

        public bool actualizarArea(Area area)
        {
            String sentenciaSQL = "update area set descripcion = @descripcion where id = @id; ";
            try
            {
                SqlCommand comando = con.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@descripcion", area.Descripcion);
                comando.Parameters.AddWithValue("@id", area.Id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> AreaDAO -> actualizar " + err + "\n");
                throw err;
            }
            return false;
        }

        public bool eliminarArea(Area area)
        {
            String sentenciaSQL = "update area set estado = 0 where id = @id; ";
            try
            {
                SqlCommand comando = con.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@id", area.Id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> AreaDAO -> eliminar " + err + "\n");
                throw err;
            }
            return false;
        }

        public List<Area> listaDeAreas()
        {
            List<Area> listaDeAreas = new List<Area>();
            String sentenciaSQL = "select id, descripcion from area where estado = '1' ";
            try
            {
                SqlDataReader resultado = con.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    Area area = new Area();
                    area.Id = resultado.GetInt32(0);
                    area.Descripcion = resultado.GetString(1);
                    listaDeAreas.Add(area);
                }
                resultado.Close();
                return listaDeAreas;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> AreaDAO -> listarTodos " + err + "\n");
                throw err;
            }
        }

        public List<Area> buscarArea(string cadena)
        {
            List<Area> listaDeAreas = new List<Area>();
            String sentenciaSQL = "select id, descripcion from area where estado = '1' and descripcion like '%" + cadena +"%' ";
            try
            {
                SqlDataReader resultado = con.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    Area area = new Area();
                    area.Id = resultado.GetInt32(0);
                    area.Descripcion = resultado.GetString(1);
                    listaDeAreas.Add(area);
                }
                resultado.Close();
                return listaDeAreas;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> AreaDAO -> listarTodos " + err + "\n");
                throw err;
            }
        }













    }//no tocar estas llaves
}
