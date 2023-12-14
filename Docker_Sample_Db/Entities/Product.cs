using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Docker_Sample_Db.Entities
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("product_name")]
        public string? ProductName { get; set; }

        [Column("product_detail")]
        public string? ProductDetail { get; set; }

        [Column("product_price")]
        public decimal ProductPrice { get; set; }
    }
}
