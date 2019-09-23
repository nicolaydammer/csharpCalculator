using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculate
    {
        //string to be calculated
        private string _calculateString;

        //constructor
        public Calculate(string calculateString)
        {
            _calculateString = calculateString;
        }

        //calculate the value and return it
        public string getCalculatedValue()
        {
            //calculate the string
            Console.WriteLine(_calculateString);
                return new DataTable().Compute(_calculateString, null).ToString();
        }
    }
}