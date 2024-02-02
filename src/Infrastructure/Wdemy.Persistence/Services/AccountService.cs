using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Constant;
using Wdemy.Domain.Common.Base;
using Wdemy.Domain.Enums;
using Wdemy.Persistence.Interfaces.Repository;
using Wdemy.Persistence.Interfaces.Services;

namespace Wdemy.Persistence.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAdminRepository _adminRepository;
        private readonly ITrainerRepository _trainerRepository;
        private readonly IStudentRepository _studentRepository;

        public AccountService(UserManager<IdentityUser> userManager, IAdminRepository adminRepository, ITrainerRepository trainerRepository, IStudentRepository studentRepository)
        {
            _userManager = userManager;
            _adminRepository = adminRepository;
            _trainerRepository = trainerRepository;
            _studentRepository = studentRepository;
        }

        public async Task<bool> AnyAsync(Expression<Func<IdentityUser, bool>> expression)
        {
            return await _userManager.Users.AnyAsync(expression);
        }

        public async Task<IdentityResult> CreateUserAsync(IdentityUser user, Roles role)
        {
            IdentityResult result;
            //StringGenerator.GenerateRandomPassword(); //TODO:Mail entegrasyonundan sonra kullanıcıya bu şifre gönderilecek.
            result = await _userManager.CreateAsync(user, "newPassword+0"); //TODO:Password oluşturulup kullanıcıya mail olarak atılmalı
            if (!result.Succeeded)
            {
                return result;
            }

            return await _userManager.AddToRoleAsync(user, role.ToString());
        }

        public Task<IdentityUser?> FindByIdAsync(Guid identityId)
        {
            return _userManager.FindByIdAsync(identityId.ToString());
        }

        public async Task<IdentityResult> DeleteUserAsync(Guid identityId)
        {
            var user = await _userManager.FindByIdAsync(identityId.ToString());
            if (user is null)
            {
                return IdentityResult.Failed(new IdentityError()
                {
                    Code = nameof(Messages.UserNotFound),
                    Description = Messages.UserNotFound
                });
            }

            return await _userManager.DeleteAsync(user);
        }

        public async Task<Guid> GetUserIdAsync(Guid identityId, string role)
        {
            BaseUser? user = role switch
            {
                "Admin" => await _adminRepository.GetByIdentityAsync(identityId), 
                "Trainer" => await _trainerRepository.GetByIdentityAsync(identityId), 
                "Student" => await _studentRepository.GetByIdentityAsync(identityId),
                _ => null

            };

            return user is null ? Guid.Empty : user.Id;
        }
    }
}
