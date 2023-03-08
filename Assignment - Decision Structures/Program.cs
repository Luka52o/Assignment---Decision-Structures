using System;
using System.Formats.Asn1;

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
            while (optionChosen.ToUpper() != "BANKING" && optionChosen.ToUpper() != "PARKING" && optionChosen.ToUpper() != "HURRICANE")
            {
                Console.WriteLine("Please enter a valid option");
                optionChosen = Console.ReadLine();
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

        // ///////////////////////////////////////////////////////////////////////////////////////////
        // ///////////////////////////////////////////////////////////////////////////////////////////
        // BANKING MACHINE ///////////////////////////////////////////////////////////////////////////
        public static void bankingMachine()
        {
            // SETUP ////////////////////////////////////////////////////////////
            string transOption;
            double randDouble, initialBalance, amountWithdrawn, amountDeposited, finalBalance;
            Random balanceGenerator = new Random();
            randDouble = balanceGenerator.NextDouble();
            initialBalance = randDouble * (150.00 - 100.00) + 100.00; 
            initialBalance = Math.Round(initialBalance, 2);

            Console.WriteLine("Current account balance: $" + initialBalance);
            Console.WriteLine("-$0.75 transaction fee:");
            initialBalance = initialBalance - 0.75;
            Console.WriteLine("Account balance: $" + initialBalance);
            Console.WriteLine("Please select one the following options:");
            Console.WriteLine("WITHDRAWL");
            Console.WriteLine("DEPOSIT");
            transOption = Console.ReadLine();
            while (transOption.ToUpper() != "WITHDRAWL" && transOption.ToUpper() != "DEPOSIT")
            {
                Console.WriteLine("Please enter a valid transaction option");
                transOption = Console.ReadLine();
            }

            // WITHDRAWLS ////////////////////////////////////////////////////
            if (transOption.ToUpper() == "WITHDRAWL")
            {
                bool done = false;
                Console.WriteLine("WITHDRAWL SELECTED");
                Console.WriteLine("Please specify the amount you wish to withdraw:");
                Console.Write("$");

                while (!done)
                {
                    while (!Double.TryParse(Console.ReadLine(), out amountWithdrawn))
                        Console.WriteLine("Please enter a valid number");

                    if (amountWithdrawn < (initialBalance) && amountWithdrawn > 0)
                    {
                        finalBalance = initialBalance - amountWithdrawn;
                        Console.WriteLine("Successfully withdrew $" + amountWithdrawn);
                        Console.WriteLine("Current account balance: $" + Math.Round(finalBalance, 2));
                        Console.WriteLine();
                        done = true;

                    }
                    else if (amountWithdrawn > initialBalance)
                    {
                        Console.WriteLine("You cannot withdraw an amount greater than your account balance. Please try again");
                        Console.WriteLine("Account Balance: $" + initialBalance);
                        Console.Write("$");
                    }
                    else if (amountWithdrawn < 0)
                    {
                        Console.WriteLine("You cannot withdraw an amount less than zero. Please try again");
                        Console.WriteLine("Account Balance: $" + initialBalance);
                        Console.Write("$");
                    }
                }
                Console.WriteLine("Press enter to close the console.");
                Console.ReadLine();
            }
            // DEPOSITS ////////////////////////////////////////////////////
            else if (transOption.ToUpper() == "DEPOSIT")
            {
                bool done = false;
                Console.WriteLine("DEPOSIT SELECTED");
                Console.WriteLine("Please enter the amount you wish to deposit:");
                Console.Write("$");
                
                while (!done) 
                {
                    while (!Double.TryParse(Console.ReadLine(), out amountDeposited))
                    {
                        Console.WriteLine("Please enter a valid number");
                        Console.Write("$");
                    }
                    if (amountDeposited < 0)
                    {
                        Console.WriteLine("You cannot deposit a negative value, please try again.");
                        Console.WriteLine("Please enter the amount you wish to deposit:");
                        Console.Write("$");
                    }
                    else
                    {
                        finalBalance = initialBalance + amountDeposited;
                        Console.WriteLine("Successfully deposited $" + amountDeposited);
                        Console.WriteLine("Current account balance: $" + Math.Round(finalBalance, 2));
                        Console.WriteLine();
                        done = true;
                    }
                }
                Console.WriteLine("Press enter to close the console.");
                Console.ReadLine();
            }
        }

        // ///////////////////////////////////////////////////////////////////////////////////////////
        // ///////////////////////////////////////////////////////////////////////////////////////////
        // PARKING MACHINE ///////////////////////////////////////////////////////////////////////////
        public static void parkingMachine()
        {
            bool done = false;
            int minutesParked;
            int hoursCharged = 0;
            int price = 4;
            Console.WriteLine("Thank you for using Sam's Parking Garage! Please enter the number of minutes you parked: ");
        
            while (!done)
            {
                while (!Int32.TryParse(Console.ReadLine(), out minutesParked) || minutesParked < 0)
                {
                    Console.WriteLine("Please enter a valid number or a number greater than zero: ");
                }

                if (minutesParked > 0)
                {
                    if (minutesParked <= 60)
                    {
                        price = price + 2;
                        Console.WriteLine("You owe $" + price + ".");
                        hoursCharged = 1;
                    }
                    else if (minutesParked > 60 && minutesParked <= 120)
                    {
                        price = price + 4;
                        Console.WriteLine("You owe $" + price + ".");
                        hoursCharged = 2;
                    }
                    else if (minutesParked > 120 && minutesParked <= 180)
                    {
                        price = price + 6;
                        Console.WriteLine("You owe $" + price + ".");
                        hoursCharged = 3;
                    }
                    else if (minutesParked > 180 && minutesParked <= 240)
                    {
                        price = price + 8;
                        Console.WriteLine("You owe $" + price + ".");
                        hoursCharged = 4;
                    }
                    else if (minutesParked > 240 && minutesParked <= 300)
                    {
                        price = price + 10;
                        Console.WriteLine("You owe $" + price + ".");
                        hoursCharged = 5;
                    }
                    else if (minutesParked > 300 && minutesParked <= 360)
                    {
                        price = price + 12;
                        Console.WriteLine("You owe $" + price + ".");
                        hoursCharged = 6;
                    }
                    else if (minutesParked > 360 && minutesParked <= 420)
                    {
                        price = price + 14;
                        Console.WriteLine("You owe $" + price + ".");
                        hoursCharged = 7;
                    }
                    else if (minutesParked > 420)
                    {
                        price = price + 16;
                        Console.WriteLine("You owe $" + price + ".");
                        hoursCharged = 8;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Here is your receipt: ");
                Console.WriteLine("MINUTES PARKED .................... " + minutesParked);
                Console.WriteLine("HOURS CHARGED  .................... " + hoursCharged);
                Console.WriteLine("AMOUNT OWING   .................... $" + price);
                Console.WriteLine("THANK YOU FOR USING SAM'S PARKING GARAGE");
                done = true;
            }
            

        }


        // ///////////////////////////////////////////////////////////////////////////////////////////
        // ///////////////////////////////////////////////////////////////////////////////////////////
        // HURRICANE ANALYZER ////////////////////////////////////////////////////////////////////////
        public static void hurricaneAnalyzer()
        {
            bool done = false;
            bool isSpeedEntered = false;
            double givenWindSpeed = 0;
            double speedKmH, speedMPH, speedKTS;
            string units;
            Console.WriteLine("Thank you for using this hurricane analysis tool.");
            Console.WriteLine("Please enter your measured wind speed and press enter, then clarify the units used");
            Console.WriteLine("(NOTE: ONLY KM/H, MPH, AND KTs IS ACCEPTED)");

            if (!done)
            {
                while (isSpeedEntered == false)
                {
                    if (!Double.TryParse(Console.ReadLine(), out givenWindSpeed))
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                    else if (givenWindSpeed < 0)
                    {
                        Console.WriteLine("Please enter a wind speed greater than zero.");
                    }
                    else
                    {
                        isSpeedEntered = true;
                    }
                }

                if (givenWindSpeed >= 0)
                {
                    Console.WriteLine("Please now enter the units used (FORMAT AS SUCH: km/h , mph , kts)");
                    units = Console.ReadLine();
                    while (units.ToUpper() != "KM/H" && units.ToUpper() != "MPH" && units.ToUpper() != "KTS")
                    {
                        Console.WriteLine("Please enter a valid unit in the correct format (km/h , mph , kts):");
                        units = Console.ReadLine();
                    }
                    if (units.ToUpper() == "KM/H")
                    {
                        speedKmH = givenWindSpeed;
                        speedMPH = speedKmH / 1.609;
                        speedKTS = speedKmH / 1.852;

                        switch (speedKmH)
                        {
                            case < 119:
                                {
                                    Console.WriteLine("Wind speed too low for hurricane classification.");
                                    Console.WriteLine($"Km/h: {speedKmH}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                            case <= 153:
                                {
                                    Console.WriteLine("CATAGORY ONE HURRICANE");
                                    Console.WriteLine($"Km/h: {speedKmH}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                            case <= 177:
                                {
                                    Console.WriteLine("CATAGORY TWO HURRICANE");
                                    Console.WriteLine($"Km/h: {speedKmH}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                            case <= 209:
                                {
                                    Console.WriteLine("CATAGORY THREE HURRICANE");
                                    Console.WriteLine($"Km/h: {speedKmH}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                            case <= 249:
                                {
                                    Console.WriteLine("CATAGORY FOUR HURRICANE");
                                    Console.WriteLine($"Km/h: {speedKmH}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;  
                                }
                            case > 249:
                                {
                                    Console.WriteLine("CATAGORY FIVE HURRICANE");
                                    Console.WriteLine($"Km/h: {speedKmH}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                                done = true;
                        }
                    }
                    else if (units.ToUpper() == "MPH")
                    {
                        speedMPH = givenWindSpeed;
                        speedKmH = speedMPH * 1.609;
                        speedKTS = speedMPH / 1.151;

                        switch (speedKmH)
                        {
                            case < 119:
                                {
                                    Console.WriteLine("Wind speed too low for hurricane classification.");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {speedMPH}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                            case <= 153:
                                {
                                    Console.WriteLine("CATAGORY ONE HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {speedMPH}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                            case <= 177:
                                {
                                    Console.WriteLine("CATAGORY TWO HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {speedMPH}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                            case <= 209:
                                {
                                    Console.WriteLine("CATAGORY THREE HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {speedMPH}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                            case <= 249:
                                {
                                    Console.WriteLine("CATAGORY FOUR HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {speedMPH}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                            case > 249:
                                {
                                    Console.WriteLine("CATAGORY FIVE HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {speedMPH}");
                                    Console.WriteLine($"KTS: {Math.Round(speedKTS, 2)}");
                                    break;
                                }
                                done = true;
                        }
                    }
                    else if (units.ToUpper() == "KTS")
                    {
                        speedKTS = givenWindSpeed;
                        speedKmH = speedKTS * 1.852;
                        speedMPH = speedKTS * 1.151;

                        switch (speedKmH)
                        {
                            case < 119:
                                {
                                    Console.WriteLine("Wind speed too low for hurricane classification.");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {speedKTS}");
                                    break;
                                }
                            case <= 153:
                                {
                                    Console.WriteLine("CATAGORY ONE HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {speedKTS}");
                                    break;
                                }
                            case <= 177:
                                {
                                    Console.WriteLine("CATAGORY TWO HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {speedKTS}");
                                    break;
                                }
                            case <= 209:
                                {
                                    Console.WriteLine("CATAGORY THREE HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {speedKTS}");
                                    break;
                                }
                            case <= 249:
                                {
                                    Console.WriteLine("CATAGORY FOUR HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {speedKTS}");
                                    break;
                                }
                            case > 249:
                                {
                                    Console.WriteLine("CATAGORY FIVE HURRICANE");
                                    Console.WriteLine($"Km/h: {Math.Round(speedKmH, 2)}");
                                    Console.WriteLine($"mph: {Math.Round(speedMPH, 2)}");
                                    Console.WriteLine($"KTS: {speedKTS}");
                                    break;
                                }
                                done = true;
                        }
                    }
                }
            }
            Console.WriteLine("Please press enter to close the program.");
            Console.ReadLine();
        }
    }
}