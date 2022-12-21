using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
            UniversityContext universityContext2 = UniversityContext.Instantiate_UniversityContext();

            List<Student> s = universityContext.Student.ToList();
           // Debug.WriteLine(string.Join(", ", s));
            foreach (Student student in s)
            {
                Debug.WriteLine("Student {0}: first name: {1} -last name: {2} -phone number: {3}  ", student.Id, student.first_name, student.last_name, student.phone_number);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}