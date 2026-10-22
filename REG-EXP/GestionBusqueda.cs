using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registro_de_expedientes
{
    public partial class GestionBusqueda : Form
    {
        public GestionBusqueda()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtNroExpediente.Text))
                {
                    MessageBox.Show("Por favor, ingrese un número de expediente a buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Seleccione el documento escaneado";
            openFile.Filter = "Documentos PDF (*.pdf)|*.pdf|Archivos de Imagen (*.jpg;*.png)|*.jpg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFile.FileName;
                MessageBox.Show("Documento cargado correctamente:\n" + rutaArchivo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            txtNombres.Enabled = true;
            txtFechaIngreso.Enabled = true;
            txtNroParte.Enabled = true;
            txtTipoTramite.Enabled = true;

            MessageBox.Show("Campos habilitados para modificación. Realice los cambios y guarde.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNroExpediente.Text))
            {
                MessageBox.Show("Ingrese o busque el expediente que desea eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este expediente del sistema?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Expediente eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}