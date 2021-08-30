using System;

namespace Income_Comparison_Assignment
{
    class Program
    {
        static void Main()
        {
            int person1HourlyRate = 15;
            int person2HourlyRate = 20;

            int person1HoursPerWeek = 40;
            int person2HoursPerWeek = 40;

            //calculate the salary for the year
            int person1Salary = (person1HourlyRate * person1HoursPerWeek) * 52;
            int person2Salary = (person2HourlyRate * person2HoursPerWeek) * 52;


            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(person1HourlyRate);
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(person1HoursPerWeek);


            //Person 2
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(person2HourlyRate);
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(person2HoursPerWeek);

            //Annual Salary of Person 1
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(person1Salary);

            //Annual Salary of Person 2
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(person2Salary);

            //Comparision of annual salary
            Console.WriteLine("Person 1 makes more money than Person 2");
            bool moreMoney = person1Salary > person2Salary;
            Console.WriteLine(moreMoney);
            Console.Read();
        }
    }
}
