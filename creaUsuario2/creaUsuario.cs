using System;
using System.IO;
using System.Windows.Forms;

namespace formulario_creacion_de_cuenta
{
    public partial class creaUsuario : Form
    {
        // Estructura para almacenar los datos del usuario
        public struct Usuario
        {
            public string nombres;
            public string apellidos;
            public string tipoDocumento;
            public string numeroDocumento;
            public string correo;
            public string cargo;
            public string clave;
        }

        static string nombreFichero = "usuarios.dat";

        private bool verPasswordNueva = false;
        private bool verPasswordConfirmacion = false;

        public creaUsuario()
        {
            InitializeComponent();

            txtContraseñaNueva.UseSystemPasswordChar = true;
            txtContraseñaConfirmacion.UseSystemPasswordChar = true;
        }

        // Crear archivo binario de usuarios
        static void crearFichero(string archivo, Usuario u)
        {
            BinaryWriter bw = null;

            try
            {
                bw = new BinaryWriter(new FileStream(
                    archivo, FileMode.Create, FileAccess.Write));

                bw.Write(u.nombres);
                bw.Write(u.apellidos);
                bw.Write(u.tipoDocumento);
                bw.Write(u.numeroDocumento);
                bw.Write(u.correo);
                bw.Write(u.cargo);
                bw.Write(u.clave);
            }
            finally
            {
                if (bw != null)
                    bw.Close();
            }
        }

        // Agregar un usuario al archivo binario
        static void agregarFichero(string archivo, Usuario u)
        {
            BinaryWriter bw = null;

            try
            {
                bw = new BinaryWriter(new FileStream(
                    archivo, FileMode.Append, FileAccess.Write));

                bw.Write(u.nombres);
                bw.Write(u.apellidos);
                bw.Write(u.tipoDocumento);
                bw.Write(u.numeroDocumento);
                bw.Write(u.correo);
                bw.Write(u.cargo);
                bw.Write(u.clave);
            }
            finally
            {
                if (bw != null)
                    bw.Close();
            }
        }

        // Verificar si el usuario ya existe
        public static bool verificaUsuario(string correo)
        {
            BinaryReader br = null;
            bool band = false;

            try
            {
                if (File.Exists(nombreFichero))
                {
                    br = new BinaryReader(new FileStream(
                        nombreFichero, FileMode.Open, FileAccess.Read));

                    Usuario u;

                    while (br.BaseStream.Position != br.BaseStream.Length)
                    {
                        u.nombres = br.ReadString();
                        u.apellidos = br.ReadString();
                        u.tipoDocumento = br.ReadString();
                        u.numeroDocumento = br.ReadString();
                        u.correo = br.ReadString();
                        u.cargo = br.ReadString();
                        u.clave = br.ReadString();

                        if (correo == u.correo)
                        {
                            band = true;
                            break;
                        }
                    }
                }
            }
            finally
            {
                if (br != null)
                    br.Close();
            }

            return band;
        }

