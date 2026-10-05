using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    internal class Libro
    {
        private string ISBN;
        private string Titulo;
        private string Autor;
        private int NumeroPaginas;

        public string ISBN1
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        public string Titulo1
        {
            get { return Titulo; }
            set { Titulo = value; }
        }

        public string Autor1
        {
            get { return Autor; }
            set { Autor = value; }
        }

        public int NumeroPaginas1
        {
            get { return NumeroPaginas; }
            set { NumeroPaginas = value; }
        }

        public override string ToString()
        {
            return "El libro con ISBN " + ISBN +
                   " creado por el autor " + Autor +
                   " tiene " + NumeroPaginas + " páginas";
        }
    }
}
