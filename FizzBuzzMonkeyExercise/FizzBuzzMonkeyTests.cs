using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzMonkeyExercise
{
    [TestFixture]
    class FizzBuzzMonkeyTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(7, "Monkey")]
        [TestCase(10, "Buzz")]
        [TestCase(14, "Monkey")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3*5*7, "FizzBuzzMonkey")]
        [TestCase(9 * 49, "FizzMonkey")]
        [TestCase(25 * 49, "BuzzMonkey")]
        [TestCase(9 * 25 * 49, "FizzBuzzMonkey")]
        public void Test_1(int input, string expected)
        {
           var result = Program.FizzBuzzMonkey(input);

            Assert.AreEqual(expected, result);
        }

    }
}
