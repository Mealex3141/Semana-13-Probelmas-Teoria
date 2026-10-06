namespace Ejercicio5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupCliente;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.TextBox txtClienteCorreo;
        private System.Windows.Forms.TextBox txtClienteTelefono;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.GroupBox groupProducto;
        private System.Windows.Forms.TextBox txtProductoNombre;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.GroupBox groupFactura;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAgregarAFactura;
        private System.Windows.Forms.ListBox lstFactura;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupCliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteTelefono = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.groupProducto = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.groupFactura = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarAFactura = new System.Windows.Forms.Button();
            this.lstFactura = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.groupCliente.SuspendLayout();
            this.groupProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.groupFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCliente
            // 
            this.groupCliente.Controls.Add(this.label1);
            this.groupCliente.Controls.Add(this.txtClienteNombre);
            this.groupCliente.Controls.Add(this.label2);
            this.groupCliente.Controls.Add(this.txtClienteCorreo);
            this.groupCliente.Controls.Add(this.label3);
            this.groupCliente.Controls.Add(this.txtClienteTelefono);
            this.groupCliente.Controls.Add(this.btnAgregarCliente);
            this.groupCliente.Location = new System.Drawing.Point(10, 53);
            this.groupCliente.Name = "groupCliente";
            this.groupCliente.Size = new System.Drawing.Size(420, 150);
            this.groupCliente.TabIndex = 0;
            this.groupCliente.TabStop = false;
            this.groupCliente.Text = "Registrar Cliente";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(80, 22);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(320, 22);
            this.txtClienteNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo:";
            // 
            // txtClienteCorreo
            // 
            this.txtClienteCorreo.Location = new System.Drawing.Point(80, 52);
            this.txtClienteCorreo.Name = "txtClienteCorreo";
            this.txtClienteCorreo.Size = new System.Drawing.Size(320, 22);
            this.txtClienteCorreo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono:";
            // 
            // txtClienteTelefono
            // 
            this.txtClienteTelefono.Location = new System.Drawing.Point(80, 82);
            this.txtClienteTelefono.Name = "txtClienteTelefono";
            this.txtClienteTelefono.Size = new System.Drawing.Size(320, 22);
            this.txtClienteTelefono.TabIndex = 5;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(300, 110);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(100, 25);
            this.btnAgregarCliente.TabIndex = 6;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // groupProducto
            // 
            this.groupProducto.Controls.Add(this.label4);
            this.groupProducto.Controls.Add(this.txtProductoNombre);
            this.groupProducto.Controls.Add(this.label5);
            this.groupProducto.Controls.Add(this.numPrecio);
            this.groupProducto.Controls.Add(this.label6);
            this.groupProducto.Controls.Add(this.numStock);
            this.groupProducto.Controls.Add(this.btnAgregarProducto);
            this.groupProducto.Location = new System.Drawing.Point(10, 245);
            this.groupProducto.Name = "groupProducto";
            this.groupProducto.Size = new System.Drawing.Size(420, 150);
            this.groupProducto.TabIndex = 1;
            this.groupProducto.TabStop = false;
            this.groupProducto.Text = "Registrar Producto";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Location = new System.Drawing.Point(80, 22);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.Size = new System.Drawing.Size(320, 22);
            this.txtProductoNombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio:";
            // 
            // numPrecio
            // 
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(80, 52);
            this.numPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 22);
            this.numPrecio.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(220, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Stock:";
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(270, 52);
            this.numStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(60, 22);
            this.numStock.TabIndex = 5;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(300, 110);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(100, 25);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // groupFactura
            // 
            this.groupFactura.Controls.Add(this.label7);
            this.groupFactura.Controls.Add(this.cmbClientes);
            this.groupFactura.Controls.Add(this.cmbProductos);
            this.groupFactura.Controls.Add(this.numCantidad);
            this.groupFactura.Controls.Add(this.btnAgregarAFactura);
            this.groupFactura.Controls.Add(this.lstFactura);
            this.groupFactura.Controls.Add(this.lblTotal);
            this.groupFactura.Controls.Add(this.btnCrearFactura);
            this.groupFactura.Location = new System.Drawing.Point(440, 10);
            this.groupFactura.Name = "groupFactura";
            this.groupFactura.Size = new System.Drawing.Size(440, 420);
            this.groupFactura.TabIndex = 2;
            this.groupFactura.TabStop = false;
            this.groupFactura.Text = "Crear Factura";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Location = new System.Drawing.Point(70, 22);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(350, 24);
            this.cmbClientes.TabIndex = 1;
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.Location = new System.Drawing.Point(10, 55);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(260, 24);
            this.cmbProductos.TabIndex = 2;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(280, 55);
            this.numCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(60, 22);
            this.numCantidad.TabIndex = 3;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarAFactura
            // 
            this.btnAgregarAFactura.Location = new System.Drawing.Point(350, 52);
            this.btnAgregarAFactura.Name = "btnAgregarAFactura";
            this.btnAgregarAFactura.Size = new System.Drawing.Size(70, 23);
            this.btnAgregarAFactura.TabIndex = 4;
            this.btnAgregarAFactura.Text = "Agregar";
            this.btnAgregarAFactura.Click += new System.EventHandler(this.btnAgregarAFactura_Click);
            // 
            // lstFactura
            // 
            this.lstFactura.ItemHeight = 16;
            this.lstFactura.Location = new System.Drawing.Point(10, 90);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(410, 260);
            this.lstFactura.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(10, 360);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total: 0,00 €";
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Location = new System.Drawing.Point(300, 390);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(120, 25);
            this.btnCrearFactura.TabIndex = 7;
            this.btnCrearFactura.Text = "Crear Factura";
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 445);
            this.Controls.Add(this.groupCliente);
            this.Controls.Add(this.groupProducto);
            this.Controls.Add(this.groupFactura);
            this.Name = "Form1";
            this.Text = "Sistema de Facturación";
            this.groupCliente.ResumeLayout(false);
            this.groupCliente.PerformLayout();
            this.groupProducto.ResumeLayout(false);
            this.groupProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.groupFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        
    }
}

