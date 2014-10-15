using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2._2
{
    class Program
    {

        string HorizontalLine;

        static void Main(string[] args)
        {
            ViewTestHeader("Test 1");
            ViewTestHeader("Test av standardkonstruktorn.");
            AlarmClock alarmClock = new AlarmClock();
            string constructorOne = alarmClock.ToString();
            Console.WriteLine(constructorOne);
            Console.WriteLine();

            ViewTestHeader("Test 2");
            ViewTestHeader("Test av konstruktorn med två parametrar, <9, 42>.");
            AlarmClock alarmClock2 = new AlarmClock(9, 42);
            string constructorTwo = alarmClock2.ToString();
            Console.WriteLine(constructorTwo);
            Console.WriteLine();

            ViewTestHeader("Test 3");
            ViewTestHeader("Test av konstruktorn med fyra parametrar, <13, 24, 7, 35>.");
            AlarmClock alarmClock3 = new AlarmClock(13, 24, 7, 35);
            string constructorThree = alarmClock3.ToString();
            Console.WriteLine(constructorThree);
            Console.WriteLine();

            ViewTestHeader("Test 4");
            ViewTestHeader("Ställer befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter");
            AlarmClock alarmClock4 = new AlarmClock(23, 58, 7, 35);

            Run(alarmClock4, 12);
            Console.WriteLine();

            ViewTestHeader("Test 5");
            ViewTestHeader("Ställer befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter.");
            AlarmClock alarmClock5 = new AlarmClock(6, 11, 6, 15);
            bool testAlarmClock = alarmClock5.TickTock();

            Run(alarmClock5, 5);
            Console.WriteLine();

            ViewTestHeader("Test 6");
            ViewTestHeader("Testar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");
            AlarmClock alarmClock6 = new AlarmClock();
            
                try
                {
                    alarmClock6.Hour = 95;
                }
                catch (Exception e)
                {
                    ViewErrorMessage(e.Message);
                }
                try
                {
                    alarmClock6.Minute = 96;
                }
                catch(Exception e)
                {
                    ViewErrorMessage(e.Message);
                }
                try
                {
                    alarmClock6.AlarmHour = 97;
                }
                catch (Exception e)
                {
                    ViewErrorMessage(e.Message);
                }
                try
                {
                    alarmClock6.AlarmMinute = 99;
                }
                catch (Exception e)
                {
                    ViewErrorMessage(e.Message);
                }

                Console.WriteLine();


            ViewTestHeader("Test 7");
            ViewTestHeader("Testar konstruktorer så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.");

            try
            {
                AlarmClock alarmClock7 = new AlarmClock(96, 97);
            }
            catch (Exception e)
            {
                ViewErrorMessage(e.Message);
            }
            try
            {
                AlarmClock alarmClock7 = new AlarmClock(11, 23, 98, 99);
            }
            catch (Exception e)
            {
                ViewErrorMessage(e.Message);
            }

            Console.WriteLine();

        }

        private static void Run(AlarmClock ac, int minutes)
        {
                for (int i = 0; i <= minutes; i++)
                {
                    if (ac.TickTock() == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine(ac.ToString() + " BEEP! BEEP! BEEP!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(ac.ToString());
                    }
                }

        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        
        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }
    }
}
