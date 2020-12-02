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
    public class TareaController : ControllerBase
    {
        private readonly DataContext _context;

        public TareaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Tarea> Get()
        {
            return _context.Tarea.ToList();
        }

        [HttpPost]
        public Tarea Post(Tarea tra)
        {
            var local = _context.Tarea.Local.FirstOrDefault(e => e.IdTareas.Equals(tra.IdTareas));

            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            if (tra.IdTareas == 0)
            {
                _context.Entry(tra).State = EntityState.Detached;
            }
            else
            {
                _context.Entry(tra).State = EntityState.Modified;
            }
            //if (tra.IdTareas == 0)
            //{
            //    _context.Tarea.Add(tra);
            //}
            //else
            //{
            //    _context.Tarea.Attach(tra);
            //    _context.Tarea.Update(tra);
            //}
            _context.SaveChanges();

            return tra;
        }

        [HttpGet("{id}")]
        public Tarea Get(int id)
        {
            return _context.Tarea.Where(i => i.IdTareas == id).Single();
        }
    }
}