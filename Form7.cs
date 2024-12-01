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
using static System.Windows.Forms.Design.AxImporter;

namespace GestionPlantas_WinForms
{
    public partial class Form7 : Form
    {
        private static List<Planta> plantas = new List<Planta>();
        private static CtrPlanta ctr = CtrPlanta.ObtenerCtrPlanta();



        public Form7()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Width = 800;
            this.Height = 430;

            ctr.CargarCatalogo();

            plantas = ctr.ObtenerCatalogo();
            if (plantas == null || !plantas.Any())
            {
                MessageBox.Show("La lista de plantas está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            dataGridView1.AutoGenerateColumns = true;

            // Cargar los datos en el DataGridView
            ActualizarDataGridView();

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

        private void buscarPlantasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenarPlantasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctr.GuardarCatalogo();
            this.Hide();
        }


        private void ActualizarDataGridView()
        {
            // Establecer la lista como fuente de datos del DataGridView
            dataGridView1.DataSource = null; // Limpiar datos anteriores
            dataGridView1.DataSource = plantas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string atributo1 = Util.AtributosComunes(comboBox1.SelectedIndex + 1);

            string valor1 = textBox1.Text;

            string atributo2 = null;
            string valor2 = null;
            string opc = "no";
            if (comboBox2.SelectedIndex != -1) {
                opc = "si";
                atributo2 = Util.AtributosComunes(comboBox2.SelectedIndex + 1);
                valor2 = textBox2.Text;
            }

            plantas = ctr.Filtrar(atributo1, valor1, atributo2, valor2, opc);
 

            // Botón para actualizar manualmente los datos
            ActualizarDataGridView();
            MessageBox.Show("Datos actualizados en la tabla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string atributo1 = Util.AtributosComunes(comboBox1.SelectedIndex + 1);
            plantas = ctr.Ordenar(atributo1);

            // Botón para actualizar manualmente los datos
            ActualizarDataGridView();
            MessageBox.Show("Datos actualizados en la tabla.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
