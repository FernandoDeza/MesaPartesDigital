using System;
using System.Windows.Forms;

namespace REG_EXP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cerrar el menú principal
            this.Close();

            // Mostrar nuevamente el inicio de sesión
            Log login = new Log();
            login.Show();
        }

        private void btnRegistrarExpediente_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de registro de expedientes
            RegistroExpedientes.FrmRegistroExpediente frmRegistro =
                new RegistroExpedientes.FrmRegistroExpediente();

            frmRegistro.ShowDialog();
        }

        private void btnGestionExpedientes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de gestión y búsqueda
            registro_de_expedientes.Form1 frmGestion =
                new registro_de_expedientes.Form1();

            frmGestion.ShowDialog();
        }
    }
}