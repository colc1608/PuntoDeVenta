using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Juridico
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String razonSocial;

        public String RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        private String ruc;

        public String Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        private String nombreContacto;

        public String NombreContacto
        {
            get { return nombreContacto; }
            set { nombreContacto = value; }
        }
    }
}
