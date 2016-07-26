using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMonkeyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string FizzBuzzMonkey(int input)
        {
            if (IsDivisibleByThreeFiveOrSeven(input))
            {
                var result = "";

                if (IsDivisibleByThree(input))
                    result += "Fizz";
                if (IsDivisibleByFive(input))
                    result += "Buzz";
                if (IsDivisibleBySeven(input))
                    result += "Monkey";

                return result;
            }
            else
            {
                return input.ToString();
            }

        }

        private static bool IsDivisibleByThreeFiveOrSeven(int input)
        {
            return IsDivisibleByFive(input) || IsDivisibleByThree(input) || IsDivisibleBySeven(input);
        }

        private static bool IsDivisibleBySeven(int input)
        {
            return input %7 == 0;
        }

        private static bool IsDivisibleByFive(int input)
        {
            return input %5 == 0;
        }

        private static bool IsDivisibleByThree(int input)
        {
            return input %3 == 0;
        }
    }
}
