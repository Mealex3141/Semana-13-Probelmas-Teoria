namespace Ejercicio2
{
    public partial class Libros : Form
    {
        //se guardan los libro
        List<Libro> libros = new List<Libro>();

        public Libros()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text == "" || txtTitulo.Text == "" ||
        txtAutor.Text == "" || txtPaginas.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            int paginas;

            if (!int.TryParse(txtPaginas.Text, out paginas))
            {
                MessageBox.Show("El número de páginas debe ser un número entero.");
                txtPaginas.Focus();
                return;
            }

            Libro libro = new Libro();

            libro.ISBN1 = txtISBN.Text;
            libro.Titulo1 = txtTitulo.Text;
            libro.Autor1 = txtAutor.Text;
            libro.NumeroPaginas1 = paginas;

            libros.Add(libro);

            dgvLibros.Rows.Add(
                libro.ISBN1,
                libro.Titulo1,
                libro.Autor1,
                libro.NumeroPaginas1
            );

            MessageBox.Show("Libro registrado correctamente");

            txtISBN.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtPaginas.Clear();

            txtISBN.Focus();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtPaginas.Clear();

            txtISBN.Focus();
        }
    }
}
