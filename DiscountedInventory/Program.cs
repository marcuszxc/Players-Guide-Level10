namespace BuyingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("\nThe following items are available:\n1 - Rope\n2 - Torches\n3 - Climbing Equipment\n4 - Clean Water\n5 - Machete\n6 - Canoe\n7 - Food Supplies\nWhat number do you want to see the price of? ");
                string UserInput = Console.ReadLine();
                Console.Write("What is your name? ");
                string Name = Console.ReadLine();

                double NameMod = 1; 
                string Item;
                double Price;

                if (Name == "Marcus" || Name == "marcus")
                {
                    NameMod = 0.5;
                }

                switch (UserInput)
                {
                    case "1":
                        Item = "Rope";
                        Price = 10 * NameMod;
                        break;

                    case "2":
                        Item = "Torches";
                        Price = 15 * NameMod;
                        break;

                    case "3":
                        Item = "Climbing Equipment";
                        Price = 25 * NameMod;
                        break;

                    case "4":
                        Item = "Clean Water";
                        Price = 1 * NameMod;
                        break;

                    case "5":
                        Item = "Machete";
                        Price = 20 * NameMod;
                        break;

                    case "6":
                        Item = "Canoe";
                        Price = 200 * NameMod;
                        break;

                    case "7":
                        Item = "Food Supplies";
                        Price = 1 * NameMod;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nPlease input one of the numbers below.");
                        continue;
                }

                Console.WriteLine($"\n{Item} cost {Price} gold.");

            }
        }
    }
}