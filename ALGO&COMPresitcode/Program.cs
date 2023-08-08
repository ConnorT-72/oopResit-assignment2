using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome!");

        Pack pack = new Pack();
        Tutorial tutorial = new Tutorial();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Instructions");
            Console.WriteLine("2. Deal 3 cards");
            Console.WriteLine("3. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    tutorial.ShowInstructions();
                    break;
                case "2":
                    try
                    {
                        pack.Shuffle();
                        var cards = pack.DealCards(3);

                        Console.WriteLine("\nYou've been dealt 3 cards:");
                        foreach (var card in cards)
                        {
                            Console.WriteLine(card);
                        }

                        Console.WriteLine("\nMaths Sum: Number1 + Number3");
                        Console.Write("Enter your answer: ");
                        int answer = int.Parse(Console.ReadLine());

                        int sum = cards[0].Number + cards[2].Number;
                        if (answer == sum)
                        {
                            Console.WriteLine("Correct! Well done!");
                        }
                        else
                        {
                            Console.WriteLine($"Not correct. The correct answer is: {sum}");
                        }

                        Console.WriteLine("Do you want to deal again (Y/N)?");
                        string repeat = Console.ReadLine();
                        if (repeat.ToUpper() != "Y")
                        {
                            running = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
