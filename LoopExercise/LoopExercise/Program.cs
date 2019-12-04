using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExercise
{
    /*class AcendingNumbers
    {
        //This class is in charge of making an acending numbers list
        static void Main(string[] args)
        {
            int numCount = 0;
            while (numCount < 100)
            {
                numCount++;
                Console.WriteLine(numCount);
            }
            Console.ReadLine();
        }
    }*/

    /*class DecendingNumbers
    {
        //This class is in charge of making a decending numbers list
        static void Main(string[] args)
        {
            int numCountDecending = 101;
            while (numCountDecending > 1) {
                numCountDecending--;
                Console.WriteLine(numCountDecending);
            }
            Console.ReadLine();
        }        
    }*/

    /*class YearCount
    {
        //This class is in charge of listing years 1995 to 2017
        static void Main(string[] args)
        {
            int yearCount = 1994;
            while (yearCount < 2017)
            {
                yearCount++;
                Console.WriteLine("The year is " + yearCount);
            }
            Console.ReadLine();
        }
    }*/

    /*class ThreeFavNum
    {
        //This class is in charge of storing numbers and reciting them back
        static void Main(string[] args)
        {
            string[] bigBoiNums = new string[3];
            Console.WriteLine("Hello, what is your first favorite number?");
            bigBoiNums[0] = Console.ReadLine();
            Console.WriteLine($"Okay, so your first number is {bigBoiNums[0]}, whats your second?");
            bigBoiNums[1] = Console.ReadLine();
            Console.WriteLine($"Okay, so your first number is {bigBoiNums[0]} and your second is {bigBoiNums[1]}, whats your third?");
            bigBoiNums[2] = Console.ReadLine();
            Console.WriteLine($"Alright, your favorite numbers {bigBoiNums[0]}, {bigBoiNums[1]}, and {bigBoiNums[2]}");
            Console.ReadLine();

        }
    }*/

    class FromXToY
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("I can make an acending order based on your choice! Whats the smaller number?");
            string xString = Console.ReadLine();
            Int32.TryParse(xString, out x);;
            Console.WriteLine("Whats the larger number?");
            string yString = Console.ReadLine();
            Int32.TryParse(yString, out y);
            for (x = x; y >= x; x++)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}