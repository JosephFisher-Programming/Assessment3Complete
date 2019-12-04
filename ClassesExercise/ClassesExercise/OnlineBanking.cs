using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    class OnlineBanking
    {
        static void Main2(string[] args)
        {

            DigitalPiggyBank dpb = new DigitalPiggyBank();
            dpb.deposit(50);
            Console.WriteLine(dpb.balance());
            dpb.deposit(75);
            Console.WriteLine(dpb.balance());
            float cashInHand = dpb.withdraw();
            Console.WriteLine(dpb.balance());
            Console.ReadKey();
        }
    }
}
