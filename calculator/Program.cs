using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => b == 0 ? double.NaN : a / b;
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");

            Console.Write("Выберите операцию: ");
            int op = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (op == 1)
                Console.WriteLine($"Результат сложения: {Add(a, b)}");
            else if (op == 2)
                Console.WriteLine($"Результат вычитания: {Subtract(a, b)}");
            else if (op == 3)
                Console.WriteLine($"Результат умножения: {Multiply(a, b)}");
            else if (op == 4)
                Console.WriteLine($"Результат деления: {Divide(a, b)}");
            else Console.WriteLine("Нет такой операции");
        }
    }
}
