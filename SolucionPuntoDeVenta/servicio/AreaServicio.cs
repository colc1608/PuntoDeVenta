using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importando librerias
using dominio;
using persistencia;

namespace servicio
{
    public class AreaServicio
    {
        private Conexion con;
        private AreaDAO dao;

        public AreaServicio()
        {
            con = new Conexion();
            dao = new AreaDAO(con);
        }



        public bool registrarArea(Area area)
        {
            bool exito;
            con.abrirConexion();
            exito = dao.registrar(area);
            con.cerrarConexion();
            return exito;
        }

        public bool actualizarArea(Area area)
        {
            bool exito;
            con.abrirConexion();
            exito = dao.actualizar(area);
            con.cerrarConexion();
            return exito;
        }

        public bool eliminarArea(Area area)
        {
            bool exito;
            con.abrirConexion();
            exito = dao.eliminar(area);
            con.cerrarConexion();
            return exito;
        }

        public List<Area> listarAreas()
        {
            List<Area> listaDeAreas;
            con.abrirConexion();
            listaDeAreas = dao.listarTodo();
            con.cerrarConexion();
            return listaDeAreas;
        }


        public List<Area> buscarArea(string cadena)
        {
            List<Area> listaDeAreas;
            con.abrirConexion();
            listaDeAreas = dao.buscar(cadena);
            con.cerrarConexion();
            return listaDeAreas;
        }










    }//no tocar estas llaves
}
