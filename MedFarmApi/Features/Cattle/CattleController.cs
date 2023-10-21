using MedFarmApi.Features.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace MedFarmApi.Features.Cattle
{
    [Route("/[controller]")]
    [ApiController]
    public class CattleController : Controller
    {
        private readonly DatabaseContext databaseContext;

        public CattleController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddCattle([FromBody] Cattles cattle)
        {
            await databaseContext.AddAsync(cattle);
            await databaseContext.SaveChangesAsync();
            return Ok("Cattle Added !");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Cattle = await databaseContext.Cattles.ToListAsync();
            return Ok(Cattle);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var cattle = await databaseContext.Cattles.FirstOrDefaultAsync(c => c.Id == id);
            return (cattle == null) ? NotFound() : Ok(cattle);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCattle([FromRoute] int id)
        {
            var cattle = await databaseContext.Cattles.FirstOrDefaultAsync(c => c.Id == id);
            if (cattle == null) return NotFound();
            databaseContext.Cattles.Remove(cattle);
            await databaseContext.SaveChangesAsync();
            return Ok("Cattle Deleted");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCattle([FromRoute] int id, [FromBody] Cattles cattle)
        {
            var cattles = await databaseContext.Cattles.FirstOrDefaultAsync(c => c.Id == id);
            if (cattles == null) return NotFound();

            cattles.Name = cattle.Name;
            cattles.Gender = cattle.Gender;
            cattles.IdNumber = cattle.IdNumber;
            cattles.DateOfBirth = cattle.DateOfBirth;
            cattles.Weight = cattle.Weight;
            cattles.Height = cattle.Height;
            cattles.Length = cattle.Length;
            cattles.Color = cattle.Color;
            cattles.TailLength = cattle.TailLength;
            cattles.HornLength = cattle.HornLength;
            cattles.EarLength = cattle.EarLength;
            cattles.Teeth = cattle.Teeth;
            cattles.EyeColor = cattle.EyeColor;
            cattles.UdderColor = cattle.UdderColor;
            cattles.MilkCapacityInLiters = cattle.MilkCapacityInLiters;
            cattles.DeliveryDate = cattle.DeliveryDate;
            cattles.MotherSideHistory = cattle.MotherSideHistory;
            cattles.FatherSideHistory = cattle.FatherSideHistory;
            cattles.Behaviour = cattle.Behaviour;
            cattles.HabitOfEating = cattle.HabitOfEating;
            cattles.Nature = cattle.Nature;

            await databaseContext.SaveChangesAsync();
            return Ok("Cattle Updated !");
        }
    }
}
