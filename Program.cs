using DieRollSimulator;

internal class Program
{
    private static void Main(string[] args)
    {
        //Welcome Message that prompts user to type in the number of time they want to roll the dice.
        Console.WriteLine("Welcome to the Dice Simulator!\nHow many dice rolls would you like to simulate?\n");

        // Sets an integer variable equal to the number entered into the command prompt after parsing the data type to an integer.
        int diceRollNum = int.Parse(Console.ReadLine());

        // This uses the DieRoll class to create a roll object. The RollSimulator method is accessed and the number of rolls is passed to it.
        DieRoll roll = new DieRoll();
        int[] rollResults = roll.RollSimulator(diceRollNum);

        // Explains what the histogram is showing
        Console.WriteLine("Dice Roll Results:");
        Console.WriteLine($"Each * represents 1% of the total number of rolls.\nThe total number of rolls is {diceRollNum}.\n");

        //Iterates through the rollResults array and prints out the roll number and correct number of * symbols based on the calculated percentage.
        for (int i = 2; i <= 12; i++)
        {
            int rollPercentage = rollResults[i] * 100 / diceRollNum;
            Console.WriteLine($"{i}: {new string('*', rollPercentage)}");
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator.\nHave a great day and play again soon!");



    }
}