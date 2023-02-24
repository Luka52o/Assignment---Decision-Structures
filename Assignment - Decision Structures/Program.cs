namespace Assignment___Decision_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string optionChosen;

            Console.WriteLine("Please select an option by typing its name:");
            Console.WriteLine("Banking");
            Console.WriteLine("Parking");
            Console.WriteLine("Hurricane");
            Console.WriteLine();
            optionChosen = Console.ReadLine();
            while (optionChosen.ToUpper() != "BANKING" || optionChosen.ToUpper() != "PARKING" || optionChosen.ToUpper() != "HURRICANE")
            {
                Console.WriteLine("Please enter a valid option");
            }

            if (optionChosen.ToUpper() == "BANKING")
            {
                bankingMachine();
            }
            else if (optionChosen.ToUpper() == "PARKING")
            {
                parkingMachine();
            }
            else if (optionChosen.ToUpper() == "HURRICANE")
            {
                hurricaneAnalyzer();
            }
        }

        public static void bankingMachine()
        {
            double initialBalance;
            Random balanceGenerator = new Random();
            initialBalance = balanceGenerator.NextDouble();
            Console.WriteLine("Current account balance: " + initialBalance);
        }

        public static void parkingMachine()
        {
            Console.WriteLine("Empty");
        }

        public static void hurricaneAnalyzer()
        {
            Console.WriteLine("Empty");
        }
    }
}