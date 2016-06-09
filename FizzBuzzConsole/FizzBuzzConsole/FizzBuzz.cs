using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    class FizzBuzz
    {
        private static int defaultStartRangeValue = 1;

        private static int defaultEndRangeValue = 10;

        private  Dictionary<int, string> fizzBuzzDictionary = new Dictionary<int, string>();

        private int startRange;

        private int endRange;

        private StringBuilder UserOutputStream { get; set; }

        public FizzBuzz()
        {
            PopulateFizzBuzzValues();
            GetStartEndFizzBuzzRange();
            UserOutputStream = new StringBuilder();
        }

        private void GetStartEndFizzBuzzRange()
        {
            startRange = GetRangeValue("Enter start Range for FizzBuzz", true);
            endRange = GetRangeValue("Enter end Range for FizzBuzz",false);
            ValidateStartEndRange();
        }

        private int GetRangeValue(string displayString, bool startRange)
        {
            try
            {
                return UserInput.ReadIntegerValue(displayString); 
            }
            catch (FormatException)
            {
                UserOutput.DisplayOutput("Defaulting Value because of bad input");
                return (startRange) ? defaultStartRangeValue : defaultEndRangeValue;
            }

            
        }

        private void ValidateStartEndRange()
        {
            if (startRange > endRange)
            {
                throw new InvalidOperationException("Start Range cannot be Greater than End Range");
            }
        }

        private void PopulateFizzBuzzValues()
        {
            GetAndSetFizzBuzzValues("Enter first Fizz Buzz Value Set");
            GetAndSetFizzBuzzValues("Enter second Fizz Buzz Value Set");
            GetAndSetFizzBuzzValues("Enter third Fizz Buzz Value Set");

            
        }

        private void GetAndSetFizzBuzzValues(string displayString)
        {
            var fizzBuzzPair = UserInput.GetFizzBuzzValuePair(displayString);
            fizzBuzzDictionary.Add(fizzBuzzPair.value, fizzBuzzPair.FizzBuzzString);

        }

        public void DoFizzBuzz()
        {
            StartFizzBuzz();
            UserOutput.DisplayOutput(UserOutputStream);
        }

        private void StartFizzBuzz()
        {
            for (int number = startRange; number <= endRange; number++)
            {
                ComputeFizzBuzz(number);
            }
        }

        private void ComputeFizzBuzz(int number)
        {
            var fizzBuzzString = number.ToString();
            foreach (var fizzBuzzSet in fizzBuzzDictionary)
            {
                fizzBuzzString = DivisibleByNumber(number, fizzBuzzSet.Key,fizzBuzzString);
            }
            AddFizzBuzzToOutput(fizzBuzzString + ((number % 5 == 0) ? "\n" : "\t"));
        }

        
        private void AddFizzBuzzToOutput(string fizzBuzzString)
        {
            UserOutputStream.Append(fizzBuzzString);
        }

        
        private string DivisibleByNumber(int number, int divider, string fizzBuzzString)
        {
            return (number % divider == 0) ? fizzBuzzDictionary[divider] : fizzBuzzString;
        }
    }
}
