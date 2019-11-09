using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
    public class Principal : RepoList
    {
        string username;
        internal void Colector()
        {
            //damos la bienvenida
            Console.WriteLine(" \nBienvenido a la lista de empleados");
            Console.WriteLine("================================");
            Console.WriteLine("");
            //que el usuario ingrese el nombre nomas para las vistas
            Console.WriteLine("Ingresa tu nombre");
            username = Console.ReadLine();
            Console.WriteLine("");
            Menu();
        }

        private void Menu()
        {
            //que el usuario ingrese una opcion 
            Console.WriteLine("Ingrese una opcion del menu");
            Console.WriteLine("=================================\n ");
            Console.WriteLine("1. Agregar empleado\n2. Lista de empleados\n3. Detalles de los empleados\n4. Detalle de empleado\n5. Salir");
            //el string que metera el usuario se usara en el switch
            switch (Console.ReadLine())
            {
                //en cada case hay un metodo que se heredo de la clase repolist, asi que llamamos al metodo y hacemos el procedimiento alli
                case "1":
                    Console.Clear();
                    Console.WriteLine("Bienvenido " + username + " a Agregar empleado");
                    AddEmploye();
                    Console.Clear();
                    break;
                    
                case "2":
                    Console.Clear();
                    Console.WriteLine("Bienvenido " + username + " a Lista de empleados");
                    Console.Clear();
                    ShowEmployeList();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Bienvenido " + username + " a Detalles de los empleados");
                    Console.Clear();
                    ShowDetails();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("bienvenido "+username+" a Detalle de empleado");
                    Console.Clear();
                    ShowEmployeDetail();
                    break;
                case "5":
                    Console.WriteLine("Hasta la proxima profe, lo amo");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(username+" ingresa una opcion valida");
                    Console.ReadKey();
                    Menu();
                    break;
                    
            }
            //para que se llame al menu cada vez que acabemos una opcion
            Menu();
        }

        
    }
}

