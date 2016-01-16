using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class SubCategoria
    {
        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        private Categoria categoria;

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
