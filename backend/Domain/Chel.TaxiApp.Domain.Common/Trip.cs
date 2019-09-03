namespace Chel.TaxiApp.Domain.Common
{
    /// <summary>
    /// Поездка
    /// </summary>
    public class Trip
    {
        /// <summary>
        /// Транспортное средство
        /// </summary>
        public Vehicle Vehicle{get;set;}

        /// <summary>
        /// Информация о заказе
        /// </summary>
        public Order Order{get;set;}
    }
}