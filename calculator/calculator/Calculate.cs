using System;
using System.Collections.Generic;
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
            //the returned value
            string stringData = "";
            //used temp to store data
            string[] tempString;
            //counts the amount of pieces within the string
            int counter = 0;

            //count the amount of pieces of the string to be calculated
            for (int i = 0; i < _calculateString.Length; i++)
            {
                switch (_calculateString[i])
                {
                    case 'x':
                        counter++;
                        break;
                    case ':':
                        counter++;
                        break;
                    case '+':
                        counter++;
                        break;
                    case '-':
                        counter++;
                        break;
                    default:
                        stringData = "Math Error, no operators found";
                        break;
                }
            }
            //special snowflake stuff
            if (counter != 1)
            {
                tempString = new string[counter += counter + 1];
            }
            else
            {
                counter += 2;
            }
            //cut the string in pieces and order it correctly.
            for (int j = 0; j < _calculateString.Length; j++)
            {
                if ((int)char.GetNumericValue(_calculateString[j]) >= 0 && (int)char.GetNumericValue(_calculateString[j]) <= 9)
                {
                    
                }
                else
                {
                    switch (Char.ConvertFromUtf32(_calculateString[j]))
                    {
                        case "x":
                            Console.WriteLine("operator");
                            break;
                        case ":":
                            Console.WriteLine("operator");
                            break;
                        case "+":
                            Console.WriteLine("operator");
                            break;
                        case "-":
                            Console.WriteLine("operator");
                            break;
                        default:
                            stringData = "Math Error, no operators found";
                            break;
                    }
                }
            }
            return stringData;
        }
    }
}