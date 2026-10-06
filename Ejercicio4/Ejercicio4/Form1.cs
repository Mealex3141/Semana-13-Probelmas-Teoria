using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        private List<MaterialBibliotecario> materiales = new List<MaterialBibliotecario>();

        public Form1()
        {
            InitializeComponent();

            // Attach events
            this.cmbTipo.SelectedIndexChanged += CmbTipo_SelectedIndexChanged;
            this.btnAgregar.Click += BtnAgregar_Click;
            this.btnBuscar.Click += BtnBuscar_Click;
            this.lstMateriales.DoubleClick += LstMateriales_DoubleClick;

            // Set default selection
            if (this.cmbTipo.Items.Count > 0) this.cmbTipo.SelectedIndex = 0;
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipo = cmbTipo.SelectedItem as string;
            switch (tipo)
            {
                case "Libro":
                    lblExtra.Text = "Autor:";
                    break;
                case "Revista":
                    lblExtra.Text = "Número:";
                    break;
                case "DVD":
                    lblExtra.Text = "Duración (min):";
                    break;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                var titulo = txtTitulo.Text.Trim();
                var codigo = txtCodigo.Text.Trim();
                var anoText = txtAno.Text.Trim();
                var extra = txtExtra.Text.Trim();

                if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(anoText) || string.IsNullOrEmpty(extra))
                {
                    MessageBox.Show("Todos los campos son requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(anoText, out int ano))
                {
                    MessageBox.Show("Año debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int anoMin = 1900;
                int anoMax = DateTime.Now.Year;
                if (ano < anoMin || ano > anoMax)
                {
                    MessageBox.Show($"Año debe estar entre {anoMin} y {anoMax}.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tipo = cmbTipo.SelectedItem as string;
                MaterialBibliotecario m = null;

                if (tipo == "Libro")
                {
                    // Autor (texto)
                    m = new Libro(titulo, codigo, ano, extra);
                }
                else if (tipo == "Revista")
                {
                    if (!int.TryParse(extra, out int numero) || numero <= 0)
                    {
                        MessageBox.Show("Número debe ser un entero positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    m = new Revista(titulo, codigo, ano, numero);
                }
                else if (tipo == "DVD")
                {
                    if (!int.TryParse(extra, out int duracion) || duracion <= 0)
                    {
                        MessageBox.Show("Duración debe ser un entero positivo (minutos).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    m = new DVD(titulo, codigo, ano, duracion);
                }

                if (m != null)
                {
                    materiales.Add(m);
                    lstMateriales.Items.Add(m);
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtTitulo.Text = "";
            txtCodigo.Text = "";
            txtAno.Text = "";
            txtExtra.Text = "";
            if (cmbTipo.Items.Count > 0) cmbTipo.SelectedIndex = 0;
            txtTitulo.Focus();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var term = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(term))
            {
                MessageBox.Show("Ingrese un título para buscar.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Buscar por título (insensible a mayúsculas)
            for (int i = 0; i < materiales.Count; i++)
            {
                if (string.Equals(materiales[i].Titulo, term, StringComparison.OrdinalIgnoreCase))
                {
                    lstMateriales.SelectedIndex = i;
                    MessageBox.Show(materiales[i].MostrarInfo(), "Material encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("No se encontró ningún material con ese título.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LstMateriales_DoubleClick(object sender, EventArgs e)
        {
            if (lstMateriales.SelectedIndex >= 0 && lstMateriales.SelectedIndex < materiales.Count)
            {
                var m = materiales[lstMateriales.SelectedIndex];
                MessageBox.Show(m.MostrarInfo(), "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
