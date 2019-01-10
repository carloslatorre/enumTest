using System;
using enumTest.Entities;
using enumTest.Entities.Enums;
namespace enumTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 2432,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };


            Console.WriteLine(order);
        }
    }
}
