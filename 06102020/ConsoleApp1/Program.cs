using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Insertar();

        }
        static void Insertar()
        {

            var ctx = new TareasDbContext();
            ctx.Usuarios.Add(new Usuario
            {
                Id = 1,
                Nombre = "Cristian",
                Clave = "123456"
            });

            ctx.SaveChanges();
        }

        static void Consultar()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.ToList();

            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.Id})");
            }
        }

        static void Actualizacion()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.Where(i => i.Id == 1).ToList();
            lista[0].Nombre = "Pepe";
            ctx.SaveChanges();
        }
        /*
        static void Actualizacion2()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.Id == 1).Single;
            usuario.Nombre = "Pepe";
            ctx.SaveChanges();
        }
        */

        static void Borrar()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.Id == 1).Single();
            ctx.Usuarios.Remove(usuario);

            ctx.SaveChanges();


        }
    }
}
