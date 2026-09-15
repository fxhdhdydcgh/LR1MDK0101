using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal class Task1
    {
        public static void TaskStart()
        {
            int orderCost = InputNumber.Input("стоимость заказа (руб.)");
            int distance = InputNumber.Input("расстояние доставки (км)");
            int time = InputNumber.Input("время заказа (час)");
            float deliveryCost = CalculateCost.CalculateDelivery(orderCost, distance, time);
            Console.WriteLine("Стоимость доставки: " + deliveryCost);
            Console.WriteLine("Итого к оплате: " + CalculateCost.CalculateTotal(deliveryCost, orderCost));
        }
    }
}
