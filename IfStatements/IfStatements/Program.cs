using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Loops looperino = new Loops();
            bool playerAlive = true;
            int invulTimer = 1;
            int score = 0;
            int x = 0;
            invulTimer--;
            if (playerAlive == true)
            {
                Console.WriteLine("The player is alive");
            }
            else
            {
                Console.WriteLine("The player is deadeded");
            }
            if (invulTimer > 0)
            {
                Console.WriteLine("You are invincible");
                if (playerAlive == true)
                {
                    invulTimer--;
                }
            }
            else if (invulTimer < 0)
            {
                invulTimer = 0;
            }
            for (x = 0; x < 20; x++)
            {
                Console.WriteLine(x + 1);
                if (score < 100)
                {
                    score += 20;
                }

                if (score > 99)
                {
                    break;
                }
            }
            Console.ReadLine();
            looperino.Looping();
        }
    }
}
