using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Empleado
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string cargo;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        private Area area;

        public Area Area
        {
            get { return area; }
            set { area = value; }
        }

        

    }
}
