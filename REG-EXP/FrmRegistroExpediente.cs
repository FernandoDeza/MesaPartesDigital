using System.IO;

namespace RegistroExpedientes
{
    public partial class FrmRegistroExpediente : Form
    {
        public FrmRegistroExpediente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los datos ingresados
            
            txtRemitente.Clear();
            cboTipoRemitente.SelectedIndex = -1;
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
            // Validar código del expediente
           
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
                MessageBox.Show("Ingrese el número de documento.");
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

          
            archivo.WriteLine(txtRemitente.Text);
            archivo.WriteLine(cboTipoRemitente.Text);
            archivo.WriteLine(cboTipoDocumento.Text);
            archivo.WriteLine(txtNumeroDocumento.Text);
            archivo.WriteLine(txtAsunto.Text);
            archivo.WriteLine(dtpFechaIngreso.Value.ToShortDateString());
            archivo.WriteLine(txtObservaciones.Text);
            archivo.WriteLine("------------------------------------");

            archivo.Close();

            // Mostrar mensaje de confirmación
            MessageBox.Show("Expediente registrado correctamente.");

            // Limpiar los campos después del registro
          
            txtRemitente.Clear();
            cboTipoRemitente.SelectedIndex = -1;
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