using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var myFizzBuzz = new FizzBuzz();
                myFizzBuzz.DoFizzBuzz();
            }
            catch (Exception ex)
            {
                UserOutput.DisplayOutput(ex.Message);
            }
            
        }
    }
}
