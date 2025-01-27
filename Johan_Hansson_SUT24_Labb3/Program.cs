namespace Johan_Hansson_SUT24_Labb3.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new SchoolDbContext();
            bool menuBool = true;

            while (menuBool)
            {
                Console.WriteLine("[1] Show all students");
                Console.WriteLine("[2] Show students according to class");
                Console.WriteLine("[3] Add staff member");
                Console.WriteLine("[4] Exit program");
                Console.WriteLine("Choose an option");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Methods.ShowStudents(context);
                        break;
                    case "2":
                        Methods.StudentsInClass(context);
                        break;
                    case "3":
                        Methods.AddMember(context);
                        break;
                    case "4":
                        menuBool = false;
                        break;
                    default:
                        Console.WriteLine("Choose between 1-4");
                        break;


                }

            }
        }
    }
}
