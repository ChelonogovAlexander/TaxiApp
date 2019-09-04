using System.Collections.Generic;
namespace Chel.TaxiApp.Domain.Common
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Заказчик
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        /// Стартовая позиция
        /// </summary>
        public Location StartLocation { get; set; }

        /// <summary>
        /// Конечная точка
        /// </summary>
        public Location EndLocation { get; set; }

        /// <summary>
        /// Промежуточные точки остановки
        /// </summary>
        public List<Location> IntermediateLocations { get; set; }
    }
}