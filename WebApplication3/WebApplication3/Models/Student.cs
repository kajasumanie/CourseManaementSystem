using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string PhoneNo { get; set; }
        public string CourseName { get; set; }
        public DateTime EnrollmentDate { get; set; }

    }
}
