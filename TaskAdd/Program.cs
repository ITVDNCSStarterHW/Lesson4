using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;

            Console.WriteLine("Какое слово о погоде вы хотите перевести?");
            word = Console.ReadLine();

            switch (word)
            {
                case "дождь":
                    Console.WriteLine("rain");
                    break;

                case "солнце":
                    Console.WriteLine("sunny");
                    break;

                case "туман":
                    Console.WriteLine("fog");
                    break;

                case "снег":
                    Console.WriteLine("snow");
                    break;

                case "ветер":
                    Console.WriteLine("wind");
                    break;

                case "облака":
                    Console.WriteLine("clouds");
                    break;

                default:
                    Console.WriteLine("Такого слова нет");
                    break;
            }

            Console.ReadLine();
        }
    }
}
