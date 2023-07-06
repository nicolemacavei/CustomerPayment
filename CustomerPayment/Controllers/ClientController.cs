using CustomerPayment.Data;
using CustomerPayment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerPayment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly CustomerDbContext _context;
        public ClientController(CustomerDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Customers>> Get()
            => await _context.Customers.ToListAsync();

        [HttpGet("id")]
        [ProducesResponseType(typeof(Customers), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var customer = await _context.Customers.FindAsync();
            return customer == null ? NotFound() : Ok(customer);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Customers customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById),new { id = customer.Id }, customer);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Update(int id, Customers customer) {
            if (id != customer.Id) return BadRequest();

            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var customerToDelete = await _context.Customers.FindAsync();
            if (customerToDelete == null) return NotFound();

            _context.Customers.Remove(customerToDelete);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
