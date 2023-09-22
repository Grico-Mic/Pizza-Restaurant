using Pizza_Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Restaurant.Services.Interfaces
{
    public interface IMenuItemService
    {
        List<MenuItem> GetAll();
        MenuItem GetById(int id);
    }
}
