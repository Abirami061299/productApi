using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineShopping.Models.ViewModels
{
    public class OrderViewModel
    {
       
     
        public Guid ProductId { get; set; }



       
        public int Quantity { get; set; }

       
        public Decimal TotalPrice { get; set; }

       

        

    }
}
