﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Prices prices = new Prices();
            Price price1 = new Price("Milk", "Varus", 21.9);
            Price price2 = new Price("Milk", "ATB", 20.9);
            Price price3 = new Price("Bread", "Varus", 11.5);

            prices.addProduct(price1);
            prices.addProduct(price2);
            prices.addProduct(price3);

            prices.Print();
            prices.nameOrder();
            prices.userConditionOrder();
            Console.ReadLine();
        }
    }
}
