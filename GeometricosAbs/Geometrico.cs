using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricosAbs
{
    public abstract class Geometrico
    {
        //hacemos la clase abstracta con metodos abstractos para que al heredar sus metodos, se hereden en todas las clases y eso genere un override para poder usarlos sin compartirle info entre clases
        public abstract void Saludo();
        public abstract string Nombre { get; set; }

        //manadaremos 2 parametros para saber los valores de cada firgura
        public abstract void CalcularArea(double lado1, double lado2);
        public abstract void CalcularPerimetro(double lado1, double lado2);

    }
}
