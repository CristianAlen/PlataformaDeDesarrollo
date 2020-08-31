using System;
using System.Drawing;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Tienes una caja la cual se abrira si adivinas escribiendo un numero del 1 al 10");
            Console.WriteLine("Solo tienes 3 intentos!");
            Console.WriteLine("Hazlo rapido antes de que se escape!");
            string nro = "";
            int intentos = 0;


            while (nro != "7" && intentos <= 2)
            {
                Console.WriteLine("Escribe!");
                nro = Console.ReadLine();
                intentos++;
                Console.WriteLine("Intentos: " + intentos);

               if(nro == "7" && intentos <= 2)
                {
                    Console.WriteLine("Abriste la caja, pero no hay nada! :(");
                    
                }
            }
            if (intentos == 3) { Console.WriteLine("La caja se escapo!"); }
            
        }
    }
}
