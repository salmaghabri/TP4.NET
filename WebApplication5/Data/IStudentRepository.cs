using WebApplication5.Models;

namespace WebApplication5.Data
{
    public interface IStudentRepository : IRepository<Student> 
    {
        IEnumerable<String> getUniqueCourses();
        IEnumerable<Student> getStudentsByCourse(string course);
        
    }
}
