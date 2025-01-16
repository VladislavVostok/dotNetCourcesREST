using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotNetCources.Models;
using dotNetCources.States;
using Microsoft.AspNetCore.Authorization;
using dotNetCources.DTO.Courses;

namespace dotNetCources.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly AppContextDB _context;

        public CoursesController(AppContextDB context)
        {
            _context = context;
        }


		[HttpGet("search")]
		public async Task<ActionResult> SearchCourses(string query)
		{
			var courses = await _context.Courses
				.Where(c => c.Title.Contains(query) && c.PlatformStatus == PlatformStatus.Published && c.TeacherCourseStatus == TeacherStatus.Published)
				.ToListAsync();

			return Ok(courses);
		}
	

	    // GET: api/Courses
	    [HttpGet]
		[AllowAnonymous]
		public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            return await _context.Courses.ToListAsync();
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }


        // PUT: api/Courses/5  
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutCourse(int id, Course course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(id))
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

        // POST: api/Courses
        [HttpPost]
        //[Authorize]
        public async Task<ActionResult<Course>> PostCourse([FromBody] CourceCreateRequestDTO courseCreateRequestDTO)
        {   
            Course course = new()
            { 
                CategoryId = courseCreateRequestDTO.CategoryId,
                TeacherId = courseCreateRequestDTO.TeacherId,
                File = courseCreateRequestDTO.File,
                Image = courseCreateRequestDTO.Image,
                Title = courseCreateRequestDTO.Title,
                Description = courseCreateRequestDTO.Description,
                Price = courseCreateRequestDTO.Price,
                Language = courseCreateRequestDTO.Language,
                Level = courseCreateRequestDTO.Level,
                TeacherCourseStatus = courseCreateRequestDTO.TeacherCourseStatus
            } ;

            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
		[Authorize]
		public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}
