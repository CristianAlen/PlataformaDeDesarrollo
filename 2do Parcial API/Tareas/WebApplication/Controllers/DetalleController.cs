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
    public class DetalleController : ControllerBase
    {
        private readonly DataContext _context;

        public DetalleController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Detalle> Get()
        {
            return _context.Detalle.ToList();
        }

        [HttpPost]
        public Detalle Post(Detalle dta)
        {
            var local = _context.Detalle.Local.FirstOrDefault(e => e.IdDetalles.Equals(dta.IdDetalles));

            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            if (dta.IdDetalles == 0)
            {
                _context.Entry(dta).State = EntityState.Detached;
            }
            else
            {
                _context.Entry(dta).State = EntityState.Modified;
            }

            //if (dta.IdDetalles == 0)
            //{
            //    _context.Detalle.Add(dta);
            //}
            //else
            //{
            //    _context.Detalle.Attach(dta);
            //    _context.Detalle.Update(dta);
            //}

            _context.SaveChanges();

            return dta;
        }

        [HttpGet("{id}")]
        public Detalle Get(int id)
        {
            return _context.Detalle.Where(i => i.IdDetalles == id).Single();
        }
    }
}