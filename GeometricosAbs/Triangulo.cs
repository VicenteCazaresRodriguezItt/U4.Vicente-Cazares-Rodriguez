using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricosAbs
{
    public class Triangulo : Geometrico
    {
        public override string Nombre { get; set; }


        public override void Saludo()
        {
            //suponiendo que es un triangulo rectangulo por que un lado es mayor al otro
            Console.WriteLine("La figura es un Triangulo rectangulo");
        }
        public override void CalcularArea(double lado1 = 5, double lado2 = 10)
        {
                
            var Res = lado1 * lado2 / 2;
            Console.WriteLine("El area del triangulo es: " + Res);

        }
        public override void CalcularPerimetro(double lado1 = 5, double lado2 = 10)
        {
            //cateto opuestro + cateto adyacente mas la suma de las raicies cuadradas de la suma de ambos al cuadrado da la hipotenusa, la suma de estos 3 datos da el perimetro
            //usamos el math.sqrt para la
            var Res = (lado1 + lado2) + (Math.Sqrt(Math.Pow(lado1, 2)) + Math.Sqrt(Math.Pow(lado2, 2)));
            Console.WriteLine("El perimetro del triangulo es "+ Math.Round(Res, 2));
            
        }
    }
}
