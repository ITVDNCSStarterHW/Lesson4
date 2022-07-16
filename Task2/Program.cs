using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 429;
            int operand2 = 10;
            string sign;

            Console.WriteLine("Choose operation");
            sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;

                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;

                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;

                case "/":
                    if (operand2 != 0)
                    {
                        Console.WriteLine((double)operand1 / operand2);
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    break;

                case "%":
                    Console.WriteLine((double)operand1 % operand2);
                    break;

                default:
                    Console.WriteLine("Unknown sign");
                    break;
            }
            Console.ReadLine();
        }
    }
}
