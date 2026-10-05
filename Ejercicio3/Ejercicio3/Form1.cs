using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Electrodomesticos : Form
    {
        List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();
        List<Cliente> clientes = new List<Cliente>();

        public Electrodomesticos()
        {
            InitializeComponent();

            // Marcas
            cmbMarca.Items.Add("Samsung");
            cmbMarca.Items.Add("LG");
            cmbMarca.Items.Add("Sony");
            cmbMarca.Items.Add("Whirlpool");
            cmbMarca.Items.Add("Mabe");

            // La fecha de compra
            dtpFechaCompra.MinDate = DateTime.Today;
            dtpFechaCompra.MaxDate = DateTime.Today;
            dtpFechaCompra.Value = DateTime.Today;
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            // Verificar campos obligatorios
            if (txtCodigo.Text == "" ||
                txtNombreProducto.Text == "" ||
                cmbMarca.SelectedIndex == -1 ||
                txtPrecioCosto.Text == "" ||
                txtPrecioVenta.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            // Validar precio de costo
            double precioCosto;

            if (!double.TryParse(txtPrecioCosto.Text, out precioCosto))
            {
                MessageBox.Show("El precio de costo debe ser un número válido.");
                txtPrecioCosto.Focus();
                return;
            }

            // Validar que el precio de costo sea mayor que cero
            if (precioCosto <= 0)
            {
                MessageBox.Show("El precio de costo debe ser mayor que cero.");
                txtPrecioCosto.Focus();
                return;
            }

            // Validar precio de venta
            double precioVenta;

            if (!double.TryParse(txtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("El precio de venta debe ser un número válido.");
                txtPrecioVenta.Focus();
                return;
            }

            // Validar que el precio de venta sea mayor que cero
            if (precioVenta <= 0)
            {
                MessageBox.Show("El precio de venta debe ser mayor que cero.");
                txtPrecioVenta.Focus();
                return;
            }

            // Calcular el precio mínimo con una ganancia del 20%
            double precioMinimo = precioCosto * 1.20;

            // Verificar ganancia mínima del 20%
            if (precioVenta < precioMinimo)
            {
                MessageBox.Show(
                    "El precio de venta debe ser al menos un 20% mayor que el precio de costo."
                );

                txtPrecioVenta.Focus();
                return;
            }

            // Verificar que la fecha sea la fecha actual
            if (dtpFechaCompra.Value.Date != DateTime.Today)
            {
                MessageBox.Show("La fecha de compra debe ser la fecha de hoy.");
                dtpFechaCompra.Focus();
                return;
            }

            // Crear objeto Electrodomestico
            Electrodomestico producto = new Electrodomestico();

            producto.Codigo1 = txtCodigo.Text;
            producto.Nombre1 = txtNombreProducto.Text;
            producto.Marca1 = cmbMarca.SelectedItem.ToString();
            producto.PrecioCosto1 = precioCosto;
            producto.PrecioVenta1 = precioVenta;
            producto.FechaCompra1 = dtpFechaCompra.Value;

            // Agregar el objeto a la lista
            electrodomesticos.Add(producto);

            MessageBox.Show("Electrodoméstico registrado correctamente.");
        }

        private void btnAgregarCorreo_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            // Verificar que no esté vacío
            if (correo == "")
            {
                MessageBox.Show("Ingrese un correo electrónico.");
                txtCorreo.Focus();
                return;
            }

            // Verificar que tenga un formato básico de correo
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                txtCorreo.Focus();
                return;
            }

            // Agregar el correo a la lista visual
            lstCorreos.Items.Add(correo);

            // Limpiar el campo para ingresar otro correo
            txtCorreo.Clear();
            txtCorreo.Focus();
        }
    }
}