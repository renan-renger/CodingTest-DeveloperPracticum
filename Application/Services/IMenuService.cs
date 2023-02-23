using GrosvenorDeveloperPracticum.Domain.Entities;
using System.Collections.Generic;

namespace GrosvenorDeveloperPracticum.Application.Services
{
    public interface IMenuService
    {
        public IList<MenuDish> LoadMenu();
    }
}
