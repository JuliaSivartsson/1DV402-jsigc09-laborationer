using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2._1
{
    class SecretNumber
    {
        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;
        private Random randomNumber;

        //made the randomnumber as a constant for safety reasons.
        private const int MinValue = 1;
        private const int MaxValue = 100;


        public SecretNumber()
        {
            Initialize();

        }

        public void Initialize()
        {
            randomNumber = new Random();
            _number = randomNumber.Next(MinValue, MaxValue);
            _count = 0;

        }

        public bool MakeGuess(int number)
        {
            int guessesLeft;

            if (_count == MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }

            if (number >= MinValue && number <= MaxValue)
            {
                if (number < _number)
                {
                    _count++;
                    Console.WriteLine("{0} är för lågt.", number);
                    guessesLeft = MaxNumberOfGuesses - _count;
                    Console.WriteLine("Du har {0} gissningar kvar.", guessesLeft);

                    if (guessesLeft == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Det hemliga numret var {0}.", _number);
                    }
                    return false;
                }
                else if (number > _number)
                {
                    _count++;
                    Console.WriteLine("{0} är för högt.", number);
                    guessesLeft = MaxNumberOfGuesses - _count;
                    Console.WriteLine("Du har {0} gissningar kvar.", guessesLeft);

                    if (guessesLeft == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Det hemliga numret var {0}.", _number);
                    }
                    return false;
                }
                else
                {
                    _count++;
                    Console.WriteLine("RÄTT GISSAT!");
                    Console.WriteLine("Du klarade det på {0} försök!", _count);

                    return true;
                }

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }


        }
    }
}
