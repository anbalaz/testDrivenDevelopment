using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public class Calculator
    {
        private string input = string.Empty;

        private int ParseString()
        {
            input = input.Trim();
            var splitArray = input.Split('+');

            var result = 0;
            foreach (var split in splitArray)
            {
                if (int.TryParse(splitArray[0].Trim(), out int number))
                {
                    result += number;
                }
            }

            if (splitArray.Length > 2)
            {
                throw new NotImplementedException();
            }

            return result;
        }

        public void Input(string input)
        {
            this.input = input;
        }

        public string Result()
        {
            return ParseString();
        }
    }
}
