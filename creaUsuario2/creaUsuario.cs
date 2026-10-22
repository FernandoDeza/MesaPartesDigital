using System;
using System.Drawing;
using System.Windows.Forms;

namespace formulario_creacion_de_cuenta
{
    public partial class creaUsuario : Form
    {
        private bool verPasswordNueva = false;
        private bool verPasswordConfirmacion = false;

        public creaUsuario()
        {
            InitializeComponent();

            // Ocultar las contraseñas al iniciar
            txtContraseñaNueva.UseSystemPasswordChar = true;
            txtContraseñaConfirmacion.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AvanzarConEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(
                    (Control)sender, true, true, true, true);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Volver al inicio de sesión
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir del sistema?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar nombres
            if (txtNombres.Text == "")
            {
                MessageBox.Show("Ingrese los nombres.");
                txtNombres.Focus();
                return;
            }

            // Validar apellidos
            if (txtApellidos.Text == "")
            {
                MessageBox.Show("Ingrese los apellidos.");
                txtApellidos.Focus();
                return;
            }

            // Validar tipo de documento
            if (cxbTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de documento.");
                cxbTipoDoc.Focus();
                return;
            }

            // Validar número de documento
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingrese el número de documento.");
                txtDocumento.Focus();
                return;
            }

            // Validar correo electrónico
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Ingrese el correo electrónico.");
                txtCorreo.Focus();
                return;
            }

            // Validar tipo de cargo
            if (cxbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de cargo.");
                cxbCargo.Focus();
                return;
            }

            // Validar contraseña
            if (txtContraseñaNueva.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña.");
                txtContraseñaNueva.Focus();
                return;
            }

            // Validar confirmación de contraseña
            if (txtContraseñaConfirmacion.Text == "")
            {
                MessageBox.Show("Confirme la contraseña.");
                txtContraseñaConfirmacion.Focus();
                return;
            }

            // Comprobar que ambas contraseñas sean iguales
            if (txtContraseñaNueva.Text != txtContraseñaConfirmacion.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                txtContraseñaConfirmacion.Clear();
                txtContraseñaConfirmacion.Focus();
                return;
            }

            // Registro correcto
            MessageBox.Show(
                "¡Cuenta registrada con éxito!",
                "Registro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar los campos
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDocumento.Clear();
            txtCorreo.Clear();

            cxbTipoDoc.SelectedIndex = -1;
            cxbCargo.SelectedIndex = -1;

            txtContraseñaNueva.Clear();
            txtContraseñaConfirmacion.Clear();

            txtNombres.Focus();
        }

        private void txtpictureojoCerrado_Click(object sender, EventArgs e)
        {
            // Mostrar u ocultar la contraseña
            if (verPasswordNueva == false)
            {
                txtContraseñaNueva.UseSystemPasswordChar = false;
                verPasswordNueva = true;
            }
            else
            {
                txtContraseñaNueva.UseSystemPasswordChar = true;
                verPasswordNueva = false;
            }
        }

        private void txlOjocerrado_Click(object sender, EventArgs e)
        {
            // Mostrar u ocultar la confirmación de contraseña
            if (verPasswordConfirmacion == false)
            {
                txtContraseñaConfirmacion.UseSystemPasswordChar = false;
                verPasswordConfirmacion = true;
            }
            else
            {
                txtContraseñaConfirmacion.UseSystemPasswordChar = true;
                verPasswordConfirmacion = false;
            }
        }
    }
}