namespace Ejercicio11dePOOPunto2.Model
{
    public class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int DistanciaAlOrigenAlCuadrado()
        {
            return X * X + Y * Y;
        }
    }
}
