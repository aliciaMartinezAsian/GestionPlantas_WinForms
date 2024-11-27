using GesttionPlantas.Controlador;
using GesttionPlantas.Modelo;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GestionPlantas_WinForms
{
    public partial class Form4 : Form
    {
        private static CtrPlanta ctr = CtrPlanta.ObtenerCtrPlanta();

        public Form4()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Width = 800;
            this.Height = 400;
        }

        private void verPlantasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void añadirPlantaDeInteriorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void añadirPlantaDeExteriorToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreCientifico = textBox1.Text;
            string nombreComun = textBox2.Text;
            int altura = Int32.Parse(textBox3.Text);
            string hojas = textBox4.Text;

            int tempMin = Int32.Parse(textBox6.Text);
            int tempMax = Int32.Parse(textBox7.Text);

            bool flor = Florece.Checked;
            bool fruto = checkBox1.Checked;
     
            int floracion = comboBox1.SelectedIndex;
           

            int cosecha = comboBox2.SelectedIndex;

            

            PlantaExterior plantaNueva = new PlantaExterior(nombreCientifico, nombreComun, altura, hojas, flor, fruto, tempMin, tempMax, floracion,cosecha);

            ctr.GuardarPlanta(plantaNueva);
            MessageBox.Show("Planta agregada con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();


        }

        private void LimpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Florece.Checked = false;
            checkBox1.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
           


        }
    }
}

