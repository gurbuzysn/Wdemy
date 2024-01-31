using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Constant;
using Wdemy.Domain.Entities;
using Wdemy.Domain.Enums;

namespace Wdemy.Persistence.Context
{
    public static class WdemyDbContextSeedData
    {
        public async static Task SeedAsync(WdemyDbContext db)
        {
            await db.Database.MigrateAsync();

            if (await db.Admins.AnyAsync() || await db.Trainers.AnyAsync() || await db.Students.AnyAsync())
            {

                return;
            }


            var user = new IdentityUser()
            {
                UserName = AuthorizationConstants.DEFAULT_ADMIN_USER,
                NormalizedUserName = AuthorizationConstants.DEFAULT_ADMIN_USER.ToUpper(),
                Email = AuthorizationConstants.DEFAULT_ADMIN_USER,
                EmailConfirmed = true,
                NormalizedEmail = AuthorizationConstants.DEFAULT_ADMIN_USER.ToUpper(),

            };

            user.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(user, AuthorizationConstants.DEFAULT_PASSWORD);
            await db.Users.AddAsync(user);
            



            var adminUser = new Admin()
            {
                FirstName = "Mesut",
                LastName = "Kılıç",
                Email = AuthorizationConstants.DEFAULT_ADMIN_USER,
                DateOfBirth = new DateTime(1985, 01, 01),
                Gender = Gender.Erkek,
            };

            
        }
    }
}
