namespace Ejercicio3
{
    partial class Electrodomesticos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRegistroComercial = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNombreProducto = new Label();
            txtNombreProducto = new TextBox();
            lblMarca = new Label();
            txtPrecioCosto = new TextBox();
            cmbMarca = new ComboBox();
            lblPrecioCosto = new Label();
            lblPrecioVenta = new Label();
            txtPrecioVenta = new TextBox();
            lblFechaCompra = new Label();
            dtpFechaCompra = new DateTimePicker();
            btnRegistrarProducto = new Button();
            btnLimpiarProducto = new Button();
            lbldaclients = new Label();
            lblDui = new Label();
            txtDui = new TextBox();
            lblNombreCliente = new Label();
            txtNombreCliente = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            btnAgregarCorreo = new Button();
            label1 = new Label();
            lstCorreos = new ListBox();
            lblTipoPago = new Label();
            rdbContado = new RadioButton();
            rdbCredito = new RadioButton();
            btnRegistrarCliente = new Button();
            btnLimpiarCliente = new Button();
            dgvClientes = new DataGridView();
            dgvElectrodomesticos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            colVenta = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvElectrodomesticos).BeginInit();
            SuspendLayout();
            // 
            // lblRegistroComercial
            // 
            lblRegistroComercial.AutoSize = true;
            lblRegistroComercial.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroComercial.Location = new Point(7, 12);
            lblRegistroComercial.Name = "lblRegistroComercial";
            lblRegistroComercial.Size = new Size(221, 25);
            lblRegistroComercial.TabIndex = 0;
            lblRegistroComercial.Text = "Datos Electrodomestico";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(14, 57);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(62, 20);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(72, 53);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(122, 27);
            txtCodigo.TabIndex = 2;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreProducto.Location = new Point(14, 96);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(71, 20);
            lblNombreProducto.TabIndex = 3;
            lblNombreProducto.Text = "Nombre:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(80, 92);
            txtNombreProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(114, 27);
            txtNombreProducto.TabIndex = 4;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(14, 135);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(56, 20);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "Marca:";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(129, 169);
            txtPrecioCosto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(65, 27);
            txtPrecioCosto.TabIndex = 6;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(70, 131);
            cmbMarca.Margin = new Padding(3, 4, 3, 4);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(124, 28);
            cmbMarca.TabIndex = 7;
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioCosto.Location = new Point(14, 173);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(119, 20);
            lblPrecioCosto.TabIndex = 8;
            lblPrecioCosto.Text = "Precio de costo:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioVenta.Location = new Point(14, 213);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(120, 20);
            lblPrecioVenta.TabIndex = 9;
            lblPrecioVenta.Text = "Precio de venta:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(129, 208);
            txtPrecioVenta.Margin = new Padding(3, 4, 3, 4);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(65, 27);
            txtPrecioVenta.TabIndex = 10;
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaCompra.Location = new Point(14, 248);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(131, 20);
            lblFechaCompra.TabIndex = 11;
            lblFechaCompra.Text = "Fecha de compra:";
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Location = new Point(14, 272);
            dtpFechaCompra.Margin = new Padding(3, 4, 3, 4);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(180, 27);
            dtpFechaCompra.TabIndex = 12;
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarProducto.Location = new Point(14, 323);
            btnRegistrarProducto.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Size = new Size(74, 47);
            btnRegistrarProducto.TabIndex = 13;
            btnRegistrarProducto.Text = "Registar";
            btnRegistrarProducto.UseVisualStyleBackColor = true;
            btnRegistrarProducto.Click += btnRegistrarProducto_Click;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarProducto.Location = new Point(120, 323);
            btnLimpiarProducto.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(74, 47);
            btnLimpiarProducto.TabIndex = 14;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            // 
            // lbldaclients
            // 
            lbldaclients.AutoSize = true;
            lbldaclients.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldaclients.Location = new Point(344, 12);
            lbldaclients.Name = "lbldaclients";
            lbldaclients.Size = new Size(163, 25);
            lbldaclients.TabIndex = 15;
            lbldaclients.Text = "Datos Del Cliente";
            // 
            // lblDui
            // 
            lblDui.AutoSize = true;
            lblDui.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDui.Location = new Point(243, 57);
            lblDui.Name = "lblDui";
            lblDui.Size = new Size(37, 20);
            lblDui.TabIndex = 16;
            lblDui.Text = "Dui:";
            // 
            // txtDui
            // 
            txtDui.Location = new Point(280, 53);
            txtDui.Margin = new Padding(3, 4, 3, 4);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(180, 27);
            txtDui.TabIndex = 17;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreCliente.Location = new Point(243, 96);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(71, 20);
            lblNombreCliente.TabIndex = 18;
            lblNombreCliente.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(314, 92);
            txtNombreCliente.Margin = new Padding(3, 4, 3, 4);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(146, 27);
            txtNombreCliente.TabIndex = 19;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(243, 135);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(47, 20);
            lblEdad.TabIndex = 20;
            lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(301, 131);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(159, 27);
            txtEdad.TabIndex = 21;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(243, 173);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 20);
            lblTelefono.TabIndex = 22;
            lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(314, 169);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(146, 27);
            txtTelefono.TabIndex = 23;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(243, 213);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(60, 20);
            lblCorreo.TabIndex = 24;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(305, 208);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(155, 27);
            txtCorreo.TabIndex = 25;
            // 
            // btnAgregarCorreo
            // 
            btnAgregarCorreo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCorreo.Location = new Point(243, 248);
            btnAgregarCorreo.Margin = new Padding(3, 4, 3, 4);
            btnAgregarCorreo.Name = "btnAgregarCorreo";
            btnAgregarCorreo.Size = new Size(217, 37);
            btnAgregarCorreo.TabIndex = 26;
            btnAgregarCorreo.Text = "Agregar";
            btnAgregarCorreo.UseVisualStyleBackColor = true;
            btnAgregarCorreo.Click += btnAgregarCorreo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 289);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 27;
            label1.Text = "Correo registrado:";
            // 
            // lstCorreos
            // 
            lstCorreos.FormattingEnabled = true;
            lstCorreos.Location = new Point(243, 313);
            lstCorreos.Margin = new Padding(3, 4, 3, 4);
            lstCorreos.Name = "lstCorreos";
            lstCorreos.Size = new Size(217, 64);
            lstCorreos.TabIndex = 28;
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoPago.Location = new Point(479, 53);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(104, 20);
            lblTipoPago.TabIndex = 29;
            lblTipoPago.Text = "Tipo de pago:";
            // 
            // rdbContado
            // 
            rdbContado.AutoSize = true;
            rdbContado.Location = new Point(479, 97);
            rdbContado.Margin = new Padding(3, 4, 3, 4);
            rdbContado.Name = "rdbContado";
            rdbContado.Size = new Size(87, 24);
            rdbContado.TabIndex = 30;
            rdbContado.TabStop = true;
            rdbContado.Text = "Contado";
            rdbContado.UseVisualStyleBackColor = true;
            // 
            // rdbCredito
            // 
            rdbCredito.AutoSize = true;
            rdbCredito.Location = new Point(479, 151);
            rdbCredito.Margin = new Padding(3, 4, 3, 4);
            rdbCredito.Name = "rdbCredito";
            rdbCredito.Size = new Size(79, 24);
            rdbCredito.TabIndex = 31;
            rdbCredito.TabStop = true;
            rdbCredito.Text = "Credito";
            rdbCredito.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCliente.Location = new Point(479, 208);
            btnRegistrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(93, 69);
            btnRegistrarCliente.TabIndex = 32;
            btnRegistrarCliente.Text = "Registrar cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCliente
            // 
            btnLimpiarCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarCliente.Location = new Point(479, 309);
            btnLimpiarCliente.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarCliente.Name = "btnLimpiarCliente";
            btnLimpiarCliente.Size = new Size(93, 69);
            btnLimpiarCliente.TabIndex = 33;
            btnLimpiarCliente.Text = "Limpiar";
            btnLimpiarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(583, 16);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(227, 367);
            dgvClientes.TabIndex = 34;
            // 
            // dgvElectrodomesticos
            // 
            dgvElectrodomesticos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElectrodomesticos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colMarca, colCosto, colVenta, colFecha });
            dgvElectrodomesticos.Location = new Point(7, 397);
            dgvElectrodomesticos.Margin = new Padding(3, 4, 3, 4);
            dgvElectrodomesticos.Name = "dgvElectrodomesticos";
            dgvElectrodomesticos.RowHeadersWidth = 51;
            dgvElectrodomesticos.Size = new Size(803, 287);
            dgvElectrodomesticos.TabIndex = 35;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.Width = 125;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "Marca";
            colMarca.MinimumWidth = 6;
            colMarca.Name = "colMarca";
            colMarca.Width = 125;
            // 
            // colCosto
            // 
            colCosto.HeaderText = "Precio de costo";
            colCosto.MinimumWidth = 6;
            colCosto.Name = "colCosto";
            colCosto.Width = 125;
            // 
            // colVenta
            // 
            colVenta.HeaderText = "Precio de venta";
            colVenta.MinimumWidth = 6;
            colVenta.Name = "colVenta";
            colVenta.Width = 125;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha de compra";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.Width = 125;
            // 
            // Electrodomesticos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 700);
            Controls.Add(dgvElectrodomesticos);
            Controls.Add(dgvClientes);
            Controls.Add(btnLimpiarCliente);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(rdbCredito);
            Controls.Add(rdbContado);
            Controls.Add(lblTipoPago);
            Controls.Add(lstCorreos);
            Controls.Add(label1);
            Controls.Add(btnAgregarCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(txtDui);
            Controls.Add(lblDui);
            Controls.Add(lbldaclients);
            Controls.Add(btnLimpiarProducto);
            Controls.Add(btnRegistrarProducto);
            Controls.Add(dtpFechaCompra);
            Controls.Add(lblFechaCompra);
            Controls.Add(txtPrecioVenta);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCosto);
            Controls.Add(cmbMarca);
            Controls.Add(txtPrecioCosto);
            Controls.Add(lblMarca);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(lblRegistroComercial);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Electrodomesticos";
            Text = "Registro Comercial";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvElectrodomesticos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroComercial;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
        private Label lblMarca;
        private TextBox txtPrecioCosto;
        private ComboBox cmbMarca;
        private Label lblPrecioCosto;
        private Label lblPrecioVenta;
        private TextBox txtPrecioVenta;
        private Label lblFechaCompra;
        private DateTimePicker dtpFechaCompra;
        private Button btnRegistrarProducto;
        private Button btnLimpiarProducto;
        private Label lbldaclients;
        private Label lblDui;
        private TextBox txtDui;
        private Label lblNombreCliente;
        private TextBox txtNombreCliente;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Button btnAgregarCorreo;
        private Label label1;
        private ListBox lstCorreos;
        private Label lblTipoPago;
        private RadioButton rdbContado;
        private RadioButton rdbCredito;
        private Button btnRegistrarCliente;
        private Button btnLimpiarCliente;
        private DataGridView dgvClientes;
        private DataGridView dgvElectrodomesticos;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colCosto;
        private DataGridViewTextBoxColumn colVenta;
        private DataGridViewTextBoxColumn colFecha;
    }
}
