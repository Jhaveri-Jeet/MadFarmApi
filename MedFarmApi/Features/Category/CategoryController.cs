using MedFarmApi.Features.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace MedFarmApi.Features.Category
{
    [Route("/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly DatabaseContext databaseContext;
        public CategoryController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [HttpPost]

        public async Task<IActionResult> AddCategory([FromBody] Categories category)
        {
            await databaseContext.AddAsync(category);
            await databaseContext.SaveChangesAsync();
            return Ok("Category Inserted !");
        }

        [HttpGet]
        public async Task<IActionResult> GetCategory()
        {
            var category = await databaseContext.Categories.ToListAsync();
            return Ok(category);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] int id)
        {
            var category = await databaseContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            var category = await databaseContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            databaseContext.Remove(category);
            await databaseContext.SaveChangesAsync();
            return Ok("Category Deleted !");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([FromRoute] int id, [FromBody] Categories newCategory)
        {
            var category = await databaseContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            category.Title = newCategory.Title;
            category.Description = newCategory.Description;
            await databaseContext.SaveChangesAsync();
            return Ok("Category Updated !");
        }
    }
}
