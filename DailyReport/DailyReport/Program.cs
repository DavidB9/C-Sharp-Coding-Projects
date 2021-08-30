using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pitman Training");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What Course are you in?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything?  Please answer “true” or “false”");
            bool helpRequired = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Is there any other feedback you’d like to provide?  Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your responses. An Instructor will respond shortly.  Have a great day!");
            Console.Read();
        }
    }
}
