using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            string interval;

            Console.WriteLine("Choose value 0 - 100");
            value = Convert.ToInt32(Console.ReadLine());

            interval = (value >= 0) ? (value <= 100) ? (value <= 25) ? "0 - 25" : (value <= 50) ? "26-50" : (value <= 75) ? "51-75" : "76-100" : ">100": "<0";
            Console.WriteLine(interval);

            Console.ReadLine();
        }
    }
}
