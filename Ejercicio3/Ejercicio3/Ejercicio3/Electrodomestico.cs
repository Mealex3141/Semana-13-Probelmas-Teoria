using System;

namespace Ejercicio3
{
    public class Electrodomestico
    {
        private string Codigo;
        private string Nombre;
        private string Marca;
        private double PrecioCosto;
        private double PrecioVenta;
        private DateTime FechaCompra;

        public string Codigo1
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string Marca1
        {
            get { return Marca; }
            set { Marca = value; }
        }

        public double PrecioCosto1
        {
            get { return PrecioCosto; }
            set { PrecioCosto = value; }
        }

        public double PrecioVenta1
        {
            get { return PrecioVenta; }
            set { PrecioVenta = value; }
        }

        public DateTime FechaCompra1
        {
            get { return FechaCompra; }
            set { FechaCompra = value; }
        }

        public override string ToString()
        {
            return Codigo + " - " + Nombre +
                   " - " + Marca +
                   " - $" + PrecioVenta;
        }
    }
}