        // Verificar el correo y la contraseña
        public static bool validarUsuario(string correo, string clave)
        {
            BinaryReader br = null;
            bool band = false;

            try
            {
                if (File.Exists(nombreFichero))
                {
                    br = new BinaryReader(new FileStream(
                        nombreFichero, FileMode.Open, FileAccess.Read));

                    Usuario u;

                    while (br.BaseStream.Position != br.BaseStream.Length)
                    {
                        u.nombres = br.ReadString();
                        u.apellidos = br.ReadString();
                        u.tipoDocumento = br.ReadString();
                        u.numeroDocumento = br.ReadString();
                        u.correo = br.ReadString();
                        u.cargo = br.ReadString();
                        u.clave = br.ReadString();

                        if (correo == u.correo && clave == u.clave)
                        {
                            band = true;
                            break;
                        }
                    }
                }
            }
            finally
            {
                if (br != null)
                    br.Close();
            }

            return band;
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

        // Verificar la estructura basica del correo
        static bool verificaCorreo(string correo)
        {
            int arroba = 0;
            int posicionArroba = -1;
            bool punto = false;
            bool band = true;

            for (int i = 0; i < correo.Length; i++)
            {
                if (correo[i] == '@')
                {
                    arroba++;
                    posicionArroba = i;
                }

                if (correo[i] == ' ')
                {
                    band = false;
                }
            }

            if (arroba != 1)
            {
                band = false;
            }

            if (posicionArroba <= 0 ||
                posicionArroba == correo.Length - 1)
            {
                band = false;
            }

            for (int i = posicionArroba + 2; i < correo.Length - 1; i++)
            {
                if (correo[i] == '.')
                {
                    punto = true;
                }
            }

            if (punto == false)
            {
                band = false;
            }

            return band;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar los datos ingresados
            if (verificaTexto(txtNombres.Text) == false)
            {
                MessageBox.Show("Ingrese los nombres.");
                txtNombres.Focus();
                return;
            }

            if (verificaTexto(txtApellidos.Text) == false)
            {
                MessageBox.Show("Ingrese los apellidos.");
                txtApellidos.Focus();
                return;
            }

            if (cxbTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de documento.");
                cxbTipoDoc.Focus();
                return;
            }

            if (verificaTexto(txtDocumento.Text) == false)
            {
                MessageBox.Show("Ingrese el número de documento.");
                txtDocumento.Focus();
                return;
            }

            if (verificaTexto(txtCorreo.Text) == false)
            {
                MessageBox.Show("Ingrese el correo electrónico.");
                txtCorreo.Focus();
                return;
            }

            string correo = txtCorreo.Text;

            if (verificaCorreo(correo) == false)
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                txtCorreo.Focus();
                return;
            }

            if (cxbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de cargo.");
                cxbCargo.Focus();
                return;
            }

            if (verificaTexto(txtContraseñaNueva.Text) == false)
            {
                MessageBox.Show("Ingrese una contraseña.");
                txtContraseñaNueva.Focus();
                return;
            }

            if (verificaTexto(txtContraseñaConfirmacion.Text) == false)
            {
                MessageBox.Show("Confirme la contraseña.");
                txtContraseñaConfirmacion.Focus();
                return;
            }

            if (txtContraseñaNueva.Text != txtContraseñaConfirmacion.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                txtContraseñaConfirmacion.Clear();
                txtContraseñaConfirmacion.Focus();
                return;
            }

            if (verificaUsuario(correo) == true)
            {
                MessageBox.Show("Este correo electrónico ya está registrado.");
                txtCorreo.Focus();
                return;
            }

            // Capturar los datos del usuario
            Usuario u;

            u.nombres = txtNombres.Text;
            u.apellidos = txtApellidos.Text;
            u.tipoDocumento = cxbTipoDoc.Text;
            u.numeroDocumento = txtDocumento.Text;
            u.correo = correo;
            u.cargo = cxbCargo.Text;
            u.clave = txtContraseñaNueva.Text;

            // Crear o agregar datos al archivo
            if (File.Exists(nombreFichero))
            {
                agregarFichero(nombreFichero, u);
            }
            else
            {
                crearFichero(nombreFichero, u);
            }

            MessageBox.Show(
                "Cuenta registrada correctamente.\n\n" +
                "Usuario: " + u.correo,
                "Registro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            limpiar();
        }

        // Limpiar los controles del formulario
        public void limpiar()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDocumento.Clear();
            txtCorreo.Clear();

            cxbTipoDoc.SelectedIndex = -1;
            cxbCargo.SelectedIndex = -1;

            txtContraseñaNueva.Clear();
            txtContraseñaConfirmacion.Clear();

            txtContraseñaNueva.UseSystemPasswordChar = true;
            txtContraseñaConfirmacion.UseSystemPasswordChar = true;

            verPasswordNueva = false;
            verPasswordConfirmacion = false;

            txtNombres.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Avanzar al siguiente control con Enter
        private void AvanzarConEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (sender == txtNombres)
                {
                    txtApellidos.Focus();
                }
                else if (sender == txtApellidos)
                {
                    cxbTipoDoc.Focus();
                }
                else if (sender == cxbTipoDoc)
                {
                    txtDocumento.Focus();
                }
                else if (sender == txtDocumento)
                {
                    txtCorreo.Focus();
                }
                else if (sender == txtCorreo)
                {
                    cxbCargo.Focus();
                }
                else if (sender == cxbCargo)
                {
                    txtContraseñaNueva.Focus();
                }
                else if (sender == txtContraseñaNueva)
                {
                    txtContraseñaConfirmacion.Focus();
                }
                else if (sender == txtContraseñaConfirmacion)
                {
                    btnRegistrar.Focus();
                }
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
            if (MessageBox.Show(
                "¿Está seguro de que desea salir del sistema?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Mostrar u ocultar la contraseña
        private void txtpictureojoCerrado_Click(object sender, EventArgs e)
        {
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

        // Mostrar u ocultar la confirmacion de contraseña
        private void txlOjocerrado_Click(object sender, EventArgs e)
        {
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