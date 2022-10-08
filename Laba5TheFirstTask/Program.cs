// See https://aka.ms/new-console-template for more information
//Пользователь вводит число. Если это целочисленное число (int.TryParse(...)),
//то вывести на экран символ соответствующий этому числу. Если это число с плавающей запятой,
//то сравнить это число с предыдущим введенным (float.NaN). Если эти числа равны, прекратить ввод,
//иначе повторить ввод. Также выполнение программы прекращается, если ввести символ q.
using System;

namespace Laba5TheFirstTask
{
    class Program
    {
        static void Main()
        {
            float floatNumberBefore = float.NaN;
            // Сравнивать с любым предыдущим введенным числом или именно с предыдущим числом типа Float?
            while (true)
            {
                string a = Console.ReadLine();
                if (a == "q")
                    return;
                if (int.TryParse(a, out int intNumber))
                {
                    Console.WriteLine((char)intNumber);
                    return;
                    //Если введено целочисленное число ввод продолжать или нет?
                }
                if (float.TryParse(a, out float floatNumber))
                {
                    if (floatNumberBefore == floatNumber)
                        return;
                    floatNumberBefore = floatNumber;
                }
            }
        }
    }
}