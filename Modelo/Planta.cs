using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesttionPlantas.Modelo
{
    public class Planta
    {
        //Límites de caracteres para los strings
        public const int MAX_NOMBRE_CIENTIFICO= 50;
        public const int MAX_NOMBRE_COMUN = 50;
        public const int MAX_HOJA = 50;


        private string nombreCientifico;

        //Atributo que hace referencia al nombre científico de la planta
        public string NombreCientifico
        {
            get
            {
                return nombreCientifico;
            }
            set
            {
                //Mientras sea menos largo que su máximo de caracteres se guarda
                if (value.Length <= MAX_NOMBRE_CIENTIFICO)
                {
                   nombreCientifico = value;
                }
                else
                {
                    //Si supera su máximo de caracteres se obtiene un substring que recorta el string
                    nombreCientifico = value.Substring(0, MAX_NOMBRE_CIENTIFICO);
                }
            }
        }

        private string nombreComun;

        //Atributo que hace referencia al nombre común de la planta
        public string NombreComun
        {  
            get
            {
                return nombreComun;
            }
            set
            {
                //Mientras sea menos largo que su máximo de caracteres se guarda
                if (value.Length <= MAX_NOMBRE_COMUN)
                {
                    nombreComun = value;
                }
                else
                {
                    //Si supera su máximo de caracteres se obtiene un substring que recorta el string
                    nombreComun = value.Substring(0, MAX_NOMBRE_COMUN);
                }
            }
           }

        //Atributo que hace referencia a la altura en centímetros de la planta
        public int Altura { get; set; }

        private string hoja;

        //Atributo que hace referencia a las características de las hojas de la planta
        public string Hoja
        {
            get
            {
                return hoja;
            }
            set
            {
                //Mientras sea menos largo que su máximo de caracteres se guarda
                if (value.Length <= MAX_HOJA)
                {
                    hoja = value;
                }
                else
                {
                    //Si supera su máximo de caracteres se obtiene un substring que recorta el string
                    hoja = value.Substring(0, MAX_HOJA);
                }
            }
        }
        //Atributo que hace referencia a si la planta da flores
        public bool Flor { get; set; }
        //Atributo que hace referencia a si la planta da frutos
        public bool Fruto { get; set; }

        //Atributo para en un futuro almacenar una foto
        public int Foto { get; set;}

        //Constructor vacío
        public Planta() { }

        //Constructor principal
        public Planta(string nombreCientifico, string nombreComun, int altura,string hoja, bool flor, bool fruto, int foto)
        {
            NombreCientifico = nombreCientifico;
            NombreComun = nombreComun;
            Altura = altura;
            Hoja = hoja;
            Flor = flor;
            Fruto = fruto;   
            Foto = foto;

        }

        //Método que muestra toda la información de la planta
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre científico: {nombreCientifico} \nNombre común:{nombreComun} \nAltura: {Altura}cm \nCaracterísticas de la hoja: {hoja}");

            if (Flor)
            {
                Console.WriteLine("Esta planta florece");
            }
            else
            {
                Console.WriteLine("Esta planta no florece");
            }

            if (Fruto)
            {
                Console.WriteLine("Esta planta da frutos");

            }
            else
            {
                Console.WriteLine("Esta planta no da frutos");
            }
        }
    }

}
