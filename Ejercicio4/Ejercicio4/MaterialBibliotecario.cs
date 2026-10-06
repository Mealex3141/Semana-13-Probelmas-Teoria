using System;

namespace Ejercicio4
{
    public abstract class MaterialBibliotecario
    {
        public string Titulo { get; set; }
        public string Codigo { get; set; }
        public int Ano { get; set; }

        public MaterialBibliotecario(string titulo, string codigo, int ano)
        {
            Titulo = titulo;
            Codigo = codigo;
            Ano = ano;
        }

        public abstract string MostrarInfo();

        public override string ToString()
        {
            return $"{GetType().Name}: {Titulo} ({Codigo})";
        }
    }

    public class Libro : MaterialBibliotecario
    {
        public string Autor { get; set; }

        public Libro(string titulo, string codigo, int ano, string autor)
            : base(titulo, codigo, ano)
        {
            Autor = autor;
        }

        public override string MostrarInfo()
        {
            return $"Tipo: Libro\r\nTítulo: {Titulo}\r\nCódigo: {Codigo}\r\nAño: {Ano}\r\nAutor: {Autor}";
        }
    }

    public class Revista : MaterialBibliotecario
    {
        public int Numero { get; set; }

        public Revista(string titulo, string codigo, int ano, int numero)
            : base(titulo, codigo, ano)
        {
            Numero = numero;
        }

        public override string MostrarInfo()
        {
            return $"Tipo: Revista\r\nTítulo: {Titulo}\r\nCódigo: {Codigo}\r\nAño: {Ano}\r\nNúmero: {Numero}";
        }
    }

    public class DVD : MaterialBibliotecario
    {
        public int Duracion { get; set; } // minutos

        public DVD(string titulo, string codigo, int ano, int duracion)
            : base(titulo, codigo, ano)
        {
            Duracion = duracion;
        }

        public override string MostrarInfo()
        {
            return $"Tipo: DVD\r\nTítulo: {Titulo}\r\nCódigo: {Codigo}\r\nAño: {Ano}\r\nDuración: {Duracion} minutos";
        }
    }
}
