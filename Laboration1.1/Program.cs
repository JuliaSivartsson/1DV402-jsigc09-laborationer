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
            int amountPaid;
            uint amountToPay;
            double roundingOffAmount;
            int moneyToReturn;

            // Collect values
            Console.Write("Amount to pay: ");
            totalCost = double.Parse(Console.ReadLine());

            if (totalCost < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("The amount is too small. The purchase is cancelled.");
                Console.ResetColor();

                Environment.Exit(0);
                // die
            }




            amountPaid = 0;
            // try if amountPaid is numeric ?

            Boolean retry = true;

            while (retry)
            {
                try
                {
                    retry = false;
                    Console.Write("Amount paid: ");
                    amountPaid = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("An error occured, try again.");
                    Console.ResetColor();

                    retry = true;
                    // start over
                }
            }



            // If you pay less than the total amount
            if (amountPaid < totalCost)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You didn't pay enough!");
                Console.ResetColor();

                // die ?
            }


            // Round off to integer
            amountToPay = (uint)Math.Round(totalCost);
            roundingOffAmount = amountToPay - totalCost;

            // How much is the roundoff?
            moneyToReturn = amountPaid - (int)amountToPay;

            // Present data
            Console.WriteLine("RECEIPT");
            Console.WriteLine("---------------------");
            Console.WriteLine(String.Format("{0,-10} | {1,-1:C}", "Total:", totalCost));
            Console.WriteLine(String.Format("{0,-10} | {1,-1:C}", "Roundoff:", roundingOffAmount));
            Console.WriteLine(String.Format("{0,-10} | {1,-1:C}", "To pay: ", amountToPay));
            Console.WriteLine(String.Format("{0,-10} | {1,-1:C}", "Paid: ", amountPaid));
            Console.WriteLine(String.Format("{0,-10} | {1,-1:C}", "Return: ", moneyToReturn));
            Console.WriteLine("---------------------");

            // What values to return

            // how many times can i divide the change in value AND count modulus on that to see what is left

            // 500
            int remains = moneyToReturn / 500;
            int change = moneyToReturn % 500;
            // if the result is largen than 0, write the following
            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,-5}", "500-dollars:", remains));
            }
            // 100
            remains = change / 100;
            change = moneyToReturn % 100;
            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,-5}", "100-dollars:", remains));
            }
            // 50
            remains = change / 50;
            change = moneyToReturn % 50;
            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,-5}", "50-dollars:", remains));
            }
            // 10
            remains = change / 10;
            change = moneyToReturn % 10;
            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,-5}", "10-dollars:", remains));
            }
            //1
            remains = change / 1;
            change = moneyToReturn % 1;
            if (remains > 0)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,-5}", "1-dollars:", remains));
            }


        }
    }
}
