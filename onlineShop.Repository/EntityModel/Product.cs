using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineShop.Repository.EntityModel
{
    public class Product
    {
        [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        [MinLength(3),MaxLength(15)]
        public string ProductName { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Range(0, 999999.99)]
        public decimal UnitPrice { get; set; }

        [Range(1,15)]
        public int AvailableQuantity { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public static void UpdateQuantity(object productId, object quantity)
        {
            throw new NotImplementedException();
        }
    }
}
