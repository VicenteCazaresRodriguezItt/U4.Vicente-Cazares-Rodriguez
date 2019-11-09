using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de empleados de gasolinera
            //Area
            //Agregar empleado
            //Lista de empleados
            //Detalles

            //instanciamos principal donde tendremos el menu
            Principal pri = new Principal();
            Console.WriteLine("Buenas, bienvenido a mi programa, con su nariz presione cualquier tecla");
            Console.ReadKey();
            pri.Colector();
        }
    }
}
