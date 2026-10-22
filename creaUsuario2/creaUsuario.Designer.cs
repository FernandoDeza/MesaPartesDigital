namespace formulario_creacion_de_cuenta
{
    partial class creaUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creaUsuario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtDocumento = new TextBox();
            txtCorreo = new TextBox();
            cxbTipoDoc = new ComboBox();
            label7 = new Label();
            cxbCargo = new ComboBox();
            dpxtFechaNacimiento = new DateTimePicker();
            label8 = new Label();
            btnRegistrar = new Button();
            btnVolver = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtContraseñaNueva = new TextBox();
            txtContraseñaConfirmacion = new TextBox();
            txtpictureojoCerrado = new PictureBox();
            txlOjocerrado = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtpictureojoCerrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txlOjocerrado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F);
            label1.Location = new Point(258, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 30);
            label1.TabIndex = 0;
            label1.Text = "CREAR NUEVA CUENTA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(244, 142);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(311, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Los Datos de su Nueva Cuenta";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(232, 196);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(232, 231);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 3;
            label4.Text = "Apellidos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(232, 303);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(216, 21);
            label5.TabIndex = 4;
            label5.Text = "Documento de Identidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(232, 336);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 21);
            label6.TabIndex = 5;
            label6.Text = "Correo Electronico:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(351, 197);
            txtNombres.Margin = new Padding(2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(219, 23);
            txtNombres.TabIndex = 6;
            txtNombres.TextChanged += textBox1_TextChanged;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(351, 232);
            txtApellidos.Margin = new Padding(2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(219, 23);
            txtApellidos.TabIndex = 7;
            txtApellidos.TextChanged += textBox2_TextChanged;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(517, 301);
            txtDocumento.Margin = new Padding(2);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(53, 23);
            txtDocumento.TabIndex = 8;
            txtDocumento.TextChanged += textBox3_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(408, 334);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(162, 23);
            txtCorreo.TabIndex = 9;
            // 
            // cxbTipoDoc
            // 
            cxbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cxbTipoDoc.FormattingEnabled = true;
            cxbTipoDoc.Items.AddRange(new object[] { "DNI", "CE" });
            cxbTipoDoc.Location = new Point(452, 301);
            cxbTipoDoc.Margin = new Padding(2);
            cxbTipoDoc.Name = "cxbTipoDoc";
            cxbTipoDoc.Size = new Size(61, 23);
            cxbTipoDoc.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(232, 368);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 11;
            label7.Text = "Tipo de Cargo:";
            // 
            // cxbCargo
            // 
            cxbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cxbCargo.FormattingEnabled = true;
            cxbCargo.Items.AddRange(new object[] { "Jefe de Registro", "Auxiliar de Registro", "Practicante" });
            cxbCargo.Location = new Point(408, 366);
            cxbCargo.Margin = new Padding(2);
            cxbCargo.Name = "cxbCargo";
            cxbCargo.Size = new Size(162, 23);
            cxbCargo.TabIndex = 12;
            // 
            // dpxtFechaNacimiento
            // 
            dpxtFechaNacimiento.Format = DateTimePickerFormat.Short;
            dpxtFechaNacimiento.Location = new Point(454, 266);
            dpxtFechaNacimiento.Margin = new Padding(2);
            dpxtFechaNacimiento.Name = "dpxtFechaNacimiento";
            dpxtFechaNacimiento.Size = new Size(116, 23);
            dpxtFechaNacimiento.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F);
            label8.Location = new Point(232, 268);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(183, 21);
            label8.TabIndex = 14;
            label8.Text = "Fecha de Nacimiento:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Goldenrod;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnRegistrar.Location = new Point(313, 479);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(214, 37);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar Cuenta";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Goldenrod;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnVolver.Location = new Point(313, 532);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(214, 33);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver al Inicio de Sesión";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += button2_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Goldenrod;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnSalir.Location = new Point(313, 583);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(214, 33);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -3);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(590, -3);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F);
            label9.Location = new Point(232, 401);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(240, 21);
            label9.TabIndex = 20;
            label9.Text = "Ingrese su nueva contraseña:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F);
            label10.Location = new Point(235, 437);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(199, 21);
            label10.TabIndex = 21;
            label10.Text = "Confirme su contraseña:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtContraseñaNueva
            // 
            txtContraseñaNueva.Location = new Point(472, 403);
            txtContraseñaNueva.Margin = new Padding(2);
            txtContraseñaNueva.Name = "txtContraseñaNueva";
            txtContraseñaNueva.Size = new Size(98, 23);
            txtContraseñaNueva.TabIndex = 23;
            txtContraseñaNueva.UseSystemPasswordChar = true;
            // 
            // txtContraseñaConfirmacion
            // 
            txtContraseñaConfirmacion.Location = new Point(472, 435);
            txtContraseñaConfirmacion.Margin = new Padding(2);
            txtContraseñaConfirmacion.Name = "txtContraseñaConfirmacion";
            txtContraseñaConfirmacion.Size = new Size(98, 23);
            txtContraseñaConfirmacion.TabIndex = 24;
            // 
            // txtpictureojoCerrado
            // 
            txtpictureojoCerrado.Image = (Image)resources.GetObject("txtpictureojoCerrado.Image");
            txtpictureojoCerrado.Location = new Point(532, 403);
            txtpictureojoCerrado.Margin = new Padding(2);
            txtpictureojoCerrado.Name = "txtpictureojoCerrado";
            txtpictureojoCerrado.Size = new Size(38, 23);
            txtpictureojoCerrado.SizeMode = PictureBoxSizeMode.Zoom;
            txtpictureojoCerrado.TabIndex = 25;
            txtpictureojoCerrado.TabStop = false;
            txtpictureojoCerrado.Click += txtpictureojoCerrado_Click;
            // 
            // txlOjocerrado
            // 
            txlOjocerrado.Image = (Image)resources.GetObject("txlOjocerrado.Image");
            txlOjocerrado.Location = new Point(532, 435);
            txlOjocerrado.Margin = new Padding(2);
            txlOjocerrado.Name = "txlOjocerrado";
            txlOjocerrado.Size = new Size(38, 23);
            txlOjocerrado.SizeMode = PictureBoxSizeMode.Zoom;
            txlOjocerrado.TabIndex = 26;
            txlOjocerrado.TabStop = false;
            txlOjocerrado.Click += txlOjocerrado_Click;
            // 
            // creaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 625);
            Controls.Add(txlOjocerrado);
            Controls.Add(txtpictureojoCerrado);
            Controls.Add(txtContraseñaConfirmacion);
            Controls.Add(txtContraseñaNueva);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrar);
            Controls.Add(label8);
            Controls.Add(dpxtFechaNacimiento);
            Controls.Add(cxbCargo);
            Controls.Add(label7);
            Controls.Add(cxbTipoDoc);
            Controls.Add(txtCorreo);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "creaUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtpictureojoCerrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)txlOjocerrado).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cxbTipoDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cxbCargo;
        private System.Windows.Forms.DateTimePicker dpxtFechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.TextBox txtContraseñaConfirmacion;
        private System.Windows.Forms.PictureBox txtpictureojoCerrado;
        private System.Windows.Forms.PictureBox txlOjocerrado;
    }
}

