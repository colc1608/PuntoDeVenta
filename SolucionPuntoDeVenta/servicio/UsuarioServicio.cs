using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importar librerias
using dominio;
using persistencia;

namespace servicio
{
    public class UsuarioServicio
    {
        private Conexion con;
        private UsuarioDAO dao;

        public UsuarioServicio()
        {
            con = new Conexion();
            dao = new UsuarioDAO(con);
        }

        public Usuario iniciarSesion(Usuario usuario)
        {
            Usuario objUsuario;
            try
            {
                con.abrirConexion();
                objUsuario = dao.iniciarSesion(usuario);
                con.cerrarConexion();
            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> servicio -> UsuarioServicio -> iniciarSesion " + err + "\n \n");
                throw err;
            }
            return objUsuario;
        }
    }//no tocar
}
