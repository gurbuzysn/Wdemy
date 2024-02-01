using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Domain.Enums;

namespace Wdemy.Persistence.Interfaces.Services
{
    public interface IAccountService
    {
        Task<bool> AnyAsync(Expression<Func<IdentityUser, bool>> expression);
        Task<IdentityUser?> FindByIdAsync(Guid identityId);
        Task<IdentityResult> CreateUserAsync(IdentityUser user, Roles role);
        Task<IdentityResult> DeleteUserAsync(Guid identityId);
        Task<Guid> GetUserIdAsync(Guid identityId, string role);
    }
}
