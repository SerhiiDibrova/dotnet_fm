// GradeController.cs
using System.Linq;
using System.Web.Http;

namespace dotnet_fm
{
    public class GradeController : ApiController
    {
        private AppDbContext _context = new AppDbContext();

        [HttpGet]
        public IHttpActionResult GetGradesForStudent(int studentId)
        {
            var grades = _context.Grades.Where(g => g.StudentId == studentId).ToList();
            return Ok(grades);
        }

        [HttpPost]
        public IHttpActionResult AddGrade(Grade grade)
        {
            _context.Grades.Add(grade);
            _context.SaveChanges();
            return Ok(grade);
        }
    }
}
