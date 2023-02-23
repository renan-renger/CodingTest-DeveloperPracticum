using GrosvenorDeveloperPracticum.Application.Services;
using GrosvenorDeveloperPracticum.Domain.Entities;
using System;

namespace GrosvenorDeveloperPracticum.Infrastructure.Services
{
    public class WaiterService : IWaiterService
    {
        private readonly IOrderService _orderService;
        private readonly IPrintService _printService;

        public WaiterService(IOrderService orderService, IPrintService printService)
        {
            _orderService = orderService;
            _printService = printService;
        }

        public string TakeOrder(string unparsedOrder)
        {
            if (string.IsNullOrEmpty(unparsedOrder))
                return "error";

            Order order = _orderService.ParseOrder(unparsedOrder);

            if (order == null) return "error";

            return _printService.FormatOutput(order);
        }
    }
}
