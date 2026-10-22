namespace registro_de_expedientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNroExpediente = new TextBox();
            btnBuscar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnCargar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtNombres = new TextBox();
            txtFechaIngreso = new TextBox();
            txtNroParte = new TextBox();
            txtTipoTramite = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            dgvExpedientes = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colRemitente = new DataGridViewTextBoxColumn();
            colTipoRemitente = new DataGridViewTextBoxColumn();
            colDniRuc = new DataGridViewTextBoxColumn();
            colTipoDocumento = new DataGridViewTextBoxColumn();
            colNumeroDocumento = new DataGridViewTextBoxColumn();
            colAsunto = new DataGridViewTextBoxColumn();
            colFechaIngreso = new DataGridViewTextBoxColumn();
            colObservaciones = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpedientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F);
            label1.Location = new Point(263, 77);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(463, 30);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN Y BÚSQUEDA DE EXPEDIENTES";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(411, 117);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 1;
            label2.Text = "Panel de Búsqueda";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(138, 172);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 2;
            label3.Text = "Código de Expediente";
            // 
            // txtNroExpediente
            // 
            txtNroExpediente.Location = new Point(433, 175);
            txtNroExpediente.Margin = new Padding(2);
            txtNroExpediente.Name = "txtNroExpediente";
            txtNroExpediente.Size = new Size(270, 23);
            txtNroExpediente.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Goldenrod;
            btnBuscar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnBuscar.Location = new Point(709, 167);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 38);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(138, 255);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 5;
            label4.Text = "Remitente:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(136, 299);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 21);
            label5.TabIndex = 6;
            label5.Text = "Fecha de ingreso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(136, 347);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(159, 21);
            label6.TabIndex = 7;
            label6.Text = "N.º de Documento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(138, 395);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(169, 21);
            label7.TabIndex = 8;
            label7.Text = "Tipo de Documento:";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.Goldenrod;
            btnCargar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnCargar.Location = new Point(139, 634);
            btnCargar.Margin = new Padding(2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(107, 61);
            btnCargar.TabIndex = 9;
            btnCargar.Text = "Cargar Archivo";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Goldenrod;
            btnModificar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnModificar.Location = new Point(262, 634);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 61);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Goldenrod;
            btnEliminar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnEliminar.Location = new Point(385, 634);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 61);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Goldenrod;
            btnLimpiar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnLimpiar.Location = new Point(506, 634);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 61);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Goldenrod;
            btnSalir.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnSalir.Location = new Point(707, 634);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 61);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(299, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, -5);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(788, -5);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // txtNombres
            // 
            txtNombres.Enabled = false;
            txtNombres.Location = new Point(433, 256);
            txtNombres.Margin = new Padding(2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(270, 23);
            txtNombres.TabIndex = 17;
            // 
            // txtFechaIngreso
            // 
            txtFechaIngreso.Enabled = false;
            txtFechaIngreso.Location = new Point(433, 299);
            txtFechaIngreso.Margin = new Padding(2);
            txtFechaIngreso.Name = "txtFechaIngreso";
            txtFechaIngreso.Size = new Size(270, 23);
            txtFechaIngreso.TabIndex = 18;
            // 
            // txtNroParte
            // 
            txtNroParte.Enabled = false;
            txtNroParte.Location = new Point(433, 348);
            txtNroParte.Margin = new Padding(2);
            txtNroParte.Name = "txtNroParte";
            txtNroParte.Size = new Size(270, 23);
            txtNroParte.TabIndex = 19;
            // 
            // txtTipoTramite
            // 
            txtTipoTramite.Enabled = false;
            txtTipoTramite.Location = new Point(433, 396);
            txtTipoTramite.Margin = new Padding(2);
            txtTipoTramite.Name = "txtTipoTramite";
            txtTipoTramite.Size = new Size(270, 23);
            txtTipoTramite.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(141, 217);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(672, 23);
            textBox6.TabIndex = 21;
            textBox6.Text = "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(141, 444);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(672, 23);
            textBox7.TabIndex = 22;
            textBox7.Text = "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // dgvExpedientes
            // 
            dgvExpedientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpedientes.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colRemitente, colTipoRemitente, colDniRuc, colTipoDocumento, colNumeroDocumento, colAsunto, colFechaIngreso, colObservaciones });
            dgvExpedientes.Location = new Point(12, 482);
            dgvExpedientes.Name = "dgvExpedientes";
            dgvExpedientes.Size = new Size(944, 138);
            dgvExpedientes.TabIndex = 23;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            // 
            // colRemitente
            // 
            colRemitente.HeaderText = "Remitente";
            colRemitente.Name = "colRemitente";
            // 
            // colTipoRemitente
            // 
            colTipoRemitente.HeaderText = "Tipo Remitente";
            colTipoRemitente.Name = "colTipoRemitente";
            // 
            // colDniRuc
            // 
            colDniRuc.HeaderText = "DNI / RUC";
            colDniRuc.Name = "colDniRuc";
            // 
            // colTipoDocumento
            // 
            colTipoDocumento.HeaderText = "Tipo Documento";
            colTipoDocumento.Name = "colTipoDocumento";
            // 
            // colNumeroDocumento
            // 
            colNumeroDocumento.HeaderText = "N.º Documento";
            colNumeroDocumento.Name = "colNumeroDocumento";
            // 
            // colAsunto
            // 
            colAsunto.HeaderText = "Asunto";
            colAsunto.Name = "colAsunto";
            // 
            // colFechaIngreso
            // 
            colFechaIngreso.HeaderText = "Fecha Ingreso";
            colFechaIngreso.Name = "colFechaIngreso";
            // 
            // colObservaciones
            // 
            colObservaciones.HeaderText = "Observaciones";
            colObservaciones.Name = "colObservaciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(966, 708);
            Controls.Add(dgvExpedientes);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(txtTipoTramite);
            Controls.Add(txtNroParte);
            Controls.Add(txtFechaIngreso);
            Controls.Add(txtNombres);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCargar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(txtNroExpediente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExpedientes).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroExpediente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtNroParte;
        private System.Windows.Forms.TextBox txtTipoTramite;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private DataGridView dgvExpedientes;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colRemitente;
        private DataGridViewTextBoxColumn colTipoRemitente;
        private DataGridViewTextBoxColumn colDniRuc;
        private DataGridViewTextBoxColumn colTipoDocumento;
        private DataGridViewTextBoxColumn colNumeroDocumento;
        private DataGridViewTextBoxColumn colAsunto;
        private DataGridViewTextBoxColumn colFechaIngreso;
        private DataGridViewTextBoxColumn colObservaciones;
    }
}

