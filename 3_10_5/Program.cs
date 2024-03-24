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
            Write("Введите максимальное целое число диапазона: ");
            int secretNumber = new Random().Next(Convert.ToInt32(ReadLine()));

            while (true)
            {
                WriteLine("Попробуйте угадать число (пустая строка - выход):");
                string userInput = ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    WriteLine($"Было загадано число {secretNumber}");
                    break;
                }

                if (Convert.ToInt32(userInput) > secretNumber)
                {
                    WriteLine("Загаданное число меньше.\n");
                } 
                else if (Convert.ToInt32(userInput) < secretNumber)
                {
                    WriteLine("Загаданное число больше.\n");
                }
                else
                {
                    WriteLine("Число отгадано!");
                    break;
                }
            }
        }
    }
}
