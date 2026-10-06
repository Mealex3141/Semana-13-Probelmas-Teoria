using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio5.Models;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        private List<Producto> productos = new List<Producto>();
        private Factura factura = new Factura();
        public Form1()
        {
            InitializeComponent();
            // Inicializar listas y referencias
            RefreshClientes();
            RefreshProductos();
            RefreshFacturaDisplay();
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var nombre = txtClienteNombre.Text.Trim();
            var correo = txtClienteCorreo.Text.Trim();
            var telefono = txtClienteTelefono.Text.Trim();
            var c = new Cliente(nombre, correo, telefono);
            if (!c.EsValido(out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clientes.Add(c);
            RefreshClientes();
            MessageBox.Show("Cliente agregado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtClienteNombre.Clear(); txtClienteCorreo.Clear(); txtClienteTelefono.Clear();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var nombre = txtProductoNombre.Text.Trim();
            var precio = numPrecio.Value;
            var stock = (int)numStock.Value;
            var p = new Producto(nombre, precio, stock);
            if (!p.EsValido(out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            productos.Add(p);
            RefreshProductos();
            MessageBox.Show("Producto agregado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtProductoNombre.Clear(); numPrecio.Value = 0; numStock.Value = 0;
        }
        private void btnAgregarAFactura_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var producto = (Producto)cmbProductos.SelectedItem;
            var cantidad = (int)numCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("Cantidad debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cantidad > producto.Stock)
            {
                MessageBox.Show("Cantidad mayor al stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbClientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente para la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            factura.Cliente = (Cliente)cmbClientes.SelectedItem;
            factura.AgregarProducto(producto, cantidad);
            RefreshFacturaDisplay();
        }
        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            if (factura.Cliente == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!factura.Detalles.Any())
            {
                MessageBox.Show("La factura no tiene productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            factura.AplicarFactura();
            var total = factura.CalcularTotal();
            MessageBox.Show($"Factura creada. Total: {total:C}", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            factura = new Factura();
            RefreshFacturaDisplay();
            RefreshProductos();
        }
        private void RefreshClientes()
        {
            var sel = cmbClientes.SelectedItem;
            cmbClientes.Items.Clear();
            foreach (var c in clientes)
                cmbClientes.Items.Add(c);
            cmbClientes.DisplayMember = "Nombre";
            if (sel != null && cmbClientes.Items.Contains(sel))
                cmbClientes.SelectedItem = sel;
        }
        private void RefreshProductos()
        {
            var sel = cmbProductos.SelectedItem;
            cmbProductos.Items.Clear();
            foreach (var p in productos)
                cmbProductos.Items.Add(p);
            cmbProductos.DisplayMember = "Nombre";
            if (sel != null && cmbProductos.Items.Contains(sel))
                cmbProductos.SelectedItem = sel;
        }
        private void RefreshFacturaDisplay()
        {
            lstFactura.Items.Clear();
            foreach (var d in factura.Detalles)
                lstFactura.Items.Add(d.ToString());
            lblTotal.Text = $"Total: {factura.CalcularTotal():C}";
        }
    }
}
