using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Time
    {
        private int hour;
        private int min;

        public Time() { }
        public Time(int _hour, int _min)
        {
            if (_hour < 0)
                hour = 0;
            else
                hour = _hour % 24;
            if (_min < 0)
                min = 0;
            else
                min = _min % 60;
        }

        public Time(int _min)
        {
            hour = _min / 60 % 24;
            min = _min % 60;
        }

        public int getHour()
        {
            return hour;
        }

        public int getMin()
        {
            return min;
        }

        public void setHour(int _hour)
        {
            if (_hour < 0)
                hour = 0;
            else
                hour = _hour % 24;
        }

        public void setMin(int _min)
        {
            if (_min < 0)
                min = 0;
            else
                min = _min % 60;
        }

        public void plus(Time _plus)
        {
            int buf = _plus.getHour() * 60 + _plus.getMin() + hour * 60 + min;
            hour = buf / 60 % 24;
            min = buf % 60;
        }

        public void minus(Time _minus)
        {
            int buf = (hour * 60 + min) - (_minus.getHour() * 60 + _minus.getMin());
            hour = buf / 60 % 24;
            min = buf % 60;
            if (hour < 0)
                hour = 0;
            if (min < 0)
                min = 0;
        }

        public void Print()
        {
            if (hour < 10 && min < 10)
                Console.WriteLine($"0{hour}:0{min}");
            else if (hour < 10 && min >= 10)
                Console.WriteLine($"0{hour}:{min}");
            else if (hour >= 10 && min < 10)
                Console.WriteLine($"{hour}:0{min}");
            else
                Console.WriteLine($"{hour}:{min}");
        }

        public void showTime(Time t)
        {
            if (t.getHour() < 10 && t.getMin() < 10)
                Console.WriteLine($"0{t.getHour()}:0{t.getMin()}");
            else if (t.getHour() < 10 && t.getMin() >= 10)
                Console.WriteLine($"0{t.getHour()}:{t.getMin()}");
            else if (t.getHour() >= 10 && t.getMin() < 10)
                Console.WriteLine($"{t.getHour()}:0{t.getMin()}");
            else
                Console.WriteLine($"{t.getHour()}:{t.getMin()}");
        }

        public static Time operator ++(Time _t1)
        {
            int buf = _t1.getHour() * 60 + _t1.getMin() + 1;
            _t1.setHour(buf / 60 % 24);
            _t1.setMin(buf % 60);
            return _t1;
        }

        public static Time operator --(Time _t1)
        {
            int buf = _t1.getHour() * 60 + _t1.getMin() - 1;
            _t1.setHour(buf / 60 % 24);
            _t1.setMin(buf % 60);
            return _t1;
        }

        public static explicit operator int(Time _t1)
        {
            int buf = _t1.getHour() * 60 + _t1.getMin();
            return buf;
        }

        public static implicit operator bool(Time _t1)
        {
            if (_t1.getHour() == 0 || _t1.getMin() == 0)
                return true;
            else
                return false;
        }

        public static Time operator +(Time _t1, int _int)
        {
            Time buf = new Time(_int);
            _t1.plus(buf);
            return _t1;
        }
        public static Time operator +(int _int , Time _t1)
        {
            Time buf = new Time(_int);
            _t1.plus(buf);
            return _t1;
        }

        public static Time operator -(Time _t1, int _int)
        {
            Time buf = new Time(_int);
            _t1.minus(buf);
            return _t1;
        }

        public static Time operator -(int _int, Time _t1)
        {
            Time buf = new Time(_int);
            buf.minus(_t1);
            return buf;
        }


        ~Time() { }
    }
}
