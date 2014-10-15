using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2._3
{

    public enum ShapeTypes {unknown, ellipseShape, rectangleShape};

    class Program
    {


        static void Main(string[] args)
        {
            bool pressedKey = true;
            while(pressedKey == true)
            {
                ViewMenu();

                Console.Write("Ange menyval [0-2]: ");
                //int shape = int.Parse(Console.ReadLine());
                int shapeNumber;
                if (int.TryParse(Console.ReadLine(), out shapeNumber) && shapeNumber >= 0 && shapeNumber <= 2)
                {
                    switch (shapeNumber)
                    {
                        case 0:
                            return;

                        case 1:
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("===========================");
                            Console.WriteLine("=          Ellips         =");
                            Console.WriteLine("===========================");
                            Console.ResetColor();
                            ViewShapeDetail(CreateShape(ShapeTypes.ellipseShape));

                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Tryck MELLANSLAG för att börja om.");
                            Console.ResetColor();
                            if (Console.ReadKey(true).Key != ConsoleKey.Spacebar)
                            {
                                pressedKey = false;
                            }
                            break;

                        case 2:
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("===========================");
                            Console.WriteLine("=        Rektangel        =");
                            Console.WriteLine("===========================");
                            Console.ResetColor();
                            ViewShapeDetail(CreateShape(ShapeTypes.rectangleShape));

                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Tryck MELLANSLAG för att börja om.");
                            Console.ResetColor();
                            if (Console.ReadKey(true).Key != ConsoleKey.Spacebar)
                            {
                                pressedKey = false;
                            }
                            break;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Ange ett nummer mellan 0-2.");
                    Console.ResetColor();
                    Console.WriteLine();

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tryck MELLANSLAG för att fortsätta");
                    Console.ResetColor();
                    if (Console.ReadKey(true).Key != ConsoleKey.Spacebar)
                    {
                        pressedKey = false;
                    }
                }
           }
        }

        
        private static Shape CreateShape(ShapeTypes shapeType)
        {
            double length = ReadDoubleGreaterThanZero("Ange längd: ");
            double width = ReadDoubleGreaterThanZero("Ange bredd: ");

            if (shapeType == ShapeTypes.ellipseShape)
            {
                Ellipse ellipse = new Ellipse(length, width);
                return ellipse;
            }
            else if (shapeType == ShapeTypes.rectangleShape)
            {
                Rectangle rectangle = new Rectangle(length, width);
                return rectangle;
            }
            else
            {
                return null;
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double inputInteger;

            do
            {
                Console.Write(prompt);

                if (double.TryParse(Console.ReadLine(), out inputInteger) && inputInteger > 0)
                {
                    return inputInteger;
                }
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("FEL! Ange ett flyttal större än noll.");
                Console.ResetColor();

            } while (true);
            
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("-            Geometriska figurer       -");
            Console.WriteLine("-                                      -");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine("0. Avsluta.");
            Console.WriteLine("1. Ellips.");
            Console.WriteLine("2. Rektangel.");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

        }

        private static void ViewShapeDetail(Shape shape)
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("-                Detaljer              -");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine(shape.ToString());
        }

    }
}
