using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//haciendo las referencias
using dominio;
using interfaz;
using System.Data.SqlClient;

namespace persistencia
{
    public class UsuarioDAO : UsuarioInterfaz 
    {
        Conexion con;

        public UsuarioDAO(Conexion cn)
        {
            con = cn;
        }


        public Usuario iniciarSesion(Usuario usuario)
        {
            Usuario objUsuario = Usuario.getInstance();
            String sentenciaSQL = " select id from usuario  where usuario = '" + usuario.User + "' and clave = '" + usuario.Clave + "'; ";
            try
            {
                SqlDataReader resultado = con.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    objUsuario.Id = resultado.GetInt32(0);
                }
                resultado.Close();

            }
            catch (Exception err)
            {
                System.Console.WriteLine("ERROR -> persistencia -> UsuarioDAO -> iniciarSesion " + err + "\n");
                throw err;
            }
            return objUsuario;
        }





















    }//no tocar esta llave xD
}
