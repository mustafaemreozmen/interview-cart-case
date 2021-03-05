using System.Threading.Tasks;
using Interview.CartCase.Application.Interfaces.Services;
using Interview.CartCase.Domain.Entities;
using Interview.CartCase.Domain.Interfaces;
using Interview.CartCase.Domain.Results;

namespace Interview.CartCase.Application.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly ICartItemRepository _cartItemRepository;
        public CartItemService(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<DataResult<CartItem>> CreateCartItem(CartItem cart)
        {
            CartItem result = new CartItem();
            try
            {
                result = await _cartItemRepository.InsertAsync(cart);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<CartItem>($"Remove operation error: {ex.Message}", result);
            }
            return new SuccessDataResult<CartItem>("Data successfully removed", result);
        }

        public async Task<DataResult<CartItem>> DeleteCartItem(string id)
        {
            CartItem result = new CartItem();
            try
            {
                result = await _cartItemRepository.DeleteAsync(id);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<CartItem>($"Remove operation error: {ex.Message}", result);
            }
            return new SuccessDataResult<CartItem>("Data successfully removed", result);
        }

        public async Task<DataResult<CartItem>> GetCartItem(string id)
        {
            CartItem result = new CartItem();
            try
            {
                result = await _cartItemRepository.GetAsync(x => x.Id == id);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<CartItem>($"Remove operation error: {ex.Message}", result);
            }
            return new SuccessDataResult<CartItem>("Data successfully removed", result);
        }

        public async Task<DataResult<CartItem>> UpdateCartItem(string id, CartItem cart)
        {
            CartItem result = new CartItem();
            try
            {
                result = await _cartItemRepository.UpdateAsync(id, cart);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<CartItem>($"Remove operation error: {ex.Message}", result);
            }
            return new SuccessDataResult<CartItem>("Data successfully removed", result);
        }
    }
}