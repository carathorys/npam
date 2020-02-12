using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Npam.Interop;

namespace Npam.IdentityStore
{
    public class UserStore<T> : IUserStore<T> where T : AccountInfo

    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public async Task<string> GetUserIdAsync(T user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<string> GetUserNameAsync(T user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task SetUserNameAsync(T user, string userName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<string> GetNormalizedUserNameAsync(T user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task SetNormalizedUserNameAsync(T user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IdentityResult> CreateAsync(T user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IdentityResult> UpdateAsync(T user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IdentityResult> DeleteAsync(T user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<T> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<T> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}