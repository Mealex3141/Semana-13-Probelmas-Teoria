using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio5.Models
{
    public class Factura
    {
        public Cliente Cliente { get; set; }
        public List<DetalleFactura> Detalles { get; } = new List<DetalleFactura>();

        public Factura() { }

        public void AgregarProducto(Producto producto, int cantidad)
        {
            var existente = Detalles.FirstOrDefault(d => d.Producto == producto);
            if (existente != null)
            {
                existente.Cantidad += cantidad;
            }
            else
            {
                Detalles.Add(new DetalleFactura { Producto = producto, Cantidad = cantidad });
            }
        }

        public decimal CalcularTotal()
        {
            return Detalles.Sum(d => d.Producto.PrecioUnitario * d.Cantidad);
        }

        public void AplicarFactura()
        {
            foreach (var d in Detalles)
            {
                d.Producto.Stock -= d.Cantidad;
            }
        }
    }

    public class DetalleFactura
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public override string ToString()
        {
            return $"{Producto.Nombre} x{Cantidad} = {Producto.PrecioUnitario * Cantidad:C}";
        }
    }
}
