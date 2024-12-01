namespace GestionPlantas_WinForms
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            menuStrip1 = new MenuStrip();
            verPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeInteriorToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeExteriorToolStripMenuItem = new ToolStripMenuItem();
            buscarPlantasToolStripMenuItem = new ToolStripMenuItem();
            ordenarPlantasToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            checkBox2 = new CheckBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(128, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 50);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(128, 122);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 50);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(128, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(59, 23);
            textBox3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 70);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre científico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 128);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 15;
            label2.Text = "Nombre común";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 178);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 16;
            label3.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 70);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 17;
            label4.Text = "Hoja";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(503, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 336);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(339, 190);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Detalles";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(277, 165);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Da frutos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(164, 242);
            button2.Name = "button2";
            button2.Size = new Size(23, 23);
            button2.TabIndex = 25;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(318, 242);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 26;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(153, 279);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 27;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(277, 279);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 28;
            button5.Text = "Borrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { verPlantasToolStripMenuItem, añadirPlantasToolStripMenuItem, buscarPlantasToolStripMenuItem, ordenarPlantasToolStripMenuItem, guardarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 29;
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
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Enabled = false;
            checkBox2.Location = new Point(277, 127);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 19);
            checkBox2.TabIndex = 30;
            checkBox2.Text = "Florece";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(314, 66);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 50);
            textBox4.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 181);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 32;
            label5.Text = "cm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 327);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 33;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(217, 242, 180);
            ClientSize = new Size(784, 391);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(checkBox2);
            Controls.Add(menuStrip1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Bloom App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;

        private TextBox textBox2;

        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem verPlantasToolStripMenuItem;
        private ToolStripMenuItem añadirPlantasToolStripMenuItem;
        private ToolStripMenuItem añadirPlantaDeInteriorToolStripMenuItem;
        private ToolStripMenuItem añadirPlantaDeExteriorToolStripMenuItem;
        private ToolStripMenuItem buscarPlantasToolStripMenuItem;
        private ToolStripMenuItem ordenarPlantasToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private CheckBox checkBox2;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
    }
}