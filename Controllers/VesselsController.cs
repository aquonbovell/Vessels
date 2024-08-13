using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vessels.Data;
using Vessels.Models;

namespace Vessels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin,User")]
    public class VesselsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public VesselsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vessel>>> Get()
        {
            return await _context.Vessels.ToArrayAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vessel>> Get(int id)
        {
            var vessel = await _context.Vessels.FindAsync(id);
            if (vessel == null)
            {
                return NotFound();
            }
            return Ok(vessel);
        }
        [HttpPost]
        public async Task<ActionResult<Vessel>> Post([FromBody] Vessel vessel)
        {
            if (vessel.ArrivalDate >= vessel.DepartureDate)
            {
                ModelState.AddModelError("Name", "Arrival Date must be eariler that departure date");
                return BadRequest(ModelState);
            }
            if (ModelState.IsValid)
            {
                vessel.ArrivalDate = new DateTime(vessel.ArrivalDate.Ticks, DateTimeKind.Unspecified);
                vessel.DepartureDate = new DateTime(vessel.DepartureDate.Ticks, DateTimeKind.Unspecified);
                _context.Vessels.Add(vessel);
                await _context.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = vessel.Id }, vessel);
            }
            return BadRequest();
        }
        [HttpPut]
        public async Task<ActionResult<Vessel>> Put(int id, [FromBody] Vessel vessel)
        {
            if (id != vessel.Id)
            {
                return BadRequest(ModelState);
            }
            if (ModelState.IsValid)
            {
                _context.Entry(vessel).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            return BadRequest(ModelState);
        }
        [HttpDelete]
        public async Task<ActionResult<Vessel>> Delete(int id)
        {
            var vessel = await _context.Vessels.FindAsync(id);
            if (vessel == null)
            {
                return NotFound();
            }
            _context.Remove(vessel);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
