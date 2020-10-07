using System;
using System.Collections.Generic;
using System.Linq;

namespace ParcialTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Insertar();
            //Consultar();
            //ActualizacionUsuario();
            ActualizacionTarea();
            //BorrarTodo();
        }

        static void Insertar()
        {
            var ctx = new TareasDbContext();

            //Usuario
            ctx.Usuario.Add(new Usuario
            {
                IdUsuario = 1,
                NombreUsuario = "Cristian",
                Clave = "12345"
            });

            //Recurso
            ctx.Recurso.Add(new Recurso
            {
                IdRecursos = 1,
                Nombre = "Cristian Recurso",
                idUsuario = 1
            });

            //Detalle
            ctx.Detalle.Add(new Detalle
            {
                Fecha = "07102020",
                Tiempo = "1530",
                IdDetalles = 1,
                IdRecurso = 1
                
            });

            //Tarea
            ctx.Tarea.Add(new Tarea
            {
                Titulo = "Realizar Parcial",
                Vencimiento = "09102020",
                Estimacion = "07102020",
                Estado = true,
                IdTareas = 1,
                IdResponsable = 1
            });

            ctx.SaveChanges();
        }

        static void Consultar()
        {
            var ctx = new TareasDbContext();

            var listaUsuario = ctx.Usuario.ToList();
            foreach (var item in listaUsuario)
            {
                Console.WriteLine($"Nombre: {item.NombreUsuario} ({item.IdUsuario})");
            }

            var listaTarea = ctx.Tarea.ToList();
            foreach (var item in listaTarea)
            {
                Console.WriteLine($"TituloTarea: {item.Titulo} | ({item.IdTareas}) | Estado: ({item.Estado}) | Vencimiento: ({item.Vencimiento}) | Estimacion: ({item.Estimacion})");
            }

        }

        static void ActualizacionUsuario()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuario.Where(i => i.IdUsuario == 1).ToList();
            lista[0].NombreUsuario = "Pepito";
            ctx.SaveChanges();
        }
        static void ActualizacionTarea()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Tarea.Where(i => i.IdTareas == 1).ToList();
            lista[0].Titulo = "Realizar Tarea";
            lista[0].Vencimiento = "08102020";

            ctx.SaveChanges();
        }

        static void BorrarTodo()
        {
            var ctx = new TareasDbContext();

            //Borramos el usuario
            var usuario = ctx.Usuario.Where(i => i.IdUsuario == 1).Single();
            ctx.Usuario.Remove(usuario);

            //Borrmamos la tarea del usuario 
            var tarea = ctx.Tarea.Where(i => i.IdTareas == 1).Single();
            ctx.Tarea.Remove(tarea);

            //Borrmamos el detalle del usuario 
            var detalle = ctx.Detalle.Where(i => i.IdDetalles == 1).Single();
            ctx.Detalle.Remove(detalle);

            //Borrmamos el recurso del usuario 
            var recurso = ctx.Recurso.Where(i => i.IdRecursos == 1).Single();
            ctx.Recurso.Remove(recurso);

            ctx.SaveChanges();
        }

    }
}
