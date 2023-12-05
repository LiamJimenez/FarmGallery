namespace Final
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            buttonIngresar = new Button();
            textBoxContraseña = new TextBox();
            textBoxUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            buttonSalir = new Button();
            panel2 = new Panel();
            label4 = new Label();
            buttonRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(232, 37);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "FarmGallery";
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.White;
            buttonIngresar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonIngresar.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonIngresar.Location = new Point(242, 290);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(123, 28);
            buttonIngresar.TabIndex = 15;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(202, 263);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(219, 23);
            textBoxContraseña.TabIndex = 14;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(202, 229);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(219, 23);
            textBoxUsuario.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(102, 265);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(43, 230);
            label3.Name = "label3";
            label3.Size = new Size(145, 17);
            label3.TabIndex = 3;
            label3.Text = "Nombre de Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(227, 64);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 138);
            panel1.TabIndex = 18;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.White;
            buttonSalir.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSalir.Location = new Point(10, 417);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(81, 31);
            buttonSalir.TabIndex = 17;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(10, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(478, 400);
            label4.Name = "label4";
            label4.Size = new Size(144, 16);
            label4.TabIndex = 20;
            label4.Text = "¿No estas registrado?";
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.White;
            buttonRegistrar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRegistrar.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonRegistrar.Location = new Point(495, 419);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(106, 29);
            buttonRegistrar.TabIndex = 21;
            buttonRegistrar.Text = "Registrarme";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(634, 458);
            Controls.Add(buttonRegistrar);
            Controls.Add(label4);
            Controls.Add(buttonSalir);
            Controls.Add(panel1);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxContraseña);
            Controls.Add(label2);
            Controls.Add(textBoxUsuario);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Name = "Login";
            Text = "FarmGallery";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxContraseña;
        private TextBox textBoxUsuario;
        private Button buttonIngresar;
        private Panel panel1;
        private Button buttonSalir;
        private Panel panel2;
        private Label label4;
        private Button buttonRegistrar;
    }
}