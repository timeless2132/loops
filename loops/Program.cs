using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

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
                Console.Clear();
                Console.WriteLine("Wecome To The Menu");
                Console.WriteLine("Choose one on the following:");
                Console.WriteLine();

                Console.WriteLine("1 - Prompter");
                Console.WriteLine();

                Console.WriteLine("2 - Bank of Blorb");
                Console.WriteLine();

                Console.WriteLine("x - Menu Option X");
                Console.WriteLine();

                Console.WriteLine("q - Quit");

                Console.WriteLine("Enter: ");
                var userChoice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

               
                
                if (userChoice == "bank of blorb" || userChoice == "2")
                {
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
                            loading();
                            Console.Clear();
                            lobby = false;
                            depositLoop = true;

                            Console.WriteLine("Enter How Much You Would Like to Deposit:");
                            double deposit = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();

                            balence = (deposit + balence) - 0.75;
                            Console.WriteLine("New balence: " + balence);

                        }


                    }
                     

                }



                if (userChoice == "prompter" || userChoice == "1")
                {
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
