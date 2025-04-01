using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrendMicroAPI.Data;
using TrendMicroAPI.Models;

namespace TrendMicroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;

        public CustomerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            return Ok(await _context.Customers.ToListAsync());
        }

    }
}
