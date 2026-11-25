using System;
using System.IO;
using System.Windows.Forms;
using RegistroExpedientes;

namespace registro_de_expedientes
{
    public partial class Form1 : Form
    {
        public struct Documento
        {
            public string codigoExpediente;
            public string rutaArchivo;
        }

        string nombreFichero = "expedientes.dat";
        string ficheroDocumentos = "documentos.dat";

        string codigoEncontrado = "";
        bool modificando = false;

        public Form1()
        {
            InitializeComponent();

            txtNombres.Enabled = false;
            txtFechaIngreso.Enabled = false;
            txtNroParte.Enabled = false;
            txtTipoTramite.Enabled = false;

            dgvExpedientes.ReadOnly = true;
            dgvExpedientes.AllowUserToAddRows = false;
            dgvExpedientes.AllowUserToDeleteRows = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarExpedientes();
        }

        // Mostrar los expedientes registrados
        private void CargarExpedientes()
        {
            BinaryReader br = null;

            dgvExpedientes.Rows.Clear();

            try
            {
                if (File.Exists(nombreFichero))
                {
                    br = new BinaryReader(new FileStream(
                        nombreFichero, FileMode.Open, FileAccess.Read));

                    FrmRegistroExpediente.Expediente exp;

                    while (br.BaseStream.Position != br.BaseStream.Length)
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

                        dgvExpedientes.Rows.Add(
                            exp.codigo,
                            exp.remitente,
                            exp.tipoRemitente,
                            exp.dniRuc,
                            exp.tipoDocumento,
                            exp.numeroDocumento,
                            exp.asunto,
                            exp.fechaIngreso,
                            exp.observaciones);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudieron cargar los expedientes.");
            }
            finally
            {
                if (br != null)
                    br.Close();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (modificando == true)
            {
                MessageBox.Show(
                    "Termine o cancele la modificación.");
                return;
            }

            if (verificaTexto(txtNroExpediente.Text) == false)
            {
                MessageBox.Show(
                    "Ingrese el código del expediente.");

                txtNroExpediente.Focus();
                return;
            }

            txtNombres.Clear();
            txtTipoTramite.Clear();
            txtNroParte.Clear();
            txtFechaIngreso.Clear();

            codigoEncontrado = "";

            buscarExpediente(
                nombreFichero, txtNroExpediente.Text);
        }

        // Busqueda secuencial de expedientes
        public void buscarExpediente(string archivo, string codigo)
        {
            BinaryReader br = null;
            bool band = false;

            if (File.Exists(archivo) == false)
            {
                MessageBox.Show(
                    "No existen expedientes registrados.");
                return;
            }

            try
            {
                br = new BinaryReader(new FileStream(
                    archivo, FileMode.Open, FileAccess.Read));

                FrmRegistroExpediente.Expediente exp;

                while (br.BaseStream.Position != br.BaseStream.Length)
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

                    if (codigo == exp.codigo)
                    {
                        txtNombres.Text = exp.remitente;
                        txtTipoTramite.Text = exp.tipoDocumento;
                        txtNroParte.Text = exp.numeroDocumento;
                        txtFechaIngreso.Text = exp.fechaIngreso;

                        codigoEncontrado = exp.codigo;

                        band = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo realizar la búsqueda.");
                return;
            }
            finally
            {
                if (br != null)
                    br.Close();
            }

            if (band == true)
            {
                string documentos = buscarDocumentos(
                    ficheroDocumentos, codigoEncontrado);

                MessageBox.Show(
                    "Expediente encontrado correctamente.\n\n" +
                    "Documentos adjuntos:\n" + documentos);
            }
            else
            {
                MessageBox.Show(
                    "No se encontró el expediente.");
            }
        }

        // Crear el archivo binario de documentos
        static void crearFicheroDocumento(
            string archivo, Documento doc)
        {
            BinaryWriter bw = null;

            try
            {
                bw = new BinaryWriter(new FileStream(
                    archivo, FileMode.Create, FileAccess.Write));

                bw.Write(doc.codigoExpediente);
                bw.Write(doc.rutaArchivo);
            }
            finally
            {
                if (bw != null)
                    bw.Close();
            }
        }

        // Agregar un documento al archivo binario
        static void agregarFicheroDocumento(
            string archivo, Documento doc)
        {
            BinaryWriter bw = null;

            try
            {
                bw = new BinaryWriter(new FileStream(
                    archivo, FileMode.Append, FileAccess.Write));

                bw.Write(doc.codigoExpediente);
                bw.Write(doc.rutaArchivo);
            }
            finally
            {
                if (bw != null)
                    bw.Close();
            }
        }

        // Verificar si el documento ya esta registrado
        static bool verificaDocumento(
            string archivo, Documento nuevo)
        {
            BinaryReader br = null;
            bool band = false;

            try
            {
                if (File.Exists(archivo))
                {
                    br = new BinaryReader(new FileStream(
                        archivo, FileMode.Open, FileAccess.Read));

                    Documento doc;

                    while (br.BaseStream.Position != br.BaseStream.Length)
                    {
                        doc.codigoExpediente = br.ReadString();
                        doc.rutaArchivo = br.ReadString();

                        if (doc.codigoExpediente == nuevo.codigoExpediente &&
                            doc.rutaArchivo == nuevo.rutaArchivo)
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

        // Buscar los documentos de un expediente
        static string buscarDocumentos(
            string archivo, string codigo)
        {
            BinaryReader br = null;

            string resultado = "";
            int cantidad = 0;

            try
            {
                if (File.Exists(archivo))
                {
                    br = new BinaryReader(new FileStream(
                        archivo, FileMode.Open, FileAccess.Read));

                    Documento doc;

                    while (br.BaseStream.Position != br.BaseStream.Length)
                    {
                        doc.codigoExpediente = br.ReadString();
                        doc.rutaArchivo = br.ReadString();

                        if (doc.codigoExpediente == codigo)
                        {
                            cantidad++;

                            resultado = resultado +
                                cantidad + ". " +
                                doc.rutaArchivo;

                            if (File.Exists(doc.rutaArchivo) == false)
                            {
                                resultado = resultado +
                                    " (Archivo no disponible)";
                            }

                            resultado = resultado + "\n";
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "No se pudieron consultar los documentos.";
            }
            finally
            {
                if (br != null)
                    br.Close();
            }

            if (cantidad == 0)
            {
                resultado = "No tiene documentos adjuntos.";
            }

            return resultado;
        }

        // Seleccionar y registrar un documento
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (modificando == true)
            {
                MessageBox.Show(
                    "Termine o cancele la modificación.");
                return;
            }

            if (codigoEncontrado == "" ||
                txtNroExpediente.Text != codigoEncontrado)
            {
                MessageBox.Show(
                    "Primero busque un expediente.");
                return;
            }

            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Seleccione el documento escaneado";

            openFile.Filter =
                "Documentos PDF (*.pdf)|*.pdf|" +
                "Archivos de Imagen (*.jpg;*.jpeg;*.png)|" +
                "*.jpg;*.jpeg;*.png";

            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Documento doc;

                doc.codigoExpediente = codigoEncontrado;
                doc.rutaArchivo = openFile.FileName;

                try
                {
                    if (verificaDocumento(
                        ficheroDocumentos, doc) == true)
                    {
                        MessageBox.Show(
                            "Este documento ya está registrado.");
                    }
                    else
                    {
                        if (File.Exists(ficheroDocumentos))
                        {
                            agregarFicheroDocumento(
                                ficheroDocumentos, doc);
                        }
                        else
                        {
                            crearFicheroDocumento(
                                ficheroDocumentos, doc);
                        }

                        MessageBox.Show(
                            "Documento vinculado correctamente.\n\n" +
                            "Expediente: " + doc.codigoExpediente +
                            "\nDocumento: " + doc.rutaArchivo);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "No se pudo registrar el documento.");
                }
            }

            openFile.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (codigoEncontrado == "" ||
                txtNroExpediente.Text != codigoEncontrado)
            {
                MessageBox.Show(
                    "Primero busque un expediente.");
                return;
            }

            if (modificando == false)
            {
                txtNombres.Enabled = true;
                txtFechaIngreso.Enabled = true;
                txtNroParte.Enabled = true;
                txtTipoTramite.Enabled = true;

                txtNroExpediente.Enabled = false;

                modificando = true;
                btnModificar.Text = "Guardar";

                txtNombres.Focus();
            }
            else
            {
                if (verificaTexto(txtNombres.Text) == false ||
                    verificaTexto(txtFechaIngreso.Text) == false ||
                    verificaTexto(txtNroParte.Text) == false ||
                    verificaTexto(txtTipoTramite.Text) == false)
                {
                    MessageBox.Show(
                        "Complete todos los campos.");
                    return;
                }

                if (MessageBox.Show(
                    "¿Desea guardar las modificaciones?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Modificar(
                        nombreFichero, codigoEncontrado) == true)
                    {
                        CargarExpedientes();
                        LimpiarCampos();
                    }
                }
            }
        }

        // Modificar un expediente mediante un archivo temporal
        public bool Modificar(string fichero, string codigo)
        {
            BinaryReader br = null;
            BinaryWriter bw_aux = null;

            string fic_temp = "temporal.dat";
            bool band = false;

            if (File.Exists(fichero) == false)
            {
                MessageBox.Show(
                    "No existen expedientes registrados.");
                return false;
            }

            try
            {
                br = new BinaryReader(new FileStream(
                    fichero, FileMode.Open, FileAccess.Read));

                bw_aux = new BinaryWriter(new FileStream(
                    fic_temp, FileMode.Create, FileAccess.Write));

                FrmRegistroExpediente.Expediente exp;

                while (br.BaseStream.Position != br.BaseStream.Length)
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

                    if (exp.codigo == codigo)
                    {
                        exp.remitente = txtNombres.Text;
                        exp.tipoDocumento = txtTipoTramite.Text;
                        exp.numeroDocumento = txtNroParte.Text;
                        exp.fechaIngreso = txtFechaIngreso.Text;

                        band = true;
                    }

                    bw_aux.Write(exp.codigo);
                    bw_aux.Write(exp.remitente);
                    bw_aux.Write(exp.tipoRemitente);
                    bw_aux.Write(exp.dniRuc);
                    bw_aux.Write(exp.tipoDocumento);
                    bw_aux.Write(exp.numeroDocumento);
                    bw_aux.Write(exp.asunto);
                    bw_aux.Write(exp.fechaIngreso);
                    bw_aux.Write(exp.observaciones);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo modificar el expediente.");
                return false;
            }
            finally
            {
                if (br != null)
                    br.Close();

                if (bw_aux != null)
                    bw_aux.Close();
            }

            if (band == true)
            {
                if (reemplazarFichero(
                    fichero, fic_temp) == true)
                {
                    MessageBox.Show(
                        "Expediente modificado correctamente.");

                    return true;
                }
            }
            else
            {
                File.Delete(fic_temp);

                MessageBox.Show(
                    "No se encontró el expediente.");
            }

            return false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (modificando == true)
            {
                MessageBox.Show(
                    "Termine o cancele la modificación.");
                return;
            }

            if (verificaTexto(txtNroExpediente.Text) == false)
            {
                MessageBox.Show(
                    "Ingrese el código del expediente que desea eliminar.");

                txtNroExpediente.Focus();
                return;
            }

            if (MessageBox.Show(
                "¿Está seguro de eliminar este expediente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string codigo = txtNroExpediente.Text;

                if (eliminarExpediente(
                    nombreFichero, codigo) == true)
                {
                    if (eliminarDocumentos(
                        ficheroDocumentos, codigo) == false)
                    {
                        MessageBox.Show(
                            "El expediente fue eliminado, pero no se pudieron eliminar todas sus vinculaciones.");
                    }

                    CargarExpedientes();
                    LimpiarCampos();
                }
            }
        }

        // Eliminar un expediente mediante un archivo temporal
        public static bool eliminarExpediente(
            string fichero, string codigo)
        {
            BinaryReader br = null;
            BinaryWriter bw_aux = null;

            string fic_temp = "temporal.dat";
            bool band = false;

            if (File.Exists(fichero) == false)
            {
                MessageBox.Show(
                    "No existen expedientes registrados.");
                return false;
            }

            try
            {
                br = new BinaryReader(new FileStream(
                    fichero, FileMode.Open, FileAccess.Read));

                bw_aux = new BinaryWriter(new FileStream(
                    fic_temp, FileMode.Create, FileAccess.Write));

                FrmRegistroExpediente.Expediente exp;

                while (br.BaseStream.Position != br.BaseStream.Length)
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

                    if (exp.codigo == codigo)
                    {
                        band = true;
                    }
                    else
                    {
                        bw_aux.Write(exp.codigo);
                        bw_aux.Write(exp.remitente);
                        bw_aux.Write(exp.tipoRemitente);
                        bw_aux.Write(exp.dniRuc);
                        bw_aux.Write(exp.tipoDocumento);
                        bw_aux.Write(exp.numeroDocumento);
                        bw_aux.Write(exp.asunto);
                        bw_aux.Write(exp.fechaIngreso);
                        bw_aux.Write(exp.observaciones);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo eliminar el expediente.");
                return false;
            }
            finally
            {
                if (br != null)
                    br.Close();

                if (bw_aux != null)
                    bw_aux.Close();
            }

            if (band == true)
            {
                if (reemplazarFichero(
                    fichero, fic_temp) == true)
                {
                    MessageBox.Show(
                        "Expediente eliminado correctamente.");

                    return true;
                }
            }
            else
            {
                File.Delete(fic_temp);

                MessageBox.Show(
                    "No se encontró el expediente.");
            }

            return false;
        }

        // Eliminar las vinculaciones de un expediente
        static bool eliminarDocumentos(
            string fichero, string codigo)
        {
            BinaryReader br = null;
            BinaryWriter bw_aux = null;

            string fic_temp = "temporalDocumentos.dat";
            bool band = false;

            if (File.Exists(fichero) == false)
            {
                return true;
            }

            try
            {
                br = new BinaryReader(new FileStream(
                    fichero, FileMode.Open, FileAccess.Read));

                bw_aux = new BinaryWriter(new FileStream(
                    fic_temp, FileMode.Create, FileAccess.Write));

                Documento doc;

                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    doc.codigoExpediente = br.ReadString();
                    doc.rutaArchivo = br.ReadString();

                    if (doc.codigoExpediente == codigo)
                    {
                        band = true;
                    }
                    else
                    {
                        bw_aux.Write(doc.codigoExpediente);
                        bw_aux.Write(doc.rutaArchivo);
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (br != null)
                    br.Close();

                if (bw_aux != null)
                    bw_aux.Close();
            }

            if (band == true)
            {
                return reemplazarFichero(fichero, fic_temp);
            }
            else
            {
                File.Delete(fic_temp);
                return true;
            }
        }

        // Reemplazar el archivo conservando un respaldo
        static bool reemplazarFichero(
            string fichero, string fic_temp)
        {
            string respaldo = fichero + ".bak";

            if (File.Exists(respaldo))
            {
                MessageBox.Show(
                    "Existe un archivo de respaldo pendiente de revisar.");
                return false;
            }

            try
            {
                File.Move(fichero, respaldo);
                File.Move(fic_temp, fichero);
            }
            catch (Exception)
            {
                try
                {
                    if (File.Exists(fichero) == false &&
                        File.Exists(respaldo) == true)
                    {
                        File.Move(respaldo, fichero);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Revise el archivo de respaldo: " +
                        respaldo);
                }

                MessageBox.Show(
                    "No se pudo actualizar el archivo.");

                return false;
            }

            try
            {
                File.Delete(respaldo);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "El archivo fue actualizado, pero se conservó el respaldo.");
            }

            return true;
        }

        // Contar los expedientes registrados
        static int contarExpedientes(string archivo)
        {
            BinaryReader br = null;
            int cantidad = 0;

            try
            {
                if (File.Exists(archivo))
                {
                    br = new BinaryReader(new FileStream(
                        archivo, FileMode.Open, FileAccess.Read));

                    FrmRegistroExpediente.Expediente exp;

                    while (br.BaseStream.Position != br.BaseStream.Length)
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

                        cantidad++;
                    }
                }
            }
            finally
            {
                if (br != null)
                    br.Close();
            }

            return cantidad;
        }

        // Cargar los expedientes en un arreglo de estructuras
        static void cargarArreglo(
            string archivo,
            FrmRegistroExpediente.Expediente[] expedientes)
        {
            BinaryReader br = null;

            try
            {
                br = new BinaryReader(new FileStream(
                    archivo, FileMode.Open, FileAccess.Read));

                for (int i = 0; i < expedientes.Length; i++)
                {
                    expedientes[i].codigo = br.ReadString();
                    expedientes[i].remitente = br.ReadString();
                    expedientes[i].tipoRemitente = br.ReadString();
                    expedientes[i].dniRuc = br.ReadString();
                    expedientes[i].tipoDocumento = br.ReadString();
                    expedientes[i].numeroDocumento = br.ReadString();
                    expedientes[i].asunto = br.ReadString();
                    expedientes[i].fechaIngreso = br.ReadString();
                    expedientes[i].observaciones = br.ReadString();
                }
            }
            finally
            {
                if (br != null)
                    br.Close();
            }
        }

        // Obtener la posicion alfabetica de un caracter
        static int valorLetra(char letra)
        {
            string mayusculas = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            string minusculas = "abcdefghijklmnñopqrstuvwxyz";

            switch (letra)
            {
                case 'Á':
                case 'á':
                    letra = 'A';
                    break;

                case 'É':
                case 'é':
                    letra = 'E';
                    break;

                case 'Í':
                case 'í':
                    letra = 'I';
                    break;

                case 'Ó':
                case 'ó':
                    letra = 'O';
                    break;

                case 'Ú':
                case 'ú':
                case 'Ü':
                case 'ü':
                    letra = 'U';
                    break;
            }

            if (letra == ' ')
            {
                return 0;
            }

            for (int i = 0; i < mayusculas.Length; i++)
            {
                if (letra == mayusculas[i] ||
                    letra == minusculas[i])
                {
                    return i + 1;
                }
            }

            return 100 + letra;
        }

        // Comparar dos nombres alfabeticamente
        static bool compararNombres(
            string nombre1, string nombre2)
        {
            int cantidad;
            int valor1;
            int valor2;

            if (nombre1.Length < nombre2.Length)
            {
                cantidad = nombre1.Length;
            }
            else
            {
                cantidad = nombre2.Length;
            }

            for (int i = 0; i < cantidad; i++)
            {
                valor1 = valorLetra(nombre1[i]);
                valor2 = valorLetra(nombre2[i]);

                if (valor1 > valor2)
                {
                    return true;
                }
                else if (valor1 < valor2)
                {
                    return false;
                }
            }

            if (nombre1.Length > nombre2.Length)
            {
                return true;
            }

            return false;
        }

        // Ordenamiento mediante el metodo burbuja
        static void ordenarBurbuja(
            FrmRegistroExpediente.Expediente[] expedientes)
        {
            FrmRegistroExpediente.Expediente aux;

            for (int x = 0; x < expedientes.Length; x++)
            {
                for (int i = 0; i < expedientes.Length - 1; i++)
                {
                    if (compararNombres(
                        expedientes[i].remitente,
                        expedientes[i + 1].remitente) == true)
                    {
                        aux = expedientes[i + 1];
                        expedientes[i + 1] = expedientes[i];
                        expedientes[i] = aux;
                    }
                }
            }
        }

        // Mostrar el arreglo ordenado
        private void mostrarArreglo(
            FrmRegistroExpediente.Expediente[] expedientes)
        {
            dgvExpedientes.Rows.Clear();

            for (int i = 0; i < expedientes.Length; i++)
            {
                dgvExpedientes.Rows.Add(
                    expedientes[i].codigo,
                    expedientes[i].remitente,
                    expedientes[i].tipoRemitente,
                    expedientes[i].dniRuc,
                    expedientes[i].tipoDocumento,
                    expedientes[i].numeroDocumento,
                    expedientes[i].asunto,
                    expedientes[i].fechaIngreso,
                    expedientes[i].observaciones);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (modificando == true)
            {
                MessageBox.Show(
                    "Termine o cancele la modificación.");
                return;
            }

            try
            {
                int cantidad = contarExpedientes(nombreFichero);

                if (cantidad <= 1)
                {
                    MessageBox.Show(
                        "No hay suficientes expedientes para ordenar.");
                    return;
                }

                FrmRegistroExpediente.Expediente[] expedientes =
                    new FrmRegistroExpediente.Expediente[cantidad];

                cargarArreglo(nombreFichero, expedientes);

                ordenarBurbuja(expedientes);

                mostrarArreglo(expedientes);

                MessageBox.Show(
                    "Remitentes ordenados alfabéticamente mediante el método burbuja.",
                    "Ordenamiento completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudieron ordenar los expedientes.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Limpiar los controles del formulario
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

            txtNroExpediente.Enabled = true;

            codigoEncontrado = "";
            modificando = false;

            btnModificar.Text = "Modificar";

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