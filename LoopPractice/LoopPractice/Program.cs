using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do while example
            int counter = 0;
            do
            {
                counter++;
                Console.WriteLine("Counter is equal to " + counter);
            } while (counter < 10);
            Console.ReadLine();

            // While example
            while (counter < 10)
            {
                counter++;
                Console.WriteLine("Counter is equal to " + counter);
            }
            Console.ReadLine();

            // For example
            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("Counter is equal to " + counter);
            }
            Console.ReadLine();

            // For each example
            string[] dogNames = { "bonzo", "fred", "killer", "arnold", "benji", "lassie" };
            foreach (String str in dogNames)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
