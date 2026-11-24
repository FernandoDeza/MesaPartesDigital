using creaUsuario;
using formulario_creacion_de_cuenta;

namespace REG_EXP
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();

            // Ocultar la contraseña al iniciar
            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btregistro_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que quieres salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            formulario_creacion_de_cuenta.creaUsuario frmCrear =
                new formulario_creacion_de_cuenta.creaUsuario();

            frmCrear.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttingresa_Click(object sender, EventArgs e)
        {
            // Validar usuario
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese su correo electrónico.");
                textBox1.Focus();
                return;
            }

            // Validar clave
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ingrese su clave.");
                textBox2.Focus();
                return;
            }

            // Verificar las credenciales registradas
            try
            {
                if (Usuarios.validarUsuario(
                    textBox1.Text, textBox2.Text) == false)
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    textBox2.Clear();
                    textBox2.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al verificar el usuario: " + ex.Message);
                return;
            }

            // Abrir el menú principal
            Form2 menu = new Form2();
            menu.Show();

            // Ocultar el inicio de sesión
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}