using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_1_POO
{
    class Time
    {
        private int _hour;
        private int _minute;
        private int _second;
        private int _millisecond;
        public Time()
        {
           _hour = 0;
           _minute = 0;
           _second = 0;
           _millisecond = 0;
        }

        public Time(int hour)
        {
            _hour = hour;
            _minute = 0;
            _second = 0;
            _millisecond = 0;
        }

        public Time(int hour, int minute)
        {
            _hour = hour;
            _minute = minute;
            _second = 0;
            _millisecond = 0;
        }

        public Time(int hour, int minute, int second)
        {
            _hour = hour;
            _minute = minute;
            _second = second;
            _millisecond = 0;
        }

        public Time(int hour, int minute, int second, int millisecond)
        {
            _hour = ValidHour(hour);
            _minute = ValidMinute(minute);
            _second = ValidSecond(second);
            _millisecond = ValidMillisecond(millisecond);
        }

        public int Hour
        {
            get => _hour;
            set => _hour = ValidHour(value);
        }

        public int Minute
        {
            get => _minute;
            set => _minute = ValidMinute(value);
        }

        public int Second
        {
            get => _second;
            set => _second = ValidSecond(value);
        }

        public int Millisencod
        {
            get => _millisecond;
            set => _millisecond = ValidMillisecond(value);
        }


        private int ValidHour(int hour)
        {
            if (hour < 0 || hour >= 24) throw new ArgumentException($"The hour: {hour}, no is valid.");
            return hour;
        }

        private int ValidMinute(int minute)
        {
            if (minute < 0 || minute >= 60) throw new ArgumentException($"The minute {minute}, no is valid.");
            return minute;
        }

        private int ValidSecond(int second)
        {
            if (second < 0 || second >= 60) throw new ArgumentException($"The second {second}, no is valid.");
            return second;
        }

        private int ValidMillisecond(int millisecond)
        {
            if (millisecond < 0 || millisecond >= 1000) throw new ArgumentException($"The millisecond {millisecond}, no is valid.");
            return millisecond;
        }

        public override string ToString()
        {
            var time = new DateTime(1, 1, 1, _hour, _minute, _second, _millisecond);
            return time.ToString("hh:mm:ss.fff tt");
        }


        public int ToMilliseconds() 
        {
            return (_hour * 3600000) + (_minute * 60000) + (_second * 1000) + _millisecond;
        }

        public int ToSeconds() 
        {
            return (_hour * 3600) + (_minute * 60) + _second;
        }

        public int ToMinutes()
        {
            return (_hour * 60) + _minute;
        }
        public bool IsOtherDay(Time other)
        {
            return (_hour + other._hour) >= 24;
        }
        public Time Add(Time other)
        {
            int newHour = (_hour + other._hour) % 24;
            int newMinute = (_minute + other._minute) % 60;
            int newSecond = (_second + other._second) % 60;
            int newMillisecond = (_millisecond + other._millisecond) % 1000;
            return new Time(newHour, newMinute, newSecond, newMillisecond);
        }
    }
}
