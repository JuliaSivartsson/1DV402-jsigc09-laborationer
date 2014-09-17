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
            // Do this as long as ESC-button is not pressed
            do
            {
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

            while (true)
            {
                Console.Write("Select an odd number <max 79> for the triangles base: ");
                try
                {
                    number = byte.Parse(Console.ReadLine());

                    if (number % 2 != 0 && number >= 1 && number < 79)
                    {
                        break;
                    }
                    else if (number < 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("The number is too small!");
                        Console.ResetColor();
                    }
                    else if (number > 79)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("The number is too large!");
                        Console.ResetColor();
                    }
                    else if (number % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("The number is not odd!");
                        Console.ResetColor();
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("This was not an int number!");
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
            int temp = bottom;

            // only display the triangle if everything is correct (number not too big, too small, odd a.s.o.)
            if (cols % 2 == 0)
            {
            }
            else
            {
                //rows
                for (int i = 1; i <= bottom; i++)
                {
                    //space from edge
                    for (int j = 1; j < temp; j++)
                    {
                        Console.Write(" ");
                    }
                    temp--;
                    //stars
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");

                        //got help with how to break the loop: http://social.msdn.microsoft.com/Forums/en-US/f3bd28d3-b0a4-47bf-96b1-c76004652e6b/how-to-exit-the-loop-in-c-before-the-end?forum=csharplanguage
                        if (k == bottom)
                        {
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Press ENTER to draw another triangle, or ESC to exit.");
                            Console.ResetColor();
                            return;
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
