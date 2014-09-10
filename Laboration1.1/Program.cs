using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Define variables.
            double totalCost;
            int amountPaid = 0;
            uint amountToPay;
            double roundingOffAmount;
            int moneyToReturn;

            while (true)
            {
                try
                {
                    // Collect values
                    Console.Write("Amount to pay: ");
                    totalCost = double.Parse(Console.ReadLine());

                    if (totalCost < 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("The amount is too small. The purchase is cancelled.");
                        Console.ResetColor();

                        return;
                        // die
                    }
                    break;
                }
                catch
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("An error occured, try again.");
                    Console.ResetColor();
                    // try again
                }
            }

            // loop to retry
            while (true)
            {
                // try if amountPaid is numeric
                try
                {
                    Console.Write("Amount paid: ");
                    amountPaid = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("An error occured, try again.");
                    Console.ResetColor();
                    // try again
                }
            }

            // If you pay less than the total amount
            if (amountPaid < totalCost)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't pay enough!");
                Console.ResetColor();

                Environment.Exit(0);
                // die
            }

            // Round off to integer (got code example from PDF)
            amountToPay = (uint)Math.Round(totalCost);
            roundingOffAmount = amountToPay - totalCost;

            // How much is the roundoff?
            moneyToReturn = amountPaid - (int)amountToPay;

            // Present data
            Console.WriteLine("RECEIPT");
            Console.WriteLine("---------------------");
            Console.WriteLine(String.Format("{0,-10} | {1,10:C}", "Total:", totalCost));
            Console.WriteLine(String.Format("{0,-10} | {1,10:C}", "Roundoff:", roundingOffAmount));
            Console.WriteLine(String.Format("{0,-10} | {1,10:C0}", "To pay: ", amountToPay));
            Console.WriteLine(String.Format("{0,-10} | {1,10:C0}", "Paid: ", amountPaid));
            Console.WriteLine(String.Format("{0,-10} | {1,10:C0}", "Return: ", moneyToReturn));
            Console.WriteLine("---------------------");

            // What values to return

            // how many times can i divide the change in value AND count modulus on that to see what is left

            // 500
            int remains = moneyToReturn / 500;
            int change = moneyToReturn % 500;

            // if the result is larger than 0, write the following
            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,10}", "500-bills:", remains));
            }
            // 100
            remains = change / 100;
            change = moneyToReturn % 100;

            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,10}", "100-bills:", remains));
            }
            // 50
            remains = change / 50;
            change = moneyToReturn % 50;

            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,10}", "50-bills:", remains));
            }
            //20
            remains = change / 20;
            change = moneyToReturn % 20;

            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,10}", "20-bills:", remains));
            }
            // 10
            remains = change / 10;
            change = moneyToReturn % 10;

            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,10}", "10-bills:", remains));
            }
            //5
            remains = change / 5;
            change = moneyToReturn % 5;

            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,10}", "5-bills:", remains));
            }
            //1
            remains = change / 1;
            change = moneyToReturn % 1;

            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,10}", "1-bills:", remains));
            }
        }
    }
}
