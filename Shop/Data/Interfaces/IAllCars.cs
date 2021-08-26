using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8_Shop.Data.Models;

namespace Lab8_Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getCar(int carId);
    }
}
