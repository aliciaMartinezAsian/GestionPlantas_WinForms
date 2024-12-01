namespace GestionPlantas_WinForms
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            menuStrip1 = new MenuStrip();
            verPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeInteriorToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeExteriorToolStripMenuItem = new ToolStripMenuItem();
            buscarPlantasToolStripMenuItem = new ToolStripMenuItem();
            ordenarPlantasToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Items.AddRange(new ToolStripItem[] { verPlantasToolStripMenuItem, añadirPlantasToolStripMenuItem, buscarPlantasToolStripMenuItem, ordenarPlantasToolStripMenuItem, guardarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 3;
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
            añadirPlantaDeInteriorToolStripMenuItem.Click += añadirPlantaDeInteriorToolStripMenuItem_Click;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(733, 283);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 5;
            label1.Text = "Primer atributo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 45);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 45);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 7;
            label3.Text = "Segundo atributo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(605, 45);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nombre científico", "nombre común ", "Altura", "Hoja", "Flor", "Fruto" });
            comboBox1.Location = new Point(105, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(99, 23);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Nombre científico", "nombre común ", "Altura", "Hoja", "Flor", "Fruto" });
            comboBox2.Location = new Point(478, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(644, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(296, 360);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(415, 360);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Ordenar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 242, 180);
            ClientSize = new Size(784, 391);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "Buscar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}