using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class UnidadDeMedida
    {
        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private String abreviado;

        public String Abreviado
        {
            get { return abreviado; }
            set { abreviado = value; }
        }
        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
