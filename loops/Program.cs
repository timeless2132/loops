using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using Die;

namespace loops
{
    internal class Program
    {
       
        public static void loading()
        {
            Console.Clear();
            string loading = "Loading";
            int loadingTime = 250;
            loading = "Loading";
            Console.WriteLine(loading);
            Thread.Sleep(loadingTime);
            loading = "Loading.";
            Console.Clear();
            Console.WriteLine(loading);
            Thread.Sleep(loadingTime);
            loading = "Loading..";

            Thread.Sleep(loadingTime);
            loading = "Loading...";
            Console.Clear();
            Console.WriteLine(loading);

            Thread.Sleep(loadingTime);
            loading = "Loading";
            Console.Clear();
            Console.WriteLine(loading);

            Thread.Sleep(loadingTime);
            loading = "Loading.";
            Console.Clear();
            Console.WriteLine(loading);

            Thread.Sleep(loadingTime);
            loading = "Loading..";
            Console.Clear();
            Console.WriteLine(loading);

            Thread.Sleep(loadingTime);
            loading = "Loading...";
            Console.Clear();
            Console.WriteLine(loading);
            Thread.Sleep(loadingTime);
            Console.Clear();
        }
        
        static void Main(string[] args)
        {


           
            bool menu = true;

            while (menu == true)
            {
                loading();
                Console.Clear();
                Console.WriteLine("Wecome To The Menu");
                Console.WriteLine("Choose one on the following:");
                Console.WriteLine();

                Console.WriteLine("1 - Prompter");
                Console.WriteLine();

                Console.WriteLine("2 - Bank of Blorb");
                Console.WriteLine();

                Console.WriteLine("x - Dice");
                Console.WriteLine();

                Console.WriteLine("q - Quit");

                Console.WriteLine("Enter: ");
                var userChoice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (userChoice == "q" || userChoice == "quit")
                {
                    Console.Clear();
                    menu = false;
                }
                
                if (userChoice == "die" || userChoice == "x")
                {
                    Console.Clear();
                    menu = false;
                    die die1, die2;
                    die1 = new die();
                    die2 = new die();

                    if (die1.Roll == die2.Roll)
                    {
                        Console.WriteLine("Doubles");
                    }
                    else { Console.WriteLine("Not Doubles"); }

                    if (die1.Roll + die2.Roll == 7)
                    {
                        Console.WriteLine("They sum of the two numbers is 7");
                    }
                    else if (die1.Roll == 1 && die2.Roll == 1)
                    {
                        Console.WriteLine("Snake eyes");
                    }
                    else if (die1.Roll - 1 == die2.Roll || die1.Roll + 1 == die2.Roll || die2.Roll - 1 == die1.Roll || die2.Roll + 1 == die2.Roll)
                    {
                        Console.WriteLine("The numbers are sequential");
                    }
                    else if ((die1.Roll + die2.Roll) % 2 == 0)
                    {
                        Console.WriteLine("The numbers are even");
                    }

                    Console.WriteLine(die1);
                    die1.DrawDie();
                    Console.WriteLine(die2);
                    die2.DrawDie();

                    if (die1.Roll > die2.Roll)
                    {
                        Console.WriteLine("Die 1 is greater than die 2");
                    }
                    else
                        Console.WriteLine("Die 2 is greater than die 1");

                    Thread.Sleep(2000);
                    Console.Clear();
                    menu = true;
                }
                
                if (userChoice == "bank of blorb" || userChoice == "2")
                {
                    loading();
                    Console.Clear();
                    double balence = 150;
                    bool lobby = true;
                    bool depositLoop = false;
                    bool withdrawalLoop = false;
                    bool billPaymentLoop = false;
                    bool accBallenceLoop = false;



                    while (lobby == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to The Bank of Blorb.");
                        Console.WriteLine();
                        Console.WriteLine("1 - Deposit");
                        Console.WriteLine("2 - Withdrawal");
                        Console.WriteLine("3 - Bill Payment");
                        Console.WriteLine("4 - Account Balence");

                        var lobbyChoice = Console.ReadLine().ToLower().Trim();
                        Console.WriteLine();

                        if (lobbyChoice == "1" || lobbyChoice == "deposit")
                        {
                            Console.Clear();
                            lobby = false;
                            depositLoop = true;

                            while (depositLoop == true)
                            {
                                Console.WriteLine("Enter How Much You Would Like to Deposit:");
                                double deposit = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();

                                balence = (deposit + balence) - 0.75;
                                Console.WriteLine("New balence: " + balence);
                                Thread.Sleep(1000);
                                depositLoop = false;
                            }

                        }
                        else if (lobbyChoice == "2" || lobbyChoice == "wtihdrawal")
                        {
                            Console.Clear();
                            lobby = false;
                            withdrawalLoop = true;
                            
                            while (withdrawalLoop == true)
                            {
                                Console.WriteLine("Enter the amount you want to withdrawal: ");
                                double withdrawal = Convert.ToDouble(Console.ReadLine());
                                while (!double.TryParse(Console.ReadLine(), out withdrawal))
                                    Console.WriteLine("Please enter a valid number");
                                
                                if (withdrawal > (balence - 0.75) || withdrawal < 0)
                                {
                                    Console.WriteLine("Invaled Number.");
                                    Thread.Sleep(750);
                                    Console.Clear();
                                }
                                else
                                {
                                    balence -= withdrawal;
                                    Console.WriteLine("Thank you, Your new balence is: " + balence);
                                    Thread.Sleep(1000);
                                    withdrawalLoop = false;
                                    lobby = true;
                                }
                                
                                

                            }

                        }
                        else if (lobbyChoice == "3" || lobbyChoice == "bill payment")
                        {
                            Console.Clear();
                            lobby = false;
                            billPaymentLoop = true;
                            double bill = balence * 0.20;
                            balence = balence - 0.75;
                            while (billPaymentLoop == true)
                            {
                                Console.WriteLine("You owe $ " + bill + " in bills.");
                                Console.WriteLine("Enter how much u want to pay");
                                double payAmount;
                                while (!double.TryParse(Console.ReadLine(), out payAmount))
                                    Console.WriteLine("Please enter a valid number");

                                if (payAmount > bill || payAmount < 0)
                                {
                                    Console.WriteLine("You do not owe that much.");
                                    Thread.Sleep(750);
                                    Console.Clear();
                                }
                                else if (payAmount > balence)
                                {
                                    Console.WriteLine("You do not have enough.");
                                }
                                else
                                {
                                    Console.WriteLine("Thank you.");
                                    Thread.Sleep(750);
                                    lobby = true;
                                    billPaymentLoop = false;
                                }


                            }

                        }
                        else if (lobbyChoice == "4" || lobbyChoice == "balence")
                        {
                            balence -= 0.75;
                            Console.WriteLine("Your balence is: $" + balence);
                            Thread.Sleep(1500);
                        }

                    }
                     

                }



                if (userChoice == "prompter" || userChoice == "1")
                {
                    loading();
                    Console.Clear();
                    menu = false;
                    bool maxMinCorrect = true;
                    bool betweenMenu = false;
                    
                    while (maxMinCorrect == true)
                    {
                        Console.WriteLine("Give me a min and a max number:");
                        Console.WriteLine("Enter a min: ");
                        double min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Enter a max: ");
                        double max = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();


                        if (min <= max && max >= min)
                        {
                            betweenMenu = true;
                        }
                        else
                            Console.WriteLine("Please Enter a Valid Number.");
                            Console.WriteLine();


                        while (betweenMenu == true)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            maxMinCorrect = false;
                            Console.WriteLine("Now enter a number between those numbers: ");
                            double between = Convert.ToInt32(Console.ReadLine());

                            if (max >= between && min <= between)
                            {
                                Console.WriteLine("Correct!");
                                Thread.Sleep(2000);
                                menu = true;
                                betweenMenu = false;
                            }
                            else
                                Console.WriteLine("Enter a Valid Number");
                                Thread.Sleep(1000);
                        }
                        
                    }
                }
           

            }
        }

      
    }
}
