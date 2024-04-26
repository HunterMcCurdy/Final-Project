
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspnetcoreapp.Data;
using aspnetcoreapp.Models;
using Microsoft.EntityFrameworkCore;


namespace aspnetcoreapp.Controllers
{
    public class StudentsController : ControllerBase
    {

        private readonly ILogger<StudentsController> _logger;

        private readonly StudentsContext _context;

        public StudentsController(ILogger<StudentsController> logger, StudentsContext context )
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpGet]
        public IActionResult get()
        {
            return Ok(_context.Students.ToList());
        }

    }

    
    
}
