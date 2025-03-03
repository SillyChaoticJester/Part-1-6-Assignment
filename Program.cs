namespace Part_1_6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //What to do:
            // - Make a multi-round loop that can end at any time
            // - Make sure you can't do invalid choices for the bet
            // - Make a summary screen

            decimal userMoney = 100M, userBet;
            int rounds = 0;
            string betType, choice = "";
            bool done = false;
            Die die1, die2;
            die1 = new Die();
            die2 = new Die();

            Console.WriteLine("Welcome to the Dice Casino! Where you can bet all your money on dice.");
            Console.WriteLine("You'll be given five rounds, and you can quit after the end of each round if you wish.");
            
            while (rounds != 6)
            {
                while (!done)
                {
                    Console.WriteLine();
                    Console.WriteLine("Here's all that you can bet on:");
                    Console.WriteLine("- Doubles: Win Twice the amount you Bet on.");
                    Console.WriteLine("- Even Sum: Win your Bet amount");
                    Console.WriteLine("- Odd Sum: Win your Bet amount");
                    Console.WriteLine();
                    Console.WriteLine("What type of bet would you like to do?");
                    betType = Console.ReadLine().ToLower().Trim();

                    if (betType == "doubles")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You chose Doubles! How much would you like to bet?");
                        while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                            Console.WriteLine("Invalid Integer, please try again:");
                        Console.WriteLine();
                        die1.DrawDie();
                        die2.DrawDie();
                        if (die1.Roll == die2.Roll)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You got doubles! Congrats!");
                            userMoney += (userBet * 2);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Oops! You didn't get doubles!");
                            Console.WriteLine("You'll recieve half of your bet back.");
                            userMoney += (userBet / 2);
                        }
                        rounds++;
                    }
                    else if (betType == "even sum")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You chose Even Sum! How much would you like to bet?");
                        while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                            Console.WriteLine("Invalid Integer, please try again:");
                        Console.WriteLine();
                        die1.DrawDie();
                        die2.DrawDie();
                        Console.WriteLine();
                        Console.WriteLine("Your sum equals to" + (die1.Roll + die2.Roll));
                        if (die1.Roll + die2.Roll % 2 == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You got an Even Sum! Congrats! You won your bet!");
                            userMoney += userBet;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Oops! You didn't get an Even Sum! You lost your Bet!");
                            userMoney -= userBet;
                        }
                        rounds++;
                    }
                    else if (betType == "odd sum")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You chose Odd Sum! How much would you like to bet?");
                        while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                            Console.WriteLine("Invalid Integer, please try again:");
                        Console.WriteLine();
                        die1.DrawDie();
                        die2.DrawDie();
                        Console.WriteLine();
                        Console.WriteLine("Your sum equals to" + (die1.Roll + die2.Roll));
                        if (die1.Roll + die2.Roll % 2 == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Oops! You didn't get an Odd Sum! You lost your Bet!");
                            userMoney -= userBet;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You got an Odd Sum! Congrats! You won your bet!");
                            userMoney += userBet;
                        }
                        rounds++;
                    }
                    else
                    {
                        Console.WriteLine("That's not a choice");
                    }
                }
            }
            


        }
    }
}
