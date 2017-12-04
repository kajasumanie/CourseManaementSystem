using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.          
            if (context.Students.Any())
            {
                return;   // DB has been seeded   
            }

            var students = new Student[]
            {
                new Student { FirstMidName = "Carson", LastName = "Alexander", PhoneNo="077059555",CourseName="llll",EnrollmentDate = DateTime.Parse("2005-0901") },
                new Student { FirstMidName = "Meredith", LastName = "Alonso", PhoneNo="077059555",CourseName="llll", EnrollmentDate = DateTime.Parse("2002-0901") },
                new Student { FirstMidName = "Arturo", LastName = "Anand", PhoneNo="077059555",CourseName="llll", EnrollmentDate = DateTime.Parse("2003-0901") },
                new Student { FirstMidName = "Gytis", LastName = "Barzdukas", PhoneNo="077059555",CourseName="llll", EnrollmentDate = DateTime.Parse("2002-0901") },
                new Student { FirstMidName = "Yan", LastName = "Li",  PhoneNo="077059555",CourseName="llll",EnrollmentDate = DateTime.Parse("2002-09-01") },
                new Student { FirstMidName = "Peggy", LastName = "Justice", PhoneNo="077059555",CourseName="llll", EnrollmentDate = DateTime.Parse("2001-0901") },
                new Student { FirstMidName = "Laura", LastName = "Norman", PhoneNo="077059555",CourseName="llll", EnrollmentDate = DateTime.Parse("2003-0901") },
                new Student { FirstMidName = "Nino", LastName = "Olivetto",  PhoneNo="077059555",CourseName="llll",EnrollmentDate = DateTime.Parse("2005-0901") } };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

        }
    }
}

