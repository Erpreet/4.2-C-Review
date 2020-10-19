using System;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        {
            char aChar;
            string aString;

            bool aBoolean;


            byte aByte;
            short aShortInt;
            int anInt;
            long aLongInt;

            float aFloat;
            double aDouble;
            decimal aDecimal;

            string name;

            Console.Write("Please enter you name");

            name = Console.ReadLine().Trim();


            if (name == "")
            {
                Console.WriteLine("Invalid Input: Please enter a name");
            }
            else
            {
                name = Console.ReadLine();
                Console.ReadLine();
                Console.WriteLine("Hello " + name + "!What a nice day today!");
                Console.WriteLine("Hello {0}! What a nice day today!", name);
                Console.WriteLine($"Hello {name}!What a nice day today!");
            }
        }

    }
}
