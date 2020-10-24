﻿using System;
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
        public int numOfTimeDieRoll = 1;
        public int dieNumber;
        /// <summary>Method to Roll a die.</summary>
        public void RollingADie()
        {
           ///Random number generated for Die from 1 to 6
            Random random = new Random();
            dieNumber = random.Next(1, 7);
        }

        /// Checks for option whether it is noplay, ladder or snake
        /// If noPlay player Stays at current position
        /// If Ladder move from current position to final position based on dieNumber
        /// If Snake move back from current position to final position based on dieNumber
       
        public void CheckForOption()
        {
            ///Random number to check Option
            Random random = new Random();
            int option = random.Next(0, 4);
            switch (option)
            {
                case 0:
                    Console.WriteLine("No Play, Current Position: " + currentPosition);
                    break;
                case 1:
                    finalPosition = currentPosition + dieNumber;
                    Console.WriteLine("Ladder, current Position: " + currentPosition + ", Die Rolled: " + dieNumber + ", Final Position: " + finalPosition);
                    currentPosition = finalPosition;

                    break;
                default:
                    finalPosition = currentPosition - dieNumber;
                    Console.WriteLine("Snake, current Position: " + currentPosition + ", Die Rolled: " + dieNumber );
                    currentPosition = finalPosition;
                    if (currentPosition < 0)
                    {
                        currentPosition = 0;
                        Console.WriteLine("the final position is" + currentPosition);
                    }
                    else
                        Console.WriteLine("the final position is" + finalPosition);
                    break;      
            }
        }
        /// <summary>Winning position of player at 50</summary>
        public void WinningPosition()
        {
            while(numOfTimeDieRoll>0)
            {
                if(finalPosition==50)
                {
                    Console.WriteLine("the player at winning position");
                    break;
                }
                else
                {
                    RollingADie();
                    CheckForOption();   
                }
                numOfTimeDieRoll++;
                Console.WriteLine(numOfTimeDieRoll);
            }
        }
    }
}
