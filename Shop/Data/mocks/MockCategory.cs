﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8_Shop.Data.Interfaces;
using Lab8_Shop.Data.Models;

namespace Lab8_Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return new List<Category>
                { new Category{categoryName = "Электромобили", desc = "Современный вид транспорта"},
                  new Category{categoryName= "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
