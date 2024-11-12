// StudentController.cs
using System.Linq;
using System.Web.Http;

namespace dotnet_fm
{
    public class StudentController : ApiController
    {
        private AppDbContext _context = new AppDbContext();

        [HttpGet]
        public IHttpActionResult GetAllStudents()
        {
            return Ok(_context.Students.ToList());
        }

        [HttpGet]
        public IHttpActionResult GetStudentWithGrades(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();

            var grades = _context.Grades.Where(g => g.StudentId == id).ToList();
            return Ok(new { Student = student, Grades = grades });
        }

        [HttpPost]
        public IHttpActionResult CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Ok(student);
        }
    }
}
