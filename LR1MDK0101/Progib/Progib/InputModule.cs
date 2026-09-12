using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progib
{
    class InputModule
    {
        public static int NumbersInput()
        {
            Console.WriteLine("Введите число");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
