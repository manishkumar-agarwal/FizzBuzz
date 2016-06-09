using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    class UserInput
    {
        public static int ReadIntegerValue(string displayString = "Please enter an Integer Value")
        {
            UserOutput.DisplayOutput(displayString);

            var userValue = ReadConsole();

            return Int32.Parse(userValue);
        }

        private static string ReadConsole()
        {
            return Console.ReadLine();
        }

        private static string ReadStringValue(string displayString = "Please enter an Input String Value")
        {
            UserOutput.DisplayOutput(displayString);

            return ReadConsole();
        }


        internal static FizzBuzzValuePair GetFizzBuzzValuePair(string displayString = "Please Enter Fizz Buzz value and String")
        {
            UserOutput.DisplayOutput(displayString);
            FizzBuzzValuePair fizzBuzzPair;
            fizzBuzzPair.value = ReadIntegerValue();
            fizzBuzzPair.FizzBuzzString = ReadStringValue("Enter Fizz Buzz String");
            return fizzBuzzPair;
        }
    }
}
