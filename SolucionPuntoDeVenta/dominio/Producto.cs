using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Producto
    {
        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        private Marca marca;

        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private SubCategoria subCategoria;

        public SubCategoria SubCategoria
        {
            get { return subCategoria; }
            set { subCategoria = value; }
        }
        private UnidadDeMedida unidadDeMedida;

        public UnidadDeMedida UnidadDeMedida
        {
            get { return unidadDeMedida; }
            set { unidadDeMedida = value; }
        }
        private Decimal precioCompra;

        public Decimal PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }
        private Decimal precioVenta;

        public Decimal PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
        private Int32 stock;

        public Int32 Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private String imagen;

        public String Imagen
        {
            get { return imagen; }
            set { imagen = value; }
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
