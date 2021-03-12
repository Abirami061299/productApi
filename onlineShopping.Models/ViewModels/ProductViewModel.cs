using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace onlineShopping.Models.ViewModels
{
    public class ProductViewModel
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        [MinLength(3), MaxLength(15)]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal UnitPrice { get; set; }

        [Range(1, 15)]
        public int AvailableQuantity { get; set; }
        
        
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

    }
}
