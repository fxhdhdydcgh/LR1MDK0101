using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progib
{
    class InvertModule
    {
        public static string InvertNumber(int[] digits)
        {
            string invertedNumber = "";
            for (int i = 0; i < digits.Length; i++)
            {
                invertedNumber = invertedNumber + digits[i];
            }
            return invertedNumber;
        }
    }
}
