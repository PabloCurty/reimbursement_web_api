using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using reimbursement.Data;
using reimbursement.Model;

namespace reimbursement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        public DataContext _context { get; }

        public ReportController(DataContext context)
        {
            _context = context;
        }
        //GET api/report
        //all reimbursement reports
        [HttpGet]
        public async Task<IActionResult> Get() //=> new Evento[] 
        { 
            try
            {
                var results = await _context.Reports.ToListAsync(); 
                return Ok(results);  
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "DB Connection fail");
            }
            
        }

        //GET api/report/user_id
        //all reimbursement reports from unique user
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)  
        { 
            try
            {
                var result = await _context.Reports.Where(x => x.user_id == id).ToListAsync();
                return Ok(result);
            }        
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status404NotFound, "Event not found");
            }
            
        }
    }
}
