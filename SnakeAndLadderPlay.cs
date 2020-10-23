using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SnakeAndLadderSimulator
{
    class SnakeAndLadderPlay
    {
        /// <summary>Creating a public variables</summary>
        public int playerPosition = 0;
        public int numOfTimeDirRoll = 0;
        public int dieNumber;
        /// <summary>Method to Roll a die.</summary>
        public void RollingADie()
        {
            Random random = new Random();
            dieNumber = random.Next(0, 6);
            Console.WriteLine("The Die Number is:" + dieNumber);
        }

        /// <summary>Checks for option whether it is noplay, ladder or snake</summary>
        public void CheckForOption()
        {
            Random random = new Random();
            int option = random.Next(0, 4);
            switch (option)
            {
                case 0:
                    Console.WriteLine("No Play, Current Position: " + playerPosition);
                    break;
                case 1: 
                    Console.WriteLine("Ladder, Initial Position: " + playerPosition + ", Die Rolled: " + dieNumber + ", Final Position: " + (playerPosition + dieNumber));
                    playerPosition += dieNumber;
                    Console.WriteLine(+playerPosition);
                    break;
                default:
                    Console.WriteLine("Snake, Initial Position: " + playerPosition + ", Die Rolled: " + dieNumber + ", Final Position: " + (playerPosition - dieNumber));
                    playerPosition -= dieNumber;
                    Console.WriteLine(+playerPosition); 
                    break;
                    
            }
        }
    }
}
