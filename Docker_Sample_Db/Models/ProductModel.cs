using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Docker_Sample_Db.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? ProductDetail { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
