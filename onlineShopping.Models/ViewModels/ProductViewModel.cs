using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShopping.Models.ViewModels
{
    public class ProductViewModel
    {

        public string ProductId { get; set; }
        public string ProductName { get; set; }
       
        public int AvailableQuantity { get; set; }
    }
}
