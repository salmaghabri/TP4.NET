using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication5.Models;

namespace WebApplication5.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        static private UniversityContext universityContextInstance = null;
        static public int i = 0;
        private UniversityContext(DbContextOptions o) : base(o)
        {
            
            i++;
        }
        static public UniversityContext Instantiate_UniversityContext()
        {
            if (universityContextInstance == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite(@"Data Source=C:\Users\salma\source\repos\WebApplication3\WebApplication3\2022 GL3 .NET Framework TP4 - SQLite database.db");
                universityContextInstance = new UniversityContext(optionsBuilder.Options);
               
            } 
            Debug.WriteLine("contstructor called {0} time", i);
            return universityContextInstance;
            
        }
    }
}
