using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(20, 25);
            Time t2 = new Time(10, 26);
            Console.Write("T1 - T2: ");
            Time t3 = minus(t1, t2);
            t3.Print();
            Time t4 = new Time(15, 10);
            t4.minus(t2);
            Console.Write("T4 - T2: ");
            t4.Print();
            t4.setHour(22);
            t4.setMin(59);
            Console.Write("Operator++:");
            t4++;
            t4.Print();
            Console.Write("Operator--: ");
            t4--;
            t4.Print();
            Console.WriteLine($"Явное преобразование в int: {(int)t4}");
            Console.WriteLine($"Неявное преобразование в bool: {(bool)t4}");
            t4.setMin(0);
            Console.WriteLine($"Неявное преобразование в bool c 0: {(bool)t4}");
            Console.Write("T4 + 10: ");
            t4 = t4 + 10;
            t4.Print();
            Console.Write("10 + T4: ");
            t4 = 10 + t4;
            t4.Print();
            Console.Write("T4 - 10: ");
            t4 = t4 - 10;
            t4.Print();
            Console.Write("1400 - T4: ");
            t4 = 1400 - t4;
            t4.Print();
            Console.WriteLine("Автосоздание массива:");
            TimeArray ta = new TimeArray(5);
            ta.show();
            Console.WriteLine("\nСоздание вручную, введите количество:");
            string buf = Console.ReadLine();
            TimeArray arr = new TimeArray(int.Parse(buf), true);
            arr.show();
            Console.WriteLine("");
            Console.WriteLine("Замена 0 элемента: ");
            arr[0] = new Time(5, 5);
            arr.show();
            Console.WriteLine($"\nВызов 2 элемента: {arr[1].getHour()}:{arr[1].getMin()}");
            Console.WriteLine("");
            arr.max();

            Console.ReadLine();
        }

        public static Time minus(Time _t1, Time _t2)
        {
            Time tBuf = new Time();
            int buf = (_t1.getHour() * 60 + _t1.getMin()) - (_t2.getHour() * 60 + _t2.getMin());
            tBuf.setHour(buf / 60);
            tBuf.setMin(buf);
            return tBuf;
        }
    }
}
