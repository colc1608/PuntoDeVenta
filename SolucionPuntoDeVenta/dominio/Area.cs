using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Area
    {
        private int id;
        private String descripcion;
        private String estado;

        


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }




}
