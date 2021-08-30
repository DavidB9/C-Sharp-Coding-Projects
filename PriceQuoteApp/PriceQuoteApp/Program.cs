using System;

namespace PriceQuoteApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below");

            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            else
            {
                Console.WriteLine("Please enter the package width");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length");
                double length = Convert.ToDouble(Console.ReadLine());

                double combine = width + height + length;

                if(combine > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
                else
                {
                    double quote = ((width * height * length) * weight) / 100 ;
                    Console.WriteLine("Your estimated total for shipping this package is: £" + quote);
                    Console.WriteLine("Thank you");   
                    Console.Read();
                }

                
            }
        }
    }
}
