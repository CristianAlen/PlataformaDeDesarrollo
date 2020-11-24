using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tareas.Data
{
    public class RecursoService
    {
        private DataContext context;
        public RecursoService(DataContext _context)
        {
            context = _context;
        }
        //PARA OBTENER TODOS LOS DATOS
        public async Task<List<Recurso>> GetAllRecurso()
        {
            return await context.Recurso.ToListAsync();
        }

        //PARA EDITAR
        public async Task<Recurso> Get(int id)
        {
            return await context.Recurso.Where(i => i.IdRecursos == id).SingleAsync();
        }
        //PARA GUARDAR
        public async Task<Recurso> Save(Recurso value)
        {
            if (value.IdRecursos == 0)
            {
                await context.Recurso.AddAsync(value);
            }
            else
            {
                context.Recurso.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }
        //ELIMINAR
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Recurso.Where(i => i.IdRecursos == id).SingleAsync();
            context.Recurso.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
    }
}

