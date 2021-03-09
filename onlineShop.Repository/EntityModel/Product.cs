using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShop.Repository.EntityModel
{
    public class Product
    {
       
        public string ProductId { get; set; }
        
        public string ProductName { get; set; }
        public int AvailableQuantity { get; set; }
    }
}
