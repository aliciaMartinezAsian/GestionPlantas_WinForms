namespace GestionPlantas_WinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            verPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantasToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeInteriorToolStripMenuItem = new ToolStripMenuItem();
            añadirPlantaDeExteriorToolStripMenuItem = new ToolStripMenuItem();
            buscarPlantasToolStripMenuItem = new ToolStripMenuItem();
            ordenarPlantasToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
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
            pictureBox1.Location = new Point(22, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(740, 320);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(217, 242, 180);
            ClientSize = new Size(784, 361);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
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
        private ToolStripMenuItem añadirPlantaDeInteriorToolStripMenuItem;
        private ToolStripMenuItem añadirPlantaDeExteriorToolStripMenuItem;
        private ToolStripMenuItem buscarPlantasToolStripMenuItem;
        private ToolStripMenuItem ordenarPlantasToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}