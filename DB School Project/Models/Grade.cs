using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_School_Project.Models
{
    internal class Grade
    {
        [Key]
        public int GradeID { get; set; }
        public DateOnly GradeDate { get; set; }

        [MaxLength(1)]
        public string CourseGrade { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int EmployeeID { get; set; }
        public virtual Student Students { get; set; }
        public virtual Course Courses { get; set; }
        public virtual Employee Employees { get; set; }

        
    }
}
