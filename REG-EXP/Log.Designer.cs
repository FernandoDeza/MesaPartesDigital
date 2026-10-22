namespace REG_EXP
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            btsalida = new Button();
            bttingresa = new Button();
            tbusuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureOlivos = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOlivos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 240, 241);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btsalida);
            panel1.Controls.Add(bttingresa);
            panel1.Controls.Add(tbusuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureOlivos);
            panel1.Location = new Point(183, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 507);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(384, 301);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(74, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 15);
            textBox2.TabIndex = 15;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Goldenrod;
            textBox3.Enabled = false;
            textBox3.Location = new Point(70, 291);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(342, 52);
            textBox3.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(70, 267);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 13;
            label3.Text = "Clave:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(384, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(74, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 15);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 12F);
            linkLabel1.Location = new Point(181, 406);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(122, 21);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Usuario Nuevo";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btsalida
            // 
            btsalida.BackColor = Color.Goldenrod;
            btsalida.BackgroundImageLayout = ImageLayout.Center;
            btsalida.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btsalida.Location = new Point(195, 444);
            btsalida.Name = "btsalida";
            btsalida.Size = new Size(91, 32);
            btsalida.TabIndex = 8;
            btsalida.Text = "SALIR";
            btsalida.UseVisualStyleBackColor = false;
            btsalida.Click += btregistro_Click;
            // 
            // bttingresa
            // 
            bttingresa.BackColor = Color.Goldenrod;
            bttingresa.BackgroundImageLayout = ImageLayout.Center;
            bttingresa.Cursor = Cursors.Hand;
            bttingresa.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            bttingresa.Location = new Point(90, 361);
            bttingresa.Name = "bttingresa";
            bttingresa.Size = new Size(299, 32);
            bttingresa.TabIndex = 7;
            bttingresa.Text = "INGRESAR";
            bttingresa.UseVisualStyleBackColor = false;
            bttingresa.Click += bttingresa_Click;
            // 
            // tbusuario
            // 
            tbusuario.BackColor = Color.Goldenrod;
            tbusuario.Enabled = false;
            tbusuario.Location = new Point(70, 205);
            tbusuario.Multiline = true;
            tbusuario.Name = "tbusuario";
            tbusuario.Size = new Size(342, 52);
            tbusuario.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(70, 181);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F);
            label1.Location = new Point(141, 126);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 2;
            label1.Text = "INICIO DE SESIÓN";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(334, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureOlivos
            // 
            pictureOlivos.Image = (Image)resources.GetObject("pictureOlivos.Image");
            pictureOlivos.Location = new Point(3, 3);
            pictureOlivos.Name = "pictureOlivos";
            pictureOlivos.Size = new Size(122, 120);
            pictureOlivos.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOlivos.TabIndex = 0;
            pictureOlivos.TabStop = false;
            pictureOlivos.Click += pictureBox1_Click;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 510);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Log";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOlivos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureOlivos;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btsalida;
        private Button bttingresa;
        private TextBox tbusuario;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
    }
}
