using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program93
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите номер четверти (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int quarter) && quarter >= 1 && quarter <= 4)
            {
                string xSign, ySign;

                if (quarter == 1)
                {
                    xSign = "+";
                    ySign = "+";
                }
                else if (quarter == 2)
                {
                    xSign = "-";
                    ySign = "+";
                }
                else if (quarter == 3)
                {
                    xSign = "-";
                    ySign = "-";
                }
                else // quarter == 4
                {
                    xSign = "+";
                    ySign = "-";
                }

                Console.WriteLine($"Четверть {quarter}: X — {xSign}, Y — {ySign}");
            }
            else
            {
                Console.WriteLine("Ошибка: номер четверти должен быть от 1 до 4.");
            }
        }
    }
}