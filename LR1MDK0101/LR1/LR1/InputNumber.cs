using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal class InputNumber
    {
        public static int Input(string neededData)
        {
            Console.WriteLine($"Введите {neededData}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
