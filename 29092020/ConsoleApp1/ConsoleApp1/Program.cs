using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrdenarTarea();
            //Intro();
            Console.ReadLine();
        }

        public static void EF()
        {
            AppContext ctx = new AppContext();

            var lista = ctx.Actividades.ToList();
            var lista2 = ctx.Actividades.Where(i => i.Fecha < DateTime.Now).ToList();

            Actividad actividad = lista[0];
            actividad.Nombre = "Pepito";

            /*BORRAR*/
            var actividad1 = ctx.Actividades.Where(i => i.id == 15).First();
            ctx.Actividades.Remove(actividad1);

            /*AGREGA UNA LINEA MAS*/
            ctx.Actividades.Add(new Actividad { Lugar = "Caba", Nombre = "Clase" }); // Tabla 

            /*COMMITEA CAMBIOS*/
            ctx.SaveChanges(); //Commit
        }

        public static void Todo()
        {
            List<Actividad> eventos = new List<Actividad>();

            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "CABA", Nombre = "Pepito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Build", Nombre = "Pepita" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Ignite", Nombre = "Cholito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Cold", Nombre = "Cholita" });

            var resultado = eventos
                .Where(i => i.Fecha < DateTime.Now)
                .OrderBy(i => i.Fecha)
                .Select(i => new ActividadDto { Nombre = i.Nombre, Lugar = i.Lugar });

            var resultado2 = eventos
                .Where(i => i.Fecha < DateTime.Now);
        }

        public static void OrdenarTarea()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            var ordenaditos = numeros.Where(i => i % 2 == 0).OrderByDescending(i => numeros);
            foreach (var item in ordenaditos)
            {
                Console.WriteLine(item);
            }

        }

        public static void Agregado(string orden)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(numeros.Average());
            Console.WriteLine(numeros.Count());
            Console.WriteLine(numeros.Sum());
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine(numeros.First());
            Console.WriteLine(numeros.Last());

        }
        public static void Proyeccion(string orden)
        {
            List<Actividad> eventos = new List<Actividad>();

            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "CABA", Nombre = "Pepito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Build", Nombre = "Pepita" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Ignite", Nombre = "Cholito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Cold", Nombre = "Cholita" });

            var nombres = eventos.Select(i => i.Nombre);
            var nombres2 = eventos.Select(i => new { i.Nombre, i.Lugar });

            var nombres3 = eventos.Select(i => new ActividadDto { Nombre =  i.Nombre, Lugar = i.Lugar });
        }

        public static void Agrupar()
        {
            List<Actividad> eventos = new List<Actividad>();

            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "CABA", Nombre = "Pepito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Build", Nombre = "Pepita" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Ignite", Nombre = "Cholito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Cold", Nombre = "Cholita" });

            var grupos = eventos.GroupBy(i => i.Lugar);
            var grupos2 = eventos.GroupBy(i => new { i.Lugar, i.Fecha });

            foreach (var item in grupos)
            {
                //item.Count();
                
            }
        }

        public static void Ordenar()
        {
            List<Actividad> eventos = new List<Actividad>();

            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "CABA", Nombre = "Pepito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Build", Nombre = "Pepita" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Ignite", Nombre = "Cholito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Cold", Nombre = "Cholita" });

            var ordenado = eventos.OrderByDescending(i => i.Fecha);
            var ordenado2 = eventos.OrderBy(i => i.Nombre);
            var ordenado3 = eventos.OrderByDescending(i => i.Fecha).ThenBy(i => i.Nombre);

        }

        public static void PruebaOfType()
        {
            ArrayList arraylist = new ArrayList();

            arraylist.Add("test");
            arraylist.Add("asd");
            arraylist.Add("fds");
            arraylist.Add("qwer");
            arraylist.Add(2);
            arraylist.Add(4);

            var nro = arraylist.OfType<int>(); //Guarda en la variable nro todos los INT del arraylist


            List<IActividad> eventos = new List<IActividad>();

           // eventos.Add(new Actividad());
            eventos.Add(new Tarea());
        }

        public static void Intro()
        {
            string[] nombres = { "Pepito", "Laurel", "Yaquisieras", "Fernandito", "Floricienta", "Mauriciela", "MadremiaWilly" };
            IEnumerable<string> empiezanConF = from nombre in nombres where nombre.StartsWith("F") select nombre; //Ingresa una lista IEnumerable los nombres con F

            IEnumerable<string> empiezanConM = nombres.Where(i => i.StartsWith("M")); //Ingresa una lista IEnumerable los nombres con M

            List<Actividad> eventos = new List<Actividad>();

            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "CABA", Nombre = "Pepito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Build", Nombre = "Pepita" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Ignite", Nombre = "Cholito" });
            eventos.Add(new Actividad { Fecha = new DateTime(2020, 11, 09), Lugar = "Cold", Nombre = "Cholita" });


            List<string> pasados = eventos.Where(i => i.Fecha < DateTime.Now).Select(i => i.Nombre).ToList();

            //Func<Actividad>

            Func<int, bool> validarEdad = (edad) => edad > 18; //Funcion .net EDAD
            Func<int, string, bool> validarEdadyGenero = (edad, genero) => (edad > 18 && genero == "M"); //Funcion .net EDAD Y GENERO



            validarEdad(20); //Funcion .net

            Action<int> imprimir = (valor) => Console.WriteLine(valor); //Funcion Action ( VOID )


            foreach (var item in empiezanConF)
            {
                Console.WriteLine(item);
            }
        }
        
        public bool validarEdadFull(int edad) //Funcion .net (lo mismo Func<>)
        {
            return edad > 18;
        }
    }
}
