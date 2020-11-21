using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tareas.Data
{
    public class UsuarioService
    {
        private DataContext context;
        public UsuarioService(DataContext _context)
        {
            context = _context;
        }
        //PARA OBTENER TODOS LOS DATOS
        public async Task<List<Usuario>> GetAllUsuario()
        {
            return await context.Usuario.ToListAsync();
        }

        //PARA EDITAR
        public async Task<Usuario> Get(int id)
        {
            return await context.Usuario.Where(i => i.IdUsuario == id).SingleAsync();
        }
        //PARA GUARDAR
        public async Task<Usuario> Save(Usuario value)
        {
            if (value.IdUsuario == 0)
            {
                await context.Usuario.AddAsync(value);
            }
            else
            {
                context.Usuario.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Usuario.Where(i => i.IdUsuario == id).SingleAsync();
            context.Usuario.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
