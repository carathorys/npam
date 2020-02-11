using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Npam.Interop;

namespace Npam.IdentityStore
{
    public class PamUserManager<T> : Microsoft.AspNetCore.Identity.UserManager<T> where T : AccountInfo
    {
        public PamUserManager(
            IUserStore<T> store,
            IOptions<IdentityOptions> optionsAccessor,
            IPasswordHasher<T> passwordHasher,
            IEnumerable<IUserValidator<T>> userValidators,
            IEnumerable<IPasswordValidator<T>> passwordValidators,
            ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors,
            IServiceProvider services,
            ILogger<PamUserManager<T>> logger) : base(store,
            optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services,
            logger)
        {
        }
    }
}