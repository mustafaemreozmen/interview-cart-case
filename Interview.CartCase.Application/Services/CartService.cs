using System.Threading.Tasks;
using Interview.CartCase.Application.Interfaces.Services;
using Interview.CartCase.Domain.Entities;
using Interview.CartCase.Domain.Interfaces;
using Interview.CartCase.Domain.Results;

namespace Interview.CartCase.Application.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<DataResult<Cart>> CreateCart(Cart cart)
        {
            Cart result = new Cart();
            try
            {
                result = await _cartRepository.InsertAsync(cart);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<Cart>($"Remove operation error: {ex.Message}", result);
            }
            return new SuccessDataResult<Cart>("Data successfully removed", result);
        }

        public async Task<DataResult<Cart>> DeleteCart(string id)
        {
            Cart result = new Cart();
            try
            {
                result = await _cartRepository.DeleteAsync(id);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<Cart>($"Remove operation error: {ex.Message}", result);
            }
            return new SuccessDataResult<Cart>("Data successfully removed", result);
        }

        public async Task<DataResult<Cart>> GetCart(string id)
        {
            Cart result = new Cart();
            try
            {
                result = await _cartRepository.GetAsync(x => x.Id == id);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<Cart>($"Fetching error: {ex.Message}", result);
            }
            return new SuccessDataResult<Cart>("Data successfully fetched", result);
        }

        public async Task<DataResult<Cart>> UpdateCart(string id, Cart cart)
        {
            Cart result = new Cart();
            try
            {
                result = await _cartRepository.UpdateAsync(id, cart);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<Cart>($"Fetching error: {ex.Message}", result);
            }
            return new SuccessDataResult<Cart>("Data successfully fetched", result);
        }
    }
}