using System;
using Chel.TaxiApp.Domain.Common;

namespace Chel.TaxiApp.Domain.Passenger
{
    public class OrderService
    {
        public TakeOrderInfo TakeOrder(Order order)
        {
            return new TakeOrderInfo()
            {
                Id = Guid.NewGuid().ToString()
            };
        }
    }
}