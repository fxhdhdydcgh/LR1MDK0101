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
            int orderCost = -1;
            while (orderCost < 0) {
                InputNumber.Input("расстояние доставки (км)");
            }
            try
            {
                InputNumber.Input("расстояние доставки (км)");
            }
            catch (FormatException)
            {

                InputNumber.Input("расстояние доставки (км)");
            }
            int distance = -1;
            while (distance < 0)
            {
                InputNumber.Input("расстояние доставки (км)");
            }
            try
            {
                InputNumber.Input("расстояние доставки (км)");
            }
            catch (FormatException)
            {

                InputNumber.Input("расстояние доставки (км)");
            }
            int time = -1;
            while (time >23 || time <0)
            {
                time = InputNumber.Input("время заказа (час)");
            }
            try
            {
                InputNumber.Input("расстояние доставки (км)");
            }
            catch (FormatException)
            {

                time = InputNumber.Input("время заказа (час)");
            }
            float deliveryCost = CalculateCost.CalculateDelivery(orderCost, distance, time);
            Console.WriteLine("Стоимость доставки: " + deliveryCost);
            Console.WriteLine("Итого к оплате: " + CalculateCost.CalculateTotal(deliveryCost, orderCost));
        }
    }
}
