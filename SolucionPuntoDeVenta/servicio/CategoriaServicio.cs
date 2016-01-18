using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importar librerias
using persistencia;
using dominio;

namespace servicio
{
    public class CategoriaServicio 
    {
        private Conexion con;
        private CategoriaDAO dao;

        public CategoriaServicio()
        {
            con = new Conexion();
            dao = new CategoriaDAO(con);

        }
        public bool registrarCategoria(Categoria categoria)
        {
            bool exito;
            con.abrirConexion();
            exito = dao.registrar(categoria);
            con.cerrarConexion();
            return exito;
        }

        public bool actualizarCategoria(Categoria categoria)
        {
            bool exito;
            con.abrirConexion();
            exito = dao.actualizar(categoria);
            con.cerrarConexion();
            return exito;
        }

        public bool eliminarCategoria(Categoria categoria)
        {
            bool exito;
            con.abrirConexion();
            exito = dao.eliminar(categoria);
            con.cerrarConexion();
            return exito;
        }

        public List<Categoria> listarTodo()
        {
            List<Categoria> listaDeCategorias;
            con.abrirConexion();
            listaDeCategorias = dao.listarTodo();
            con.cerrarConexion();
            return listaDeCategorias;
        }


        public List<Categoria> buscarCategoria(string cadena)
        {
            List<Categoria> listaDeCategorias;
            con.abrirConexion();
            listaDeCategorias = dao.buscar(cadena);
            con.cerrarConexion();
            return listaDeCategorias;
        }
    }
}
