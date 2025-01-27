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
            }
        }
    }
}
