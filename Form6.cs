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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionPlantas_WinForms
{
    public partial class Form6 : Form
    {
        private static List<Planta> plantas = new List<Planta>();
        private static CtrPlanta ctr = CtrPlanta.ObtenerCtrPlanta();
        private static int indice = 0;
        private int nextNumber = ctr.Obtener_Num_Imagenes();

        public Form6(int index)
        {

            indice = index;
            InitializeComponent();

            this.Width = 800;
            this.Height = 430;

            ctr.CargarCatalogo();
            plantas = ctr.ObtenerCatalogo();

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

                // Guardar las temperaturas mínima y máxima
                int tempMin, tempMax;
                if (!int.TryParse(textBox8.Text, out tempMin))
                {
                    throw new ArgumentException("La temperatura mínima debe ser un número válido.");
                }
                if (!int.TryParse(textBox5.Text, out tempMax))
                {
                    throw new ArgumentException("La temperatura máxima debe ser un número válido.");
                }
                if (tempMin >= tempMax)
                {
                    throw new ArgumentException("La temperatura mínima debe ser menor que la máxima.");
                }

                // Guardar si florece
                bool flor = Florece.Checked;

                // Guardar si tiene fruto
                bool fruto = checkBox1.Checked;

                // Guardar el índice de floración
                int floracion = comboBox1.SelectedIndex;
                

                // Guardar el índice de cosecha
                int cosecha = comboBox2.SelectedIndex;
                

                // Generar el identificador único para la planta
                int num = nextNumber;

                // Crear la nueva instancia de PlantaExterior
                PlantaExterior plantaModificada = new PlantaExterior(nombreCientifico, nombreComun, altura, hojas, flor, fruto, num, tempMin, tempMax, floracion, cosecha);


                for (int i = 0; i < plantas.Count; i++)
                {
                    if (i == indice)
                    {
                        plantas[i] = plantaModificada;
                    }
                }

                this.Hide();

                // Mostrar mensaje de éxito
                MessageBox.Show("Planta agregada con éxito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException ex)
            {
                // Captura errores de validación de entrada
                MessageBox.Show("Error: " + ex.Message, "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Captura cualquier otro error general
                MessageBox.Show("Error: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

    }
}