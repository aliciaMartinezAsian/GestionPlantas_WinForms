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


        private int nextNumber = ctr.Obtener_Num_Imagenes() + 1;

        public Form3()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Width = 800;
            this.Height = 430;

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

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctr.GuardarCatalogo();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar el nombre científico
                string nombreCientifico = textBox1.Text;
                if (string.IsNullOrEmpty(nombreCientifico))
                {
                    throw new ArgumentException("El nombre científico no puede estar vacío.");
                }

                // Guardar el nombre común
                string nombreComun = textBox2.Text;
                if (string.IsNullOrEmpty(nombreComun))
                {
                    throw new ArgumentException("El nombre común no puede estar vacío.");
                }

                // Guardar la altura
                int altura;
                if (!int.TryParse(textBox3.Text, out altura))
                {
                    throw new ArgumentException("La altura debe ser un número válido.");
                }

                // Guardar las hojas
                string hojas = textBox4.Text;
                if (string.IsNullOrEmpty(hojas))
                {
                    throw new ArgumentException("El campo hojas no puede estar vacío.");
                }

                // Guardar si florece
                bool flor = Florece.Checked;

                // Guardar si tiene fruto
                bool fruto = checkBox1.Checked;

                // Guardar la toxicidad
                bool toxicidad = checkBox2.Checked;

                // Guardar la luz
                int luz = comboBox1.SelectedIndex;
                if (luz == -1)
                {
                    throw new ArgumentException("Debe seleccionar el tipo de luz.");
                }

                // Guardar la humedad
                int humedad = comboBox2.SelectedIndex;
                if (humedad == -1)
                {
                    throw new ArgumentException("Debe seleccionar el nivel de humedad.");
                }

                int num = nextNumber;

                // Crear la nueva instancia de PlantaInterior
                PlantaInterior plantaNueva = new PlantaInterior(nombreCientifico, nombreComun, altura, hojas, flor, fruto, num, luz, humedad, toxicidad);

                // Guardar la planta   
                ctr.GuardarPlanta(plantaNueva);

                nextNumber = ctr.Obtener_Num_Imagenes(); // Actualizar el contador          

                // Mostrar mensaje de éxito
                MessageBox.Show("Planta agregada con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos del formulario
                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                // Captura errores de argumentos como valores vacíos o incorrectos
                MessageBox.Show("Error: " + ex.Message, "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Captura cualquier otro error general
                MessageBox.Show("Error: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            pictureBox1.Image = pictureBox1.InitialImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Archivos de Imagen (*.jpg;*.jpeg)|*.jpg;*.jpeg",
                    Title = "Seleccionar imagen"
                };

                // Mostrar el diálogo y verificar si se seleccionó un archivo
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Definir la carpeta para guardar las imágenes
                    string folderPath = "../../../res";

                    // Crear la carpeta si no existe
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    int num = nextNumber;

                    // Generar el nombre de archivo único
                    string filePath = Path.Combine(folderPath, $"{num}.jpg");

                    // Copiar la imagen seleccionada al destino
                    File.Copy(ofd.FileName, filePath, true);

                    // Cargar la imagen seleccionada en el PictureBox
                    pictureBox1.Image = new Bitmap(filePath);

                    MessageBox.Show("Imagen cargada y guardada correctamente.", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar o guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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