using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class StudentsController : Controller
    {
        private static StudentRepository repo= new StudentRepository(UniversityContext.Instantiate_UniversityContext()); 
        public IActionResult Index()
        {   
            return View();
        }
        [Route("/Courses")]
        public IActionResult UniqueCourses()
        {
            List<string> c = (List<string>)repo.getUniqueCourses();
            foreach (string course in c)
            {
                
                Debug.WriteLine(course);
            }
            return View(c);
        }
        [Route("{course}/Students/")]
        public IActionResult StudentsByCourse(string course)
        {
            List<Student> students = (List<Student>)repo.getStudentsByCourse(course);

            return View(students); 
        }
    }
}
