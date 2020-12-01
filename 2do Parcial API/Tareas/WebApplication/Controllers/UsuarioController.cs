using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary.Entidades;
using Microsoft.AspNetCore.Mvc;
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
            if(usr.IdUsuario == 0)
            {
                _context.Usuario.Add(usr);
            }
            else
            {
                _context.Usuario.Attach(usr);
                _context.Usuario.Update(usr);
            }
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