﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8_Shop.Data.Models;

namespace Lab8_Shop.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
