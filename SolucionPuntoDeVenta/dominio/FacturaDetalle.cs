using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class FacturaDetalle
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }


        private Producto producto;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        
        private decimal precioVenta;

        public decimal PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
