using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            ///creating object for player1 and player2
            SnakeAndLadderPlay player1 = new SnakeAndLadderPlay(1);
            SnakeAndLadderPlay player2 = new SnakeAndLadderPlay(2);
            while (player1.finalPosition != 50 && player2.finalPosition != 50)
            {
                int numOfTimeDieRoll = -1;
                Console.WriteLine("\nPlayer " + player1.playerId + ": ");
                ///checking number of time player1 rolling a die
                numOfTimeDieRoll = player1.RollingADie();
                if (numOfTimeDieRoll > 0)
                {
                    if (player1.finalPosition == 50)
                        break;
                    player1.CheckForOption();
                }
                Console.WriteLine("\nPlayer " + player2.playerId + ": ");
                ///checking number of time player2 rolling a die
                numOfTimeDieRoll = player2.RollingADie();
                if (numOfTimeDieRoll > 0)
                {
                    if (player2.finalPosition == 50)
                        break;
                    player2.CheckForOption();
                }
            }
            ///Condition to check who reaches final position first
            if (player1.finalPosition == 50)
                Console.WriteLine("\nPlayer " + player1.playerId + " wins");
            if (player2.finalPosition == 50)
                Console.WriteLine("\nPlayer " + player2.playerId + " wins");
        }
    }   
    
}
    

