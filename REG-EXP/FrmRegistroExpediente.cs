using System.IO;

namespace RegistroExpedientes
{
    public partial class FrmRegistroExpediente : Form
    {
        int numeroExpediente = 1;

        public FrmRegistroExpediente()
        {
            InitializeComponent();

            // Buscar cuántos expedientes ya existen
            if (File.Exists("expedientes.txt"))
            {
                string[] lineas = File.ReadAllLines("expedientes.txt");

                for (int i = 0; i < lineas.Length; i++)
                {
                    if (lineas[i] == "------------------------------------")
                    {
                        numeroExpediente++;
                    }
                }
            }

            // Mostrar el siguiente código de expediente
            lblCodigoGenerado.Text = "EX" + numeroExpediente.ToString("D6");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los datos ingresados
            txtRemitente.Clear();
            cboTipoRemitente.SelectedIndex = -1;
            txtDniRuc.Clear();
            cboTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtAsunto.Clear();
            dtpFechaIngreso.Value = DateTime.Now;
            txtObservaciones.Clear();

            // Colocar el cursor en el primer campo
            txtRemitente.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar remitente
            if (txtRemitente.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del remitente.");
                txtRemitente.Focus();
                return;
            }

            // Validar tipo de remitente
            if (cboTipoRemitente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de remitente.");
                cboTipoRemitente.Focus();
                return;
            }

            // Validar DNI o RUC
            if (txtDniRuc.Text == "")
            {
                MessageBox.Show("Ingrese el DNI o RUC del remitente.");
                txtDniRuc.Focus();
                return;
            }

            // Validar tipo de documento
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de documento.");
                cboTipoDocumento.Focus();
                return;
            }

            // Validar número de documento
            if (txtNumeroDocumento.Text == "")
            {
                MessageBox.Show("Ingrese el número del documento.");
                txtNumeroDocumento.Focus();
                return;
            }

            // Validar asunto
            if (txtAsunto.Text == "")
            {
                MessageBox.Show("Ingrese el asunto del documento.");
                txtAsunto.Focus();
                return;
            }

            // Guardar los datos en el archivo
            StreamWriter archivo = File.AppendText("expedientes.txt");

            archivo.WriteLine(lblCodigoGenerado.Text);
            archivo.WriteLine(txtRemitente.Text);
            archivo.WriteLine(cboTipoRemitente.Text);
            archivo.WriteLine(txtDniRuc.Text);
            archivo.WriteLine(cboTipoDocumento.Text);
            archivo.WriteLine(txtNumeroDocumento.Text);
            archivo.WriteLine(txtAsunto.Text);
            archivo.WriteLine(dtpFechaIngreso.Value.ToShortDateString());
            archivo.WriteLine(txtObservaciones.Text);
            archivo.WriteLine("------------------------------------");

            archivo.Close();

            // Confirmar registro
            MessageBox.Show("Expediente registrado correctamente.");

            // Generar el siguiente código
            numeroExpediente++;
            lblCodigoGenerado.Text = "EX" + numeroExpediente.ToString("D6");

            // Limpiar los campos
            txtRemitente.Clear();
            cboTipoRemitente.SelectedIndex = -1;
            txtDniRuc.Clear();
            cboTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtAsunto.Clear();
            dtpFechaIngreso.Value = DateTime.Now;
            txtObservaciones.Clear();

            txtRemitente.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual
            this.Close();
        }
    }
}
