using System.ComponentModel.DataAnnotations;

namespace MedFarmApi.Features.Category
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public static implicit operator int(Categories v)
        {
            throw new NotImplementedException();
        }
    }
}
