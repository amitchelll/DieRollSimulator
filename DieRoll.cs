using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRollSimulator
{
    internal class DieRoll
    {
        // When a new instance of DieRoll is created the variable random is also created
        private Random random;
        public DieRoll() 
        { 
            random = new Random();
        }
        //The method RollSimulator is passed the dice roll number and returns an array of integers
        public int[] RollSimulator(int diceRollNum)
        {
            //The results can only be 2-12 so the size of the array is 13
            int[] rollResults = new int[13];

            //As long as the counter is less than the number of desired rolls the loop with generate a random number (1-6) for each die
            //The die are added together and added to the array
            for (int i = 0; i < diceRollNum; i++)
            {
                int dice1Num = random.Next(1, 7);
                int dice2Num = random.Next(1, 7);
                int dieSum = dice1Num + dice2Num;

                rollResults[dieSum]++;
            }
            return rollResults;
        }
    }
}
