using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Streaming_API.Models;
using Streaming_API.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class VideosController : ControllerBase
{
    private readonly STREAMING_APIDbContext _context;

    public VideosController(STREAMING_APIDbContext context)
    {
        _context = context;
    }

    // GET: api/Videos
    [HttpGet]
    public IActionResult GetVideos()
    {
        var videos = _context.Videos.ToList();
        return Ok(videos);
    }

    // GET: api/Videos/5
    [HttpGet("{id}")]
    public IActionResult GetVideo(int id)
    {
        var video = _context.Videos.FirstOrDefault(v => v.Id == id);
        if (video == null)
        {
            return NotFound();
        }
        return Ok(video);
    }

    // POST: api/Videos
    [HttpPost]
    public async Task<IActionResult> PostVideo([FromBody] Video video)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        _context.Videos.Add(video);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetVideo", new { id = video.Id }, video);
    }

    // PUT: api/Videos/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutVideo(int id, [FromBody] Video video)
    {
        if (id != video.Id)
        {
            return BadRequest();
        }

        _context.Entry(video).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Videos.Any(e => e.Id == id))
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

    // DELETE: api/Videos/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteVideo(int id)
    {
        var video = await _context.Videos.FindAsync(id);
        if (video == null)
        {
            return NotFound();
        }

        _context.Videos.Remove(video);
        await _context.SaveChangesAsync();

        return Ok(video);
    }
}
