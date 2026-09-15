using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal class CalculateCost
    {

        public static float CalculateDelivery(int orderSum, int distanceKm, int time)
        {
            if (orderSum >= 2000) return 0;
            int baseCost = 150;
            float finalCost = 0;
            finalCost = distanceKm > 3 ? baseCost * (distanceKm - 3) : baseCost;
            finalCost = (time >= 12 && time <= 14 || time >= 18 && time <= 20) ? finalCost * 1.3f : finalCost;
            return finalCost;
        }
       
    }
}
