using System;
using System.IO;
using System.Windows.Forms;

namespace RegistroExpedientes
{
    public partial class FrmRegistroExpediente : Form
    {
        // Estructura para almacenar los datos del expediente
        public struct Expediente
        {
            public string codigo;
            public string remitente;
            public string tipoRemitente;
            public string dniRuc;
            public string tipoDocumento;
            public string numeroDocumento;
            public string asunto;
            public string fechaIngreso;
            public string observaciones;
        }

        string nombreFichero = "expedientes.dat";
        string ficheroCorrelativo = "correlativo.dat";

        long numeroExpediente = 1;

        public FrmRegistroExpediente()
        {
            InitializeComponent();

            numeroExpediente = obtenerCorrelativo();

            lblCodigoGenerado.Text =
                generarCodigo(numeroExpediente);
        }

        // Obtener el siguiente numero de expediente
        long obtenerCorrelativo()
        {
            BinaryReader br = null;
            long mayor = 0;

            try
            {
                if (File.Exists(ficheroCorrelativo))
                {
                    br = new BinaryReader(new FileStream(
                        ficheroCorrelativo,
                        FileMode.Open,
                        FileAccess.Read));

                    mayor = br.ReadInt64();
                }
            }
            finally
            {
                if (br != null)
                    br.Close();
            }

            // Verificar los expedientes registrados anteriormente
            br = null;

            try
            {
                if (File.Exists(nombreFichero))
                {
                    br = new BinaryReader(new FileStream(
                        nombreFichero,
                        FileMode.Open,
                        FileAccess.Read));

                    Expediente exp;

                    while (br.BaseStream.Position !=
                           br.BaseStream.Length)
                    {
                        exp.codigo = br.ReadString();
                        exp.remitente = br.ReadString();
                        exp.tipoRemitente = br.ReadString();
                        exp.dniRuc = br.ReadString();
                        exp.tipoDocumento = br.ReadString();
                        exp.numeroDocumento = br.ReadString();
                        exp.asunto = br.ReadString();
                        exp.fechaIngreso = br.ReadString();
                        exp.observaciones = br.ReadString();

                        string numero = "";

                        for (int i = 2; i < exp.codigo.Length; i++)
                        {
                            numero = numero + exp.codigo[i];
                        }

                        long actual = long.Parse(numero);

                        if (actual > mayor)
                        {
                            mayor = actual;
                        }
                    }
                }
            }
            finally
            {
                if (br != null)
                    br.Close();
            }

            return mayor + 1;
        }

        // Guardar el ultimo numero asignado
        static void guardarCorrelativo(string archivo, long numero)
        {
            BinaryWriter bw = null;

            try
            {
                bw = new BinaryWriter(new FileStream(
                    archivo,
                    FileMode.Create,
                    FileAccess.Write));

                bw.Write(numero);
            }
            finally
            {
                if (bw != null)
                    bw.Close();
            }
        }

        // Generar el codigo del expediente
        static string generarCodigo(long numero)
        {
            string codigo;

            if (numero < 10)
            {
                codigo = "EX00000" + numero;
            }
            else if (numero < 100)
            {
                codigo = "EX0000" + numero;
            }
            else if (numero < 1000)
            {
                codigo = "EX000" + numero;
            }
            else if (numero < 10000)
            {
                codigo = "EX00" + numero;
            }
            else if (numero < 100000)
            {
                codigo = "EX0" + numero;
            }
            else
            {
                codigo = "EX" + numero;
            }

            return codigo;
        }

        // Crear archivo binario de expedientes
        static void crearFichero(string archivo, Expediente exp)
        {
            BinaryWriter bw = null;

            try
            {
                bw = new BinaryWriter(new FileStream(
                    archivo,
                    FileMode.Create,
                    FileAccess.Write));

                bw.Write(exp.codigo);
                bw.Write(exp.remitente);
                bw.Write(exp.tipoRemitente);
                bw.Write(exp.dniRuc);
                bw.Write(exp.tipoDocumento);
                bw.Write(exp.numeroDocumento);
                bw.Write(exp.asunto);
                bw.Write(exp.fechaIngreso);
                bw.Write(exp.observaciones);
            }
            finally
            {
                if (bw != null)
                    bw.Close();
            }
        }

        // Agregar un expediente al archivo binario
        static void agregarFichero(string archivo, Expediente exp)
        {
            BinaryWriter bw = null;

            try
            {
                bw = new BinaryWriter(new FileStream(
                    archivo,
                    FileMode.Append,
                    FileAccess.Write));

                bw.Write(exp.codigo);
                bw.Write(exp.remitente);
                bw.Write(exp.tipoRemitente);
                bw.Write(exp.dniRuc);
                bw.Write(exp.tipoDocumento);
                bw.Write(exp.numeroDocumento);
                bw.Write(exp.asunto);
                bw.Write(exp.fechaIngreso);
                bw.Write(exp.observaciones);
            }
            finally
            {
                if (bw != null)
                    bw.Close();
            }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar los datos ingresados
            if (verificaTexto(txtRemitente.Text) == false)
            {
                MessageBox.Show("Ingrese el nombre del remitente.");
                txtRemitente.Focus();
                return;
            }

            if (cboTipoRemitente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de remitente.");
                cboTipoRemitente.Focus();
                return;
            }

            if (verificaTexto(txtDniRuc.Text) == false)
            {
                MessageBox.Show("Ingrese el DNI o RUC.");
                txtDniRuc.Focus();
                return;
            }

            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de documento.");
                cboTipoDocumento.Focus();
                return;
            }

            if (verificaTexto(txtNumeroDocumento.Text) == false)
            {
                MessageBox.Show("Ingrese el número de documento.");
                txtNumeroDocumento.Focus();
                return;
            }

            if (verificaTexto(txtAsunto.Text) == false)
            {
                MessageBox.Show("Ingrese el asunto del expediente.");
                txtAsunto.Focus();
                return;
            }

            // Capturar los datos del expediente
            Expediente exp;

            exp.codigo = generarCodigo(numeroExpediente);
            exp.remitente = txtRemitente.Text;
            exp.tipoRemitente = cboTipoRemitente.Text;
            exp.dniRuc = txtDniRuc.Text;
            exp.tipoDocumento = cboTipoDocumento.Text;
            exp.numeroDocumento = txtNumeroDocumento.Text;
            exp.asunto = txtAsunto.Text;
            exp.fechaIngreso = dtpFechaIngreso.Value.ToShortDateString();
            exp.observaciones = txtObservaciones.Text;

            try
            {
                // Guardar el numero asignado
                guardarCorrelativo(
                    ficheroCorrelativo, numeroExpediente);

                // Crear o agregar el expediente
                if (File.Exists(nombreFichero))
                {
                    agregarFichero(nombreFichero, exp);
                }
                else
                {
                    crearFichero(nombreFichero, exp);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo guardar el expediente.");

                numeroExpediente = obtenerCorrelativo();

                lblCodigoGenerado.Text =
                    generarCodigo(numeroExpediente);

                return;
            }

            MessageBox.Show(
                "Expediente registrado correctamente.\n\n" +
                "Código: " + exp.codigo);

            // Generar el siguiente codigo
            numeroExpediente++;

            lblCodigoGenerado.Text =
                generarCodigo(numeroExpediente);

            limpiar();
        }

        // Limpiar los controles del formulario
        public void limpiar()
        {
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
            this.Close();
        }
    }
}