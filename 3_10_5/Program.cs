using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace example_3_10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Игра угадайка");
            Random random = new Random();

            int iiNumber = random.Next(1, 1000);
            int count = 0;
            int userNumber;

            for (; ; )
            {
                Write("Введите число: ");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < iiNumber)
                {
                    WriteLine("Введенное число меньше загаданного, попробуйте еще");
                }
                else if (userNumber > iiNumber)
                {
                    WriteLine("Введенное число больше загаданного, попробуйте еще");
                }
                else
                {
                    WriteLine($"Вы угадали! Число попыток: {count}");
                    ReadKey();
                }
            }
        }
    }
}