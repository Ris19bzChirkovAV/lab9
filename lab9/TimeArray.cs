using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class TimeArray
    {
        Time[] arr;
        int size = 0;

        public TimeArray() { }
        public TimeArray(int _count)
        {
            Array.Resize(ref arr, _count);
            Random rand = new Random();
            for (int i = 0; i < _count; i++)
            {
                arr[size] = new Time(rand.Next(24), rand.Next(60));
                size++;
            }
        }

        public TimeArray(int _count, bool a)
        {
            Array.Resize(ref arr, _count);
            for (int i = 0; i < _count; i++)
            {
                Console.Clear();
                Console.WriteLine("Введите часы:");
                string buf = Console.ReadLine();
                int hour = int.Parse(buf);
                Console.WriteLine("Введите минуты:");
                buf = Console.ReadLine();
                int min = int.Parse(buf);
                arr[size] = new Time(hour, min);
                size++;
            }
        }

        public Time this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
            
        }
        public void show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i].getHour()}:{arr[i].getMin()} ");
            }
        }

        public void max()
        {
            int _max = 0;
            int buf;
            for (int i = 0; i < arr.Length; i++)
            {
                buf = arr[i].getHour() * 60 + arr[i].getMin();
                if (_max < buf)
                    _max = buf;
            }
            Console.WriteLine($"Максимальное значение: {_max / 60 % 24}:{_max % 60}");
        }
        ~TimeArray() { }
    }
}
