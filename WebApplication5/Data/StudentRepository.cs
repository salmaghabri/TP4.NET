using WebApplication5.Models;

namespace WebApplication5.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly UniversityContext context;
        public StudentRepository(UniversityContext context) : base(context)
        {
            this.context = context;
        }
        public IEnumerable<String> getUniqueCourses()
        {
            return  context.Student.Select(student => student.course).Distinct().ToList();
        }
        public IEnumerable<Student> getStudentsByCourse(string course) { 
            return context.Student.Where(student => student.course==course).ToList();
        }
    }
}
