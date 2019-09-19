using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculate
    {
        private string _calculateString;

        public Calculate(string calculateString)
        {
            _calculateString = calculateString;
        }

        public string getCalculatedValue()
        {
            string stringData = "";
            string[] tempString;
            int counter = 0;

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
            if (counter != 1)
            {
                tempString = new string[counter += counter + 1];
            }
            else
            {
                counter += 2;
            }
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