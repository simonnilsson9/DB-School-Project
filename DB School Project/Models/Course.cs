using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_School_Project.Models
{
    internal class Course
    {
        [Key]
        public int CourseID { get; set; }
        [MaxLength(50)]
        public string CourseName { get; set; }
        public bool IsCourseActive { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
