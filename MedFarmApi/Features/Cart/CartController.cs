using MedFarmApi.Features.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MadFarmApi.Features.Cart
{
    [Route("/[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        private readonly DatabaseContext databaseContext;

        public CartController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddCart([FromBody] Cart cart)
        {
            await databaseContext.AddAsync(cart);
            await databaseContext.SaveChangesAsync();
            return Ok(cart);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cart = await databaseContext.Cart.ToListAsync();
            if(cart is null) return NotFound();

            return Ok(cart);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var cart = await databaseContext.Cart.FirstOrDefaultAsync(x => x.Id == id);
            if(cart is null) return NotFound();

            return Ok(cart);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart([FromRoute] int id)
        {
            var cart  = await databaseContext.Cart.FirstOrDefaultAsync(x => x.Id == id);
            if(cart is null) return NotFound();

            databaseContext.Cart.Remove(cart);
            await databaseContext.SaveChangesAsync();

            return Ok("Cart Deleted !");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCart([FromRoute] int id, [FromBody] Cart newCart)
        {
            var cart = await databaseContext.Cart.FirstOrDefaultAsync(x => x.Id == id);
            if (cart is null) return NotFound();

            cart.Price = newCart.Price;
            cart.Quantity = newCart.Quantity;
            cart.Date = newCart.Date;
            cart.Status = newCart.Status;
            cart.UserId = newCart.UserId;
            cart.ProductId = newCart.ProductId;

            await databaseContext.SaveChangesAsync();
            return Ok("Cart Updated !");
        }
    }
}
