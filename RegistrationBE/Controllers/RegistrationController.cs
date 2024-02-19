using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistrationBE.Models;

namespace RegistrationBE.Controllers;

[ApiController]
[Route("[controller]")]
public class RegistrationController : ControllerBase
{
    private readonly AppDbContext _context;

    public RegistrationController(AppDbContext context)
    {
        _context = context;
    }

    // POST: api/Registration 
    [HttpPost]
    public async Task<ActionResult<Student>> PostRegistration(Student student)
    {
        if (_context.Students == null)
        {
            return Problem("Entity set 'AppDbContext.Students'  is null.");
        }
        int totalCount = _context.Students.Count(item => item.PrefferedLocation == student.PrefferedLocation);
        if (totalCount > 2)
        {
            return BadRequest("Preffered location is full.");
        }

        student.StudentId = Guid.NewGuid();
        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        // return Ok("Registration successful!");
        return Ok(student);
    }

    // GET: api/Registration
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
    {
        return await _context.Students.ToListAsync();
    }
    // GET: api/Registration/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudent(Guid id)
    {
        var student = await _context.Students.FindAsync(id);

        if (student == null)
        {
            return NotFound();
        }

        return student;
    }

    // PUT: api/Registration/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutStudent(Guid id, Student student)
    {
        if (id != student.StudentId)
        {
            return BadRequest();
        }

        _context.Entry(student).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!StudentExists(id))
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

    // DELETE: api/Registration/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(Guid id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null)
        {
            return NotFound();
        }

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool StudentExists(Guid id)
    {
        return _context.Students.Any(e => e.StudentId == id);
    }
}
