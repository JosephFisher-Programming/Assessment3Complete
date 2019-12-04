using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVariables
{
    
    class Program
    {
        int score;
        static void Main()
        {
            string greetingTalk = "How do you do fellow Kids?  The game will start when: ";
            bool gameStarted = false;
            string displayGameState = greetingTalk + gameStarted;
            Console.WriteLine(displayGameState);

            string middleTalk = "Oh wait, I forgot that you dont have a score. You want one right? ";
            gameStarted = true;
            displayGameState = middleTalk + gameStarted;
            Console.WriteLine(displayGameState);

            string startTalk = "Lemme give you one of mine! ";
            int playerScore = 1;
            string endTalk = "Now what's your score? ";
            displayGameState = startTalk + endTalk + playerScore;
            Console.WriteLine(displayGameState);
            Console.ReadKey();
        }
    }
}
