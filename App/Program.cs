using App.Entities;
using App.Entities.Enums;
using System;

namespace App // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            OrderStatus os1 = (OrderStatus)2;
            Console.WriteLine(os1);

            int n1 = (int)OrderStatus.Processing;
            Console.WriteLine(n1);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            
        }
    }
}