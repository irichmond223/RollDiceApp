using System;

namespace Lab6
{
    class Program
    {
        //RandomNum method was created to roll the dice 1 and use this method to call 2 sides with random number.
        public static int RandomNum1()
        {
            Random rnd = new Random();
            //with next the value returned will never equal it.
            //Need to add one in order to get fair roll on a six sided die.
            return rnd.Next(1, 7);
        }

        public static int RandomNum2()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
        public class DiceRollerApp
        {
            public int Rolls()
            {
                int diceOne = 0;
                int diceTwo = 0;

                diceOne = RandomNum1();
                diceTwo = RandomNum2();

                Console.WriteLine("Roll 1: ");
                Console.WriteLine(diceOne);
                Console.WriteLine(diceTwo);

                int sum = diceOne + diceTwo;

                if (sum == 12)
                {
                    Console.WriteLine("Box Cars");
                }
                else if (sum == 2)
                {
                    Console.WriteLine("Snake Eyes");
                }
                else if (sum == 7 || sum == 11)
                {
                    Console.WriteLine("Craps");
                }
                return sum;
            }
        }

        static void Main(string[] args)
        {
            bool playAgain = true;
            //Asks the user to to play a game.
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice ? (y / n): ");
            string userInput = Console.ReadLine();

            while (playAgain)
            {
                //using try catch to check formatting, it could be only characters that will be allowed y,Y,n,N.
                try
                {
                    char characterUserInput = char.Parse(userInput);

                    if (characterUserInput == 'Y' || characterUserInput == 'y')
                    {
                        Console.WriteLine("How many sides should each die have?");
                        //try catch is used to check formatting that will only allow numbers to be entered.
                        try
                        {
                            int intUserInput = int.Parse(Console.ReadLine());

                            //An objects that refers to an instance of a class.
                            DiceRollerApp firstClass = new DiceRollerApp();
                            firstClass.Rolls();


                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Only numbers allowed. Try again.");
                            playAgain = true;
                        }
                    }
                    else if (characterUserInput == 'N' || characterUserInput == 'n')
                    {
                        Console.WriteLine("Goodbye.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter in the correct format and try again.");
                    playAgain = true;
                }
                //To play again.
                Console.WriteLine("Roll again? (y/n): ");
                string stringUserInput = Console.ReadLine();
                try
                {
                    char charUserInput = char.Parse(stringUserInput);
                    {
                        if (charUserInput == 'y' || charUserInput == 'Y')
                        {
                            playAgain = true;
                        }
                        else if (charUserInput == 'n' || charUserInput == 'N')
                        {
                            Console.WriteLine("Goodbye.");
                            playAgain = false;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter in the correct format and try again.");
                    playAgain = true;
                }
            }
        }
    }
}
