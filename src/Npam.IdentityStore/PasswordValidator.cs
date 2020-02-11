using System.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Npam.Interop;

namespace Npam.IdentityStore
{
    public class PasswordValidator<T> : IPasswordValidator<T> where T : AccountInfo
    {
        public Task<IdentityResult> ValidateAsync(Microsoft.AspNetCore.Identity.UserManager<T> manager, T user, string password)
        {
            return Task.FromResult(NpamUser.Authenticate("App", user.Username, password)
                ? IdentityResult.Success
                : IdentityResult.Failed());
        }
    }
}