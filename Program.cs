using System;
using System.Threading;
using static System.Console;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Clear();
            WriteLine("S = Seconds => 10s = 10 seconds");
            WriteLine("M = Minutes = 1m = 1 minute");
            WriteLine("0 = Quit");
            WriteLine("How long do you want to count?");

            string data = ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (type == 0)
                Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Clear();

            WriteLine("Ready...");
            Thread.Sleep(1000);

            WriteLine("Set...");
            Thread.Sleep(1000);

            WriteLine("Go!!!");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Clear();
                currentTime++;
                WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Clear();
            WriteLine("Stopwatch finished!!");
            Thread.Sleep(2500);

            Menu();
        }
    }
}
