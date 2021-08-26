using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8_Shop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Lab8_Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car { name = "Tesla Model S", shortDesc = "удобный и тихий", longDesc = "Очень комфортный автомобиль, оснащенный всеми новейшими технологиями", img = "/img/tesla.jpg", price = 45000, isFavourite = true, available = true, Category = Categories["Электромобили"] },
                    new Car { name = "BMW X5", shortDesc = "Стильный и модный", longDesc = "Быстрый, комфортный автомобиль, полноприводный, с хорошей шумоизоляцией", img = "/img/x5.jpg", price = 60000, isFavourite = true, available = true, Category = Categories["Классические автомобили"] },
                    new Car { name = "Mercedes C class", shortDesc = "стиль и комфорт", longDesc = "Автомобиль для города, супер комфортный, тихий", img = "/img/cClass.jpg", price = 25000, isFavourite = false, available = false, Category = Categories["Классические автомобили"] },
                    new Car { name = "Skoda Octavia", shortDesc = "Бюджетный и практичный", longDesc = "Автомобиль для семьи, оснащен всеми свежими технологиями для комфортной езды", img = "/img/Ocravia.jpg", price = 15000, isFavourite = true, available = true, Category = Categories["Классические автомобили"] },
                    new Car { name = "Renault Logan", shortDesc = "Бюджетный и семейный", longDesc = "Недорогой автомобиль для семьи, как в городе так и в деревне", img = "/img/Logan.jpg", price = 10000, isFavourite = true, available = true, Category = Categories["Классические автомобили"] }
                );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category{categoryName= "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
