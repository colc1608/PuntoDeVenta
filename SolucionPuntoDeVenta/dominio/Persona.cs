using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Persona
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private String correo;

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private String telefono;

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
