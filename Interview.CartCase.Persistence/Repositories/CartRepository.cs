using Interview.CartCase.Domain.Entities;
using Interview.CartCase.Domain.Interfaces;

namespace Interview.CartCase.Persistence.Repositories
{
    public class CartRepository: BaseRepository<Cart>, ICartRepository
    {
    }
}
