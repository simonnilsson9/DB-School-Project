using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_School_Project.Models
{
    internal class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
