using Microsoft.AspNetCore.Identity;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPamStores(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUserStore<>), typeof(Npam.IdentityStore.UserStore<>));
            services.AddScoped(typeof(IRoleStore<>), typeof(Npam.IdentityStore.RoleStore<>));
            return services;
        }
    }
}