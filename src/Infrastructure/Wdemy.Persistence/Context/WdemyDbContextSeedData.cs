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

            if (await db.Admins.AnyAsync() || await db.Trainers.AnyAsync() || await db.Students.AnyAsync() || await db.Roles.AnyAsync()) return;

            await AddRoles(db);

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
            var adminRoleId = db.Roles.FirstOrDefault(role => role.Name == Roles.Admin.ToString())!.Id;
            await db.UserRoles.AddAsync(new IdentityUserRole<string> { UserId = user.Id, RoleId = adminRoleId });

            var adminUser = new Admin()
            {
                Status = Status.Added,
                CreatedBy = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                ModifiedBy = Guid.NewGuid(),
                ModifiedDate = DateTime.Now,
                FirstName = "Mesut",
                LastName = "Kılıç",
                Email = AuthorizationConstants.DEFAULT_ADMIN_USER,
                DateOfBirth = new DateTime(1985, 01, 01),
                Gender = Gender.Erkek,
                IdentityId = new Guid(user.Id),
            };

            await db.Admins.AddAsync(adminUser);

            var trainerUser = new IdentityUser()
            {
                UserName = AuthorizationConstants.DEFAULT_TRAINER_USER,
                NormalizedUserName = AuthorizationConstants.DEFAULT_TRAINER_USER.ToUpper(),
                Email = AuthorizationConstants.DEFAULT_TRAINER_USER,
                EmailConfirmed = true,
                NormalizedEmail = AuthorizationConstants.DEFAULT_TRAINER_USER.ToUpper(),
            };

            trainerUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(trainerUser, AuthorizationConstants.DEFAULT_PASSWORD);
            await db.Users.AddAsync(trainerUser);
            var trainerRoleId = db.Roles.FirstOrDefault(role => role.Name == Roles.Trainer.ToString())!.Id;
            await db.UserRoles.AddAsync(new IdentityUserRole<string> { UserId = trainerUser.Id, RoleId = trainerRoleId });
            
            var trainer = new Trainer()
            {
                Status = Status.Added,
                CreatedBy = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                ModifiedBy = Guid.NewGuid(),
                ModifiedDate = DateTime.Now,
                FirstName = "Egitmen",
                LastName = "Wdemy",
                Email = AuthorizationConstants.DEFAULT_TRAINER_USER,
                DateOfBirth = new DateTime(1985, 01, 01),
                Gender = Gender.Erkek,
                IdentityId = new Guid(trainerUser.Id),
            };

            await db.Trainers.AddAsync(trainer);

            var studentUser = new IdentityUser()
            {
                UserName = AuthorizationConstants.DEFAULT_STUDENT_USER,
                NormalizedUserName = AuthorizationConstants.DEFAULT_STUDENT_USER.ToUpper(),
                Email = AuthorizationConstants.DEFAULT_STUDENT_USER,
                EmailConfirmed = true,
                NormalizedEmail = AuthorizationConstants.DEFAULT_STUDENT_USER.ToUpper(),
            };

            studentUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(studentUser, AuthorizationConstants.DEFAULT_PASSWORD);
            await db.Users.AddAsync(studentUser);
            var studentRoleId = db.Roles.FirstOrDefault(role => role.Name == Roles.Student.ToString())!.Id;
            await db.UserRoles.AddAsync(new IdentityUserRole<string> { UserId = studentUser.Id, RoleId = studentRoleId });

            var student = new Trainer()
            {
                Status = Status.Added,
                CreatedBy = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                ModifiedBy = Guid.NewGuid(),
                ModifiedDate = DateTime.Now,
                FirstName = "Egitmen",
                LastName = "Wdemy",
                Email = AuthorizationConstants.DEFAULT_TRAINER_USER,
                DateOfBirth = new DateTime(1985, 01, 01),
                Gender = Gender.Erkek,
                IdentityId = new Guid(studentUser.Id),
            };

            await db.Trainers.AddAsync(student);

            await db.SaveChangesAsync();
        }
        private static async Task AddRoles(WdemyDbContext db)
        {
            string[] roles = Enum.GetNames(typeof(Roles));
            for (int i = 0; i < roles.Length; i++)
            {
                if (await db.Roles.AnyAsync(role => role.Name == roles[i]))
                {
                    continue;
                }

                await db.Roles.AddAsync(new IdentityRole(roles[i]));
                await db.SaveChangesAsync();
            }
        }
    }
}
