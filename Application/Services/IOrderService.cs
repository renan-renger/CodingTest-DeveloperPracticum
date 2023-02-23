using GrosvenorDeveloperPracticum.Domain.Entities;

namespace GrosvenorDeveloperPracticum.Application.Services
{
    public interface IOrderService
    {
        public Order ParseOrder(string orderString);
    }
}
