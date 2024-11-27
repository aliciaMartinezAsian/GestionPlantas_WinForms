namespace GestionPlantas_WinForms
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            Florece = new CheckBox();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre científico";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 18;
            label2.Text = "Nombre común";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Altura";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 22;
            label4.Text = "Hoja";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(131, 172);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 26;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(271, 116);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 19);
            checkBox2.TabIndex = 38;
            checkBox2.Text = "Toxicidad";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(232, 260);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 39;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(529, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 261);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // Florece
            // 
            Florece.AutoSize = true;
            Florece.Location = new Point(271, 150);
            Florece.Name = "Florece";
            Florece.Size = new Size(57, 19);
            Florece.TabIndex = 42;
            Florece.Text = "Flores";
            Florece.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(271, 185);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 43;
            checkBox1.Text = "Frutos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Muy baja", "Baja", "Media", "Alta", "Muy Alta" });
            comboBox2.Location = new Point(356, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 78);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 46;
            label6.Text = "Humedad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Muy baja", "Baja", "Media", "Alta", "Muy Alta" });
            comboBox1.Location = new Point(356, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 40);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 44;
            label5.Text = "Iluminación";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 183, 195);
            ClientSize = new Size(784, 361);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(Florece);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private CheckBox checkBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private CheckBox Florece;
        private CheckBox checkBox1;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
    }
}