using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace onlineShopping.Models.ViewModels
{
    public class ProductViewModel
    {


 
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

       
        public int AvailableQuantity { get; set; }

        
       
    }
}
