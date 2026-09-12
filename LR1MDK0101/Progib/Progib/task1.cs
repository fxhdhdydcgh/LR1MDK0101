using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progib
{
    class task1
    {
        public static int NumbersInput()
        {
            Console.WriteLine("Введите число");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int[] NumberToDigits(int number)
        {
            int[] digits = new int[number.ToString().Length - 1];
            for (int i = 0; i < number.ToString().Length - 1; i++)
            {
                digits[i] = number % 10;
            }
            return digits;
        }
        public static int DigitsSum(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length - 1; i++)
            {
                sum += digits[i];
            }
            return sum;
        }
    }
}
