using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    class Remote
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Television Project");
            Television myTv = new Television();
            Console.WriteLine("The current channel is "+ myTv.channel() );
            myTv.increaseChannel();
            Console.WriteLine("The current channel is " + myTv.channel());
            Console.ReadKey();
        }
    }
}
