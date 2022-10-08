// See https://aka.ms/new-console-template for more information

//Пользователь вводит целочисленное число (оно может быть как положительным, так и отрицательным).
//Нужно проверить, что число корректно без использования любого стороннего преобразования строки в число
//т.е. нельзя использовать int.Parse(), int.TryParse(), Convert.ToInt() и т.д..
//Если нет, то вывести сообщение и завершить программу. Если корретно, то опять же без вызова
//сторонних методов и без конвертирования строки в число найти сумму цифр введенного числа.


using System;
using System.Globalization;

namespace Laba5TheSecondTask
{
    class Program
    {
        static void Main()
        {   
            string a = Console.ReadLine();
            int it=0;
            bool flag=true;
            int j =0;
            if ((a[0] == '-'))
                j =1;
            else
                j =0;

            for (int i=j;i<a.Length;i++)
            {
                int indicatorCharIndex = a[i] - '0';
                if ((indicatorCharIndex >= 0) && (indicatorCharIndex < 10))
                {
                    it += indicatorCharIndex;
                }
                else
                {
                    flag= false;
                    break;
                }
            }
                
            if (flag)
            {
                Console.WriteLine(it);
            }
            else
            {
                Console.WriteLine("The number is incorrect");
            }
        }
    }
}