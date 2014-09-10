using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration1._2
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                Console.Write("Select an odd number <max 79> for the triangles base: ");
                
                //Contact method
                RenderTriangle();
            }
            //check if ESC is pressed, source (http://stackoverflow.com/questions/5891538/listen-for-key-press-in-net-console-app)
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }


        // Method to check for odd number
        static byte ReadOddByte()
        {

            byte number = 0;

            Boolean retry = true;
            while (retry)
            {
                try
                {

                    number = byte.Parse(Console.ReadLine());

                    if (number % 2 != 0)
                    {
                        retry = false;
                    }
                    else if (number < 1)
                    {
                        retry = false;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("The number is too small!");
                        Console.ResetColor();

                    }
                    else if (number > 79)
                    {
                        retry = false;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("The number is too large!");
                        Console.ResetColor();

                    }
                    else if (number % 2 == 0)
                    {
                        retry = false;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("The number is not odd!");
                        Console.ResetColor();


                    }
                }
                catch
                {
                    retry = false;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("this was not an int number!");
                    Console.ResetColor();

                }
            }

            return number;

        }

        //Method to draw the triangle
        static void RenderTriangle()
        {
            byte cols = ReadOddByte();
            int bottom = cols;
            int number = 1;

            // only display the triangle if everything is correct (number not too big, too small, odd a.s.o.)
            if (cols % 2 == 0)
            {
            }
            else
            {
                //rows
                for (int a = 1; a <= bottom; a++)
                {
                    //space from edge
                    for (int c = bottom; c >= a; c--)
                    {
                        Console.Write(" ");
                    }
                    //stars
                    for (int b = 0; b < number; b++)
                    {

                        Console.Write("*");

                    }
                    Console.WriteLine();
                    number = number + 2;

                }
            }

            Console.WriteLine("Press ENTER to draw another triangle, or ESC to exit.");

        }

    }
}
