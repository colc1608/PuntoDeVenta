using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Factura
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Empleado empleado;

        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }


        private Juridico juridico;

        public Juridico Juridico
        {
            get { return juridico; }
            set { juridico = value; }
        }

        
        private int numeroSerie;

        public int NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }
        private int numeroCorrelativo;

        public int NumeroCorrelativo
        {
            get { return numeroCorrelativo; }
            set { numeroCorrelativo = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private decimal subTotal;

        public decimal SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        private decimal igv;

        public decimal Igv
        {
            get { return igv; }
            set { igv = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }




    }

}
