using System;
using System.Collections.Generic;
using System.Text;

namespace CBasics
{
    class RandomExercices
    {
        public static void AddNumbers(int number1, int number2)
        {

            int result = 0;
            if (number1 < 0 || number2 < 0)
            { result = number1 + number2; }

            Console.WriteLine(result);
        }

        public static void SignChar(int n1, int n2, char s)
        {
            int result;
            if (s == '-')
            {
                result = n1 - n2;
            }
            else if (s == '+')
            {
                result = n1 + n2;
            }
            else if (s == '*')
            {
                result = n1 * n2;
            }
            else if (s == '/')
            {
                result = n1 / n2;
            }
            else
            {
                Console.WriteLine($"Operation sign {s} differs from  +-*/ ");
                return;
            }


            Console.WriteLine($"Result is:{result}");

        }


        public static void SwitchSign(int n1, int n2, char s)
        {
            int result;
            switch (s)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
                default:
                    Console.WriteLine($"Operation sign {s} differs from  +-*/ ");
                    return;
            }
            Console.WriteLine($"Result is:{result}");
        }
    }
}
