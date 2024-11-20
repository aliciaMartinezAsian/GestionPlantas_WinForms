﻿using GesttionPlantas.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace GesttionPlantas.Controlador
{
    public class CtrPlanta
    {
        //Marcas según el tipo de planta que sea
        private const char MARCA_INTERIORES = 'I';
        private const char MARCA_EXTERIORES = 'E';

        //Número de bytes que ocupa guardar cada tipo de planta
        private const int BYTES_INTERIORES = 169;
        private const int BYTES_EXTERIORES = 176;

        //Lista de plantas para manejar las plantas
        private static List<Planta> list = new List<Planta>();

        //Controlador para hacer el singleton
        private static CtrPlanta miControlador;

        //El constructor es privado para mejorar la seguridad con el método singleton
        private CtrPlanta() { }


        //Método público por el que se llama al constructor del controlador
        public static CtrPlanta ObtenerCtrPlanta()
        {
            if (miControlador == null)
            {
                miControlador = new CtrPlanta();
            }
            return miControlador;
        }

        //Método para guardar en el archivo las plantas 
        public void GuardarCatalogo()
        {
            //Si el archivo existe se mueve cambiandole el nombre para asi tener "copias de seguridad" 
            if (File.Exists("catalogo.dat"))
            {

                DateTime dt = DateTime.Now;
                File.Move("catalogo.dat", $"catalogo_{dt.Day}-{dt.Month}-{dt.Year}_{dt.Ticks}_.dat");
            }

            //Creamos el archivo 
            using (var bw = new BinaryWriter(new FileStream("catalogo.dat", FileMode.Create)))
            {
                //Iteramos las plantas de nuestra lista y vamos guardandolas
                foreach (Planta planta in list)
                {
                    //Si la planta que hemos iterado es interior
                    if (planta is PlantaInterior interior)
                    {
                        //Escribimos la marca de planta interior
                        bw.Write(MARCA_INTERIORES);
                        //Guardamos los atributos comunes
                        GuardarComun(interior, bw);
                        //Pasamos los enums a int y los guardamos
                        bw.Write((int)interior.TipoIluminacion);
                        bw.Write((int)interior.Humedad);
                        //Guardamos el booleano
                        bw.Write(interior.Toxicidad);
                    }

                    //Si la planta que hemos iterado es exterior
                    else if (planta is PlantaExterior exterior)
                    {
                        //Escribimos la marca de planta exterior
                        bw.Write(MARCA_EXTERIORES);
                        //Guardamos los atributos comunes
                        GuardarComun(exterior, bw);
                        //Pasamos los enums a int y los guardamos
                        bw.Write((int)exterior.EpocaFloracion);
                        bw.Write((int)exterior.EpocaCosecha);
                        //Guardamos los int de temperaturas
                        bw.Write(exterior.TemperaturaMin);
                        bw.Write(exterior.TemperaturaMax);
                    }
                }
            }
        }

        // Método para leer el archivo y cargar las plantas en la lista
        public void CargarCatalogo()
        {
            // Verifica si el archivo  existe antes de intentar abrirlo
            if (File.Exists("catalogo.dat"))
            {
                //Usamos el modo abrir solo
                using (var fileStr = new FileStream("catalogo.dat", FileMode.Open))

                using (var br = new BinaryReader(fileStr))
                {
                    // Recorre el archivo hasta que llegue al final
                    while (fileStr.Position < fileStr.Length - sizeof(Char))
                    {
                        // Lee el siguiente carácter que actúa como marca identificadora
                        char marca = br.ReadChar();

                        // Dependiendo de la marca, decide el tipo de planta que se está leyendo
                        switch (marca)
                        {
                            case MARCA_INTERIORES: 
                                // Comprueba si hay suficientes bytes disponibles para leer una planta de interior
                                if (Util.SePuedeLeer(br, BYTES_INTERIORES - sizeof(Char)))
                                {
                                    // Carga la planta de interior desde el archivo y la agrega a la lista
                                    list.Add(CargarPlantaInterior(br));
                                }
                                break;

                            case MARCA_EXTERIORES: 
                                   // Comprueba si hay suficientes bytes disponibles para leer una planta de exterior
                                if (Util.SePuedeLeer(br, BYTES_EXTERIORES - sizeof(Char)))
                                {
                                    // Carga la planta de exterior desde el archivo y la agrega a la lista
                                    list.Add(CargarPlantaExterior(br));
                                }
                                break;
                        }
                    }
                }
            }
        }


        //Método para obtener la lista con las plantas
        public List<Planta> ObtenerCatalogo()
        {
            return new List<Planta>(list);
        }

        // Método para guardar una planta en el archivo y añadirla a la lista
        public void GuardarPlanta(Planta planta)
        {
            // Añade las plantas después de la última
            using (var bw = new BinaryWriter(new FileStream("catalogo.dat", FileMode.Append)))
            {
                // Si la planta es de tipo PlantaInterior
                if (planta is PlantaInterior interior)
                {
                    // Escribe la marca de planta interior y sus datos
                    bw.Write(MARCA_INTERIORES);
                    GuardarComun(interior, bw);
                    bw.Write((int)interior.TipoIluminacion);
                    bw.Write((int)interior.Humedad);
                    bw.Write(interior.Toxicidad);
                    // Añade la planta a la lista
                    list.Add(interior);
                }
                // Si la planta es de tipo PlantaExterior
                else if (planta is PlantaExterior exterior)
                {
                    // Escribe la marca de planta exterior y sus datos
                    bw.Write(MARCA_EXTERIORES);
                    GuardarComun(exterior, bw);
                    bw.Write((int)exterior.EpocaFloracion);
                    bw.Write((int)exterior.EpocaCosecha);
                    bw.Write(exterior.TemperaturaMin);
                    bw.Write(exterior.TemperaturaMax);
                    // Añade la planta a la lista en memoria
                    list.Add(exterior);
                }
            }
        }

        // Método auxiliar para guardar atributos comunes de cualquier planta
        private void GuardarComun(Planta plant, BinaryWriter bw)
        {
            // Escribe en el archivo los datos comunes a todas las plantas
            bw.Write(Util.CompletarHasta(plant.NombreCientifico, 50));
            bw.Write(Util.CompletarHasta(plant.NombreComun, 50));
            bw.Write(plant.Altura);
            bw.Write(Util.CompletarHasta(plant.Hoja, 50));
            bw.Write(plant.Flor);
            bw.Write(plant.Fruto);
        }

        // Método para cargar una planta de tipo PlantaInterior desde el archivo
        private PlantaInterior CargarPlantaInterior(BinaryReader br)
        {
            // Lee los datos de una planta de interior
            string nombreCientifico = br.ReadString().Trim();
            string nombreComun = br.ReadString().Trim();
            int altura = br.ReadInt32();
            string hoja = br.ReadString().Trim();
            bool flor = br.ReadBoolean();
            bool fruto = br.ReadBoolean();
            int tipoIluminacion = br.ReadInt32();
            int humedad = br.ReadInt32();
            bool toxicidad = br.ReadBoolean();

            // Devuelve una nueva instancia de PlantaInterior
            return new PlantaInterior(nombreCientifico, nombreComun, altura, hoja, flor, fruto, tipoIluminacion, humedad, toxicidad);
        }

        // Método para cargar una planta de tipo PlantaExterior desde el archivo
        private PlantaExterior CargarPlantaExterior(BinaryReader br)
        {
            // Lee los datos  de una planta de exterior
            string nombreCientifico = br.ReadString().Trim();
            string nombreComun = br.ReadString().Trim();
            int altura = br.ReadInt32();
            string hoja = br.ReadString().Trim();
            bool flor = br.ReadBoolean();
            bool fruto = br.ReadBoolean();
            int epocaFloracion = br.ReadInt32();
            int epocaCosecha = br.ReadInt32();
            int temperaturaMin = br.ReadInt32();
            int temperaturaMax = br.ReadInt32();

            // Devuelve una nueva instancia de PlantaExterior
            return new PlantaExterior(nombreCientifico, nombreComun, altura, hoja, flor, fruto, epocaFloracion, epocaCosecha, temperaturaMin, temperaturaMax);
        }

        // Método para ordenar la lista de plantas según un atributo específico
        public List<Planta> Ordenar(string atributo)
        {
            List<Planta> ordenada;

            // Decide cómo ordenar según el atributo proporcionado
            switch (atributo.ToLower())
            {
                case "nombre cientifico":
                    ordenada = list.OrderBy(planta => planta.NombreCientifico).ToList();
                    break;
                case "nombre comun":
                    ordenada = list.OrderBy(planta => planta.NombreComun).ToList();
                    break;
                case "altura":
                    ordenada = list.OrderBy(planta => planta.Altura).ToList();
                    break;
                case "hoja":
                    ordenada = list.OrderBy(planta => planta.Hoja).ToList();
                    break;
                case "flor":
                    ordenada = list.OrderBy(planta => planta.Flor).ToList();
                    break;
                case "fruto":
                    ordenada = list.OrderBy(planta => planta.Fruto).ToList();
                    break;
                default:
                    // Lanza una excepción si el atributo no es válido
                    throw new ArgumentException("Atributo no válido.");
            }

            Console.WriteLine("Lista ordenada por " + atributo);
            return ordenada;
        }

        // Método para filtrar plantas según uno o dos atributos
        public List<Planta> Filtrar(string atributo1, string valor1, string atributo2 = null, string valor2 = null, string opcion = "no")
        {
            List<Planta> filtrada;

            // Aplica el primer filtro
            filtrada = FiltrarPorAtributo(list, atributo1, valor1);

            // Si se requiere un segundo filtro, lo aplica
            if (opcion.ToLower() == "si" && atributo2 != null && valor2 != null)
            {
                filtrada = FiltrarPorAtributo(filtrada, atributo2, valor2);
            }

            return filtrada;
        }

        // Método para filtrar plantas según un atributo y valor específicos
        private List<Planta> FiltrarPorAtributo(List<Planta> lista, string atributo, string valor)
        {
            // Filtra según el atributo y valor proporcionados
            switch (atributo.ToLower())
            {
                case "nombre cientifico":
                    return lista.FindAll(planta => planta.NombreCientifico.Equals(valor));

                case "nombre comun":
                    return lista.FindAll(planta => planta.NombreComun.Equals(valor));

                case "altura":
                    return lista.FindAll(planta => planta.Altura.ToString().Equals(valor));

                case "hoja":
                    return lista.FindAll(planta => planta.Hoja.Equals(valor));

                case "flor":
                    return lista.FindAll(planta => planta.Flor.ToString().Equals(valor));

                case "fruto":
                    return lista.FindAll(planta => planta.Fruto.ToString().Equals(valor));

                default:
                    // Lanza una excepción si el atributo no es válido
                    throw new ArgumentException("Atributo no válido.");
            }
        }

        // Método para eliminar plantas de la lista
        public void Eliminar(List<Planta> listaEliminadas)
        {
            // Recorre cada planta de la lista proporcionada
            foreach (Planta planta in listaEliminadas)
            {
                // Recorre la lista principal desde el final para evitar problemas de índices
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].Equals(planta))
                    {
                        list.RemoveAt(i); // Elimina la planta
                        Console.WriteLine("Planta eliminada con éxito.");
                        break; // Sale del bucle
                    }
                }
            }
        }

        // Método para modificar una planta existente en la lista
        public void Modificar(Planta plantaOriginal, Planta plantaModificada)
        {
            // Busca la planta original en la lista
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(plantaOriginal))
                {
                    // Sustituye la planta original por la modificada
                    list[i] = plantaModificada;
                    Console.WriteLine("Planta modificada con éxito.");
                }
            }
        }





    }
}