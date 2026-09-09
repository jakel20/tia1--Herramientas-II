using CapaNegocio;

namespace TIA1
{
    public partial class frmLogin : Form
    {
        private readonly BLLLogin _loginService = new();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object? sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Debe ingresar usuario y contraseña.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool loginCorrecto = _loginService.ValidarUsuario(usuario, contrasena);

                if (!loginCorrecto)
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                frmPrincipal principal = new();
                principal.FormClosed += (_, _) => Close();
                principal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo validar el usuario contra SQL Server.\n\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
