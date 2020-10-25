using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SnakeAndLadderSimulator
{
    class SnakeAndLadderPlay
    {
        /// <summary>Creating a public variables</summary>
        public int currentPosition = 0;
        public int finalPosition = 0;
        public int numOfTimeDieRoll = -1;
        public int dieNumber;
        public int playerId;
        /// <summary>Initializes a new instance of the <see cref="SnakeAndLadderPlay" /> class.</summary>
        /// <param name="playerId">The player identifier.</param>
        public SnakeAndLadderPlay(int playerId)
        {
            this.playerId = playerId;
        }
        /// <summary>Method to Roll a die.</summary>
        public int RollingADie()
        {
           ///Random number generated for Die from 1 to 6
            Random random = new Random();
            dieNumber = random.Next(1, 7);
            return dieNumber;
        }

        /// Checks for option whether it is noplay, ladder or snake
        
        public void CheckForOption()
        {
            ///Random number to check Option
            Random random = new Random();
            int option = random.Next(0, 4);
            switch (option)
            {
                case 0:
                    /// If noPlay player Stays at current position
                    Console.WriteLine("No Play, Current Position: " + currentPosition);
                    break;
                
                case 1:
                    /// If Ladder move from current position to final position based on dieNumber
                    finalPosition = currentPosition + dieNumber;
                    Console.WriteLine("Ladder, current Position: " + currentPosition + ", Die Rolled: " + dieNumber + ", Final Position: " + finalPosition);              
                    ///If player finalposition exceds 50, player stays at current position
                    if (finalPosition > 50)
                    {
                        finalPosition = currentPosition;
                        Console.WriteLine("The player is at position" + finalPosition);
                    }
                    else
                    {
                        currentPosition = finalPosition;
                        Console.WriteLine("The Player at position" + currentPosition);
                    }
                    ///If player gets ladder one more chance to play
                    RollingADie();
                    break;
                default:
                    /// If Snake move back from current position to final position based on dieNumber
                    finalPosition = currentPosition - dieNumber;
                    Console.WriteLine("Snake, current Position: " + currentPosition + ", Die Number: " + dieNumber );
                    currentPosition = finalPosition;
                    ///when player gets snake reaches 0 again he starts from 0
                    if (currentPosition < 0)
                    {
                        currentPosition = 0;
                        Console.WriteLine("The player at position" + currentPosition);
                    }
                    else
                        Console.WriteLine("The player at position" + finalPosition);
                    break;      
            }
        }
        
    }
}
