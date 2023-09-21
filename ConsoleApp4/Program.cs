using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public enum account : int
    {
        current = 1000000,
        savings = 2000000
    }
    internal class Program
    {
        public struct bank {
            public long number;
            public string type;
            public int balance;
            public override string ToString()
            {
                return $"({number},{type},{balance})";
            }
        };
        public struct university {
            public string name;
            public string college;
            public override string ToString()
            {
                return $"({name},{college})";
            }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("3.1.Создать перечислимый тип данных отображающий виды банковского счета (текущий и сберегательный).");
            account first = account.current;
            account second = account.savings;
            Console.WriteLine("Текущий счёт: {0},Сберегательный счёт:{1}",(int)first,(int)second);
            Console.WriteLine("3.2.Создать структуру с данными о номере, типе и балансе банковского счёта");
            bank Point;
            Point.number = 4082005090845638294;
            Point.type = "расчётный";
            Point.balance = 1000000;
            Console.WriteLine("Номер счёта:"+Point.number.ToString());
            Console.WriteLine("Тип:"+Point.type.ToString());
            Console.WriteLine("Баланс:"+Point.balance.ToString());
            Console.WriteLine("3.3.Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ.");
            university Point1;
            Point1.name = "Иванов Иван Иванович";
            Point1.college = "КАИ";
            Console.WriteLine("ФИО:" + Point1.name.ToString());
            Console.WriteLine("Университет:" + Point1.college.ToString());
        }
        

    }
}
