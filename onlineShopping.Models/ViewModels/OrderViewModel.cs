using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace onlineShopping.Models.ViewModels
{
    public class OrderViewModel
    {
       
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }



        public Guid CustomerId { get; set; } 
        [Range(1, 15)]
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Range(0, 999999.99)]
        public Decimal TotalPrice { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        

    }
}
