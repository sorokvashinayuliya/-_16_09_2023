using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

 namespace ДЗ_09._09._2023
{
    internal static class Program
    {
        static void Main() 
        {
            Console.WriteLine("2.1 Программа спрашивает имя пользователя, и затем приветствует пользователя по имени.");
            Console.Write("Введите имя:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Добрый день," + name1);
            Console.WriteLine("2.1.Вывести следующую букву алфавита");
            Console.WriteLine("Введите букву английского или русского алфавита");
            char name = Console.ReadLine()[0];
            if (name == 'Z' || name == 'Я')
            {
                Console.WriteLine("Последняя буква алфавита");
            }
            else
            {
                Console.WriteLine($"Следующая буква:{(char)((int)name + 1)}");
            }
            Console.WriteLine("2.1.Написать программу, которой на вход подается два целых числа, на выходе – результат деления одного числа на другое.");
            Console.WriteLine("Введите делимое");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите делитель");
            int b1 = Convert.ToInt32(Console.ReadLine());
            if (b1 == 0)
            {
                Console.WriteLine("На 0 делить нельзя");
            }
            else
            {
                Console.WriteLine("Результат деления = " + (a1 / b1));
            }
            Console.WriteLine("2.2.Решение квадратного уравнения");
            Console.WriteLine("Введите коэффициенты");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double discriminant = (b * b) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Корней нет");
            }
            if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Корень уравнения:" + x);

            }
            if (discriminant > 0)
            {
                double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Первый корень уравнения:" + x1);
                Console.WriteLine("Второй корень уравнения:" + x2);
            }

        }

    }
    

}
