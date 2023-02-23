using GrosvenorDeveloperPracticum.Application.Services;
using GrosvenorDeveloperPracticum.Domain.Entities;
using GrosvenorDeveloperPracticum.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrosvenorDeveloperPracticum.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMenuService _menuService;
        private static IList<MenuDish> _menuDishes;

        public OrderService(IMenuService menuService) {
            _menuService = menuService;
            _menuDishes = _menuService.LoadMenu();
        }

        public Order ParseOrder(string orderString)
        {
            if (string.IsNullOrWhiteSpace(orderString))
            {
                return null;
            }

            var orderComponents = orderString.Split(',');
            try
            {
                var order = new Order() { TimeOfDay = Enum.Parse<MenuPeriodsEnum>(orderComponents[0], true), Dishes = new List<MenuDish>() };
                orderComponents.Skip(1).ToList().ForEach(orderDish => {
                    order.Dishes.Add(_menuDishes.FirstOrDefault(x => x.AvailableDuringPeriod.Equals(order.TimeOfDay) && x.Code.Equals(int.Parse(orderDish))));
                });
                if (!ValidadeOrder(order)) { return null; }
                return order;

            }
            catch {
                return null;
            }
        }

        private bool ValidadeOrder(Order processingOrder)
        {
            return processingOrder.Dishes.All(x => x != null) && processingOrder.Dishes.GroupBy(x => x.Code).Where(y => y.Count() > 1).All(z => z.All(w => w.CanOrderMultiples.Equals(true)));
        }
    }
}
