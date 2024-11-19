using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartoonsController : ControllerBase
    {
        private readonly FinalProjectContext _context;

        public CartoonsController(FinalProjectContext context)
        {
            _context = context;
        }

        // GET: api/Cartoons
        [HttpGet]
       public IActionResult GetCartoons()
        {
            return Ok(_context.Cartoon);
        }

        // GET: api/Cartoons/5
        [HttpGet("{id}")]
        public IActionResult GetCartoon(int id)
        {
            Cartoon cartoon = _context.Cartoon.Find(id);

            if (cartoon == null)
            {
                return NotFound();
            }

            return Ok(cartoon);
        }

        // POST: api/Cartoons
        [HttpPost]
        public IActionResult PostCartoon(Cartoon cartoon)
        {
            _context.Cartoon.Add(cartoon);
            _context.SaveChanges();
            return Ok();
        }

        // PUT: api/Cartoons
        [HttpPut]
        public IActionResult PutCartoon(Cartoon cartoon)
        {
            try
            {
                _context.Entry(cartoon).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            { 
                return NotFound();
            }
            return Ok();
        }

        // DELETE: api/Cartoons/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCartoon(int id) {
            Cartoon cartoon = _context.Cartoon.Find(id);
            if (cartoon == null)
            {
                return NotFound();
            }
            try
            {
                _context.Cartoon.Remove(cartoon);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }

            return Ok();
        }

    }
}
