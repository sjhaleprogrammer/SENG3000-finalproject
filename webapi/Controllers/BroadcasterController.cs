using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Streaming_API.Models;
using System;
using Streaming_API.Data;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

[Route("api/[controller]")]
[ApiController]
public class BroadcastersController : ControllerBase
{
    private readonly STREAMING_APIDbContext _context;

    public BroadcastersController(STREAMING_APIDbContext context)
    {
        _context = context;
    }


    // GET: /
    [AllowAnonymous]
    [HttpGet]
    [Route("/")]
    public ActionResult<string> Get()
    {
        return Ok("Welcome to the homepage!");
    }

    // GET: api/Broadcasters
    [HttpGet]
    public IActionResult GetBroadcasters()
    {
        var broadcasters = _context.Broadcasters.ToList();
        return Ok(broadcasters);
    }

    // GET: api/Broadcaster/5
    [HttpGet("{id}")]
    public IActionResult GetBroadcaster(int id)
    {
        var broadcaster = _context.Broadcasters.FirstOrDefault(v => v.Id == id);
        if (broadcaster == null)
        {
            return NotFound();
        }
        return Ok(broadcaster);
    }

    // POST: api/Broadcasters
    [HttpPost]
    public async Task<IActionResult> PostBroadcaster([FromBody] Broadcaster broadcaster)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        _context.Broadcasters.Add(broadcaster);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetBroadcaster", new { id = broadcaster.Id }, broadcaster);
    }

    // PUT: api/Broadcasters/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutBroadcaster(int id, [FromBody] Broadcaster broadcaster)
    {
        if (id != broadcaster.Id)
        {
            return BadRequest();
        }

        _context.Entry(broadcaster).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Broadcasters.Any(e => e.Id == id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/Broadcasters/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBroadcaster(int id)
    {
        var broadcaster = await _context.Broadcasters.FindAsync(id);
        if (broadcaster == null)
        {
            return NotFound();
        }

        _context.Broadcasters.Remove(broadcaster);
        await _context.SaveChangesAsync();

        return Ok(broadcaster);
    }
}
