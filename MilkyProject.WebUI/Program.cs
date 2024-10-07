using MilkyProject.DataAccessLayer.Context;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Dtos.RegisterDto;
using MilkyProject.WebUI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MilkyContext>();


builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<MilkyContext>().AddErrorDescriber<CustomIdentityValidator>();
builder.Services.AddHttpClient();

builder.Services.AddControllersWithViews();

var app = builder.Build();

//builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<MilkyContext>().AddErrorDescriber<CreateNewUserDto>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
