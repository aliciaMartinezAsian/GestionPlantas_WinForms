using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace GesttionPlantas.Controlador
{
    public static class Util
    {

        // Método para leer un entero dentro de un rango específico (pasandole un valor mínimo,uno máximo  y el mensaje que vamos a imprimir en consola )
        public static int LeerEntero(string mensaje, int min = int.MinValue, int max = int.MaxValue)
        {
            int valor;
            do
            {
                //Muestra el mensaje
                Console.Write(mensaje);
                //Lo lee
                valor = Int32.Parse(Console.ReadLine());
                //Minetras que el valor esté entre los rangos se "guarda"
                if (valor >= min && valor <= max) return valor;
                //Si no está se muestra este mensaje y se vuelve a repetir porque no ha habido return
                Console.WriteLine($"Valor no válido. Debe ser un número entre {min} y {max}. Inténtelo de nuevo.");
            } while (true);
        }

        // Método para leer un valor booleano ("Si" o "No"), parecido al anterior
        public static bool LeerBooleano(string mensaje)
        {
            do
            {
                //Muestra el mensaje
                Console.Write(mensaje);
                //Lee el mensaje
                string entrada = Console.ReadLine().ToLower();
                //Devuelve el booleano según lo que lea
                if (entrada == "si") return true;
                if (entrada == "no") return false;
                //Si no es ninguna de las dos opciones muestra este mensaje y lo repite porque no ha habido return
                Console.WriteLine("Respuesta no válida. Introduzca 'Si' o 'No'.");
            } while (true);
        }

        //Métood que rellena un string hasta cierto tamaño con espacios
        public static string CompletarHasta(string str, int tamanio)
        {
            return str.PadRight(tamanio, ' ');
        }

        //Método para verificar que se puede leer un BinaryReader
        public static bool SePuedeLeer(BinaryReader br, int numBytes)
        {
            //Primero, se verifica si el objeto BinaryReader (br) es null.
            //Si lo es, el método devuelve false, ya que no se puede leer de un flujo inexistente.
            if (br == null) return false;
            //Si la cantidad de bytes restantes es mayor o igual a numBytes devuelve true (se pueden leer esos bytes), de lo contrario devuelve false.
            return br.BaseStream.Length - br.BaseStream.Position >= numBytes;
        }

        //Método que transforma un número pasado al string de un atributo común a las dos subclases
        public static string AtributosComunes(int num)
        {
            string atributo = "";
            switch (num)
            {
                case 1:
                    atributo = "Nombre cientifico";
                    break;
                case 2:
                    atributo = "Nombre comun";
                    break;
                case 3:
                    atributo = "Altura";
                    break;
                case 4:
                    atributo = "Hoja";
                    break;
                case 5:
                    atributo = "Flor";
                    break;
                case 6:
                    atributo = "Fruto";
                    break;
               
            }

            return atributo;



        }

    }
}
