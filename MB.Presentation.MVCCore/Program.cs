using MB.Application;
using MB.Applications.Contracts.Art;
using MB.Applications.Contracts.ArtCategory;
using MB.Applications.Contracts.Comment;
using MB.Domain.ArtAgg;
using MB.Domain.ArtAgg.Services;
using MB.Domain.ArtCategoryAgg;
using MB.Domain.ArtCategoryAgg.Services;
using MB.Domain.CommentAgg;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repositories;
using MB.infrasturctureQuery;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//Art nad art category ---> repository and app and service 
builder.Services.AddTransient<IArtCategoryRepository, ArtCategoryRepository>();
builder.Services.AddTransient<IArtCategoryApplication, ArtCategoryApplication>();
builder.Services.AddTransient<IArtCategoryValidatorService, ArtCategoryValidatorService>();

builder.Services.AddTransient<IArtApplication, ArtApplictaion>();
builder.Services.AddTransient<IArtRepository, ArtRepository>();
builder.Services.AddTransient<IArtValidationService, ArtValidationService>();

builder.Services.AddTransient<ICommentApp, CommentApplication>();
builder.Services.AddTransient<ICommentRepository, CommentRepository>();

builder.Services.AddTransient<IArtQuery, ArtQuery>();

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

