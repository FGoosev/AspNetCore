using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab8_Shop.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        public List<Car> cars { get; set; }

    }
}
