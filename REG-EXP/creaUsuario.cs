using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario_creacion_de_cuenta
{
    public partial class creaUsuario : Form
    {
        public creaUsuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AvanzarConEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
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

            {
                this.Hide();
            }
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
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text) ||
                cxbTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Por favor, complete todos los campos obligatorios.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            MessageBox.Show(
                "¡Cuenta registrada con éxito!",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            //Si todo funciona en la parte de arriba este comando debera de limpiar los campos despues de registrar.
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDocumento.Clear();
            txtCorreo.Clear();
            cxbTipoDoc.SelectedIndex = -1;
            cxbCargo.SelectedIndex = -1;
            txtNombres.Focus();

        }
        private bool verPasswordNueva = false;
        private void txtpictureojoCerrado_Click(object sender, EventArgs e)
        {
            if (verPasswordNueva == false)
            {
                // Muestra la contraseña.
                txtContraseñaNueva.UseSystemPasswordChar = false;
                txtpictureojoCerrado.Image = Image.FromFile(@"C:\Users\Usuario\Pictures\Gemini_Generated_Image_jjtc8gjjtc8gjjtc.jpeg");
                verPasswordNueva = true;
            }
            else
            {
                // Oculta la contraseña.
                txtContraseñaNueva.UseSystemPasswordChar = true;
                txtpictureojoCerrado.Image = Image.FromFile(@"C:\Users\Usuario\Pictures\Gemini_Generated_Image_jjnpuzjjnpuzjjnp.jpeg");
                verPasswordNueva = false;
            }
        }
        private bool verPasswordConfirmacion = false;
        private void txlOjocerrado_Click(object sender, EventArgs e)
        {
            if (verPasswordConfirmacion == false)
            {
                // Muestra la contraseña de confirmación.
                txtContraseñaConfirmacion.UseSystemPasswordChar = false;
                txlOjocerrado.Image = Image.FromFile(@"C:\Users\Usuario\Pictures\Gemini_Generated_Image_jjtc8gjjtc8gjjtc.jpeg"); // Ruta de tu ojo abierto
                verPasswordConfirmacion = true;
            }
            else
            {
                // Oculta la contraseña de la confirmacion
                txtContraseñaConfirmacion.UseSystemPasswordChar = true;
                txlOjocerrado.Image = Image.FromFile(@"C:\Users\Usuario\Pictures\Gemini_Generated_Image_jjnpuzjjnpuzjjnp.jpeg"); // Ruta de tu ojo cerrado
                verPasswordConfirmacion = false;
            }
        }
    }
}