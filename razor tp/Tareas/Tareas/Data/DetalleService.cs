using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tareas.Data
{
    public class DetalleService
    {
        private DataContext context;
        public DetalleService(DataContext _context)
        {
            context = _context;
        }
        //PARA OBTENER TODOS LOS DATOS
        public async Task<List<Detalle>> GetAllDetalle()
        {
            return await context.Detalle.ToListAsync();
        }

        //PARA EDITAR
        public async Task<Detalle> Get(int id)
        {
            return await context.Detalle.Where(i => i.IdDetalles == id).SingleAsync();
        }
        //PARA GUARDAR
        public async Task<Detalle> Save(Detalle value)
        {
            if (value.IdDetalles == 0)
            {
                await context.Detalle.AddAsync(value);
            }
            else
            {
                context.Detalle.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }
        //ELIMINAR
        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Detalle.Where(i => i.IdDetalles == id).SingleAsync();
            context.Detalle.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
