using MedFarmApi.Features.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedFarmApi.Features.Product
{
    [Route("/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly DatabaseContext databaseContext;

        public ProductController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Products product)
        {
            var category = await databaseContext.Categories.FirstOrDefaultAsync(c => c.Id == product.CategoryId);
            if (category == null) return NotFound();

            product.CategoryId = category.Id;
            await databaseContext.AddAsync(product);
            await databaseContext.SaveChangesAsync();
            return Ok("Product Added !");
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var product = await databaseContext.Products.Include(product => product.Category).ToListAsync();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var product = await databaseContext.Products.Include(product => product.Category).FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet("byCategory/{id}")]
        public async Task<IActionResult> GetProductByCategoryId([FromRoute] int id)
        {
            var product = await databaseContext.Products.Include(product => product.Category).Where(p => p.CategoryId == id).ToListAsync();
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] int id, [FromBody] Products newProduct)
        {
            var product = await databaseContext.Products.Include(product => product.Category).FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) return NotFound();

            product.Name = newProduct.Name;
            product.Description = newProduct.Description;
            product.Price = newProduct.Price;
            product.ImageName = newProduct.ImageName;
            product.CategoryId = newProduct.CategoryId;

            await databaseContext.SaveChangesAsync();

            return Ok("Product Updated !");
        }

    }
}
