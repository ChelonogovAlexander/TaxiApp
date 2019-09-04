namespace Chel.TaxiApp.Domain.Common
{
    /// <summary>
    /// Информация о локации
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Координаты
        /// </summary>
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Название локации
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }
    }
}