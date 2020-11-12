using System;

namespace Ejercicio11dePOOPunto2.Model
{
    public class Circunferencia
    {
        public Punto Centro { get; set; }
        public int Radio { get; set; }
        public Borde Borde { get; set; }
        public string Relleno { get; set; }

        public Circunferencia() {}

        public Circunferencia(string DatosCSV)
        {
            string[] Datos = DatosCSV.Split(',');
            Centro = new Punto()
            {
                X = int.Parse(Datos[0]),
                Y = int.Parse(Datos[1])
            };
            Radio = int.Parse(Datos[2]);
            Borde = (Borde)Enum.Parse(typeof(Borde), Datos[3]);
            Relleno = Datos[4];
        }

        public override string ToString()
        {
            return $"{Centro.X},{Centro.Y},{Radio},{Borde},{Relleno}";
        }

        // Comparo los ToString
        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Circunferencia c = (Circunferencia)obj;

                return ToString().Equals(c.ToString());
            }
        }

        // Devuelvo el hash del ToString
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public double GetPerimetro()
        {
            return Math.PI * Radio * 2;
        }

        public double GetSuperficie()
        {
            return Math.PI * Radio * Radio;
        }
    }
}
