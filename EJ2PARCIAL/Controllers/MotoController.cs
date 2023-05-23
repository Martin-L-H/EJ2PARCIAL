using EJ2PARCIAL.DAL;
using EJ2PARCIAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ2PARCIAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoController : ControllerBase
    {
        private readonly MotoContext _context;
        public MotoController(MotoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Moto>> Get()
        {
            return _context.Motos.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Moto> GetID(int id)
        {
            var SELECT = _context.Motos.FirstOrDefault(x => x.Id == id);
            if (SELECT == null)
            {
                return NotFound();
            }
            else
            {
                return SELECT;
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody] Moto motoNueva)
        {
            _context.Motos.Add(motoNueva);
            _context.SaveChanges();
            return Created("MOTO CREADA",motoNueva);
        }
        [HttpDelete("{id}")]
        public ActionResult<Moto> Delete(int id)
        {
            var SELECT = _context.Motos.FirstOrDefault(a => a.Id == id);
            if (SELECT == null)
            {
                return NotFound();
            }
            _context.Motos.Remove(SELECT);
            _context.SaveChanges();
            return SELECT;
        }
        [HttpPut("{id}")]
        public ActionResult<Moto> Put(int id, [FromBody] Moto motoUpdate)
        {
            Moto _moto = _context.Motos.Find(id);
            if (_moto == null)
            {
                return NotFound();
            }
            _moto.Marca = motoUpdate.Marca;
            _moto.Modelo = motoUpdate.Modelo;
            _context.SaveChanges();
            return motoUpdate;
        }
    }
}
