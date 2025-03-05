namespace Part_1_6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal userMoney = 100M, userBet, betTotal = 0;
            int rounds = 0;
            string betType, choice = "";
            bool done = false;
            Die die1, die2;
            die1 = new Die();
            die2 = new Die();

            Console.WriteLine("Welcome to the Dice Casino! Where you can bet all your money on dice.");
            Console.WriteLine("You'll be given five rounds, and you can quit after the end of each round if you wish.");
            
            while (!done)
            {
                while (rounds != 6)
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
                        Console.WriteLine($"You currently have ${userMoney} to bet with.");
                        while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                            Console.WriteLine("Invalid Integer, please try again:");
                        while (userBet < 0)
                        {
                            Console.WriteLine("You cannot bet a negative amount. Please try again: ");
                            while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                                Console.WriteLine("Invalid Integer, please try again:");
                        }
                        while (userBet > userMoney)
                        {
                            Console.WriteLine("You cannot bet more than what you have. Please try again: ");
                            while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                                Console.WriteLine("Invalid Integer, please try again:");
                        }
                        Console.WriteLine();
                        die1.RollDie();
                        die2.RollDie();
                        die1.DrawDie();
                        die2.DrawDie();
                        if (die1.Roll == die2.Roll)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You got doubles! Congrats!");
                            userMoney += (userBet * 2);
                            betTotal += (userBet * 2);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Oops! You didn't get doubles!");
                            Console.WriteLine("You'll recieve half of your bet back.");
                            userMoney += (userBet / 2);
                            betTotal += (userBet / 2);
                        }
                        rounds++;
                    }
                    else if (betType == "even sum")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You chose Even Sum! How much would you like to bet?");
                        Console.WriteLine($"You currently have ${userMoney} to bet with.");
                        while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                            Console.WriteLine("Invalid Integer, please try again:");
                        while (userBet < 0M)
                        {
                            Console.WriteLine("You cannot bet a negative amount. Please try again: ");
                            while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                                Console.WriteLine("Invalid Integer, please try again:");
                        }
                        while (userBet > userMoney)
                        {
                            Console.WriteLine("You cannot bet more than what you have. Please try again: ");
                            while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                                Console.WriteLine("Invalid Integer, please try again:");
                        }

                        Console.WriteLine();
                        die1.RollDie();
                        die2.RollDie();
                        die1.DrawDie();
                        die2.DrawDie();
                        Console.WriteLine();
                        Console.WriteLine("Your sum equals to " + (die1.Roll + die2.Roll));
                        if ((die1.Roll + die2.Roll) % 2 == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You got an Even Sum! Congrats! You won your bet!");
                            userMoney += userBet;
                            betTotal += userBet;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Oops! You didn't get an Even Sum! You lost your Bet!");
                            userMoney -= userBet;
                            betTotal -= userBet;
                        }
                        rounds++;

                    }
                    else if (betType == "odd sum")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You chose Odd Sum! How much would you like to bet?");
                        Console.WriteLine($"You currently have ${userMoney} to bet with.");
                        while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                            Console.WriteLine("Invalid Integer, please try again:");

                        while (userBet < 0)
                        {
                            Console.WriteLine("You cannot bet a negative amount. Please try again: ");
                            while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                                Console.WriteLine("Invalid Integer, please try again:");
                        }

                        while (userBet > userMoney)
                        {
                            Console.WriteLine("You cannot bet more than what you have. Please try again: ");
                            while (!Decimal.TryParse(Console.ReadLine(), out userBet))
                                Console.WriteLine("Invalid Integer, please try again:");
                        }

                        Console.WriteLine();
                        die1.RollDie();
                        die2.RollDie();
                        die1.DrawDie();
                        die2.DrawDie();
                        Console.WriteLine();
                        Console.WriteLine("Your sum equals to " + (die1.Roll + die2.Roll));
                        if ((die1.Roll + die2.Roll) % 2 == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Oops! You didn't get an Odd Sum! You lost your Bet!");
                            userMoney -= userBet;
                            betTotal -= userBet;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You got an Odd Sum! Congrats! You won your bet!");
                            userMoney += userBet;
                            betTotal += userBet;
                        }
                        rounds++;

                    }
                    else
                    {
                        Console.WriteLine("That's not a choice");
                    }

                    if (rounds == 6)
                    {
                        done = true;
                        Console.WriteLine("You've ran out of rounds");
                        Console.WriteLine($"Here's how much money you have left: ${userMoney}");
                        Console.WriteLine($"And here's how much you've won or lost: ${betTotal}");
                    }
                    else if (rounds != 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Would you like to continue?");
                        choice = Console.ReadLine().ToLower().Trim();
                        if (choice == "yes")
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Ok! Here's how much money you have left: ${userMoney}");
                            Console.WriteLine($"And here's how much you've won or lost: ${betTotal}");
                        }
                        else if (choice == "no")
                        {
                            done = true;
                            Console.WriteLine();
                            Console.WriteLine($"Ok! Here's how much money you have left: ${userMoney}");
                            Console.WriteLine($"And here's how much you've won or lost: ${betTotal}");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("That's not an option. Automatically continuing.");
                        }
                    }
                }
            }
            


        }
    }
}
