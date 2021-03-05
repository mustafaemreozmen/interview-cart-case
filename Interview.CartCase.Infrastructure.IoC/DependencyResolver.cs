using Interview.CartCase.Application.Interfaces.Services;
using Interview.CartCase.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Interview.CartCase.Domain.Interfaces;
using Interview.CartCase.Persistence.Repositories;

namespace Interview.CartCase.Infrastructure.IoC
{
    public class DependencyResolver
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartService, CartService>();

            services.AddScoped<ICartItemRepository, CartItemRepository>();
            services.AddScoped<ICartItemService, CartItemService>();
        }
    }
}