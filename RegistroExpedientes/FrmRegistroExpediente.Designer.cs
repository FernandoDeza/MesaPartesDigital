namespace RegistroExpedientes
{
    partial class FrmRegistroExpediente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroExpediente));
            lblCodigo = new Label();
            lblRemitente = new Label();
            txtRemitente = new TextBox();
            lblTipoRemitente = new Label();
            cboTipoRemitente = new ComboBox();
            lblTipoDocumento = new Label();
            cboTipoDocumento = new ComboBox();
            lblNumeroDocumento = new Label();
            txtNumeroDocumento = new TextBox();
            lblAsunto = new Label();
            txtAsunto = new TextBox();
            lblFechaIngreso = new Label();
            dtpFechaIngreso = new DateTimePicker();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            picLosOlivos = new PictureBox();
            picUPN = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLosOlivos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUPN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(209, 110);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(190, 21);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código de Expediente:";
            // 
            // lblRemitente
            // 
            lblRemitente.AutoSize = true;
            lblRemitente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemitente.Location = new Point(209, 148);
            lblRemitente.Name = "lblRemitente";
            lblRemitente.Size = new Size(96, 21);
            lblRemitente.TabIndex = 4;
            lblRemitente.Text = "Remitente:";
            // 
            // txtRemitente
            // 
            txtRemitente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemitente.Location = new Point(414, 145);
            txtRemitente.Name = "txtRemitente";
            txtRemitente.Size = new Size(250, 27);
            txtRemitente.TabIndex = 5;
            // 
            // lblTipoRemitente
            // 
            lblTipoRemitente.AutoSize = true;
            lblTipoRemitente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoRemitente.Location = new Point(209, 188);
            lblTipoRemitente.Name = "lblTipoRemitente";
            lblTipoRemitente.Size = new Size(157, 21);
            lblTipoRemitente.TabIndex = 6;
            lblTipoRemitente.Text = "Tipo de Remitente:";
            // 
            // cboTipoRemitente
            // 
            cboTipoRemitente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoRemitente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipoRemitente.FormattingEnabled = true;
            cboTipoRemitente.Items.AddRange(new object[] { "Persona", "Organización" });
            cboTipoRemitente.Location = new Point(414, 185);
            cboTipoRemitente.Name = "cboTipoRemitente";
            cboTipoRemitente.Size = new Size(250, 29);
            cboTipoRemitente.TabIndex = 7;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoDocumento.Location = new Point(209, 230);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(169, 21);
            lblTipoDocumento.TabIndex = 8;
            lblTipoDocumento.Text = "Tipo de Documento:";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Items.AddRange(new object[] { "Solicitud", "Carta", "Oficio", "Otro" });
            cboTipoDocumento.Location = new Point(414, 227);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(250, 29);
            cboTipoDocumento.TabIndex = 9;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroDocumento.Location = new Point(209, 272);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(159, 21);
            lblNumeroDocumento.TabIndex = 10;
            lblNumeroDocumento.Text = "N.º de Documento:";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroDocumento.Location = new Point(414, 269);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(250, 27);
            txtNumeroDocumento.TabIndex = 11;
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAsunto.Location = new Point(209, 311);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new Size(60, 21);
            lblAsunto.TabIndex = 12;
            lblAsunto.Text = "Parte :";
            // 
            // txtAsunto
            // 
            txtAsunto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAsunto.Location = new Point(414, 308);
            txtAsunto.Name = "txtAsunto";
            txtAsunto.Size = new Size(250, 27);
            txtAsunto.TabIndex = 13;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaIngreso.Location = new Point(209, 353);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(149, 21);
            lblFechaIngreso.TabIndex = 14;
            lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaIngreso.Location = new Point(414, 348);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(314, 27);
            dtpFechaIngreso.TabIndex = 15;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObservaciones.Location = new Point(209, 394);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(130, 21);
            lblObservaciones.TabIndex = 16;
            lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservaciones.Location = new Point(414, 391);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(350, 60);
            txtObservaciones.TabIndex = 17;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Goldenrod;
            btnRegistrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(158, 471);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(200, 45);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "REGISTRAR DOCUMENTO";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Goldenrod;
            btnLimpiar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(414, 471);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 45);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Goldenrod;
            btnVolver.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(672, 471);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(200, 45);
            btnVolver.TabIndex = 20;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // picLosOlivos
            // 
            picLosOlivos.Image = (Image)resources.GetObject("picLosOlivos.Image");
            picLosOlivos.Location = new Point(25, 22);
            picLosOlivos.Name = "picLosOlivos";
            picLosOlivos.Size = new Size(145, 147);
            picLosOlivos.SizeMode = PictureBoxSizeMode.Zoom;
            picLosOlivos.TabIndex = 21;
            picLosOlivos.TabStop = false;
            // 
            // picUPN
            // 
            picUPN.Image = (Image)resources.GetObject("picUPN.Image");
            picUPN.Location = new Point(713, 36);
            picUPN.Name = "picUPN";
            picUPN.Size = new Size(145, 123);
            picUPN.SizeMode = PictureBoxSizeMode.Zoom;
            picUPN.TabIndex = 22;
            picUPN.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(414, 110);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 24;
            label1.Text = "EX0000001";
            // 
            // FrmRegistroExpediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(884, 561);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(picUPN);
            Controls.Add(picLosOlivos);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtObservaciones);
            Controls.Add(lblObservaciones);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(lblFechaIngreso);
            Controls.Add(txtAsunto);
            Controls.Add(lblAsunto);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(lblNumeroDocumento);
            Controls.Add(cboTipoDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(cboTipoRemitente);
            Controls.Add(lblTipoRemitente);
            Controls.Add(txtRemitente);
            Controls.Add(lblRemitente);
            Controls.Add(lblCodigo);
            Name = "FrmRegistroExpediente";
            Text = "REGISTRO DE EXPEDIENTES";
            ((System.ComponentModel.ISupportInitialize)picLosOlivos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUPN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCodigo;
        private Label lblRemitente;
        private TextBox txtRemitente;
        private Label lblTipoRemitente;
        private ComboBox cboTipoRemitente;
        private Label lblTipoDocumento;
        private ComboBox cboTipoDocumento;
        private Label lblNumeroDocumento;
        private TextBox txtNumeroDocumento;
        private Label lblAsunto;
        private TextBox txtAsunto;
        private Label lblFechaIngreso;
        private DateTimePicker dtpFechaIngreso;
        private Label lblObservaciones;
        private TextBox txtObservaciones;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private PictureBox picLosOlivos;
        private PictureBox picUPN;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
