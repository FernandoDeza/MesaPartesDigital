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
            this.Close();
        }

        private void btnRegistrarExpediente_Click(object sender, EventArgs e)
        {
            RegistroExpedientes.FrmRegistroExpediente frmRegistro =
                new RegistroExpedientes.FrmRegistroExpediente();

            frmRegistro.ShowDialog();
        }

        private void btnGestionExpedientes_Click(object sender, EventArgs e)
        {
            registro_de_expedientes.Form1 frmGestion =
                new registro_de_expedientes.Form1();

            frmGestion.ShowDialog();
        }
    }
}