using System;
using System.Windows.Forms;
using formulario_creacion_de_cuenta;

namespace REG_EXP
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();

            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btregistro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Seguro que quieres salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
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
            creaUsuario frmCrear = new creaUsuario();

            frmCrear.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Verificar que el texto no este vacio
        static bool verificaTexto(string texto)
        {
            bool band = false;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')
                {
                    band = true;
                    break;
                }
            }

            return band;
        }

        private void bttingresa_Click(object sender, EventArgs e)
        {
            // Validar los datos ingresados
            if (verificaTexto(textBox1.Text) == false)
            {
                MessageBox.Show("Ingrese su correo electrónico.");
                textBox1.Focus();
                return;
            }

            if (verificaTexto(textBox2.Text) == false)
            {
                MessageBox.Show("Ingrese su clave.");
                textBox2.Focus();
                return;
            }

            string correo = textBox1.Text;
            string clave = textBox2.Text;

            // Verificar los datos en el archivo binario
            if (creaUsuario.validarUsuario(correo, clave) == true)
            {
                Form2 menu = new Form2();

                this.Hide();

                menu.ShowDialog();

                textBox1.Clear();
                textBox2.Clear();

                this.Show();

                textBox1.Focus();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}