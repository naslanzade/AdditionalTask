using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    class Product
    {

        public  int Id { get; set; }
        public string Name { get; set; }        
        public int Count { get; set; }
        public double Price { get; set; }
        public bool IsDeleted { get; set; }

        

        public Product(string ProductName,int ProductCount, double ProductPrice,bool ProductIsDeletd)
        {
            
            Name = ProductName;
            Count = ProductCount;
            Price = ProductPrice;
            IsDeleted = ProductIsDeletd;
        }







    }
}
