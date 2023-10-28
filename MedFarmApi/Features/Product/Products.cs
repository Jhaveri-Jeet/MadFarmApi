using System.ComponentModel.DataAnnotations.Schema;

namespace MedFarmApi.Features.Product
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public decimal Price { get; set; }

        public string? ImageName { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }
        public virtual Category.Categories? Category { get; set; }
    }
}
