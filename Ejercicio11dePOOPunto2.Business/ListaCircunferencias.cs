using Ejercicio11dePOOPunto2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ejercicio11dePOOPunto2.Business
{
    public class ListaDeCircunferencias
    {
        private readonly List<Circunferencia> Lista = new List<Circunferencia>();

        private readonly string FilePath = Directory.GetCurrentDirectory() + "/datos.csv";

        public void Agregar(Circunferencia circunferencia)
        {
            // Sólo lo agrego si no existe
            if (Lista.IndexOf(circunferencia) < 0)
            {
                Lista.Add(circunferencia);
            }
        }

        public void Eliminar(Circunferencia circunferencia)
        {
            Lista.Remove(circunferencia);
        }

        public List<Circunferencia> GetLista()
        {
            return Lista;
        }

        public void Guardar()
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (Circunferencia circunferencia in Lista)
                {
                    writer.WriteLine(circunferencia.ToString());
                }
            }
        }

        public void Leer()
        {
            // Si el archivo no existe, no cargo nada
            if (!File.Exists(FilePath)) return;

            using (StreamReader reader = new StreamReader(FilePath))
            {
                while (!reader.EndOfStream)
                {
                    string Linea = reader.ReadLine();
                    // La circunferencia se carga a partir de un string
                    Lista.Add(new Circunferencia(Linea));
                }
            }
        }

        public bool Existe(Circunferencia circunferencia)
        {
            return Lista.IndexOf(circunferencia) >= 0;
        }

        public List<Circunferencia> OrdenarPorRadio(bool descendente)
        {
            if (descendente)
            {
                return Lista.OrderByDescending(c => c.Radio).ToList();
            }
            else
            {
                return Lista.OrderBy(c => c.Radio).ToList();
            }
        }

        // Comparo la distancia al cuadrado
        public List<Circunferencia> OrdenarPorCentro(bool descendente)
        {
            if (descendente)
            {
                return Lista.OrderByDescending(c => c.Centro.DistanciaAlOrigenAlCuadrado()).ToList();
            }
            else
            {
                return Lista.OrderBy(c => c.Centro.DistanciaAlOrigenAlCuadrado()).ToList();
            }
        }

        public List<Circunferencia> FiltrarPorBorde(Borde borde)
        {
            return Lista.Where(c => c.Borde == borde).ToList();
        }

        public List<Circunferencia> FiltrarPorRelleno(string relleno)
        {
            return Lista.Where(c => c.Relleno == relleno).ToList();
        }
    }
}
