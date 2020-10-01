using System;

namespace NumeroRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int secreto = random.Next(10);
            int nro = 0;


            int intentos = 3;
            
            Console.WriteLine("Solo tienes 3 intentos!");

            for (int i=0; i < intentos; i++)
            {
                Console.WriteLine("Ingresar");
                string valorSecreto = Console.ReadLine();
                int valorSecreto2 = int.Parse(valorSecreto);

                if (valorSecreto2 == secreto)
                    break;
            }
            
            if(nro == secreto)
            {
                Win();
            }
            else
            {
                Lose(secreto);
            }

        }

        static void Win()
        {
            Console.WriteLine("Ganaste");
        }
        static void Lose(int valor)
        {
            Console.WriteLine("Perdiste, el numero era: "+valor );
        }
    }
}
