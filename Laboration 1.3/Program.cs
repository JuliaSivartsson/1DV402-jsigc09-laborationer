using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_1._3
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declare variable for saleries
            int salariesInput = 0;
            int getSalariesValue = 0;

            //Message
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Press any key to start (except ESC, that will exit the program.)");
            Console.ResetColor();

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                while (true)
                {
                    try
                    {
                        // call method ReadInt.
                        while (true)
                        {
                            salariesInput = ReadInt("Select how many saleries: ");
                            if (salariesInput > 1)
                            {
                                break;
                            }
                            else
                            {
                                //Error
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have to select atleast two salaries!");
                                Console.ResetColor();
                            }
                        }
                        break;
                    }
                    catch
                    {
                        //Error
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Can not be read as an integer. Try again!");
                        Console.ResetColor();
                    }
                }

                while (true)
                {
                    int[] valuesOfSalaries = new int[salariesInput];
                    try
                    {
                        // Accepting value from user 
                        for (int i = 0; i < salariesInput; i++)
                        {
                            getSalariesValue = ReadInt("Value number " + (i + 1) + ":");

                            //Storing value in an array
                            valuesOfSalaries[i] = Convert.ToInt32(getSalariesValue);
                        }

                        ProcessSalaries(valuesOfSalaries);
                        break;
                    }
                    catch
                    {
                        //Error
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Can not be read as an integer. Try again!");
                        Console.ResetColor();
                    }
                }
            }
        }

        //Method to count
        static void ProcessSalaries(int[] salaries)
        {
            int numberOfSalariesInArray = salaries.Count();
            double averageSalary = salaries.Average();

            int[] sortedSalaries = new int[numberOfSalariesInArray];
            Array.Copy(salaries, sortedSalaries, numberOfSalariesInArray);
            Array.Sort(sortedSalaries);

            double medianSalary;
            if (sortedSalaries.Length % 2 != 0)
            {
                medianSalary = sortedSalaries[sortedSalaries.Length / 2];
            }
            else
            {
                int middle = sortedSalaries.Length / 2;
                double first = sortedSalaries[middle];
                double second = sortedSalaries[middle - 1];
                medianSalary = (first + second) / 2;
            }

            int salarySpread = salaries.Max() - salaries.Min();

            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine(String.Format("{0,-10} | {1,10:C0}", "Average salary:", averageSalary));
            Console.WriteLine(String.Format("{0,-10} | {1,10:C0}", "Salary spread:", salarySpread));
            Console.WriteLine(String.Format("{0,-10} | {1,10:C0}", "Median salary:", medianSalary));
            Console.WriteLine("-------------------");

            //got help from: http://stackoverflow.com/questions/7437084/printing-out-3-elements-in-array-per-line
            for (int i = 0; i < salaries.Length; i++)
            {
                Console.Write(String.Format("{0,10:C0} ", salaries[i]));
                if (i % 3 == 2)
                {
                    Console.WriteLine();
                }
            }

            //Message
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Press ESC to exit, any other key to start over");
            Console.ResetColor();
        }

        //Method to return integer
        static int ReadInt(string prompt)
        {
            int inputInteger;

            Console.Write(prompt);
            inputInteger = int.Parse(Console.ReadLine());

            return inputInteger;
        }
    }
}
