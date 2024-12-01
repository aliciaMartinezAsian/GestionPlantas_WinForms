using GesttionPlantas.Controlador;
using GesttionPlantas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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
            this.Height = 430;

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

        private void ActualizarIndice()
        {
            label6.Text = $"Planta {index + 1} de {plantas.Count}";
        }

        private void ActualizarVista()
        {
            // Verificar si el índice es válido y si hay plantas en la lista
            if (index >= 0 && index < plantas.Count)
            {
                var plantaActual = plantas[index];
                textBox1.Text = plantaActual.NombreCientifico;
                textBox2.Text = plantaActual.NombreComun;
                textBox3.Text = plantaActual.Altura.ToString();
                textBox4.Text = plantaActual.Hoja;

                checkBox2.Checked = plantaActual.Flor;
                checkBox1.Checked = plantaActual.Fruto;

                // Comprobar si la foto existe antes de intentar cargarla
                string filePath = $"../../../res/{plantaActual.Foto}.jpg";

                // Verificar si el archivo existe
                if (File.Exists(filePath))
                {
                    // Cargar la imagen
                    pictureBox1.Image = new Bitmap(filePath);

                }
                else
                {
                    MessageBox.Show("No se encontró la imagen asociada a esta planta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pictureBox1.Image = null; // Limpiar la imagen si no se encuentra
                }

                plantaMasInfo = plantaActual;

                // Habilitar o deshabilitar los botones según el índice
                button2.Enabled = index > 0; // Deshabilita si estamos en el primer elemento
                button3.Enabled = index < plantas.Count - 1; // Deshabilita si estamos en el último elemento
                button5.Enabled = plantas.Count > 0 ; //Deshabilita si no hay elementos
            }

            else
            {
                MessageBox.Show("Índice fuera de rango.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ActualizarIndice();
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
                PlantaInterior planta = (PlantaInterior)plantaMasInfo;
                MessageBox.Show($"¿Es tóxica para perros o humanos?: {(planta.Toxicidad ? "sí" : "no")}\nIluminación: {planta.TipoIluminacion}\nHumedad: {planta.Humedad}", "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (plantaMasInfo is PlantaExterior exterior)
            {
                PlantaExterior planta = (PlantaExterior)plantaMasInfo;
                MessageBox.Show($"Temperatura mínima: {planta.TemperaturaMin}ºC\n Temperatura máxima: {planta.TemperaturaMax}ºC\n Época de floración: {planta.EpocaFloracion}\n Época de cosecha: {planta.EpocaCosecha}", "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (plantaMasInfo != null)
            {
                ctr.Eliminar(plantaMasInfo);
                plantas = ctr.ObtenerCatalogo();
                if (index >= plantas.Count)
                {
                    index = plantas.Count - 1; // Ajusta al último índice válido
                }
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("No hay ninguna planta seleccionada para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
