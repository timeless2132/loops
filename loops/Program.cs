using System.Transactions;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;

            while (menu == true)
            {
                Console.Clear();
                Console.WriteLine("Wecome To The Menu");
                Console.WriteLine("Choose one on the following:");
                Console.WriteLine();

                Console.WriteLine("1 - Promter");
                Console.WriteLine();

                Console.WriteLine("2 - Menu Option 2");
                Console.WriteLine();

                Console.WriteLine("x - Menu Option X");
                Console.WriteLine();

                Console.WriteLine("q - Quit");

                Console.WriteLine("Enter: ");
                var userChoice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                
                if (userChoice == "Promter" || userChoice == "1")
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
                          

                        }
                        
                    }
                }
           

            }
        }
    }
}
