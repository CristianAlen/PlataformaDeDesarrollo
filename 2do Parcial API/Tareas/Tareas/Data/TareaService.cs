using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tareas.Data
{
    public class TareaService
    {
        private DataContext context;
        public TareaService(DataContext _context)
        {
            context = _context;
        }

        public async Task<List<Tarea>> GetTareas()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetTarea();
        }

        //PARA OBTENER TODOS LOS DATOS
        //public async Task<List<Tarea>> GetAllTareas()
        //{
        //    return await context.Tarea.ToListAsync();
        //}
        //PARA EDITAR

        public async Task<Tarea> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.GetIdTarea(id);
            //return await context.Usuario.Where(i => i.IdUsuario == id).SingleAsync();
        }
        //public async Task<Tarea> Get(int id)
        //{
        //    return await context.Tarea.Where(i => i.IdTareas == id).SingleAsync();
        //}
        //PARA GUARDAR
        public async Task<Tarea> Save(Tarea tra)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44364/api/");

            return await remoteService.SetTarea(tra);
        }
        //public async Task<Tarea> Save(Tarea value)
        //{
        //    if (value.IdTareas == 0)
        //    {
        //        await context.Tarea.AddAsync(value);
        //    }
        //    else
        //    {
        //        context.Tarea.Update(value);
        //    }
        //    await context.SaveChangesAsync();
        //    return value;
        //}

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Tarea.Where(i => i.IdTareas == id).SingleAsync();
            context.Tarea.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

        //[HttpPost]
        //public List<Tarea> Post() 
        //{ 

        //}
        
    }
}