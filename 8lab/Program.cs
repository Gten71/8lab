using System;
using System.Runtime.Serialization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan Time;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            int gg = 0;
            int tt = 0;
            int ss = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите время разговора в часах: ");
                    gg = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            while (1000 < gg || gg < 0);
            hours = gg;
            do
            {
                try
                {
                    Console.WriteLine("Введите время разговора в минутах: ");
                    tt = Convert.ToInt32(Console.ReadLine());
                    if (59 < tt || tt < 0)
                    {
                        throw new Exception("Ошибка! минуты больше 60 или меньше 0");
                        tt = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            while (59 < tt || tt < 0);
            minutes = tt;
            do
            {
                try
                {
                    Console.WriteLine("Введите время разговора в секундах: ");
                    ss = Convert.ToInt32(Console.ReadLine());
                    if (59 < ss || ss < 0)
                    {
                        throw new Exception("Ошибка! секунды больше 60 или меньше 0");
                        ss = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            while (59 < ss || ss < 0);
            seconds = ss;

            Time = new TimeSpan(hours, minutes, seconds);
            Console.WriteLine("время разговора: {0}, В минутах: {1}", Time, Time.TotalMinutes);
        }
    }
}