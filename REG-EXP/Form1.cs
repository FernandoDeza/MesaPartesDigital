using System;
using System.IO;
using System.Windows.Forms;

namespace registro_de_expedientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Los campos se muestran bloqueados al iniciar
            txtNombres.Enabled = false;
            txtFechaIngreso.Enabled = false;
            txtNroParte.Enabled = false;
            txtTipoTramite.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostrar los expedientes registrados al abrir el formulario
            CargarExpedientes();
        }

        private void CargarExpedientes()
        {
            // Limpiar la tabla antes de cargar los datos
            dgvExpedientes.Rows.Clear();

            // Verificar si existe el archivo
            if (!File.Exists("expedientes.txt"))
            {
                return;
            }

            string[] lineas = File.ReadAllLines("expedientes.txt");

            // Cada expediente tiene 9 datos y una línea separadora
            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].StartsWith("EX") && i + 8 < lineas.Length)
                {
                    dgvExpedientes.Rows.Add(
                        lineas[i],       // Código
                        lineas[i + 1],   // Remitente
                        lineas[i + 2],   // Tipo de remitente
                        lineas[i + 3],   // DNI / RUC
                        lineas[i + 4],   // Tipo de documento
                        lineas[i + 5],   // N.º de documento
                        lineas[i + 6],   // Asunto
                        lineas[i + 7],   // Fecha de ingreso
                        lineas[i + 8]    // Observaciones
                    );

                    // Avanzar hasta el siguiente expediente
                    i = i + 9;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un código
            if (txtNroExpediente.Text == "")
            {
                MessageBox.Show("Ingrese el código del expediente.");
                txtNroExpediente.Focus();
                return;
            }

            // Verificar que exista el archivo
            if (!File.Exists("expedientes.txt"))
            {
                MessageBox.Show("No existen expedientes registrados.");
                return;
            }

            string[] lineas = File.ReadAllLines("expedientes.txt");
            bool encontrado = false;

            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i] == txtNroExpediente.Text)
                {
                    if (i + 8 < lineas.Length)
                    {
                        txtNombres.Text = lineas[i + 1];
                        txtTipoTramite.Text = lineas[i + 4];
                        txtNroParte.Text = lineas[i + 5];
                        txtFechaIngreso.Text = lineas[i + 7];

                        encontrado = true;
                        break;
                    }
                }
            }

            if (encontrado == true)
            {
                MessageBox.Show("Expediente encontrado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró el expediente.");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Seleccione el documento escaneado";
            openFile.Filter =
                "Documentos PDF (*.pdf)|*.pdf|Archivos de Imagen (*.jpg;*.png)|*.jpg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFile.FileName;

                MessageBox.Show(
                    "Documento cargado correctamente:\n" + rutaArchivo);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNroExpediente.Text == "")
            {
                MessageBox.Show("Primero busque un expediente.");
                return;
            }

            txtNombres.Enabled = true;
            txtFechaIngreso.Enabled = true;
            txtNroParte.Enabled = true;
            txtTipoTramite.Enabled = true;

            MessageBox.Show("Campos habilitados para modificación.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNroExpediente.Text == "")
            {
                MessageBox.Show(
                    "Ingrese o busque el expediente que desea eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este expediente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Función de eliminación preparada para la siguiente etapa.");

                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNroExpediente.Clear();
            txtNombres.Clear();
            txtFechaIngreso.Clear();
            txtNroParte.Clear();
            txtTipoTramite.Clear();

            txtNombres.Enabled = false;
            txtFechaIngreso.Enabled = false;
            txtNroParte.Enabled = false;
            txtTipoTramite.Enabled = false;

            txtNroExpediente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}