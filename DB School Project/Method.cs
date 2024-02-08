using DB_School_Project.Data;
using DB_School_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_School_Project
{
    internal class Method
    {
        public static void Run()
        {
            Console.WriteLine("Välkommen till Skolan!");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välj något av följande val i menyn.");
                Console.WriteLine("[1] Antal lärare");
                Console.WriteLine("[2] Hämta information om elever");
                Console.WriteLine("[3] Aktiva kurser");
                Console.WriteLine("[4] Stäng av programmet");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Teachers();
                        break;

                    case "2":
                        StudentInfo();
                        break;

                    case "3":
                        ActiveCourses();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static void Teachers()
        {
            using SchoolDbContext context = new SchoolDbContext();
            Console.Clear();

            var teacherCount = context.Employees.Where(e => e.WorkPosition == "Teacher").GroupBy(e => e.DepartmentID).Select
            (g => new
            {
                DepartmentID = g.Key,
                TeacherCount = g.Count()
            }
            ).ToList();

            var departmentNames = context.Departments.ToDictionary(d => d.DepartmentID, d => d.Name);
            
            Console.WriteLine("Antal lärare per avdelning:\n");

            foreach (var e in teacherCount)
            {
                var departmentName = departmentNames.ContainsKey(e.DepartmentID) ? departmentNames[e.DepartmentID] : "Okänd avdelning";
                Console.WriteLine($"Avdelning: {departmentName}\nAntal lärare: {e.TeacherCount}\n");
            }

            Console.WriteLine("Tryck ENTER för att försätta.");
            Console.ReadKey();
        }

        public static void StudentInfo()
        {
            using SchoolDbContext context = new SchoolDbContext();
            Console.Clear();

            var allStudents = context.Students.ToList();

            Console.WriteLine("Information om eleverna:\n");

            foreach (var s in allStudents)
            {
                Console.WriteLine($"ID: {s.StudentID}\nNamn: {s.FirstName} {s.LastName}\nKlass: {s.ClassName}\nPersonnummer: {s.SecurityNumber}\n");
            }

            Console.WriteLine("Tryck ENTER för att försätta.");
            Console.ReadKey();
        }

        public static void ActiveCourses()
        {
            using SchoolDbContext context = new SchoolDbContext();
            Console.Clear();

            var activeCourses = context.Courses.Where(c => c.IsCourseActive == true).ToList();

            Console.WriteLine("Lista över aktiva kurser:\n");

            foreach(var c in activeCourses)
            {
                Console.WriteLine($"ID: {c.CourseID}\nKursnamn: {c.CourseName}\n");
            }

            Console.WriteLine("Tryck ENTER för att försätta.");
            Console.ReadKey();
        }
    }
}
