﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.ProductName= "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { ID = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "kalem",UnitPrice=35 };//bu şekilde de yazılabilir.

            //PascalCase      //camelCase
            PruductManager pruductManager = new PruductManager();
            pruductManager.Add(product1);
            pruductManager.Add();
        
        }
    }
}
