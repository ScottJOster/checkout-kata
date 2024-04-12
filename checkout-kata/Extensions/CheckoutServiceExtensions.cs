using checkout_kata.CheckoutLogic;
using Microsoft.Extensions.DependencyInjection;


namespace checkout_kata.Extensions
{
    public static class CheckoutServiceExtensions
    {
        public static IServiceCollection AddCheckoutService(this IServiceCollection services)
        {
            services.AddScoped<ICheckout, Checkout>();
            return services;
        }

    }
}
