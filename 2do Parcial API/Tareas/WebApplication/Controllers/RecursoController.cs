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
    public class RecursoController : ControllerBase
    {
        private readonly DataContext _context;

        public RecursoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Recurso> Get()
        {
            return _context.Recurso.ToList();
        }

        [HttpPost]
        public Recurso Post(Recurso rec)
        {
            if (rec.IdRecursos == 0)
            {
                _context.Recurso.Add(rec);
            }
            else
            {
                _context.Recurso.Attach(rec);
                _context.Recurso.Update(rec);
            }
            _context.SaveChanges();

            return rec;
        }

        [HttpGet("{id}")]
        public Recurso Get(int id)
        {
            return _context.Recurso.Where(i => i.IdRecursos == id).Single();
        }
    }
}