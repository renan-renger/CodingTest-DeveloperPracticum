using GrosvenorDeveloperPracticum.Domain.Entities;

namespace GrosvenorDeveloperPracticum.Application.Services
{
    public interface IPrintService
    {
        public string FormatOutput(Order order);
    }
}
