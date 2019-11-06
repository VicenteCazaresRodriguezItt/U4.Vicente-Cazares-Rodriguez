using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricosAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos todas las clases y tambien llamamos a los metodos de cada una, que seran los mismos del override de la clase Geometrico
            Triangulo t = new Triangulo();
            t.Saludo();
            t.CalcularArea();
            t.CalcularPerimetro();
            Console.WriteLine("==================================");

            Cuadrado c = new Cuadrado();
            c.Saludo();
            c.CalcularArea();
            c.CalcularPerimetro();
            Console.WriteLine("==================================");

            Rectangulo r = new Rectangulo();
            r.Saludo();
            r.CalcularArea();
            r.CalcularPerimetro();
            Console.ReadKey();
            Console.WriteLine("==================================");
        }
    }
}
