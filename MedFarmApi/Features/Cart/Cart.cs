using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MadFarmApi.Features.Cart
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Date { get; set; }
        public string? Status { get; set; }

        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
        public virtual User.User? User { get; set; }

        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }
        public virtual MedFarmApi.Features.Product.Products? Product { get; set; }

    }
}
