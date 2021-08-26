using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8_Shop.Data.Interfaces;
using Lab8_Shop.Data.Models;

namespace Lab8_Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars { get {
                return new List<Car>
                {
                    new Car{name="Tesla Model S", shortDesc = "удобный и тихий", longDesc="Очень комфортный автомобиль, оснащенный всеми новейшими технологиями", img="/img/tesla.jpg", price=45000, isFavourite=true, available = true, Category =_categoryCars.AllCategories.First()},
                    new Car{name="BMW X5", shortDesc = "Стильный и модный", longDesc="Быстрый, комфортный автомобиль, полноприводный, с хорошей шумоизоляцией", img="/img/x5.jpg", price=60000, isFavourite=true, available = true, Category =_categoryCars.AllCategories.Last()},
                    new Car{name="Mercedes C class", shortDesc = "стиль и комфорт", longDesc="Автомобиль для города, супер комфортный, тихий", img="/img/cClass.jpg", price=25000, isFavourite=false, available = false, Category =_categoryCars.AllCategories.Last()},
                    new Car{name="Skoda Octavia", shortDesc = "Бюджетный и практичный", longDesc="Автомобиль для семьи, оснащен всеми свежими технологиями для комфортной езды", img="/img/Ocravia.jpg", price=15000, isFavourite=true, available = true, Category =_categoryCars.AllCategories.Last()},
                    new Car{name="Renault Logan", shortDesc = "Бюджетный и семейный", longDesc="Недорогой автомобиль для семьи, как в городе так и в деревне", img="/img/Logan.jpg", price=10000, isFavourite=true, available = true, Category =_categoryCars.AllCategories.Last()},
                };
            } 
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
