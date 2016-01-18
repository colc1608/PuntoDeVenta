using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importar librerias
using dominio;
using interfaz;
using System.Data.SqlClient;

namespace persistencia
{
    public class CategoriaDAO : CategoriaInterfaz
    {
        Conexion con;

        public CategoriaDAO(Conexion cn)
        {
            con = cn;
        }

        public bool registrar(Categoria categoria)
        {
            String sentenciaSQL = "insert into categoria (descripcion) values (@descripcion);";
            try
            {
                SqlCommand comando = con.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> CategoriaDAO -> registrar " + err + "\n");
                throw err;
            }
            return false;
        }

        public bool actualizar(Categoria categoria)
        {
            String sentenciaSQL = "update categoria set descripcion = @descripcion where id = @id; ";
            try
            {
                SqlCommand comando = con.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
                comando.Parameters.AddWithValue("@id", categoria.Id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> CategoriaDAO -> actualizar " + err + "\n");
                throw err;
            }
            return false;
        }

        public bool eliminar(Categoria categoria)
        {
            String sentenciaSQL = "update categoria set estado = 0 where id = @id; ";
            try
            {
                SqlCommand comando = con.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@id", categoria.Id);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> CategoriaDAO -> eliminar " + err + "\n");
                throw err;
            }
            return false;
        }

        public List<Categoria> listarTodo()
        {
            List<Categoria> listaDeCategorias = new List<Categoria>();
            String sentenciaSQL = "select id, descripcion from categoria where estado = '1' ";
            try
            {
                SqlDataReader resultado = con.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = resultado.GetInt32(0);
                    categoria.Descripcion = resultado.GetString(1);
                    listaDeCategorias.Add(categoria);
                }
                resultado.Close();
                return listaDeCategorias;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> CategoriaDAO -> listarTodos " + err + "\n");
                throw err;
            }
        }

        public List<Categoria> buscar(string cadena)
        {
            List<Categoria> listaDeCategorias = new List<Categoria>();
            String sentenciaSQL = "select id, descripcion from categoria where estado = '1' and descripcion like '%" + cadena + "%' ";
            try
            {
                SqlDataReader resultado = con.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = resultado.GetInt32(0);
                    categoria.Descripcion = resultado.GetString(1);
                    listaDeCategorias.Add(categoria);
                }
                resultado.Close();
                return listaDeCategorias;
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> CategoriaDAO -> buscar " + err + "\n");
                throw err;
            }
        }
    }
}
