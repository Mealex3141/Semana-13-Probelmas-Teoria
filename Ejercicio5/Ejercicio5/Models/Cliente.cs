using System;
using System.Text.RegularExpressions;

namespace Ejercicio5.Models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Cliente() { }

        public Cliente(string nombre, string correo, string telefono)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }

        public bool EsValido(out string error)
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                error = "El nombre es obligatorio.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Correo) || !Regex.IsMatch(Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                error = "Correo no válido.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Telefono) || !Regex.IsMatch(Telefono, @"^[0-9\-\+\s]{6,20}$"))
            {
                error = "Teléfono no válido.";
                return false;
            }
            error = null;
            return true;
        }
    }
}
