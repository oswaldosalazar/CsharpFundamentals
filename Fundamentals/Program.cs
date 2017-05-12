using System;

namespace Fundamentals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int myAge = 22;
            int yourAge = 35;

            myAge = 23;

            const int retirement = 65;
			// retirement = 72;

            int yearsToRetirementForMe = retirement - myAge;
            int yearsToRetirementForYou = retirement - yourAge;

            string message = "Will we be able to retire soon?";

            Console.WriteLine(message);
            Console.WriteLine("Years to retirement for you: " + yearsToRetirementForYou);
            Console.WriteLine("Years to retirement for me: {0}", yearsToRetirementForMe);
        }
    }
}
