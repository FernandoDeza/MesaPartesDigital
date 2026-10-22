namespace REG_EXP
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblTitulo = new Label();
            btnRegistrarExpediente = new Button();
            btnGestionExpedientes = new Button();
            btnCerrarSesion = new Button();
            pictureBox1 = new PictureBox();
            pictureOlivos = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOlivos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 26F);
            lblTitulo.Location = new Point(239, 156);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 42);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "MENÚ PRINCIPAL";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnRegistrarExpediente
            // 
            btnRegistrarExpediente.BackColor = Color.Goldenrod;
            btnRegistrarExpediente.BackgroundImageLayout = ImageLayout.Center;
            btnRegistrarExpediente.Cursor = Cursors.Hand;
            btnRegistrarExpediente.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnRegistrarExpediente.Location = new Point(239, 223);
            btnRegistrarExpediente.Name = "btnRegistrarExpediente";
            btnRegistrarExpediente.Size = new Size(299, 32);
            btnRegistrarExpediente.TabIndex = 8;
            btnRegistrarExpediente.Text = "REGISTRAR EXPEDIENTE";
            btnRegistrarExpediente.UseVisualStyleBackColor = false;
            btnRegistrarExpediente.Click += btnRegistrarExpediente_Click;
            // 
            // btnGestionExpedientes
            // 
            btnGestionExpedientes.BackColor = Color.Goldenrod;
            btnGestionExpedientes.BackgroundImageLayout = ImageLayout.Center;
            btnGestionExpedientes.Cursor = Cursors.Hand;
            btnGestionExpedientes.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnGestionExpedientes.Location = new Point(239, 277);
            btnGestionExpedientes.Name = "btnGestionExpedientes";
            btnGestionExpedientes.Size = new Size(299, 32);
            btnGestionExpedientes.TabIndex = 9;
            btnGestionExpedientes.Text = "GESTIÓN DE EXPEDIENTES";
            btnGestionExpedientes.UseVisualStyleBackColor = false;
            btnGestionExpedientes.Click += btnGestionExpedientes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Goldenrod;
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Center;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnCerrarSesion.Location = new Point(240, 330);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(299, 32);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(563, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureOlivos
            // 
            pictureOlivos.Image = (Image)resources.GetObject("pictureOlivos.Image");
            pictureOlivos.Location = new Point(48, 30);
            pictureOlivos.Name = "pictureOlivos";
            pictureOlivos.Size = new Size(164, 142);
            pictureOlivos.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOlivos.TabIndex = 11;
            pictureOlivos.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(753, 464);
            Controls.Add(pictureBox1);
            Controls.Add(pictureOlivos);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnGestionExpedientes);
            Controls.Add(btnRegistrarExpediente);
            Controls.Add(lblTitulo);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOlivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnRegistrarExpediente;
        private Button btnGestionExpedientes;
        private Button btnCerrarSesion;
        private PictureBox pictureBox1;
        private PictureBox pictureOlivos;
    }
}