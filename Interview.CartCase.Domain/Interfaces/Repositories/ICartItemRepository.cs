using Interview.CartCase.Domain.Entities;

namespace Interview.CartCase.Domain.Interfaces
{
    public interface ICartItemRepository: IBaseRepository<CartItem, string>
    {
    }
}
