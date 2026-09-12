using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progib
{
    class Program
    {
       
        static void Main(string[] args)
        {

        }
       private int NumbersInput()
        {
            Console.WriteLine("Введите число");
            return Convert.ToInt32(Console.ReadLine());
        }
        private int[] NumberToDigits(int number)
        {
            int[] digits = { };
            for (int i = 0; i < number.ToString().Length; i++)
            {
                digits[i] = number / 10;
            }
            return digits;
        }
    }
}
