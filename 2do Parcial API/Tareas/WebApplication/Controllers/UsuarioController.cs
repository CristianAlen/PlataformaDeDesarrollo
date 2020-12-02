using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;

        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return _context.Usuario.ToList();
        }

        [HttpPost]
        public Usuario Post(Usuario usr)
        {
            var local = _context.Usuario.Local.FirstOrDefault(e => e.IdUsuario.Equals(usr.IdUsuario));

            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            if(usr.IdUsuario == 0)
            {
                _context.Entry(usr).State = EntityState.Detached;
            }
            else
            {
                _context.Entry(usr).State = EntityState.Modified;
            }
            //if(usr.IdUsuario == 0)
            //{
            //    _context.Usuario.Add(usr);
            //}
            //else
            //{
            //    _context.Usuario.Attach(usr);
            //    _context.Usuario.Update(usr);
            //}
            _context.SaveChanges();

            return usr;
        }

        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return _context.Usuario.Where(i => i.IdUsuario == id).Single();
        }
    }
}