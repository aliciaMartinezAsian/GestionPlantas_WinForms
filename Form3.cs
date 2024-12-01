using GesttionPlantas.Controlador;
using GesttionPlantas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPlantas_WinForms
{
    public partial class Form3 : Form
    {

        private static CtrPlanta ctr = CtrPlanta.ObtenerCtrPlanta();

        public Form3()
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

        private void añadirPlantaDeInteriorToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreCientifico = textBox1.Text;
            string nombreComun = textBox2.Text;
            int altura = Int32.Parse(textBox3.Text);
            string hojas = textBox4.Text;

            bool flor = Florece.Checked;
            bool fruto = checkBox1.Checked;
            bool toxicidad = checkBox2.Checked;
            int luz = comboBox1.SelectedIndex;
            

            int humedad = comboBox2.SelectedIndex;

           

            PlantaInterior plantaNueva = new PlantaInterior(nombreCientifico, nombreComun, altura, hojas, flor, fruto, luz, humedad, toxicidad);

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
            checkBox2.Checked = false;

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;


        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctr.GuardarCatalogo();
            this.Hide();
        }
    }
}
