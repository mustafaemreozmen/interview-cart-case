using System.Threading.Tasks;
using Interview.CartCase.Application.Interfaces.Services;
using Interview.CartCase.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Interview.CartCase.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartItemsController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;
        public CartItemsController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartItem(string id)
        {
            var result = await _cartItemService.GetCartItem(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCartItem([FromBody] CartItem cartItem)
        {
            var result = await _cartItemService.CreateCartItem(cartItem);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCartItem(string id, [FromBody] CartItem cartItem)
        {
            var result = await _cartItemService.UpdateCartItem(id, cartItem);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItem(string id)
        {
            var result = await _cartItemService.DeleteCartItem(id);
            if (result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }
    }
}
