namespace GestionPlantas_WinForms
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            menuStrip1 = new MenuStrip();
            verPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeInteriorToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeExteriorToolStripMenuItem = new ToolStripMenuItem();
            buscarPlantasToolStripMenuItem = new ToolStripMenuItem();
            ordenarPlantasToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            Florece = new CheckBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label5 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            comboBox2 = new ComboBox();
            label11 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { verPlantasToolStripMenuItem, añadirPlantasToolStripMenuItem, buscarPlantasToolStripMenuItem, ordenarPlantasToolStripMenuItem, guardarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // verPlantasToolStripMenuItem
            // 
            verPlantasToolStripMenuItem.Name = "verPlantasToolStripMenuItem";
            verPlantasToolStripMenuItem.Size = new Size(76, 20);
            verPlantasToolStripMenuItem.Text = "Ver plantas";
            verPlantasToolStripMenuItem.Click += verPlantasToolStripMenuItem_Click_1;
            // 
            // añadirPlantasToolStripMenuItem
            // 
            añadirPlantasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { añadirPlantaDeInteriorToolStripMenuItem, añadirPlantaDeExteriorToolStripMenuItem });
            añadirPlantasToolStripMenuItem.Name = "añadirPlantasToolStripMenuItem";
            añadirPlantasToolStripMenuItem.Size = new Size(95, 20);
            añadirPlantasToolStripMenuItem.Text = "Añadir plantas";
            // 
            // añadirPlantaDeInteriorToolStripMenuItem
            // 
            añadirPlantaDeInteriorToolStripMenuItem.Name = "añadirPlantaDeInteriorToolStripMenuItem";
            añadirPlantaDeInteriorToolStripMenuItem.Size = new Size(204, 22);
            añadirPlantaDeInteriorToolStripMenuItem.Text = "Añadir planta de interior";
            añadirPlantaDeInteriorToolStripMenuItem.Click += añadirPlantaDeInteriorToolStripMenuItem_Click_1;
            // 
            // añadirPlantaDeExteriorToolStripMenuItem
            // 
            añadirPlantaDeExteriorToolStripMenuItem.Name = "añadirPlantaDeExteriorToolStripMenuItem";
            añadirPlantaDeExteriorToolStripMenuItem.Size = new Size(204, 22);
            añadirPlantaDeExteriorToolStripMenuItem.Text = "Añadir planta de exterior";
            añadirPlantaDeExteriorToolStripMenuItem.Click += añadirPlantaDeExteriorToolStripMenuItem_Click_1;
            // 
            // buscarPlantasToolStripMenuItem
            // 
            buscarPlantasToolStripMenuItem.Name = "buscarPlantasToolStripMenuItem";
            buscarPlantasToolStripMenuItem.Size = new Size(95, 20);
            buscarPlantasToolStripMenuItem.Text = "Buscar plantas";
            buscarPlantasToolStripMenuItem.Click += buscarPlantasToolStripMenuItem_Click;
            // 
            // ordenarPlantasToolStripMenuItem
            // 
            ordenarPlantasToolStripMenuItem.Name = "ordenarPlantasToolStripMenuItem";
            ordenarPlantasToolStripMenuItem.Size = new Size(103, 20);
            ordenarPlantasToolStripMenuItem.Text = "Ordenar plantas";
            ordenarPlantasToolStripMenuItem.Click += ordenarPlantasToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(61, 20);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 54);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre científico";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 89);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 18;
            label2.Text = "Nombre común";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 122);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Altura";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(67, 23);
            textBox3.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 156);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 22;
            label4.Text = "Hoja";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 23;
            // 
            // Florece
            // 
            Florece.AutoSize = true;
            Florece.Location = new Point(144, 198);
            Florece.Name = "Florece";
            Florece.Size = new Size(57, 19);
            Florece.TabIndex = 25;
            Florece.Text = "Flores";
            Florece.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(533, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 336);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(299, 198);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Frutos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(236, 282);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 42;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(299, 132);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 43;
            label6.Text = "Temperatura min";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(411, 129);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(46, 23);
            textBox6.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(299, 161);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 45;
            label7.Text = "Temperatura max";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(411, 161);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(46, 23);
            textBox7.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(463, 132);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 47;
            label5.Text = "ºC";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(463, 164);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 48;
            label8.Text = "ºC";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Primavera", "Verano", "Otoño", "Invierno" });
            comboBox1.Location = new Point(360, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(295, 60);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 49;
            label9.Text = "Floración";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(299, 94);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 50;
            label10.Text = "Cosecha";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Primavera", "Verano", "Otoño", "Invierno" });
            comboBox2.Location = new Point(360, 94);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(220, 122);
            label11.Name = "label11";
            label11.Size = new Size(24, 15);
            label11.TabIndex = 52;
            label11.Text = "cm";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(217, 242, 180);
            ClientSize = new Size(784, 391);
            Controls.Add(label11);
            Controls.Add(comboBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(Florece);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "BloomApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem verPlantasToolStripMenuItem;
        private ToolStripMenuItem añadirPlantasToolStripMenuItem;
        private ToolStripMenuItem añadirPlantaDeInteriorToolStripMenuItem;
        private ToolStripMenuItem añadirPlantaDeExteriorToolStripMenuItem;
        private ToolStripMenuItem buscarPlantasToolStripMenuItem;
        private ToolStripMenuItem ordenarPlantasToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private CheckBox Florece;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Button button1;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label5;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private Label label10;
        private ComboBox comboBox2;
        private Label label11;
    }
}