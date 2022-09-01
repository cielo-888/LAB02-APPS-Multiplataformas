using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string valor = "";
            Console.WriteLine("Ingresar valor");
            Console.WriteLine("Ingresar valor");
            Console.WriteLine("Ingresar valor");
            Console.WriteLine("Ingresar valor");
            Console.WriteLine("Ingresar valor");
            Console.WriteLine("Ingresar valor");
            Console.WriteLine("Ingresar valor");
            Console.WriteLine("Ingresar valor");
            

            valor = Console.ReadLine();

            

            Console.WriteLine("Hola mundo");
            //Declaració variablaes

            int edad = 34;            
            string nombre = "hugo";
            decimal sueldo = 10000;
            bool esNuevo = true;

            int edad2 ;
            string nombre2 ;
            decimal sueldo2;
            bool esNuevo2;

            edad2 = 34;
            nombre2 = "hugo2";
            sueldo2 = 5000;


            //Sentencias
            if (edad>18)
            {
                Console.WriteLine("Es Mayor Edad");
            }
            if (sueldo>2000)
            {
                Console.WriteLine("Millonario");
            }
            else
            {
                Console.WriteLine("Pobre");
            }
            switch (edad2)
            {
                case 20:
                    Console.WriteLine("Es Joven");
                    break;
                case 30:
                    Console.WriteLine("Es Adulto");
                    break;
                default:
                    break;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(nombre);
            }

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.x1 = 0;
            rectangulo.y1 = 0;

            rectangulo.x2 = 10;
            rectangulo.y2 = 0;

            

            Console.WriteLine(rectangulo.HallarArea());



            Console.Read();

        }
    }
}
