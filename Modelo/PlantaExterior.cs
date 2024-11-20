using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesttionPlantas.Modelo
{
    public class PlantaExterior : Planta
    {

        private Estacion epocaFloracion;

        //Atributo que hace referencia a la época en la que se florecen las flores de la planta, si tiene
        public Estacion EpocaFloracion { get
            {
                return epocaFloracion;
            }

            set { 
                
                if (Flor) {

                    epocaFloracion = value;

                }

            }
        }

        private Estacion epocaCosecha;

       //Atributo que hace referencia a la época en la que se puede cosechar los frutos de la planta, si tiene
        public Estacion EpocaCosecha {
            get
            {
                return epocaCosecha;
            }
            set
            {
                if (Fruto) {

                    epocaCosecha = value;
                    

                }
            }
        }

        //Atributo que hace referencia a la temperatura mínima que aguanta la planta
        public int TemperaturaMin { get; set; }

        //Atributo que hace referencia a la temperatura máxima que aguanta la planta
        public int TemperaturaMax { get; set; }


        //Constructor principal que coge los atributos del padre también
        public PlantaExterior(string nombreCientifico, string nombreComun, int altura, string hoja, bool flor, bool fruto, int epocaFloracion, int epocaCosecha, int temperaturaMin, int temperaturaMax)
            : base(nombreCientifico, nombreComun, altura, hoja, flor, fruto)
        {
            EpocaFloracion = (Estacion) epocaFloracion;
            EpocaCosecha = (Estacion) epocaCosecha;
            TemperaturaMax = temperaturaMax;
            TemperaturaMin = temperaturaMin;
        }

        //Método sobreescrito del padre para mostrar toda la información de una planta exterior
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Temperatura habitable: Desde {TemperaturaMin}ºC a {TemperaturaMax}°C");

            if (Flor)
            {
                Console.WriteLine($"Época de floración: {EpocaFloracion}");
            }

            if (Fruto)
            {
                Console.WriteLine($"Época de cosecha: {EpocaCosecha}");
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        //Método con previsión a futuro

        public void ResistenciaFrio(int temperatura)
        {
            if (temperatura >= TemperaturaMin)
            {
                Console.WriteLine($"{NombreCientifico} puede resistir a la temperatura actual de {temperatura}°C.");
            }
            else
            {
                Console.WriteLine($"{NombreCientifico} no resiste el frío por debajo de {TemperaturaMin}°C.");
            }
        }

        //Método con previsión a futuro

        public void ResisteciaCalor(int temperatura)
        {
            if (temperatura <= TemperaturaMax)
            {
                Console.WriteLine($"{NombreCientifico} puede resistir a la temperatura actual de {temperatura}°C.");
            }
            else
            {
                Console.WriteLine($"{NombreCientifico} no resiste el frío por debajo de {TemperaturaMax}°C.");
            }
        }

        //Enum que guarda las estaciones del año y la relaciona con un int
        public enum Estacion
        {
            PRIMAVERA = 1,
            VERANO = 2,
            OTOÑO = 3,
            INVIERNO = 4,
        }
    }

}