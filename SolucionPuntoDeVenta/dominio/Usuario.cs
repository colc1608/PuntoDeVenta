using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Usuario
    {
        //SINGLETON
        private static Usuario usuario;
        public static Usuario getInstance()
        {
            if (usuario == null)
                usuario = new Usuario();
            return usuario;
        }


        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        private String user;

        public String User
        {
            get { return user; }
            set { user = value; }
        }
        private String clave;

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private int intentos;

        public int Intentos
        {
            get { return intentos; }
            set { intentos = value; }
        }
        private string tipoUsuario;

        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        
    }
    
}
