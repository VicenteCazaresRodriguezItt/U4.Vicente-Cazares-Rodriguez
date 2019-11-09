using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
  public class RepoList
  {
        //lista que usaremos con los atributos de Data
        List<Data> lista = new List<Data>();
        
        
        public void AddEmploye()
        {
            //instanciamos la clase data, con todo sus atributos
            Data data = new Data();
            Console.WriteLine("Nombre del empleado:");
            data.Nombre = Console.ReadLine();
            Console.WriteLine("=====================\n ");
            Console.WriteLine("Area en la que trabajara el empleado:");
            data.Area = Console.ReadLine();
            //que los atributos que usamos se añada a la lista 
            lista.Add(data);

        }
        public void ShowEmployeList()
        {
            Data data = new Data();
            //hacemos que al imprimir la lista se haga con numeros
            int Listnumber = 0;
            foreach (Data d in lista)
            {
                //para que se incremente el numero del Id
                Listnumber++;
                Console.WriteLine(Listnumber+"| " +d.Nombre);
                Console.WriteLine("========================================\n");
                
            }
        }
        public void ShowDetails()
        {
            //aqui emprimimos todos los empleados con sus areas
            Data data = new Data();
            int ListNumber = 0;
            foreach (Data d in lista)
            {
                ListNumber++;
                //para que se incremente el numero de lista
                Console.WriteLine(ListNumber + "| " + d.Nombre+" labora en el area "+d.Area);
                Console.WriteLine("========================================\n");

            }
        }
        public void ShowEmployeDetail()
        {
            //emprimomos los empleados para que el usuario vea los nombres
            int Listnumber = 0;
            foreach (Data d in lista)
            {
                //para que se incremente el numero del Id
                
                Listnumber++;
                Console.WriteLine(Listnumber+"| " +d.Nombre);
                
            }
            string opc;
            Console.WriteLine("Ingrese el nombre del empleado:");
            opc = Console.ReadLine();

            //hacemos que cunado ingrese un nombre de la lista, se evalue y vea los datos
            foreach (Data d in lista)
            {
                if (opc == d.Nombre)
                {
                    Console.WriteLine("");

                    Console.WriteLine("El empleado " + d.Nombre + " labora en el area de " + d.Area);
                    Console.WriteLine("========================================\n");
                }
            }    
        }
  }
}

