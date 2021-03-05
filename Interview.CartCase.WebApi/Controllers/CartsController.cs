using System.Threading.Tasks;
using Interview.CartCase.Application.Interfaces.Services;
using Interview.CartCase.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Interview.CartCase.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCart(string id)
        {
            var result = await _cartService.GetCart(id);
            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCart([FromBody] Cart cart)
        {
            var result = await _cartService.CreateCart(cart);
            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCart(string id, [FromBody] Cart cart)
        {
            var result = await _cartService.UpdateCart(id, cart);
            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(string id)
        {
            var result = await _cartService.DeleteCart(id);
            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result.Message);
        }
    }
}
