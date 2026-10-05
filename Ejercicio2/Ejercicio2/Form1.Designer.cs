namespace Ejercicio2
{
    partial class Libros
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
            lblTitulo = new Label();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblTituloLibro = new Label();
            txtTitulo = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblPaginas = new Label();
            txtPaginas = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            dgvLibros = new DataGridView();
            colISBN = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colAutor = new DataGridViewTextBoxColumn();
            colPaginas = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(67, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(160, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE LIBROS";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(13, 58);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 17);
            lblISBN.TabIndex = 1;
            lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(59, 57);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(206, 23);
            txtISBN.TabIndex = 2;
            // 
            // lblTituloLibro
            // 
            lblTituloLibro.AutoSize = true;
            lblTituloLibro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLibro.Location = new Point(13, 95);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(49, 17);
            lblTituloLibro.TabIndex = 3;
            lblTituloLibro.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(67, 94);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(198, 23);
            txtTitulo.TabIndex = 4;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(12, 131);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(48, 17);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(66, 130);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(198, 23);
            txtAutor.TabIndex = 6;
            // 
            // lblPaginas
            // 
            lblPaginas.AutoSize = true;
            lblPaginas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaginas.Location = new Point(13, 165);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(133, 17);
            lblPaginas.TabIndex = 7;
            lblPaginas.Text = "Numero de paginas:";
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(152, 164);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(112, 23);
            txtPaginas.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(13, 209);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(89, 39);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(176, 209);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(89, 39);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { colISBN, colTitulo, colAutor, colPaginas });
            dgvLibros.Location = new Point(12, 273);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(442, 150);
            dgvLibros.TabIndex = 11;
            // 
            // colISBN
            // 
            colISBN.HeaderText = "ISBN";
            colISBN.Name = "colISBN";
            // 
            // colTitulo
            // 
            colTitulo.HeaderText = "Título";
            colTitulo.Name = "colTitulo";
            // 
            // colAutor
            // 
            colAutor.HeaderText = "Autor";
            colAutor.Name = "colAutor";
            // 
            // colPaginas
            // 
            colPaginas.HeaderText = "Número de páginas";
            colPaginas.Name = "colPaginas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagen_2026_10_05_000257382_removebg_preview;
            pictureBox1.Location = new Point(271, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Libros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 435);
            Controls.Add(pictureBox1);
            Controls.Add(dgvLibros);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPaginas);
            Controls.Add(lblPaginas);
            Controls.Add(txtAutor);
            Controls.Add(lblAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblTituloLibro);
            Controls.Add(txtISBN);
            Controls.Add(lblISBN);
            Controls.Add(lblTitulo);
            Name = "Libros";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblISBN;
        private TextBox txtISBN;
        private Label lblTituloLibro;
        private TextBox txtTitulo;
        private Label lblAutor;
        private TextBox txtAutor;
        private Label lblPaginas;
        private TextBox txtPaginas;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn colISBN;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colAutor;
        private DataGridViewTextBoxColumn colPaginas;
        private PictureBox pictureBox1;
    }
}
