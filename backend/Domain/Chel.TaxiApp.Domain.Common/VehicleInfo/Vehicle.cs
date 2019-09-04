namespace Chel.TaxiApp.Domain.Common
{
    /// <summary>
    /// Транспортное средство
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Марка машины
        /// </summary>
        public VehicleMark Mark { get; set; }

        /// <summary>
        /// Водитель
        /// </summary>
        public Driver Driver { get; set; }
    }
}