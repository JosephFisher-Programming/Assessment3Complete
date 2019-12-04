using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHealth;
            bool inCombat;
            int monsterHealth = 100;
            playerHealth = 100;
            monsterHealth = 50;
            string battleStartText = "A wild monster has appeared!";
            string playerChooseText = "I choose you violent actions!";
            string playerHealthText = "Player Health = " + playerHealth;
            string monsterHealthText = "Monster Health = " + monsterHealth;
            Console.WriteLine(battleStartText);
            Console.WriteLine(playerChooseText);
            Console.WriteLine(playerHealthText);
            Console.WriteLine(monsterHealthText);
            Console.ReadLine();
        }
    }
}
