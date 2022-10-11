namespace BuyingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("The following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\nWhat number do you want to see the price of? ");
                string UserInput = Console.ReadLine();

                string Item;
                int Price;

                switch (UserInput)
                {
                    case "1":
                        Item = "Rope";
                        Price = 10;
                        break;

                    case "2":
                        Item = "Torches";
                        Price = 15;
                        break;

                    case "3":
                        Item = "Climbing Equipment";
                        Price = 25;
                        break;

                    case "4":
                        Item = "Clean Water";
                        Price = 1;
                        break;

                    case "5":
                        Item = "Machete";
                        Price = 20;
                        break;

                    case "6":
                        Item = "Canoe";
                        Price = 200;
                        break;

                    case "7":
                        Item = "Food Supplies";
                        Price = 1;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nPlease input one of the numbers below.\n");
                        continue;
                }

                Console.WriteLine($"{Item} cost {Price} gold.");

            }
        }
    }
}