using MB.Application;
using MB.Applications.Contracts.ArtCategory;
using MB.Domain.ArtCategoryAgg;
using MB.Domain.ArtCategoryAgg.Services;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//
builder.Services.AddTransient<IArtCategoryRepository, ArtCategoryRepository>();
builder.Services.AddTransient<IArtCategoryApplication, ArtCategoryApplication>();
builder.Services.AddTransient<IArtCategoryValidatorService, ArtCategoryValidatorService>();
//db
builder.Services.AddDbContext<MBContext>(options=>options.UseNpgsql(builder.Configuration.GetConnectionString("MasterBloggerDB")));
//
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
app.MapDefaultControllerRoute();

app.Run();

