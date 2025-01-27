using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johan_Hansson_SUT24_Labb3.Models
{
    public class Methods
    {
        public static void ShowStudents(SchoolDbContext context)
        {
            Console.Clear();
            Console.WriteLine("Sort by:");
            Console.WriteLine("[1]First name Ascending");
            Console.WriteLine("[2]First name Descending");
            Console.WriteLine("[3]Last name Ascending");
            Console.WriteLine("[4]Last name Descending");
            string userInput = Console.ReadLine();

            IQueryable<Student> students = context.Students;

            switch (userInput)
            {
                case "1":
                    students = students.OrderBy(students => students.FirstName);
                    break;
                case "2":
                    students = students.OrderByDescending(students => students.FirstName);
                    break;
                case "3":
                    students = students.OrderBy(students => students.LastName);
                    break;
                case "4":
                    students = students.OrderByDescending(students => students.LastName);
                    break;
                default:
                    Console.WriteLine("Choose between 1-4");
                    break;
            }
            var student = students.ToList();
            foreach (var stud in student)
            {
                Console.WriteLine($"{stud.FirstName} {stud.LastName}");
            }
        }
        public static void StudentsInClass(SchoolDbContext context)
        {
            var classes = context.Classes.ToList();
            Console.WriteLine("Choose a class: ");
            for (int i = 0; i < classes.Count; i++)
            {
                Console.WriteLine($"{i + 1}, {classes[i].ClassName}");
            }
            int userChoice;
            if(int.TryParse(Console.ReadLine(), out userChoice) && userChoice > 0 && userChoice <= classes.Count)
            {
                var classChoice = classes[userChoice - 1];
                var classStudents = context.Students.Where(students => students.ClassId == classChoice.Id).ToList();
                Console.WriteLine($"Students i choosen class: {classChoice.ClassName}");
                foreach (var stud in classStudents)
                {
                    Console.WriteLine($"{stud.FirstName} {stud.LastName}");
                }
            }
            else
            {
                Console.WriteLine("Choose a class in the list.");
            }
        }
        public static void AddMember(SchoolDbContext context)
        {
            Console.WriteLine("Add new staff member");
            Console.WriteLine("Type in full name");
        }
    }
}
