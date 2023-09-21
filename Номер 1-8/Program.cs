using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Номер_1_8
{
    public static class Program
    {
        public struct person
        {
            public string surname;
            public string name;
            public int id;
            public string date;
            public string category;
            public double alco;
            public double procent;
            public override string ToString()
            {
                return $"({surname},{name},{id},{date},{category})";
            }
        };
        public static int Count(this string input, string substr)
        {
            return Regex.Matches(input, substr).Count;
        }
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Выведите на экран информацию о каждом типе данных в виде: Тип данных – максимальное значение – минимальное значение");
            Console.WriteLine("Byte максимальное значение:" + Byte.MaxValue + " минимальное значение:" + Byte.MinValue);
            Console.WriteLine("Sbyte максимальное значение:" + SByte.MaxValue + " минимальное значение:" + SByte.MinValue);
            Console.WriteLine("Short максимальное значение:" + short.MaxValue + " минимальное значение:" + short.MinValue);
            Console.WriteLine("Ushort максимальное значение:" + ushort.MaxValue + " минимальное значение:" + ushort.MinValue);
            Console.WriteLine("Integer максимальное значение:" + Int32.MaxValue + " минимальное значение:" + Int32.MinValue);
            Console.WriteLine("UInteger максимальное значение:" + UInt32.MaxValue + " минимальное значение:" + UInt32.MinValue);
            Console.WriteLine("Long максимальное значение:" + long.MaxValue + " минимальное значение:" + long.MinValue);
            Console.WriteLine("Ulong максимальное значение:" + ulong.MaxValue + " минимальное значение:" + ulong.MinValue);
            Console.WriteLine("Float максимальное значение:" + float.MaxValue + " минимальное значение:" + float.MinValue);
            Console.WriteLine("Double максимальное значение:" + double.MaxValue + " минимальное значение:" + double.MinValue);
            Console.WriteLine("Decimal максимальное значение:" + Decimal.MaxValue + " минимальное значение:" + Decimal.MinValue);
            Console.WriteLine("2. Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN-кода.");
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите город:");
            string city = Console.ReadLine();
            Console.WriteLine("Введите PIN-код:");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Имя:{0} Город:{1} PIN-код:{2}", (string)name, (string)city, (int)pin);
            Console.WriteLine("3.Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.");
            Console.WriteLine("Ведите строку");
            string str = Console.ReadLine();
            char[] strch = str.ToCharArray();
            string strch1 = "";
            for (int i = 0; i < strch.Length; i++)
            {

                if (strch[i] >= 'a' && strch[i] <= 'z')
                {
                    strch1 += char.ToUpper(strch[i]);

                }

                else if (strch[i] >= 'A' && strch[i] <= 'Z')
                {
                    strch1 += char.ToLower(strch[i]);
                }
            }
            Console.WriteLine(strch1);
            Console.WriteLine("4.Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.");
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            Console.WriteLine("Введите подстроку");
            string str1 = Console.ReadLine();
            int stroka1 = input.Count(str1);
            Console.WriteLine("Подстрока встречается в строке "+stroka1+" раз");
            Console.WriteLine("5.Определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск.");
            Console.WriteLine("Введите стоимость бутылки");
            int boutle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку");
            int discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            int price = Convert.ToInt32(Console.ReadLine());
            int discount1 = boutle-(boutle * discount / 100);
            int quantity = price / discount1;
            Console.WriteLine("Нужно купить "+quantity+" бутылок");
            Console.WriteLine("Воспроизвести разговор Гарри Поттера и дневника Тома Реддла.");
            Console.WriteLine("Пользователь здоровается с консолью");
            Console.WriteLine("Нажмите любую клавишу и Enter");
            string hello=Console.ReadLine();
            Console.WriteLine("Введите своё имя");
            string name2 = Console.ReadLine();
            Console.WriteLine("Привет, "+ name2);
            Console.WriteLine("Пользователь спрашивает про Тайную комнату");
            Console.WriteLine("Нажмите любую клавишу и Enter");
            Console.WriteLine("Да");
            Console.WriteLine("Пользователь спрашивает, может ли рассказать");
            Console.WriteLine("Нажмите любую клавишу и Enter");
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Console.ForegroundColor = GetRandomConsoleColor();
            Console.WriteLine(";)");
            Console.WriteLine("Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата рождения, Категория алкоголизма, также у студента есть Объем выпитого алкоголя.");
            person Point;
            Point.surname = "Иванов";
            Point.name = "Иван";
            Point.id = 56;
            Point.date = "01.01.2005";
            Point.category = "студент алкоголик";
            Point.alco = 2;
            person Point1;
            Point1.surname = "Соколов";
            Point1.name = "Сергей";
            Point1.id = 57;
            Point1.date = "02.02.2005";
            Point1.category = "студент любитель выпить, но не алкоголик";
            Point1.alco = 1;
            person Point2;
            Point2.surname = "Сергеев";
            Point2.name = "Игорь";
            Point2.id = 58;
            Point2.date = "03.03.2005";
            Point2.category = "студент пьёт по праздникам";
            Point2.alco = 0.5;
            person Point3;
            Point3.surname = "Павлова";
            Point3.name = "Виктория";
            Point3.id = 59;
            Point3.date = "03.03.2005";
            Point3.category = "студент не пьёт";
            Point3.alco = 0;
            person Point4;
            Point4.surname = "Макарова";
            Point4.name = "Елена";
            Point4.id = 60;
            Point4.date = "14.12.2005";
            Point4.category = "студент не пьёт";
            Point4.alco = 0;
            double alcoo = Point.alco + Point1.alco + Point2.alco + Point3.alco + Point4.alco;
            Point.procent = Point.alco/alcoo*100;
            Point1.procent = Point1.alco / alcoo * 100;
            Point2.procent = Point2.alco / alcoo * 100;
            Point3.procent = Point3.alco / alcoo * 100;
            Point4.procent = Point4.alco / alcoo * 100;
            Console.WriteLine("Фамилия: "+Point.surname+" Имя: "+Point.name+" Идентификатор: "+Point.id+" Дата рождения: "+Point.date+" Категория алкоголизма: "+Point.category+" Объём выпитого алкоголя: "+Point.alco+" Процент выпитого алкоголя: "+Point.procent+"%");
            Console.WriteLine("Фамилия: " + Point1.surname + " Имя: " + Point1.name + " Идентификатор: " + Point1.id + " Дата рождения: " + Point1.date + " Категория алкоголизма: " + Point1.category + " Объём выпитого алкоголя " + Point1.alco+" Процент выпитого алкоголя: " + Point1.procent+"%");
            Console.WriteLine("Фамилия: " + Point2.surname + " Имя: " + Point2.name + " Идентификатор: " + Point2.id + " Дата рождения: " + Point2.date + " Категория алкоголизма: " + Point2.category + " Объём выпитого алкоголя " + Point2.alco+ " Процент выпитого алкоголя: " + Point2.procent+"%");
            Console.WriteLine("Фамилия: " + Point3.surname + " Имя: " + Point3.name + " Идентификатор: " + Point3.id + " Дата рождения: " + Point3.date + " Категория алкоголизма: " + Point3.category + " Объём выпитого алкоголя " + Point3.alco+ " Процент выпитого алкоголя: " + Point3.procent+"%");
            Console.WriteLine("Фамилия:  " + Point4.surname + " Имя: " + Point4.name +" Идентификатор: " + Point4.id + " Дата рождения: " + Point4.date + " Категория алкоголизма: " + Point4.category + " Объём выпитого алкоголя " + Point4.alco+ " Процент выпитого алкоголя: " + Point4.procent+"%");
        }
    }
}
