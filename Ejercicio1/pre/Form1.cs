namespace pre
{
    public partial class Contraseñas : Form
    {
        Password password = new Password();

        public Contraseñas()
        {
            InitializeComponent();

            nudLongitud.Value = password.getLongitud();
            txtPassword.Text = password.getContraseña();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int longitud = (int)nudLongitud.Value;

            password.setLongitud(longitud);

            password.generarPassword();

            txtPassword.Text = password.getContraseña();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (password.esFuerte())
            {
                txtresultado.Text = "CONTRASEÑA FUERTE";
            }
            else
            {
                txtresultado.Text = "CONTRASEÑA DÉBIL";
            }
        }
    }
}
