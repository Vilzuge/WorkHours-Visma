//Ville Martas
//09.03.2020

using System;

namespace ValidationVisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Shift Monday = new Shift(new DateTime(2021, 3, 8), "07:30", "15:00");
            Shift Tuesday = new Shift(new DateTime(2021, 3, 9), "07:00", "16:30");
            Shift Wednesday = new Shift(new DateTime(2021, 3, 10), "07:15", "15:45");

            Console.WriteLine(Monday.DayLength);
            Console.WriteLine(Tuesday.DayLength);
            Console.WriteLine(Wednesday.DayLength);

            //For testing the new class
            while (true)
            {
                Console.WriteLine("\nTesting the new Shift class");
                Console.WriteLine("1) Create a new shift and output the hours");
                Console.WriteLine("0) Exit");
                Console.Write(">> ");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Console.Write("Give a year: ");
                        string year = Console.ReadLine();
                        Console.Write("Give a month: ");
                        string month = Console.ReadLine();
                        Console.Write("Give a day: ");
                        string day = Console.ReadLine();

                        Console.Write("Give a starting time (hh:mm): ");
                        string start = Console.ReadLine();
                        Console.Write("Give an ending time (hh:mm): ");
                        string end = Console.ReadLine();

                        try
                        {
                            Shift Today = new Shift(new DateTime(int.Parse(year), int.Parse(month), int.Parse(day)), start, end);
                            Console.WriteLine("Length of this shift is: " + Today.DayLength.ToString() + " hours.");
                        }
                        catch (SystemException e)
                        {
                            Console.WriteLine(e);
                        }
                        break;

                    case "0":
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Not a valid choise, choose again.");
                        break;
                }

            }
        }
    }
}
