using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz3_Kalkuliator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)       //Для того чтоб программа не закрывалась
            {
                
                Console.Clear();       //Для очищения консоли
                double first;
                string Value;
                try                 //Чтоб ошибка не ломала программу
                {
                    Console.WriteLine("Введите число");
                    first = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите операцию");
                    Value = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено неправильное значение");
                    Console.ReadLine();
                    continue;
                }
                switch (Value)       //case для того чтоб использовать математические операции
                {
                    case "+":
                        Console.WriteLine("Введите число");
                        try
                        {
                            double second1 = double.Parse(Console.ReadLine());
                            double resalt1 = first + second1;
                            Console.WriteLine($"Результат: {resalt1}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Введено неправильное значение");
                            Console.ReadLine();
                            continue;
                        }
                        
                        break;
                    case "-":
                        try
                        {
                            Console.WriteLine("Введите число");
                            double second2 = double.Parse(Console.ReadLine());
                            double resalt2 = first - second2;
                            Console.WriteLine($"Результат: {resalt2}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Введено неправильное значение");
                            Console.ReadLine();
                            continue;
                        }
                        break;
                    case "/":
                        try
                        {
                            Console.WriteLine("Введите число");
                            double second3 = double.Parse(Console.ReadLine());
                            if (second3 == 0)
                            {
                                Console.WriteLine("На ноль делить нельзя");
                            }
                            else
                            {
                                double resalt3 = first / second3;
                                Console.WriteLine($"Результат: {resalt3}");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Введено неправильное значение");
                            Console.ReadLine();
                            continue;
                        }
                        break;
                    case "*":
                        try
                        {
                            Console.WriteLine("Введите число");
                            double second4 = double.Parse(Console.ReadLine());
                            double resalt4 = first * second4;
                            Console.WriteLine($"Результат: {resalt4}");
                        }
                        catch
                        {
                            Console.WriteLine("Введено неправильное значение");
                            Console.ReadLine();
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Вы ввели неизвестное значение.");
                        break;
                }

            }


        }
    }
}
