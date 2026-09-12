using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progib
{
    class ToDigits
    {
        public static int[] NumberToDigits(int number)
        {
            int[] digits = new int[number.ToString().Length];

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = number % 10;
                number = number / 10;
            }
            return digits;
        }
    }
}
