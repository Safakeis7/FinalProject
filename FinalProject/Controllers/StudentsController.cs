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
    public class StudentsController : ControllerBase
    {
        private readonly FinalProjectContext _context;

        public StudentsController(FinalProjectContext context)
        {
            _context = context;
        }

        // GET: api/Students

        //SAFA KEIS
        [HttpGet]
        public IActionResult GetStudents() 
        { 
            return Ok(_context.Students.ToList());
        }
        [HttpPost]
        public IActionResult PostStudent(Students student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Students student = _context.Students.Find(id);
            if (student == null)
                return NotFound();
            try
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult PutStudent(Students student)
        {
            //var s = _context.Student.Find(student.Id);
            //if(s==null)
            //    return NotFound();
            //s.Name = student.Name;
            //s.Age = student.Age;
            //_context.Student.Update(s);
            try
            {
                _context.Entry(student).State = EntityState.Modified;
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
