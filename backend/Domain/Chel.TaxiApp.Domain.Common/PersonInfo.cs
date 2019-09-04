namespace Chel.TaxiApp.Domain.Common
{
    /// <summary>
    /// Информация о человеке
    /// </summary>
    public class PersonInfo
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; }
    }
}