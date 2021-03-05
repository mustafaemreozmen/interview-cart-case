using System.Threading.Tasks;
using Interview.CartCase.Domain.Entities;
using Interview.CartCase.Domain.Results;

namespace Interview.CartCase.Application.Interfaces.Services
{
    public interface ICartService
    {
         Task<DataResult<Cart>> GetCart(string id);
         Task<DataResult<Cart>> CreateCart(Cart cart);
         Task<DataResult<Cart>> UpdateCart(string id, Cart cart);
         Task<DataResult<Cart>> DeleteCart(string id);
    }
}