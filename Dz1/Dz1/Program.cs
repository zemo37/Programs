using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            int result1 = (a + b + c);
            int result2 = (a * b * c);
            Console.Write("Сума чисел: ");
            Console.WriteLine(result1);
            Console.Write("Произведение чисел: ");
            Console.WriteLine(result2);
        }
    }
}
