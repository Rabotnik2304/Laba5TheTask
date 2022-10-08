// See https://aka.ms/new-console-template for more information

using System;


namespace Laba5TheFourthTask
{
    class Program1
    {
        static void Main()
        {
            double[] inputArray = { 8, -5, -12.067, 45.11934 };
            double[] returnArray = new double[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                double variable1 = inputArray[i];

                if ((inputArray[i] > 0) & (inputArray[i]) == (int)inputArray[i])
                    variable1 = Factorial(inputArray[i]);
                else if ((inputArray[i]) != (int)inputArray[i])
                    variable1 = HighlightingHundredths(inputArray[i]);

                returnArray[i] = variable1;
            }
            ReturnOfArrays(inputArray, returnArray);
        }

        private static void ReturnOfArrays(double[] array1, double[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
        }

        private static double HighlightingHundredths(double variable2)
        {
            variable2 = Math.Round(variable2, 2);
            variable2 = (variable2 * 100) % 100;
            variable2 = Math.Abs(variable2);
            return variable2;
        }

        private static int Factorial(double variable2)
        {
            int factorial = 1;
            for (int j = 1; j <= variable2; j++)
            {
                factorial *= j;
            }

            return factorial;
        }
    }
}



