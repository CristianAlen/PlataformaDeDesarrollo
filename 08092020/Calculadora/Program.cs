using System;
using Calculadora;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculadora calculadora = new Calculadora();

            int numero1 = 2;
            int numero2 = 2;

            Console.WriteLine("Suma: " + calculadora.Sumar(numero1, numero2));
            Console.WriteLine("Division: " + calculadora.Dividir(numero1, numero2));
            Console.WriteLine("Multiplicacion: " + calculadora.Multiplicar(numero1, numero2));
            Console.WriteLine("Resta: " + calculadora.Restar(numero1, numero2));

            /*
            double resto = calculadora.Dividir(numero1, 0);
            if(resto == 0)
            {
                Console.WriteLine("No se puede dividir por cero, pa.");
            }
            */
        }



    }
}
