using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_School_Project.Models
{
    internal class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(25)]
        public string SecurityNumber { get; set; }
        public int Salary { get; set; }
        [MaxLength(50)]
        public string WorkPosition { get; set; }
        public int DepartmentID { get; set; }
        public DateOnly StartedWorkYear { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

    }
}
