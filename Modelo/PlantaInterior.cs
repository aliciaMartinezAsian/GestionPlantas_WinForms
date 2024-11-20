using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesttionPlantas.Modelo
{
    public class PlantaInterior : Planta
    {

        //Atributo que hace referencia a la iluminación que necesita la planta
        public Intensidad TipoIluminacion { get; set; }

        //Atributo que hace referencia a la humedad o riego que necesita la planta
        public Intensidad Humedad { get; set; }

        //Atributo que hace referencia a si la planta es tóxica para humanos o animales
        public bool Toxicidad { get; set; }


        //Constructor principal que coge los atributos del padre también
        public PlantaInterior(string nombreCientifico, string nombreComun, int altura, string hoja, bool flor, bool fruto, int tipoIluminacion,int humedad, bool toxicidad)
            : base(nombreCientifico,nombreComun, altura,hoja,flor, fruto)
        {
            TipoIluminacion = (Intensidad) tipoIluminacion;
            Humedad =(Intensidad) humedad;
            Toxicidad = toxicidad;

        }

        //Método sobreescrito del padre para mostrar toda la información de una planta interior
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Tipo de Iluminación: {TipoIluminacion}\n Humedad: {Humedad} \n ¿Es tóxica?: {(Toxicidad ? "Sí" : "No")}");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        //Método con previsión a futuro
        public void EsToxica()
        {
            if (Toxicidad)
            {
                Console.WriteLine($"{NombreCientifico} es tóxica para mascotas o humanos.");
            }
            else
            {
                Console.WriteLine($"{NombreCientifico} no es tóxica.");
            }
        }

        //Enum que guarda los grados de intesidad (para iluminación y humedad) y la relaciona con un int
        public enum Intensidad
        {
            MUY_BAJA = 1,
            BAJA = 2,
            MEDIA = 3,
            ALTA = 4,
            MUY_ALTA = 5,
        }
    }

}