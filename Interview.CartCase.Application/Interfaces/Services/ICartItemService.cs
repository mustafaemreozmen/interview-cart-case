using System.Threading.Tasks;
using Interview.CartCase.Domain.Entities;
using Interview.CartCase.Domain.Results;

namespace Interview.CartCase.Application.Interfaces.Services
{
    public interface ICartItemService
    {
         Task<DataResult<CartItem>> GetCartItem(string id);
         Task<DataResult<CartItem>> CreateCartItem(CartItem cart);
         Task<DataResult<CartItem>> UpdateCartItem(string id, CartItem cart);
         Task<DataResult<CartItem>> DeleteCartItem(string id);
    }
}