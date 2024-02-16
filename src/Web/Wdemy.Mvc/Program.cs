using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Application.Services;
using Wdemy.Mvc.Authorization;
using Wdemy.Persistence.Context;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Persistence.Interfaces.Services;
using Wdemy.Persistence.Repositories;
using Wdemy.Persistence.Services;
using Wdemy.Mvc.Extensions;
using Wdemy.Application.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WdemyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(WdemyDbContext.ConnectionName),
        options => options.EnableRetryOnFailure(
                    10,
                    TimeSpan.FromSeconds(10),
                    null));
});
 
builder.Services.AddBusinessServices()
                .AddMvcServices();



builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.Password.RequiredLength = 4;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredUniqueChars = 0;
})
            .AddEntityFrameworkStores<WdemyDbContext>()
            .AddClaimsPrincipalFactory<ApplicationUserClaimsPrincipalFactory>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = new PathString("/Login/Index");
    options.LogoutPath = new PathString("/Login/SignOut");
    options.Cookie = new CookieBuilder
    {
        Name = "BAExamAppCookie",
        HttpOnly = false,
        SameSite = SameSiteMode.Lax,
        SecurePolicy = CookieSecurePolicy.Always
    };
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(45);
    options.AccessDeniedPath = new PathString("/Login/AccessDenied");
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<ITrainerRepository, TrainerRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IVideoRepository, VideoRepository>();
builder.Services.AddScoped<ISectionRepository, SectionRepository>();
builder.Services.AddScoped<IStudentCourseRepository, StudentCourseRepository>();
builder.Services.AddScoped<IAccountService, AccountService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<WdemyDbContext>();

    await WdemyDbContextSeedData.SeedAsync(db);
}

app.Run();
