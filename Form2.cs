using GesttionPlantas.Controlador;
using GesttionPlantas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GestionPlantas_WinForms
{

    public partial class Form2 : Form
    {

        private static List<Planta> plantas = new List<Planta>();
        private static CtrPlanta ctr = CtrPlanta.ObtenerCtrPlanta();
        private static int index = 0;
        private static Planta plantaMasInfo;

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Width = 800;
            this.Height = 400;

            ctr.CargarCatalogo();
            plantas = ctr.ObtenerCatalogo();

            // Si hay plantas, muestra la primera
            if (plantas.Count > 0)
            {
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("No hay plantas en el catálogo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarVista()
        {
            // Si el índice es válido y hay plantas en la lista
            if (index < plantas.Count && index >= 0)
            {
                var plantaActual = plantas[index];
                textBox1.Text = plantaActual.NombreCientifico;
                textBox2.Text = plantaActual.NombreComun;
                textBox3.Text = plantaActual.Altura.ToString();
                textBox4.Text = plantaActual.Hoja;

                checkBox2.Checked = plantaActual.Flor;
                checkBox1.Checked = plantaActual.Fruto;

                plantaMasInfo = plantaActual;

                // Habilita o deshabilita los botones según el índice
                button2.Enabled = index > 0; // Deshabilita si estamos en el primer elemento
                button3.Enabled = index < plantas.Count - 1; // Deshabilita si estamos en el último elemento
            }
            else
            {
                MessageBox.Show("Índice fuera de rango.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--; // Decrementa el índice
            ActualizarVista();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            index++; // Incrementa el índice
            ActualizarVista();

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


        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica el tipo de planta para mostrar atributos específicos
            if (plantaMasInfo is PlantaInterior interior)
            {


            }
            else if (plantaMasInfo is PlantaExterior exterior)
            {

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

            if (plantaMasInfo is PlantaInterior)
            {
                Form5 interior = new Form5(index);
                interior.Show();

            }
            if (plantaMasInfo is PlantaExterior)
            {
                Form6 exterior = new Form6(index);
                exterior.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ctr.Eliminar(plantaMasInfo);
            plantas = ctr.ObtenerCatalogo();
            index--;
            ActualizarVista();
        }


        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctr.GuardarCatalogo();
            this.Hide();
        }


    }
}
