using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            int counteven = 0;
            int countodd = 0;
            while (start<=end)
            {
                Console.WriteLine(start);
                if (start % 2 == 0) counteven++;
                else countodd++;
                 start++; 
            }
            Console.WriteLine($"Even: {counteven} \nodd: {countodd}");
        }
    }
}
