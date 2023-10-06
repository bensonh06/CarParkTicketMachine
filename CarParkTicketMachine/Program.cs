using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkTicketMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.WriteLine("\n#################################################\n");
                Console.WriteLine("  W E L C O M E  T O  B O B ' S  C A R  P A R K  \n");
                Console.WriteLine("#################################################");

                Console.WriteLine("\nPlease enter car registration: ");
                string reg = Console.ReadLine();

                Console.WriteLine("\nRegistration entered: " + reg);
                Console.WriteLine("\nIs this correct? (y/n)");

                string check = Console.ReadLine();

                if (check == "y")
                {
                    break;
                }


            }

            Console.Clear();
            Console.WriteLine("\n#################################################\n");
            Console.WriteLine("  W E L C O M E  T O  B O B ' S  C A R  P A R K  \n");
            Console.WriteLine("#################################################\n");

            Console.WriteLine("Please select duration:\t (Press number 1-7)\n");
            Console.WriteLine("1\tUp to 30 minutes\t£1");
            Console.WriteLine("2\t30 to 60 minutes\t£2");
            Console.WriteLine("3\tUp to 2 hours\t\t£3");
            Console.WriteLine("4\tUp to 3 hours\t\t£4");
            Console.WriteLine("5\tUp to 4 hours\t\t£5");
            Console.WriteLine("6\tUp to 6 hours\t\t£6");
            Console.WriteLine("7\tUp to 12 hours\t\t£10");

            int parkingDuration = 0;

            while (true)
            {
                Console.SetCursorPosition(0, 17);

                Console.Write("\nEnter number: ");

                parkingDuration = int.Parse(Console.ReadLine());

                if (parkingDuration < 1 || parkingDuration > 7)
                {
                    Console.SetCursorPosition(0, 19);
                    Console.WriteLine("Invalid entry, please retry.");

                } else
                {
                    break;
                }
            }

            double amountOwed = 0;
            double amountEntered = 0;
            bool paidForTicket = false;

            if (parkingDuration == 7) 
            {
                amountOwed = 10;
            } else
            {
                amountOwed = parkingDuration;
            }

            while (paidForTicket == false)
            {
                Console.SetCursorPosition(0, 17);

                Console.WriteLine("Amount entered: £" + amountEntered);

                Console.Write("Please enter coins to the value of £" + amountOwed + ": ");

                double moneyInserted = double.Parse(Console.ReadLine());

                amountEntered = amountEntered + moneyInserted;
                amountOwed = amountOwed - amountEntered;

                if (amountOwed <= 0)
                {
                    paidForTicket = true;
                }
                
            }

            if (amountOwed < 0)
            {
                Console.WriteLine("Dispensing change of £" + (-amountOwed));
            }

            Console.WriteLine("\nPrinting your ticket... ");
            Task.Delay(5000).Wait();

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("");
        }
    }
}
