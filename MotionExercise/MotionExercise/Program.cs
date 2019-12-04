using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionExercise
{
    class Program
    {
        static int Ask(string ask)
        {
            Console.WriteLine(ask);
            Int32.TryParse(Console.ReadLine(), out int result);
            return result;
        }
        static void Main(string[] args)
        {
            float velocity = 0;
            float time = 0;
            float distance = Ask("How tall is the building?");

            for (time = 0;time < distance; time++)
            {
                velocity += 9.8f;
                Console.WriteLine($"Velocity : {velocity - 4.9f}     Distance Remaining : {distance - (velocity/2)}");
                distance -= velocity;
                Console.WriteLine($"Velocity : {velocity}     Distance Remaining : {distance}");
                if (distance / ((velocity * 2) + 19.6 ) < 2)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
