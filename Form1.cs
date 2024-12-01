using GesttionPlantas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPlantas_WinForms
{
    public partial class Form1 : Form
    {
        private static CtrPlanta ctr = CtrPlanta.ObtenerCtrPlanta();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Width = 800;
            this.Height = 400;
        }

        private void verPlantasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void añadirPlantaDeInteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void añadirPlantaDeExteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctr.GuardarCatalogo();
            this.Hide();
        }

        private void buscarPlantasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();

        }

        private void ordenarPlantasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
    }
}
