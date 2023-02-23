using System.Linq;
using System.Text;
using GrosvenorDeveloperPracticum.Application.Services;
using GrosvenorDeveloperPracticum.Domain.Entities;

namespace GrosvenorDeveloperPracticum.Infrastructure.Services
{
    public class PrintService : IPrintService
    {
        public string FormatOutput(Order order)
        {
            StringBuilder stringBuilder = new StringBuilder();
            order.Dishes.OrderBy(x => x.DishType).GroupBy(y => y.Code).ToList().ForEach(x =>
            {
                var dishName = x.First().Name;
                var dishQuantity = x.Count();
                stringBuilder.Append(dishQuantity.Equals(1) ? $"{dishName}," : $"{dishName}(x{dishQuantity}),");
            });
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            return stringBuilder.ToString();
        }
    }
}
