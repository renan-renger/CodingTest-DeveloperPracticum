using GrosvenorDeveloperPracticum.Domain.Enums;
using System.Collections.Generic;

namespace GrosvenorDeveloperPracticum.Domain.Entities
{
    public class Order
    {
        public MenuPeriodsEnum TimeOfDay { get; set; }
        public List<MenuDish> Dishes { get; set; }
    }
}