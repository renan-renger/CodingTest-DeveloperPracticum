using GrosvenorDeveloperPracticum.Application.Services;
using GrosvenorDeveloperPracticum.Domain.Entities;
using System.Collections.Generic;

namespace GrosvenorDeveloperPracticum.Infrastructure.Services
{
    public class MenuService : IMenuService
    {
        public IList<MenuDish> LoadMenu()
        {
            IList<MenuDish> menuDishes = new List<MenuDish>
            {
                new MenuDish() { Code = 1, Name = "egg", DishType = Domain.Enums.DishTypeEnum.Entree, AvailableDuringPeriod = Domain.Enums.MenuPeriodsEnum.Morning, CanOrderMultiples = false },
                new MenuDish() { Code = 2, Name = "toast", DishType = Domain.Enums.DishTypeEnum.Side, AvailableDuringPeriod = Domain.Enums.MenuPeriodsEnum.Morning, CanOrderMultiples = false },
                new MenuDish() { Code = 3, Name = "coffee", DishType = Domain.Enums.DishTypeEnum.Drink, AvailableDuringPeriod = Domain.Enums.MenuPeriodsEnum.Morning, CanOrderMultiples = true },

                new MenuDish() { Code = 1, Name = "steak", DishType = Domain.Enums.DishTypeEnum.Entree, AvailableDuringPeriod = Domain.Enums.MenuPeriodsEnum.Evening, CanOrderMultiples = false },
                new MenuDish() { Code = 2, Name = "potato", DishType = Domain.Enums.DishTypeEnum.Side, AvailableDuringPeriod = Domain.Enums.MenuPeriodsEnum.Evening, CanOrderMultiples = true },
                new MenuDish() { Code = 3, Name = "wine", DishType = Domain.Enums.DishTypeEnum.Drink, AvailableDuringPeriod = Domain.Enums.MenuPeriodsEnum.Evening, CanOrderMultiples = false },
                new MenuDish() { Code = 4, Name = "cake", DishType = Domain.Enums.DishTypeEnum.Dessert, AvailableDuringPeriod = Domain.Enums.MenuPeriodsEnum.Evening, CanOrderMultiples = false }
            };

            return menuDishes;
        }
    }
}
