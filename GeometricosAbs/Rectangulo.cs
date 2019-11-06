using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricosAbs
{
    public class Rectangulo : Geometrico
    {
        //heredamos y al momento de heredar tendremos que hacer el override de los atributos de la clase Geometrico

        public override string Nombre { get; set; }

        public override void Saludo()
        {
            //el rectangulo tiene un lado mas grande que el otro
            Console.WriteLine("La figura es un Rectangulo");
        }
        public override void CalcularArea(double lado1 = 10, double lado2 = 6)
        {
            //recibimos parametros en double y los regresamos en double 
            var Res = lado1 * lado2;
            Console.WriteLine("El area de un rectangulo es: " + Res);
        }
        public override void CalcularPerimetro(double lado1 = 10, double lado2 = 6)
        {
            var Res = 2 * (lado1 + lado2);
            Console.WriteLine("El perimetro del rectangulo es: " + Res);
        }
    }
}
