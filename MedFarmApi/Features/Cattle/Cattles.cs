using System.ComponentModel.DataAnnotations;

namespace MedFarmApi.Features.Cattle
{
    public class Cattles
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int IdNumber { get; set; }

        public DateTimeOffset? DateOfBirth { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public double? Length { get; set; }
        public string? Color { get; set; }
        public double? TailLength { get; set; }
        public double? HornLength { get; set; }
        public double? EarLength { get; set; }
        public int? Teeth { get; set; }
        public string? EyeColor { get; set; }
        public string? UdderColor { get; set; }
        public double? MilkCapacityInLiters { get; set; }
        public DateTimeOffset? DeliveryDate { get; set; }
        public string? MotherSideHistory { get; set; }
        public string? FatherSideHistory { get; set; }
        public string? Behaviour { get; set; }
        public string? HabitOfEating { get; set; }
        public string? Nature { get; set; }
    }
}
