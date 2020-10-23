using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulator
{
    class SnakeAndLadderPlay
    {
        /// <summary>Creating Variable as playerPosition</summary>
        public int playerPosition = 0;
        /// <summary>Method to Roll a die.</summary>
        public void RollingADie()
        {
            Random random = new Random();
            int dieNum = random.Next(0, 6);
            Console.WriteLine("The Die Number is:" + dieNum);
        }
    }
}
