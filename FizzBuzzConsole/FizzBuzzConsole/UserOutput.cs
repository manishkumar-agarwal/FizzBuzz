using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    class UserOutput
    {
        public static void DisplayOutput(String displayString)
        {
            Console.WriteLine(displayString);
        }
        public static void DisplayOutput(StringBuilder displayString)
        {
            Console.WriteLine(displayString);
        }
    }
}
