using GrosvenorDeveloperPracticum.Domain.Enums;

namespace GrosvenorDeveloperPracticum.Domain.Entities
{
    /// <summary>
    /// Contains a dish by name and number of times the dish has been ordered
    /// </summary>
    public class MenuDish
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public DishTypeEnum DishType { get; set; }
        public MenuPeriodsEnum AvailableDuringPeriod { get; set; }
        public bool CanOrderMultiples { get; set; }
    }
}