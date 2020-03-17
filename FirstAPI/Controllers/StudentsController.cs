using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public string GetStudents()
        {
            return "Jankowski, Maciejewski, Andrzejewski";
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
                return Ok("Jankowski");
            else if (id == 2)
                return Ok("Maciejewski");
            else if (id == 3)
                return Ok("Andrzejewski");
            return NotFound("Nie znaleziono studenta");
        }
    }
}