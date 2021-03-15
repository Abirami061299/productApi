using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace onlineShop.Repository.EntityModel
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }

        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerId { get; set; }
        [Range(1, 15)]
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Range(0, 999999.99)]
        public Decimal TotalPrice { get; set; }

        public DateTime OrderedDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        

    }
}
