using System;

namespace Ejercicio5.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }

        public Producto() { }

        public Producto(string nombre, decimal precioUnitario, int stock)
        {
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Stock = stock;
        }

        public bool EsValido(out string error)
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                error = "El nombre del producto es obligatorio.";
                return false;
            }
            if (PrecioUnitario < 0)
            {
                error = "El precio no puede ser negativo.";
                return false;
            }
            if (Stock < 0)
            {
                error = "El stock no puede ser negativo.";
                return false;
            }
            error = null;
            return true;
        }

        public override string ToString()
        {
            return $"{Nombre} - {PrecioUnitario:C} (Stock: {Stock})";
        }
    }
}
