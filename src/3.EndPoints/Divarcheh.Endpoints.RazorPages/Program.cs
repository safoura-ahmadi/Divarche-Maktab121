using Divarcheh.Domain.Services;
using Divarcheh.Domain.AppServices;
using Microsoft.EntityFrameworkCore;
using Divarcheh.Domain.Core.Entities.Configs;
using Divarcheh.Infrastructure.EfCore.Common;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Infrastructure.EfCore.Repositories;

var builder = WebApplication.CreateBuilder(args);

#region Configuration

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var siteSettings = configuration.GetSection("SiteSettings").Get<SiteSettings>();
builder.Services.AddSingleton(siteSettings);

#endregion

#region Rgister Services

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserAppService, UserAppService>();


builder.Services.AddScoped<IBaseDataRepository, BaseDataRepository>();
builder.Services.AddScoped<IBaseDataService, BaseDataService>();
builder.Services.AddScoped<IBaseDataAppService, BaseDataAppService>();


builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryAppService, CategoryAppService>();


builder.Services.AddScoped<IDashboardAppService, DashboardAppService>();

#endregion



// Add services to the container.
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(siteSettings.ConnectionStrings.SqlConnection));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
