namespace GestionPlantas_WinForms
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            menuStrip1 = new MenuStrip();
            verPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeInteriorToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeExteriorToolStripMenuItem = new ToolStripMenuItem();
            buscarPlantasToolStripMenuItem = new ToolStripMenuItem();
            ordenarPlantasToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            Florece = new CheckBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            checkBox2 = new CheckBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
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
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // verPlantasToolStripMenuItem
            // 
            verPlantasToolStripMenuItem.Name = "verPlantasToolStripMenuItem";
            verPlantasToolStripMenuItem.Size = new Size(76, 20);
            verPlantasToolStripMenuItem.Text = "Ver plantas";
            verPlantasToolStripMenuItem.Click += verPlantasToolStripMenuItem_Click;
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
            añadirPlantaDeExteriorToolStripMenuItem.Click += añadirPlantaDeExteriorToolStripMenuItem_Click;
            // 
            // buscarPlantasToolStripMenuItem
            // 
            buscarPlantasToolStripMenuItem.Name = "buscarPlantasToolStripMenuItem";
            buscarPlantasToolStripMenuItem.Size = new Size(95, 20);
            buscarPlantasToolStripMenuItem.Text = "Buscar plantas";
            // 
            // ordenarPlantasToolStripMenuItem
            // 
            ordenarPlantasToolStripMenuItem.Name = "ordenarPlantasToolStripMenuItem";
            ordenarPlantasToolStripMenuItem.Size = new Size(103, 20);
            ordenarPlantasToolStripMenuItem.Text = "Ordenar plantas";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(61, 20);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(531, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 261);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 198);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 21;
            label4.Text = "Hoja";
            // 
            // Florece
            // 
            Florece.AutoSize = true;
            Florece.Location = new Point(267, 167);
            Florece.Name = "Florece";
            Florece.Size = new Size(57, 19);
            Florece.TabIndex = 24;
            Florece.Text = "Flores";
            Florece.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 157);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 19;
            label3.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 114);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 17;
            label2.Text = "Nombre común";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 69);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 15;
            label1.Text = "Nombre científico";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 25;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(267, 194);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "Frutos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(217, 281);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 29;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(267, 142);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 19);
            checkBox2.TabIndex = 37;
            checkBox2.Text = "Toxicidad";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 69);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 39;
            label5.Text = "Iluminación";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Muy baja", "Baja", "Media", "Alta", "Muy Alta" });
            comboBox1.Location = new Point(352, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 104);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 41;
            label6.Text = "Humedad";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Muy baja", "Baja", "Media", "Alta", "Muy Alta" });
            comboBox2.Location = new Point(352, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 42;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 242, 180);
            ClientSize = new Size(784, 361);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(checkBox2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox4);
            Controls.Add(Florece);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Bloom App";
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
        private ToolStripMenuItem buscarPlantasToolStripMenuItem;
        private ToolStripMenuItem ordenarPlantasToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label4;
        private CheckBox Florece;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox4;
        private CheckBox checkBox1;
        private ToolStripMenuItem añadirPlantaDeInteriorToolStripMenuItem;
        private ToolStripMenuItem añadirPlantaDeExteriorToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private Button button1;
        private CheckBox checkBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox comboBox2;
    }
}