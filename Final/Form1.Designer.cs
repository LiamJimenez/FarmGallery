namespace Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxEmpresa = new TextBox();
            label7 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            elementToolStripMenuItem = new ToolStripMenuItem();
            farmaciaEspecificaToolStripMenuItem = new ToolStripMenuItem();
            farmaciaSanLuisToolStripMenuItem = new ToolStripMenuItem();
            farmaciaPisoFrancoToolStripMenuItem = new ToolStripMenuItem();
            farmaTodoToolStripMenuItem = new ToolStripMenuItem();
            porEstadoDeSaludToolStripMenuItem = new ToolStripMenuItem();
            buenoToolStripMenuItem = new ToolStripMenuItem();
            regularToolStripMenuItem = new ToolStripMenuItem();
            maloToolStripMenuItem = new ToolStripMenuItem();
            severoToolStripMenuItem = new ToolStripMenuItem();
            graveToolStripMenuItem = new ToolStripMenuItem();
            laboratorioEspecificoToolStripMenuItem = new ToolStripMenuItem();
            begingLabToolStripMenuItem = new ToolStripMenuItem();
            laboratorioDeSanJoseToolStripMenuItem = new ToolStripMenuItem();
            elPepeLabsToolStripMenuItem = new ToolStripMenuItem();
            tipoDeQuimicoUsadoToolStripMenuItem = new ToolStripMenuItem();
            acetaminofenToolStripMenuItem = new ToolStripMenuItem();
            diclofenacToolStripMenuItem = new ToolStripMenuItem();
            rb26ToolStripMenuItem = new ToolStripMenuItem();
            metodoDeAplicacionToolStripMenuItem = new ToolStripMenuItem();
            oralToolStripMenuItem = new ToolStripMenuItem();
            inyeccionToolStripMenuItem = new ToolStripMenuItem();
            directoEnSangreToolStripMenuItem = new ToolStripMenuItem();
            cremaToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            label8 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxEmpresa
            // 
            textBoxEmpresa.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmpresa.Location = new Point(208, 9);
            textBoxEmpresa.Margin = new Padding(3, 4, 3, 4);
            textBoxEmpresa.Multiline = true;
            textBoxEmpresa.Name = "textBoxEmpresa";
            textBoxEmpresa.Size = new Size(639, 36);
            textBoxEmpresa.TabIndex = 7;
            textBoxEmpresa.TextChanged += textBoxEmpresa_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(128, 128, 255);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(190, 34);
            label7.TabIndex = 11;
            label7.Text = "FarmGallery";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(853, 9);
            button1.Name = "button1";
            button1.Size = new Size(170, 36);
            button1.TabIndex = 15;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(9, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 29);
            panel1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, elementToolStripMenuItem, farmaciaEspecificaToolStripMenuItem, porEstadoDeSaludToolStripMenuItem, laboratorioEspecificoToolStripMenuItem, tipoDeQuimicoUsadoToolStripMenuItem, metodoDeAplicacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1011, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(63, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // elementToolStripMenuItem
            // 
            elementToolStripMenuItem.Name = "elementToolStripMenuItem";
            elementToolStripMenuItem.Size = new Size(156, 24);
            elementToolStripMenuItem.Text = "Articulos guardados";
            // 
            // farmaciaEspecificaToolStripMenuItem
            // 
            farmaciaEspecificaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { farmaciaSanLuisToolStripMenuItem, farmaciaPisoFrancoToolStripMenuItem, farmaTodoToolStripMenuItem });
            farmaciaEspecificaToolStripMenuItem.Name = "farmaciaEspecificaToolStripMenuItem";
            farmaciaEspecificaToolStripMenuItem.Size = new Size(152, 24);
            farmaciaEspecificaToolStripMenuItem.Text = "Farmacia especifica";
            // 
            // farmaciaSanLuisToolStripMenuItem
            // 
            farmaciaSanLuisToolStripMenuItem.Name = "farmaciaSanLuisToolStripMenuItem";
            farmaciaSanLuisToolStripMenuItem.Size = new Size(230, 26);
            farmaciaSanLuisToolStripMenuItem.Text = "Farmacia San Luis";
            // 
            // farmaciaPisoFrancoToolStripMenuItem
            // 
            farmaciaPisoFrancoToolStripMenuItem.Name = "farmaciaPisoFrancoToolStripMenuItem";
            farmaciaPisoFrancoToolStripMenuItem.Size = new Size(230, 26);
            farmaciaPisoFrancoToolStripMenuItem.Text = "Farmacia Piso Franco";
            // 
            // farmaTodoToolStripMenuItem
            // 
            farmaTodoToolStripMenuItem.Name = "farmaTodoToolStripMenuItem";
            farmaTodoToolStripMenuItem.Size = new Size(230, 26);
            farmaTodoToolStripMenuItem.Text = "FarmaTodo";
            // 
            // porEstadoDeSaludToolStripMenuItem
            // 
            porEstadoDeSaludToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buenoToolStripMenuItem, regularToolStripMenuItem, maloToolStripMenuItem, severoToolStripMenuItem, graveToolStripMenuItem });
            porEstadoDeSaludToolStripMenuItem.Name = "porEstadoDeSaludToolStripMenuItem";
            porEstadoDeSaludToolStripMenuItem.Size = new Size(128, 24);
            porEstadoDeSaludToolStripMenuItem.Text = "Estado de salud";
            // 
            // buenoToolStripMenuItem
            // 
            buenoToolStripMenuItem.Name = "buenoToolStripMenuItem";
            buenoToolStripMenuItem.Size = new Size(143, 26);
            buenoToolStripMenuItem.Text = "Bueno";
            // 
            // regularToolStripMenuItem
            // 
            regularToolStripMenuItem.Name = "regularToolStripMenuItem";
            regularToolStripMenuItem.Size = new Size(143, 26);
            regularToolStripMenuItem.Text = "Regular";
            // 
            // maloToolStripMenuItem
            // 
            maloToolStripMenuItem.Name = "maloToolStripMenuItem";
            maloToolStripMenuItem.Size = new Size(143, 26);
            maloToolStripMenuItem.Text = "Malo";
            // 
            // severoToolStripMenuItem
            // 
            severoToolStripMenuItem.Name = "severoToolStripMenuItem";
            severoToolStripMenuItem.Size = new Size(143, 26);
            severoToolStripMenuItem.Text = "Severo";
            // 
            // graveToolStripMenuItem
            // 
            graveToolStripMenuItem.Name = "graveToolStripMenuItem";
            graveToolStripMenuItem.Size = new Size(143, 26);
            graveToolStripMenuItem.Text = "Grave";
            // 
            // laboratorioEspecificoToolStripMenuItem
            // 
            laboratorioEspecificoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { begingLabToolStripMenuItem, laboratorioDeSanJoseToolStripMenuItem, elPepeLabsToolStripMenuItem });
            laboratorioEspecificoToolStripMenuItem.Name = "laboratorioEspecificoToolStripMenuItem";
            laboratorioEspecificoToolStripMenuItem.Size = new Size(172, 24);
            laboratorioEspecificoToolStripMenuItem.Text = "Laboratorio especifico";
            // 
            // begingLabToolStripMenuItem
            // 
            begingLabToolStripMenuItem.Name = "begingLabToolStripMenuItem";
            begingLabToolStripMenuItem.Size = new Size(251, 26);
            begingLabToolStripMenuItem.Text = "Beging Lab";
            // 
            // laboratorioDeSanJoseToolStripMenuItem
            // 
            laboratorioDeSanJoseToolStripMenuItem.Name = "laboratorioDeSanJoseToolStripMenuItem";
            laboratorioDeSanJoseToolStripMenuItem.Size = new Size(251, 26);
            laboratorioDeSanJoseToolStripMenuItem.Text = "Laboratorio de San Jose";
            // 
            // elPepeLabsToolStripMenuItem
            // 
            elPepeLabsToolStripMenuItem.Name = "elPepeLabsToolStripMenuItem";
            elPepeLabsToolStripMenuItem.Size = new Size(251, 26);
            elPepeLabsToolStripMenuItem.Text = "El Pepe Labs";
            // 
            // tipoDeQuimicoUsadoToolStripMenuItem
            // 
            tipoDeQuimicoUsadoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acetaminofenToolStripMenuItem, diclofenacToolStripMenuItem, rb26ToolStripMenuItem });
            tipoDeQuimicoUsadoToolStripMenuItem.Name = "tipoDeQuimicoUsadoToolStripMenuItem";
            tipoDeQuimicoUsadoToolStripMenuItem.Size = new Size(152, 24);
            tipoDeQuimicoUsadoToolStripMenuItem.Text = "Tipo de compuesto";
            tipoDeQuimicoUsadoToolStripMenuItem.Click += tipoDeQuimicoUsadoToolStripMenuItem_Click;
            // 
            // acetaminofenToolStripMenuItem
            // 
            acetaminofenToolStripMenuItem.Name = "acetaminofenToolStripMenuItem";
            acetaminofenToolStripMenuItem.Size = new Size(185, 26);
            acetaminofenToolStripMenuItem.Text = "Acetaminofen";
            // 
            // diclofenacToolStripMenuItem
            // 
            diclofenacToolStripMenuItem.Name = "diclofenacToolStripMenuItem";
            diclofenacToolStripMenuItem.Size = new Size(185, 26);
            diclofenacToolStripMenuItem.Text = "Diclofenac";
            // 
            // rb26ToolStripMenuItem
            // 
            rb26ToolStripMenuItem.Name = "rb26ToolStripMenuItem";
            rb26ToolStripMenuItem.Size = new Size(185, 26);
            rb26ToolStripMenuItem.Text = "Rb26";
            // 
            // metodoDeAplicacionToolStripMenuItem
            // 
            metodoDeAplicacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oralToolStripMenuItem, inyeccionToolStripMenuItem, directoEnSangreToolStripMenuItem, cremaToolStripMenuItem });
            metodoDeAplicacionToolStripMenuItem.Name = "metodoDeAplicacionToolStripMenuItem";
            metodoDeAplicacionToolStripMenuItem.Size = new Size(169, 24);
            metodoDeAplicacionToolStripMenuItem.Text = "Metodo de aplicacion";
            // 
            // oralToolStripMenuItem
            // 
            oralToolStripMenuItem.Name = "oralToolStripMenuItem";
            oralToolStripMenuItem.Size = new Size(209, 26);
            oralToolStripMenuItem.Text = "Oral";
            // 
            // inyeccionToolStripMenuItem
            // 
            inyeccionToolStripMenuItem.Name = "inyeccionToolStripMenuItem";
            inyeccionToolStripMenuItem.Size = new Size(209, 26);
            inyeccionToolStripMenuItem.Text = "Inyeccion";
            // 
            // directoEnSangreToolStripMenuItem
            // 
            directoEnSangreToolStripMenuItem.Name = "directoEnSangreToolStripMenuItem";
            directoEnSangreToolStripMenuItem.Size = new Size(209, 26);
            directoEnSangreToolStripMenuItem.Text = "Directo en sangre";
            // 
            // cremaToolStripMenuItem
            // 
            cremaToolStripMenuItem.Name = "cremaToolStripMenuItem";
            cremaToolStripMenuItem.Size = new Size(209, 26);
            cremaToolStripMenuItem.Text = "Crema";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(12, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 289);
            panel2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 402);
            label1.Name = "label1";
            label1.Size = new Size(402, 33);
            label1.TabIndex = 18;
            label1.Text = "Recomendados para la gripe";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Saca_Grip_jarabe_natural_rangel_1;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(30, 448);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 135);
            panel3.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 586);
            label2.Name = "label2";
            label2.Size = new Size(206, 18);
            label2.TabIndex = 20;
            label2.Text = "SACA-GRIP (Jarabe Natural)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 604);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 21;
            label3.Text = "RD $250.00";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(289, 448);
            panel4.Name = "panel4";
            panel4.Size = new Size(163, 135);
            panel4.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(254, 586);
            label4.Name = "label4";
            label4.Size = new Size(226, 18);
            label4.TabIndex = 23;
            label4.Text = "Resfridol (Jarabe contra la tos)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(328, 604);
            label5.Name = "label5";
            label5.Size = new Size(86, 18);
            label5.TabIndex = 24;
            label5.Text = "RD $350.00";
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(578, 448);
            panel5.Name = "panel5";
            panel5.Size = new Size(163, 135);
            panel5.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(514, 586);
            label6.Name = "label6";
            label6.Size = new Size(273, 18);
            label6.TabIndex = 26;
            label6.Text = "Inistolin pedriatico (Tos y congestion)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(619, 604);
            label8.Name = "label8";
            label8.Size = new Size(86, 18);
            label8.TabIndex = 27;
            label8.Text = "RD $275.00";
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(826, 448);
            panel6.Name = "panel6";
            panel6.Size = new Size(163, 135);
            panel6.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(817, 586);
            label9.Name = "label9";
            label9.Size = new Size(181, 18);
            label9.TabIndex = 29;
            label9.Text = "Gripaben (Solucion oral)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(867, 604);
            label10.Name = "label10";
            label10.Size = new Size(86, 18);
            label10.TabIndex = 30;
            label10.Text = "RD $175.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 670);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel6);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(panel5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBoxEmpresa);
            Controls.Add(label7);
            Controls.Add(panel2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "FarmGallery";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxEmpresa;
        private Label label7;
        private Button button1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem elementToolStripMenuItem;
        private ToolStripMenuItem farmaciaEspecificaToolStripMenuItem;
        private ToolStripMenuItem porEstadoDeSaludToolStripMenuItem;
        private ToolStripMenuItem laboratorioEspecificoToolStripMenuItem;
        private ToolStripMenuItem tipoDeQuimicoUsadoToolStripMenuItem;
        private ToolStripMenuItem metodoDeAplicacionToolStripMenuItem;
        private Panel panel2;
        private ToolStripMenuItem farmaciaSanLuisToolStripMenuItem;
        private ToolStripMenuItem farmaciaPisoFrancoToolStripMenuItem;
        private ToolStripMenuItem farmaTodoToolStripMenuItem;
        private ToolStripMenuItem buenoToolStripMenuItem;
        private ToolStripMenuItem regularToolStripMenuItem;
        private ToolStripMenuItem maloToolStripMenuItem;
        private ToolStripMenuItem severoToolStripMenuItem;
        private ToolStripMenuItem graveToolStripMenuItem;
        private ToolStripMenuItem begingLabToolStripMenuItem;
        private ToolStripMenuItem laboratorioDeSanJoseToolStripMenuItem;
        private ToolStripMenuItem elPepeLabsToolStripMenuItem;
        private ToolStripMenuItem acetaminofenToolStripMenuItem;
        private ToolStripMenuItem diclofenacToolStripMenuItem;
        private ToolStripMenuItem rb26ToolStripMenuItem;
        private ToolStripMenuItem oralToolStripMenuItem;
        private ToolStripMenuItem inyeccionToolStripMenuItem;
        private ToolStripMenuItem directoEnSangreToolStripMenuItem;
        private ToolStripMenuItem cremaToolStripMenuItem;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Panel panel5;
        private Label label6;
        private Label label8;
        private Panel panel6;
        private Label label9;
        private Label label10;
    }
}