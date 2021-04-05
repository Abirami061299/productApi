using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onlineShop.Repository.EntityModel
{
    public class Product
    {
        [Key]
        [Required]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        [Required]
        [MinLength(3),MaxLength(15)]
        public string ProductName { get; set; }
        
        [Column(TypeName = "decimal(8, 2)")]
        [Range(0, 999999.99)]
        [Required]
        public decimal UnitPrice { get; set; }

        [Range(1,15)]
        [Required]
        public int AvailableQuantity { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        
    }
}
