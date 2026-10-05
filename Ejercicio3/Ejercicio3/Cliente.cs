using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    internal class Cliente
    {
        private string Dui;
        private string Nombre;
        private int Edad;
        private string Telefono;
        private List<string> Correos;
        private string TipoPago;

        public Cliente()
        {
            Correos = new List<string>();
        }

        public string Dui1
        {
            get { return Dui; }
            set { Dui = value; }
        }

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public int Edad1
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public string Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        public List<string> Correos1
        {
            get { return Correos; }
            set { Correos = value; }
        }

        public string TipoPago1
        {
            get { return TipoPago; }
            set { TipoPago = value; }
        }

        public override string ToString()
        {
            return Dui + " - " + Nombre +
                   " - Edad: " + Edad +
                   " - Teléfono: " + Telefono +
                   " - Tipo de pago: " + TipoPago;
        }
    }
}