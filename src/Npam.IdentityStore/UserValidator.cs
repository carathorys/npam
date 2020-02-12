using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Npam.Interop;

namespace Npam.IdentityStore
{
    public class UserValidator<T> : IUserValidator<T> where T : AccountInfo
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<T> manager, T user)
        {
            var userId = await manager.GetUserIdAsync(user);
            return !string.IsNullOrWhiteSpace(userId) ? IdentityResult.Success : IdentityResult.Failed();
        }
    }
}